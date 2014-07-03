using System.Collections.Generic;
using Xunit;

namespace QuartzCronGenerator.Tests
{
    public class Tests
    {
        [Fact]
        public void TestEveryNMinutes()
        {
            var ce1 = CronExpression.EveryNMinutes(1);
            var ce2 = CronExpression.EveryNMinutes(59);
            var ce3 = CronExpression.EveryNMinutes(3600);

            Assert.Equal("0 0/1 * 1/1 * ? *", ce1);
            Assert.Equal("0 0/59 * 1/1 * ? *", ce2);
            Assert.Equal("0 0/3600 * 1/1 * ? *", ce3);
        }

        [Fact]
        public void TestEveryNHours()
        {
            var ce1 = CronExpression.EveryNHours(1);
            var ce2 = CronExpression.EveryNHours(23);
            var ce3 = CronExpression.EveryNHours(72);

            Assert.Equal("0 0 0/1 1/1 * ? *", ce1);
            Assert.Equal("0 0 0/23 1/1 * ? *", ce2);
            Assert.Equal("0 0 0/72 1/1 * ? *", ce3);
        }

        [Fact]
        public void TestEveryDayAt()
        {
            var ce1 = CronExpression.EveryDayAt(12, 0);
            var ce2 = CronExpression.EveryDayAt(7, 23);
            var ce3 = CronExpression.EveryDayAt(22, 22);

            Assert.Equal("0 0 12 1/1 * ? *", ce1);
            Assert.Equal("0 23 7 1/1 * ? *", ce2);
            Assert.Equal("0 22 22 1/1 * ? *", ce3);
        }

        [Fact]
        public void TestEveryNDaysAt()
        {
            var ce1 = CronExpression.EveryNDaysAt(1, 12, 0);
            var ce2 = CronExpression.EveryNDaysAt(6, 7, 23);
            var ce3 = CronExpression.EveryNDaysAt(30, 22, 22);

            Assert.Equal("0 0 12 1/1 * ? *", ce1);
            Assert.Equal("0 23 7 1/6 * ? *", ce2);
            Assert.Equal("0 22 22 1/30 * ? *", ce3);
        }

        [Fact]
        public void TestEveryWeekDay()
        {
            var ce1 = CronExpression.EveryWeekDayAt(12, 0);
            var ce2 = CronExpression.EveryWeekDayAt(7, 23);
            var ce3 = CronExpression.EveryWeekDayAt(22, 22);

            Assert.Equal("0 0 12 ? * MON-FRI *", ce1);
            Assert.Equal("0 23 7 ? * MON-FRI *", ce2);
            Assert.Equal("0 22 22 ? * MON-FRI *", ce3);
        }

        [Fact]
        public void TestEverySpecificWeekDayAt()
        {
            var ce1 = CronExpression.EverySpecificWeekDayAt(12, 0, DaysOfWeek.Monday);
            var ce2 = CronExpression.EverySpecificWeekDayAt(7, 23, DaysOfWeek.Monday | DaysOfWeek.Wednesday | DaysOfWeek.Friday);
            var ce3 = CronExpression.EverySpecificWeekDayAt(22, 22, DaysOfWeek.Saturday | DaysOfWeek.Sunday);

            Assert.Equal("0 0 12 ? * MON *", ce1);
            Assert.Equal("0 23 7 ? * MON,WED,FRI *", ce2);
            Assert.Equal("0 22 22 ? * SAT,SUN *", ce3);
        }

        [Fact]
        public void TestDaysOfWeekRepresentation()
        {
            var monString = CronConverter.ToCronRepresentationSingle(DaysOfWeek.Monday);
            Assert.Equal("MON", monString);

            const DaysOfWeek days = DaysOfWeek.Monday | DaysOfWeek.Wednesday | DaysOfWeek.Friday;
            var daysList = new List<DaysOfWeek> { DaysOfWeek.Monday, DaysOfWeek.Wednesday, DaysOfWeek.Friday };
            Assert.Equal(daysList, CronConverter.GetFlags(days));

            const string expectedString = "MON,WED,FRI";
            Assert.Equal(expectedString, CronConverter.ToCronRepresentation(days));

            const string exprectedString2 = "SAT,SUN";
            Assert.Equal(exprectedString2, CronConverter.ToCronRepresentation(DaysOfWeek.Saturday | DaysOfWeek.Sunday));
        }

