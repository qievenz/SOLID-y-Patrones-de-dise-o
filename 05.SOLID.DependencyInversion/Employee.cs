using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SOLID.DependencyInversion
{
    public class Employee
    {
        private IList<IMessageSender> _senders;
        
        public Employee(IList<IMessageSender> senders)
        {
            _senders = senders;
        }

        public void Send()
        {
            foreach (var sender in _senders)
            {
                sender.Send();
            }
        }
    }
}
