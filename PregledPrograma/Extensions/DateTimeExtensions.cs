using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PregledPrograma.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime ChangeDateOnly(this DateTime dateTime, DateTime target)
        {
            return new DateTime(
                target.Year,
                target.Month,
                target.Day,
                dateTime.Hour,
                dateTime.Minute,
                dateTime.Second,
                dateTime.Millisecond,
                dateTime.Kind);
        }

        public static DateTime ChangeTimeOnly(this DateTime dateTime, TimeSpan timespan)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                timespan.Hours,
                timespan.Minutes,
                timespan.Seconds,
                timespan.Milliseconds,
                dateTime.Kind);
        }
    }
}
