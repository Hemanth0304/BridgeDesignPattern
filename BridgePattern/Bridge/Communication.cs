using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    class Communication
    {
        public string NotificationType;

        public void Send()
        {
            string Message = CreateMessage();
            Notify(Message);

        }

        public void Notify(string Message)
        {
            if (NotificationType == "SMS")
                Console.WriteLine(Message + "Sent Through SMS");
            else if(NotificationType =="Email")
                Console.WriteLine(Message + "Sent Through Email");
            else
                Console.WriteLine(Message + "Not Sent");


        }

        public string CreateMessage()
        {
            return "Information";
        }
    }
}
