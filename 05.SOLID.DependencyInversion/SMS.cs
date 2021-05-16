using System;

namespace _05.SOLID.DependencyInversion
{
    public class SMS : ISMS
    {
        public string Origin { get ; set ; }
        public string Destiny { get ; set ; }
        public string Content { get ; set ; }

        public void Send()
        {
            Console.WriteLine("Enviando SMS");
        }
        
        public SMS(string phoneNumberFrom, string phoneNumberTo, string smsContent)
        {
            Origin = phoneNumberFrom;
            Destiny = phoneNumberTo;
            Content = smsContent;
        }
    }
}