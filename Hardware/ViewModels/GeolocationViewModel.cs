using Hardware.Models;
using Hardware.Services;

namespace Hardware.ViewModels
{
    public class GeolocationViewModel
    {
        private readonly GeolocationService Service;

        public GeolocationModel Model { get; private set; }

        public GeolocationViewModel()
        {
            Service = new GeolocationService();
            Model = Service.Get();
        }

        public void Start() => Service.Start();

        public void Stop() => Service.Stop();
    }
}
