using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

//Colocar a classe no namespace System para não ter que importar
namespace System
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return duration.Hours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
            {
                return duration.Days.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}
