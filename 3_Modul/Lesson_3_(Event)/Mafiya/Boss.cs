using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Mafiya
{
    internal class Boss
    {
        public event EventHandler<EventHandler>? Order;
        event EventHandler next;
         public void strart()
         {
            others Others = new();
            next += Others.Method1;
            Order.Invoke(this,next);
         }

    }
}
