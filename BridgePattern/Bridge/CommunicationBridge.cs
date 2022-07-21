using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    class CommunicationBridge
    {
       public  INotifier Notification;

        public void Send()
        {
            string Message = CreateMessage();
            if (Notification != null)
                Notification.Notify(Message);
            else

            Console.WriteLine(Message + " Not Sent");

        }

       

        public string CreateMessage()
        {
            return "Information";
        }
    }
}
