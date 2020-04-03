namespace Hardware.Models
{
    public class VibratorModel : NotifyModel
    {
        private double duration = 2500;
        private bool isVibrating = false;

        public double Duration 
        { 
            get { return duration; }
            set { SetProperty(ref duration, value); } 
        }
        public bool IsVibrating
        {
            get { return isVibrating; }
            set { SetProperty(ref isVibrating, value); }
        }
    }
}
