using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            IMesenger email = new Email();
            IMesenger sms = new SMS();
            IMesenger mms = new MMS();

            List<IMesenger> mesengers = new List<IMesenger>();
            mesengers.Add(email);
            mesengers.Add(sms);
            mesengers.Add(mms);

            //Constructor Injection
            Console.WriteLine("Constructor Injection");
            for (int i = 0; i < mesengers.Count; i++)
            {
                Notification1 notification1 = new Notification1(mesengers[i]);
                notification1.DoNotify();
            }

            //Property Injection
            Console.WriteLine("\n\nProperty Injection");
            for (int i = 0; i < mesengers.Count; i++)
            {
                Notification2 notification2 = new Notification2();
                notification2.MessagaService = mesengers[i];
                notification2.DoNotify();
            }

            //Method Injection
            Console.WriteLine("\n\nMethod Injection");
            for (int i = 0; i < mesengers.Count; i++)
            {
                Notification3 notification3 = new Notification3();
                notification3.DoNotify(mesengers[i]);
            }
        }
    }
}
