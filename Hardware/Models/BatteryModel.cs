using Xamarin.Essentials;

namespace Hardware.Models
{
    public class BatteryModel
    {
        public double ChargeLevel { get; set; }
        public BatteryState State { get; set; }
        public BatteryPowerSource PowerSource { get; set; }
        public EnergySaverStatus EnergySaverStatus { get; set; }
    }
}
