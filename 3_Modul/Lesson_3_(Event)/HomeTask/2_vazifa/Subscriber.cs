using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.HomeTask._2_vazifa
{
    internal class Subscriber //Kosmik stanstsiya
    {
        List<(object, string)> GetAllMessages = new();
        public void ShowAllMessages()
        {
            foreach (var item in GetAllMessages)
            {
                Console.WriteLine(item);
            }
        }

        public void OnClickGetSms(object? sender, string smsText)
        {
            GetAllMessages.Add(((sender as EventPublisher).Country, smsText));
        }

        internal void SendMessage()
        {
            Console.WriteLine("SendMessage");
        }
    }
}
