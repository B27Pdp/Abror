using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Try_end_Catch._2_vazifa
{

    class NotEnoughMoney : SystemException
    {
        public override string Message { get; } = "Pul yetarli bo'lmagan holat. ";

    }
}
