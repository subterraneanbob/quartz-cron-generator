using System;
using System.Collections.Generic;
using System.Linq;

namespace QuartzCronGenerator
{
    public class CronConverter
    {
        public static string ToCronRepresentationSingle(DaysOfWeek day)
        {
            switch (day)
            {
                case DaysOfWeek.Monday:
                    return "MON";
                case DaysOfWeek.Tuesday:
                    return "TUE";
                case DaysOfWeek.Wednesday:
                    return "WED";
                case DaysOfWeek.Thursday:
                    return "THU";
                case DaysOfWeek.Friday:
                    return "FRI";
                case DaysOfWeek.Saturday:
                    return "SAT";
                case DaysOfWeek.Sunday:
                    return "SUN";
                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// Converts enumerator DaysOfWeek into string representation
        /// like "MON, TUE, WED"
        /// </summary>
        /// <param name="days">Enumerator to convert</param>
        /// <returns>String representation</returns>
        public static string ToCronRepresentation(DaysOfWeek days)
        {
            return String.Join(",", GetFlags(days).Select(ToCronRepresentationSingle));
        }

        public static IEnumerable<DaysOfWeek> GetFlags(DaysOfWeek days)
        {
            return Enum.GetValues(days.GetType()).Cast<DaysOfWeek>().Where(v => days.HasFlag(v));
        }
    }
}
