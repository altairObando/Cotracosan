using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Utils
{
    public static class DateTimeExtensions
    {
        public static string NombreMes(this DateTime fecha)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(fecha.Month);
        }
        public static string ToAMPM (this TimeSpan hora)
        {
            return string.Format("{0}:{1} {2}", (hora.Hours % 12), hora.ToString(@"mm"), hora.Hours > 11 ? "PM" : "AM");
        }
    }
}
