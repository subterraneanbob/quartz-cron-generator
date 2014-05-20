using System;

namespace QuartzCronGenerator
{
    public class CronExpression
    {
        private readonly DaysOfWeek _days;
        private readonly int _interval;
        private readonly int _startHour;
        private readonly int _startMinute;

        private readonly CronExpressionType _expressionType;
        private string _cronString;

        public CronExpressionType ExpressionType
        {
            get { return _expressionType; }
        }

        private void BuildCronExpression()
        {
            switch (ExpressionType)
            {
                case CronExpressionType.EveryNMinutes:
                    _cronString = string.Format("0 0/{0} * 1/1 * ? *", _interval);
                    break;
                case CronExpressionType.EveryNHours:
                    _cronString = string.Format("0 0 0/{0} 1/1 * ? *", _interval);
                    break;
                case CronExpressionType.EveryNDaysAt:
                case CronExpressionType.EveryDayAt:
                    _cronString = string.Format("0 {0} {1} 1/{2} * ? *", _startMinute, _startHour, _interval);
                    break;
                case CronExpressionType.EveryWeekDay:
                    _cronString = string.Format("0 {0} {1} ? * MON-FRI *", _startMinute, _startHour);
                    break;
                case CronExpressionType.EverySpecificWeekDayAt:
                    _cronString = string.Format("0 {0} {1} ? * {2} *", _startMinute, _startHour, CronConverter.ToCronRepresentation(_days));
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        protected CronExpression(int interval, CronExpressionType expressionType)
        {
            _interval = interval;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpression(int startHour, int startMinute, CronExpressionType expressionType)
        {
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpression(int interval, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _interval = interval;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpression(DaysOfWeek days, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _days = days;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs every *minutesInteval* minutes
        /// </summary>
        /// <param name="minutesInteval">Interval in minutes</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpression EveryNMinutes(int minutesInteval)
        {
            var ce = new CronExpression(minutesInteval, CronExpressionType.EveryNMinutes);
            return ce;
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs every *hoursInterval* hours
        /// </summary>
        /// <param name="hoursInterval">Interval in hours</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpression EveryNHours(int hoursInterval)
        {
            var ce = new CronExpression(hoursInterval, CronExpressionType.EveryNHours);
            return ce;
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs every day at specified hours
        /// </summary>
        /// <param name="hour">Hour, when occurence will happen</param>
        /// <param name="minute">Minute, when occurence will happen</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpression EveryDayAt(int hour, int minute)
        {
            var ce = new CronExpression(1, hour, minute, CronExpressionType.EveryDayAt);
            return ce;
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs every *daysInterval* days at specified hours
        /// </summary>
        /// <param name="daysInterval">Interval in days</param>
        /// <param name="hour">Hour, when occurence will happen</param>
        /// <param name="minute">Minute, when occurence will happen</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpression EveryNDaysAt(int daysInterval, int hour, int minute)
        {
            var ce = new CronExpression(daysInterval, hour, minute, CronExpressionType.EveryNDaysAt);
            return ce;
        }
        
        /// <summary>
        /// Create new CronExpression instance, which occurs monday to friday at specified hours
        /// </summary>
        /// <param name="hour">Hour, when occurence will happen</param>
        /// <param name="minute">Minute, when occurence will happen</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpression EveryWeekDayAt(int hour, int minute)
        {
            var ce = new CronExpression(hour, minute, CronExpressionType.EveryWeekDay);
            return ce;
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs on specified days at specified hours
        /// </summary>
        /// <param name="hour">Hour, when occurence will happen</param>
        /// <param name="minute">Minute, when occurence will happen</param>
        /// <param name="days">Days, when occurence will happen</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpression EverySpecificWeekDayAt(int hour, int minute, DaysOfWeek days)
        {
            var ce = new CronExpression(days, hour, minute, CronExpressionType.EverySpecificWeekDayAt);
            return ce;
        }

        // TODO Implement montly and yearly methods

        public override string ToString()
        {
            return _cronString;
        }

        public static implicit operator string(CronExpression expression)
        {
            return expression.ToString();
        }
    }
}
