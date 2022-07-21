using BridgePattern.Bridge;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CommunicationBridge obj = new CommunicationBridge(); 

            obj.Send();

            obj.Notification = new SMSNotifier();
            obj.Send();


        }
    }
}
