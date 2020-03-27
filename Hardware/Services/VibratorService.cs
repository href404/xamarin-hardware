using Hardware.Models;
using System.Diagnostics;
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
                Model = new VibratorModel() { Duration = 2500 };

            return Model;
        }

        public async Task Vibrate() 
        {
            await Task.Run(() => 
            {
                Debug.WriteLine($"Duration : {Model.Duration} ms");
                Vibration.Vibrate(Model.Duration); 
            });
        }

    }
}
