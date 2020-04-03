using Hardware.Models;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class VibratorService
    {
        private VibratorModel Model;
        
        public VibratorModel Get() 
        {
            if (Model == null)
                Model = new VibratorModel();

            return Model;
        }

        public async Task Vibrate() 
        { 
            await Task.Run(() => Vibration.Vibrate()); 
        }

        public async Task Vibrate(double duration) 
        {
            if (duration == 0)
                return;

            await Task.Run(() => Vibration.Vibrate(duration)); 
        }
    }
}
