using Hardware.Models;
using Hardware.Services;

namespace Hardware.ViewModels
{
    public class BatteryViewModel
    {
        private readonly BatteryService Service;

        public BatteryModel Model { get; private set; }

        public BatteryViewModel()
        {
            Service = new BatteryService();
            Model = Service.Get();
        }

    }
}
