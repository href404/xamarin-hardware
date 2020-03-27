using Hardware.Models;
using Hardware.Services;

namespace Hardware.ViewModels
{
    public class ApplicationViewModel
    {
        private readonly ApplicationService Service;

        public ApplicationModel Model { get; private set; }

        public ApplicationViewModel() { 
            Service = new ApplicationService();
            Model = Service.Get();
        }

    }
}
