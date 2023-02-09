using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Mafiya
{
    internal class others
    {
        public void Method1(object ? sender,EventArgs e)
        {
            Console.WriteLine("Method1");
        }
        public void Method2(object? sender, EventArgs e)
        {
            Console.WriteLine("Method2");
        }
        public void Method3(object? sender, EventArgs e)
        {
            Console.WriteLine("Method3");
        }
        public void Method4(object? sender, EventArgs e)
        {
            Console.WriteLine("Method4");
        }
        public void Method5(object? sender, EventArgs e)
        {
            Console.WriteLine("Method5");
        }
    }
}
