using _3_Modul.Lesson_1__Delegate_.LessonTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_1__Delegate_.HomeTask._1_vazifa
{
    static class Mathematics
    {
     /* 1.Mathematics degan sinf yarating. Sinf ichida 4 ta (sum, substract, multiply, divide)
      * qiymat qaytarmaydigan metodlar bo'lsin va ular 2 son bilan nomlariga mos matematik amallarni
      * bajarsin va natijasini ekranga uzatsin. Delegate yordamida ushbu metodlarni vazifalarini 
      * ishga tushuring. (Oson) */
        public static void Sum(double a,double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        public static void Substract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }


        

    }
}
