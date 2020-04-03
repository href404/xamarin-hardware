using Hardware.Models;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hardware.Services
{
    public class CameraService
    {
        private CameraModel Model;

        public CameraModel Get()
        {
            if (Model == null)
                Model = new CameraModel();

            return Model;
        }

        public async Task AcquireAsync()
        {
            MediaFile photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions());
            Model.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }
    }
}
