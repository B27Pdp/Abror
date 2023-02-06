using _3_Modul.Lesson_3__Event_.LessonTask;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.HomeTask._1_vazifa
{
    //  delegate void ClickSendSms(object? sender, string smsText);
    internal class OnEvenNumberFount
    {/*2. OnEvenNumberFound nomli event hosil qiling va bu event'ni to'plam
      * ichida juft sonlar topilgan paytda ishlashligini ta'minlang (Qiyin)*/

        public EventHandler<EventArgs> OnEvenNumberFound = delegate { };

        private List<int>? _list;

        public List<int> ListOfElement
        {
            set
            {
                int a = value.Find(a => a % 2 == 0);
                if (a > 0)
                {
                    OnEvenNumberFound.Invoke(this, new EventArgs());
                }
            }
        }
    }
}
