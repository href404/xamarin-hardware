using Hardware.Models;
using Hardware.Services;
using Xamarin.Essentials;

namespace Hardware.ViewModels
{
    public class BatteryViewModel : BaseViewModel
    {
        private readonly BatteryService Service;

        public BatteryModel Model { get; private set; }

        public BatteryViewModel()
        {
            Service = new BatteryService();
            Model = Service.Get();

            Battery.BatteryInfoChanged += OnBatteryInfoChanged;
            Battery.EnergySaverStatusChanged += OnEnergySaverStatusChanged;
        }

        private void OnEnergySaverStatusChanged(object sender, EnergySaverStatusChangedEventArgs e)
        {
            Model.EnergySaverStatus = e.EnergySaverStatus;
        }

        private void OnBatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            Model.ChargeLevel = e.ChargeLevel;
            Model.State = e.State;
            Model.PowerSource = e.PowerSource;
        }

    }
}
