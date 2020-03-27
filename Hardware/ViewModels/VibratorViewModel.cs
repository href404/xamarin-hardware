using Hardware.Models;
using Hardware.Services;
using Xamarin.Forms;

namespace Hardware.ViewModels
{
    public class VibratorViewModel
    {
        private readonly VibratorService Service;

        public VibratorModel Model { get; private set; }
        public Command VibrateCommand { get; private set; }

        public VibratorViewModel()
        {
            Service = new VibratorService();
            Model = Service.Get();
            VibrateCommand = new Command(async () => await Service.Vibrate());
        }

    }
}
