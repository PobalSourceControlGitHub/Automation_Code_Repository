using Automation_Suite.Utility_Tier;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Automation_Suite.Constant
{
    class DateTimeUtil
    {

        public static IEnumerable<DateTime> AllDatesInMonth(int year, int month)
        {
            int days = DateTime.DaysInMonth(year, month);
            for (int day = 1; day <= days; day++)
            {
                yield return new DateTime(year, month, day);
            }

            var mondays = AllDatesInMonth(2017, 7).Where(i => i.DayOfWeek == DayOfWeek.Monday);
        }

        

        [TestMethod]
        public void SetDaySunday()
        {
            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(-1);

            var chickDOB = newDate.ToString("dd/MM/yyyy");

        }

        [TestMethod]
        public void Date_ECE()
        {
            var myDate = DateTime.Now;
            var newDate = myDate.AddYears(-1);

            var chickDOB = newDate.ToString("dd/MM/yyyy");


        }

        [TestMethod]
        public void PRE_ECE()
        {


        }

    }
}
