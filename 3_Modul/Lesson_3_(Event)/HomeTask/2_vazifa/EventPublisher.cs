using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.HomeTask._2_vazifa
{
    delegate void ClickSendSms(object? sender, string smsText);

    internal class EventPublisher
    {
        public string Country { get; internal set; }

        public event ClickSendSms? OnClickSendSms;
        public void SendSmsMessage()
        {
            Console.Write("Xabarni kiriting : ");
            string smsText = Console.ReadLine() ?? "No Txt";
            OnClickSendSms.Invoke(this, smsText);


        }
    }
}
