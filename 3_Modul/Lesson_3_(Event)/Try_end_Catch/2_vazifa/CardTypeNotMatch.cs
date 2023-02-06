using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Try_end_Catch._2_vazifa
{
    class CardTypeNotMatch : SystemException
    {
        public override string Message { get; } = "Kartalar holati mos bo'lmagan holat. ";

    }
}
