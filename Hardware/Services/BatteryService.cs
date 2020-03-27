using Hardware.Models;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class BatteryService
    {
        public BatteryModel Get()
        {
            return new BatteryModel()
            {
                ChargeLevel = Battery.ChargeLevel,
                State = Battery.State,
                PowerSource = Battery.PowerSource,
                EnergySaverStatus = Battery.EnergySaverStatus
            };
        }
    }
}
