using System.Text.RegularExpressions;

namespace _3_Modul.Lesson_4__Regex_.HomeTask._1_vazifa
{
    internal class NameRegex
    {
        // Ismlar to'plami berilgan. Regex yordamida to'plam ichidan bosh harfi 'S'
        // bilan boshlanuvchi ismlarni ajratib beruvchi dastur tuzing. (Qiyin)
        List<string> name1 = new List<string>() { "Sarvar", "Abror", "Jamshid", "Sardor", "siroch" };
        List<string> name2 = new List<string>();


        public void RegexName()
        {
            for (int i = 0; i < name1.Count; i++)
            {

                Console.Write(name1[i] + " ");
                if (Regex.IsMatch(name1[i], "^[S]"))
                {
                    name2.Add(name1[i]);
                }
            }
        }
        public void PrintName()
        {
            Console.WriteLine("\nBosh harf S bolgan Ismlar : ");
            foreach (string item in name2)
            {
                Console.WriteLine(item);
            }

        }

    }
}
