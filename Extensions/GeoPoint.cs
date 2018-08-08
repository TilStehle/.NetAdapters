using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelservicePricing.ConvertedWindowsPhone.extensions
{

    public enum DistanceType { Miles, Kilometers }; 
    public class GeoPoint
    {

        public GeoPoint(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public GeoPoint(string s)
        { }
        public double Latitude { get; set; }

        public double Longitude { get; set; }


        public static GeoPoint get(global::Windows.Devices.Geolocation.Geopoint globalWindowsDevicesGeolocationGeopoint)
        {
            throw new NotImplementedException();
        }

        public double DistanceTo(GeoPoint location)
        {
            return DistanceTo(location, DistanceType.Kilometers)*1000;
        }
        /// <summary>  
        /// Returns the distance in miles or kilometers of any two  
        /// latitude / longitude points.  
        /// </summary>  
        public double DistanceTo(GeoPoint pos2, DistanceType type)
        {
            double R = (type == DistanceType.Miles) ? 3960 : 6371;
            double dLat = this.toRadian(pos2.Latitude - this.Latitude);
            double dLon = this.toRadian(pos2.Longitude - this.Longitude);
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                Math.Cos(this.toRadian(this.Latitude)) * Math.Cos(this.toRadian(pos2.Latitude)) *
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Asin(Math.Min(1, Math.Sqrt(a)));
            double d = R * c;
            return d;
        }
        /// <summary>  
        /// Convert to Radians.  
        /// </summary>  
        private double toRadian(double val)
        {
            return (Math.PI / 180) * val;
        }
    }
}
