using _3_Modul.Lesson_4__Regex_.HomeTask;
using _3_Modul.Lesson_4__Regex_.HomeTask._1_vazifa;
using _3_Modul.Lesson_4__Regex_.HomeTask._2_vazifa;
using _3_Modul.Lesson_4__Regex_.HomeTask_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4__Regex_.LessonTask
{
    internal class Lesson_4
    {
        public void Main_4()
        {
            /*Regexx reg = new();
            reg.RegexStart();*/
            vazifa_1();
            //vazifa_2();
           // vazifa_L389();
        }
        public void vazifa_1()
        {
            NameRegex name = new NameRegex();
            name.RegexName();
            name.PrintName();
        }
        public void vazifa_2()
        {
            NumberRegex number = new NumberRegex();
            number.RegexNumber();
        }public void vazifa_L389()
        {
            LeetCode_389 let = new LeetCode_389();
            Console.WriteLine(let.FindTheDifference("abcd","abcdf"));
        }
    }
}
