using System;

namespace ExpenseTrackerWeb.BusinessObjects.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt)
        {
            int diff = dt.DayOfWeek - DayOfWeek.Monday;
            if (diff < 0)
            {
                diff += 7;
            }
            return dt.AddDays(-1 * diff).Date;
        }

        public static DateTime EndOfWeek(this DateTime dt)
        {
            return StartOfWeek(dt).AddDays(6);
        }
    }
}
