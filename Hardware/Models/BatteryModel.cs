using Xamarin.Essentials;

namespace Hardware.Models
{
    public class BatteryModel : NotifyModel
    {
        private double chargeLevel;
        private BatteryState state;
        private BatteryPowerSource powerSource;
        private EnergySaverStatus energySaverStatus;

        public double ChargeLevel 
        {
            get { return chargeLevel;  }
            set { SetProperty(ref chargeLevel, value); }
        }
        public BatteryState State
        {
            get { return state; }
            set { SetProperty(ref state, value); }
        }
        public BatteryPowerSource PowerSource
        {
            get { return powerSource; }
            set { SetProperty(ref powerSource, value); }
        }
        public EnergySaverStatus EnergySaverStatus
        {
            get { return energySaverStatus; }
            set { SetProperty(ref energySaverStatus, value); }
        }
    }
}
