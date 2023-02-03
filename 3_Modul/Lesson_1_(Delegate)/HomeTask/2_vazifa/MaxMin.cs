using _3_Modul.Lesson_1__Delegate_.LessonTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_1__Delegate_.HomeTask._2_vazifa
{
    public delegate (int, int) Del2(List<int> list);

    static class MaxMin
    {
        public static void Start(List<int> list)
        {
            Del2 delegat=MaxMinPrint;
            Console.WriteLine(delegat(list));
        }
        public static (int, int) MaxMinPrint(List<int> list)
        {
            return (list.Max(), list.Min());
        }
    }
}
