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
    }
}
