using Hardware.Models;
using Hardware.Services;

namespace Hardware.ViewModels
{
    public class AccelerometerViewModel
    {
        private readonly AccelerometerService Service;

        public AccelerometerModel Model { get; private set; }

        public AccelerometerViewModel()
        {
            Service = new AccelerometerService();
            Model = Service.Get();
        }

        public void Start() => Service.Start();
        public void Stop() => Service.Start();
    }
}
