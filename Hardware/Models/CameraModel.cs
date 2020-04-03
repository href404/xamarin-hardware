using Xamarin.Forms;

namespace Hardware.Models
{
    public class CameraModel : NotifyModel
    {
        private ImageSource source;

        public ImageSource Source
        {
            get { return source; }
            set { SetProperty(ref source, value); }
        }
    }
}
