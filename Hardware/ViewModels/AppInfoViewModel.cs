using Hardware.Models;
using Hardware.Services;

namespace Hardware.ViewModels
{
    public class AppInfoViewModel : BaseViewModel
    {
        private readonly AppInfoService Service;

        public AppInfoModel Model { get; set; }

        public AppInfoViewModel() { 
            Service = new AppInfoService();
            Model = Service.Get();
        }

    }
}
