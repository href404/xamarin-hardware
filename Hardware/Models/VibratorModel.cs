namespace Hardware.Models
{
    public class VibratorModel : NotifyModel
    {
        private double duration;
        
        public double Duration 
        { 
            get { return duration; }
            set { SetProperty(ref duration, value); } 
        }
    }
}
