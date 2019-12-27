using System;
using System.Collections.Generic;
//using System.Net.Mail;
using System.Text;
using System.Net;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace StockTickerApp
{
    public class MailService
    {

        /*
        public static void Email(string html)
        {
           
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("toplikarbot@yahoo.com");
                message.To.Add(new MailAddress("christoplikar@gmail.com"));
                message.Subject = "Test";
                message.IsBodyHtml = false;
                message.Body = html;
                smtp.Port = 587;
                smtp.Host = "smtp.mail.yahoo.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("toplikarbot@yahoo.com", "Chris3095!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            
            
        }
        public static void Email2(string html)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.mail.yahoo.com";
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("toplikarbot@yahoo.com", "Chris3095!");
            client.Send("toplikarbot@yahoo.com", "toplikarbot@yahoo.com", "Subject=Test", html);
        }
        */
        /*
        public void sendMailbyMailKit()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Joey Tribbiani", "toplikarbot@yahoo.com"));
            message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "christoplikar@gmail.com"));
            message.Subject = "How you doin'?";

            message.Body = new TextPart("plain")
            {
                Text = @"Hey Chandler,

I just wanted to let you know that Monica and I were going to go play some paintball, you in?

-- Joey"
            };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.mail.yahoo.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("toplikarbot@yahoo.com", "Chris3095!");

                client.Send(message);
                client.Disconnect(true);
            }
        }
        */
        public void tradingBotBuyEmail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Toplikar Bot", "toplikarbot@gmail.com"));
            message.To.Add(new MailboxAddress("Mr. Chris", "christoplikar@gmail.com"));
            message.Subject = "Stock Market Alert!";

            double price= MarketScanner.dowCurrentPrice();
            message.Body = new TextPart("plain")
            {
                Text = $"Hello sir, you should look into buying the index fund now, it is priced at {price.ToString("C")} --Trading Bot"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);


                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("toplikarbot@gmail.com", "Chris3095!");

                client.Send(message);
                client.Disconnect(true);
                Console.WriteLine("Message Sent");
                Console.WriteLine("Ending Program");
            }
        }
        public void tradingBotBuyEmail2(double predictedBenefit)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Toplikar Bot", "toplikarbot@gmail.com"));
            message.To.Add(new MailboxAddress("Mr. Chris", "christoplikar@gmail.com"));
            message.Subject = "Stock Market Alert!";

            double price = MarketScanner.dowCurrentPrice();
            message.Body = new TextPart("plain")
            {
                Text = $"Hello sir, buying index fund now has the highest benefit of the current year, it is priced at {price.ToString("C")} " +
                $"your predicted benefit is {predictedBenefit}--Trading Bot"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);


                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("toplikarbot@gmail.com", "Chris3095!");

                client.Send(message);
                client.Disconnect(true);
                Console.WriteLine("Message Sent");
                Console.WriteLine("Ending Program");
            }
        }
    }
}
