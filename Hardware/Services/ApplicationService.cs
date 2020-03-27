using Hardware.Models;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class ApplicationService
    {
        public ApplicationModel Get() 
        {
            return new ApplicationModel()
            {
                Name = AppInfo.Name,
                Package = AppInfo.PackageName,
                Version = AppInfo.VersionString,
                Build = AppInfo.BuildString
            };
        }
    }
}
