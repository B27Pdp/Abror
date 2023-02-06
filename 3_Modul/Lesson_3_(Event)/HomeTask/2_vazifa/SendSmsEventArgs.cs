using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.HomeTask._2_vazifa
{
    internal class SendSmsEventArgs : EventArgs
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime SendDate { get; set; }


    }
}
