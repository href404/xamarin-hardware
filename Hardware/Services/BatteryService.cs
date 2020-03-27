using Hardware.Models;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class BatteryService
    {
        private BatteryModel Model;

        public BatteryService()
        {
            Battery.BatteryInfoChanged += OnBatteryInfoChanged;
            Battery.EnergySaverStatusChanged += OnEnergySaverStatusChanged;
        }

        public BatteryModel Get()
        {
            if (Model == null)
                Model = new BatteryModel()
                {
                    ChargeLevel = Battery.ChargeLevel,
                    State = Battery.State,
                    PowerSource = Battery.PowerSource,
                    EnergySaverStatus = Battery.EnergySaverStatus
                };
            
            return Model;
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
