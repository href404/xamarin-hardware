using Hardware.Models;
using Hardware.Services;
using Xamarin.Forms;

namespace Hardware.ViewModels
{
    public class VibrationViewModel
    {
        private readonly VibrationService Service;

        public VibrationModel Model { get; private set; }
        public Command VibrateCommand { get; set; }

        public VibrationViewModel()
        {
            Service = new VibrationService();
            Model = Service.Get();
            VibrateCommand = new Command(async () => await Service.Vibrate());
        }

    }
}
