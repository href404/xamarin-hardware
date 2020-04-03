namespace Hardware.Models
{
    public class VibratorModel : NotifyModel
    {
        private double duration = 2500;
        
        public double Duration 
        { 
            get { return duration; }
            set { SetProperty(ref duration, value); } 
        }
    }
}
