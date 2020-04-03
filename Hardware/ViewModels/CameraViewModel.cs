using Hardware.Models;
using Hardware.Services;
using Xamarin.Forms;

namespace Hardware.ViewModels
{
    public class CameraViewModel
    {
        private readonly CameraService Service;

        public CameraModel Model { get; private set; }
        public Command AcquireCommand { get; private set; }

        public CameraViewModel()
        {
            Service = new CameraService();
            Model = Service.Get();
            AcquireCommand = new Command(async () => await Service.AcquireAsync());
        }
    }
}
