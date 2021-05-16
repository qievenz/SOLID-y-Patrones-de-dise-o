using System;

namespace _05.SOLID.DependencyInversion
{

    public class Email : IEmail
    {
        public string Subject { get ; set ; }
        public string Origin { get ; set ; }
        public string Destiny { get ; set ; }
        public string Content { get ; set ; }

        public void Send()
        {
            Console.WriteLine("Enviando email");            
        }

        public Email(string subject, string emailFrom, string emailTo, string emailContent)
        {
            Subject = subject;
            Origin = emailFrom;
            Destiny = emailTo;
            Content = emailContent;
        }
    }
}