using _3_Modul.Lesson_2__Event_.LessonTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4__Regex_.HomeTask._2_vazifa
{
    internal class NumberRegex
    {
        //Matn berilgan.Regex yordamida matnni ichidan sonlarni ajratib
        //beruvchi dastur tuzing. (Eng qiyin)
        string str = "Salom4 Dun5yo 47";
        public void RegexNumber()
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = Regex.Replace(str, "[ -/:-~]", "");
            }
            Console.WriteLine(str);
        }
    }
}
