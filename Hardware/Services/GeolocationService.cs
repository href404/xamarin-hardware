using Hardware.Models;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class GeolocationService
    {
        private static readonly TimeSpan Timeout = new TimeSpan(0, 0, 2);
        private static readonly GeolocationRequest GeolocationRequest = new GeolocationRequest(GeolocationAccuracy.Medium, Timeout);

        private GeolocationModel Model;
        private bool IsStarted = false;

        public GeolocationModel Get()
        {
            if (Model == null)
                Model = new GeolocationModel();

            return Model;
        }

        public void Start()
        {
            if (IsStarted)
                return;

            IsStarted = true;
            Acquire();
        }

        public void Stop()
        {
            if (!IsStarted)
                return;

            IsStarted = false;
        }

        private void Acquire()
        {
            ThreadPool.QueueUserWorkItem(async (object state) => 
            {
                int tick = Environment.TickCount;
                await GetLocationAsync();
                
                int duration = Environment.TickCount - tick;
                Debug.WriteLine($"Delta temps : {duration} ms");

                int waitingDuration = duration < 1000 ? 1000 - duration : 1;
                Thread.Sleep(waitingDuration);
                
                if (IsStarted)
                    Acquire();
            });
        }

        private async Task GetLocationAsync()
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
      
    }
}
