using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Mafiya
{
    internal class Asisan
    {
        public void Task(object? sender , EventHandler e)
        {
            Console.WriteLine("Bajardim!");
            e.Invoke(sender, new EventArgs());

        }
    }
}