        [Fact]
        public void TestEverySpecificDayEveryNMonthAt()
        {
            var ce1 = CronExpression.EverySpecificDayEveryNMonthAt(1, 1, 12, 0);
            var ce2 = CronExpression.EverySpecificDayEveryNMonthAt(7, 3, 7, 15);
            var ce3 = CronExpression.EverySpecificDayEveryNMonthAt(28, 6, 21, 30);

            Assert.Equal("0 0 12 1 1/1 ? *", ce1);
            Assert.Equal("0 15 7 7 1/3 ? *", ce2);
            Assert.Equal("0 30 21 28 1/6 ? *", ce3);
        }

        [Fact]
        public void TestEverySpecificSeqWeekDayEveryNMonthAt()
        {
            var ce1 = CronExpression.EverySpecificSeqWeekDayEveryNMonthAt(DaySeqNumber.First, DaysOfWeek.Monday, 1, 12, 0);
            var ce2 = CronExpression.EverySpecificSeqWeekDayEveryNMonthAt(DaySeqNumber.Second, DaysOfWeek.Wednesday, 3, 7, 15);
            var ce3 = CronExpression.EverySpecificSeqWeekDayEveryNMonthAt(DaySeqNumber.Third, DaysOfWeek.Friday, 6, 21, 30);
            var ce4 = CronExpression.EverySpecificSeqWeekDayEveryNMonthAt(DaySeqNumber.Fourth, DaysOfWeek.Sunday, 77, 22, 45);

            Assert.Equal("0 0 12 ? 1/1 MON#1 *", ce1);
            Assert.Equal("0 15 7 ? 1/3 WED#2 *", ce2);
            Assert.Equal("0 30 21 ? 1/6 FRI#3 *", ce3);
            Assert.Equal("0 45 22 ? 1/77 SUN#4 *", ce4);
        }

        [Fact]
        public void TestEverySpecificDayOfMonthAt()
        {
            var ce1 = CronExpression.EverySpecificDayOfMonthAt(Months.January, 1, 12, 0);
            var ce2 = CronExpression.EverySpecificDayOfMonthAt(Months.February, 3, 15, 17);
            var ce3 = CronExpression.EverySpecificDayOfMonthAt(Months.August, 13, 20, 45);
            var ce4 = CronExpression.EverySpecificDayOfMonthAt(Months.December, 16, 23, 59);

            Assert.Equal("0 0 12 1 1 ? *", ce1);
            Assert.Equal("0 17 15 3 2 ? *", ce2);
            Assert.Equal("0 45 20 13 8 ? *", ce3);
            Assert.Equal("0 59 23 16 12 ? *", ce4);
        }

        [Fact]
        public void TestEverySpecificSeqWeekDayOfMonthAt()
        {
            var ce1 = CronExpression.EverySpecificSeqWeekDayOfMonthAt(DaySeqNumber.First, DaysOfWeek.Monday, Months.January, 12, 0);
            var ce2 = CronExpression.EverySpecificSeqWeekDayOfMonthAt(DaySeqNumber.Second, DaysOfWeek.Wednesday, Months.February, 7, 15);
            var ce3 = CronExpression.EverySpecificSeqWeekDayOfMonthAt(DaySeqNumber.Third, DaysOfWeek.Friday, Months.August, 21, 30);
            var ce4 = CronExpression.EverySpecificSeqWeekDayOfMonthAt(DaySeqNumber.Fourth, DaysOfWeek.Sunday, Months.December, 22, 45);

            Assert.Equal("0 0 12 ? 1 MON#1 *", ce1);
            Assert.Equal("0 15 7 ? 2 WED#2 *", ce2);
            Assert.Equal("0 30 21 ? 8 FRI#3 *", ce3);
            Assert.Equal("0 45 22 ? 12 SUN#4 *", ce4);
        }
    }
}
