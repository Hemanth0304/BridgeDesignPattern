using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    class EmailNotifier : INotifier
    {
        public void Notify(string Message)
        {
            Console.WriteLine(Message + "Sent Through Email");
        }
    }
}
