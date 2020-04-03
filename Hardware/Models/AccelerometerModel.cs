namespace Hardware.Models
{
    public class AccelerometerModel : NotifyModel
    {
        private float x, y, z;

        public float X 
        { 
            get { return x; }
            set { SetProperty(ref x, value); } 
        }
        public float Y
        {
            get { return y; }
            set { SetProperty(ref y, value); }
        }
        public float Z
        {
            get { return z; }
            set { SetProperty(ref z, value); }
        }
    }
}
