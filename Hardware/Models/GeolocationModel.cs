namespace Hardware.Models
{
    public class GeolocationModel : NotifyModel
    {
        private double latitude, longitude;
        private double? altitude;

        public double Latitude
        {
            get { return latitude; }
            set { SetProperty(ref latitude, value); }
        }
        public double Longitude
        {
            get { return longitude; }
            set { SetProperty(ref longitude, value); }
        }
        public double? Altitude
        {
            get { return altitude; }
            set { SetProperty(ref altitude, value); }
        }
    }
}
