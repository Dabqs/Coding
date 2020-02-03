using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Bank
{
    class MailSender
    {
        private string emailAddress;

        public MailSender(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }

        public void SendEmail(string msg)
        {
            Console.WriteLine($"Sending email to {emailAddress}. Message is: '{msg}'.");
        }
    }
}
