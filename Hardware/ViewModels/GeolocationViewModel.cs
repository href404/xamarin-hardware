using Hardware.Models;
using Hardware.Services;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Hardware.ViewModels
{
    public class GeolocationViewModel
    {
        private readonly GeolocationService Service;

        public GeolocationModel Model { get; private set; }
        public Command UpdateCommand { get; private set; }
        public double DistanceFromAgen { get; private set; }

        public GeolocationViewModel()
        {
            Service = new GeolocationService();
            Model = Service.Get();
            UpdateCommand = new Command(async () =>
            {
                await Service.GetLastKnownLocationAsync();
                Location agen = new Location(44.201408, 0.611980);
                DistanceFromAgen = await Service.DistanceFromCityAsync(agen);
            });
        }
    }
}
