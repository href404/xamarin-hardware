using Hardware.Models;
using System.Timers;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class VibratorService
    {
        private VibratorModel Model;
        private readonly Timer Timer;

        public VibratorService()
        {
            Timer = new Timer();
            Timer.Elapsed += Timer_Elapsed;
        }

        public VibratorModel Get() 
        {
            if (Model == null)
                Model = new VibratorModel();

            return Model;
        }

        public void Vibrate(double duration) 
        {
            if (duration <= 0)
                return;

            if (Model.IsVibrating)
                return;

            Model.IsVibrating = true;
            Timer.Interval = duration;
            Timer.Start();
            Vibration.Vibrate(duration);
        }

        public void Cancel()
        {
            if (Model.IsVibrating)
                Vibration.Cancel();

            Timer.Stop();
            Model.IsVibrating = false;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Cancel();
        }
    }
}
