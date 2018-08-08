using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{
    class SimpleDateFormat
    {
        private CultureInfo _culture;

        public SimpleDateFormat (string format, CultureInfo culture)
        {
            _culture=culture;
            _formatProvider= new 
        // Change time to match GMT + 1.
        var gmt1Date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcDate, "W. Europe Standard Time");
        // Output the GMT+1 time in our specified format using the US-culture. 
        var str = gmt1Date.ToString("ddd, dd MMM yyyy HH:mm:ss z", usCulture);
        }
        public DateTime parse(string date)
        {
            return DateTime.Parse(date, _culture);
        }
    }
}
