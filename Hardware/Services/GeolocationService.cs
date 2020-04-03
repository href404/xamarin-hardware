using Hardware.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class GeolocationService
    {
        private GeolocationModel Model;
        private static TimeSpan Timeout = new TimeSpan(0, 0, 1);
        private readonly GeolocationRequest GeolocationRequest = new GeolocationRequest(GeolocationAccuracy.Medium, Timeout);

        public GeolocationModel Get()
        {
            if (Model == null)
                Model = new GeolocationModel();

            return Model;
        }

        public async Task GetLastKnownLocationAsync()
        {
            try
            {
                Location currentlocation = await Geolocation.GetLocationAsync(GeolocationRequest);
                if (currentlocation == null)
                    return;

                Model.Latitude = currentlocation.Latitude;
                Model.Longitude = currentlocation.Longitude;
                Model.Altitude = currentlocation.Altitude;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public async Task<double> DistanceFromCityAsync(Location city)
        {
            if (city == null)
                return 0;

            Location currentlocation = await Geolocation.GetLocationAsync(GeolocationRequest);
            return Location.CalculateDistance(currentlocation, city, DistanceUnits.Kilometers);
        }
    }
}
