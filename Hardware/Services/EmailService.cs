using Hardware.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Hardware.Services
{
    internal class EmailService
    {
        private EmailModel Model;

        public EmailModel Get()
        {
            if (Model == null)
                Model = new EmailModel();

            return Model;
        }

        public async Task SendEmailAsync(EmailModel email)
        {
            try
            {
                EmailMessage message = new EmailMessage
                {
                    Subject = email.Subject,
                    Body = email.Body,
                    To = new List<string>() { email.Recipient },
                    BodyFormat = EmailBodyFormat.PlainText
                };
                await Email.ComposeAsync(message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
           
        }
    }
}
