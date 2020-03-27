using Hardware.Models;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class VibrationService
    {
        public VibrationModel Get() { return new VibrationModel(); }
        public async Task Vibrate() { await Task.Run(() => Vibration.Vibrate()); }

    }
}
