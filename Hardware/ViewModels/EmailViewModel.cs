using Hardware.Models;
using Hardware.Services;
using Xamarin.Forms;

namespace Hardware.ViewModels
{
    internal class EmailViewModel
    {
        private readonly EmailService Service;

        public EmailModel Model { get; private set; }
        public Command SendCommand { get; private set; }

        public EmailViewModel()
        {
            Service = new EmailService();
            Model = Service.Get();
            SendCommand = new Command(async () => await Service.SendEmailAsync(Model));
        }
    }
}
