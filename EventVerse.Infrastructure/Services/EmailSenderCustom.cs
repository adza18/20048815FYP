﻿using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EventVerse.Infrastructure.Services
{
    public class EmailSenderCustom : IEmailSender
    {
        public async Task SendEmailAsync(string email,  string subject, string htmlMessage)
        {
          ;

            //MailMessage message = new MailMessage();
            //SmtpClient smtpClient = new SmtpClient();
            //message.From = new MailAddress("ad.tech");
            //message.To.Add(email);
            //message.Subject = subject;
            //message.IsBodyHtml = true;
            //message.Body = htmlMessage;
            //smtpClient.Port = 587;
            //smtpClient.Host = "smtpt.sippl.com";
            //smtpClient.EnableSsl = true;
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new NetworkCredential("u", "p");
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.Send(message);


          
        }
    }
}
