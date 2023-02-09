using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_5__DateTime_.LessonTask
{
    internal class Lesson_5
    {
        public void Main_5()
        {
            //vazifa_1();
            //vazifa_2();
            //vazifa_3();
            vazifa_4();
        }
        public void vazifa_1()
        {
          //Hozirgi sanani vaqtsiz va hozirgi vaqtni sanasiz chiqazuvchi dastur tuzing.
            Console.Write("DateTime : ");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            Console.WriteLine("Date : "+dateTime.ToString("yyyy.MM.dd"));
            Console.WriteLine("Time : "+dateTime.ToString("T"));
        }
        public void vazifa_2()
        {
            //Foydalanuvchi bergan vaqt va hozirgi vaqtning farqini
            //(hh:mm:ss formatda) hisoblaydigan method tuzing. 
            Console.Write("Vaqtni kiriting : ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.Now.Subtract(date).ToString());
        }
        public void vazifa_3()
        {
            //Foydalanuvchi tug'ilgan yili, oyi va kunini kiritganida hozir
            //necha yosh, oy va kunligini hisoblab chiqaradigan dastur tuzing.
            Console.Write("Tugulgan Yilingizni : ");
            int yil=int.Parse(Console.ReadLine());
            Console.Write("Tugulgan oyingiz : ");
            int oy = int.Parse(Console.ReadLine());
            Console.Write("Tugulgan kuningiz : ");
            int kun = int.Parse(Console.ReadLine());
            DateTime dateTime = new(yil, oy, kun);
            DateTime DateTimeNow = DateTime.Now;
            DateTime dateTime2 = new();
            //dateTime2.AddDays(kun);
            //dateTime2.AddYears(yil);
            //dateTime2.AddMonths(oy);
            int Yosh = DateTimeNow.Year - dateTime.Year;
            int Oy = DateTimeNow.Month - dateTime.Month;
            int Kun = DateTimeNow.Day - dateTime.Day;
            Console.WriteLine($"Yosh : {Yosh} Oy : {Oy} : Kun {Kun}");
        }
        public void vazifa_4()
        {

            Console.WriteLine("Enter your birth date in the format YYYY-MM-DD: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;

            int ageInYears = today.Year - birthDate.Year;
            int ageInMonths = today.Month - birthDate.Month;
            int ageInDays = today.Day - birthDate.Day;

            if (ageInDays < 0)
            {
                ageInDays += DateTime.DaysInMonth(today.Year, today.Month);
                ageInMonths--;
            }
            if (ageInMonths < 0)
            {
                ageInMonths += 12;
                ageInYears--;
            }

            Console.WriteLine($"You are {ageInYears} years, {ageInMonths} months, and {ageInDays} days old.");
        }

    }
}
