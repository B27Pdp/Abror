using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Try_end_Catch._1_vazifa
{
    public class TryCatch
    {
        /* 1. Berilgan matnning uzunligini aniqlaydigan method yarating.
         * Ushbu methoddan foydalangan holda Klaviaturadan kiritilgan
         * matnning uzunligini ekranga chiqazadigan dastur tuzing. Agarda
         * matn bo’sh bo’lsa ArgumentException throw qilinsin. Message sifatida
         * “Kiritilgan matn bo’sh bo’lmasligi kerak” degan xabar bo’lsin. (Oson)*/
        public void TxtLength()
        {
            Console.Write("txt kiriting ");
            string s =Console.ReadLine();
            try 
            {
                if (s.Length == 0) throw new Exception();
                else Console.WriteLine("Txt Length => " + s.Length);
            } 
            catch
            {
                Console.WriteLine("Kiritilgan matn bo’sh bo’lmasligi kerak");
            }
        }
    }
}
