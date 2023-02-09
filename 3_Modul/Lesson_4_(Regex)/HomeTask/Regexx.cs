using System.Text.RegularExpressions;

namespace _3_Modul.Lesson_4__Regex_.HomeTask
{
    public class Regexx
    {
        
        public void RegexStart()
        {
            /*
            * ^ - Starts with
            * $ - Ends with
            * [] - Range
            * () - Group
            * . - Single character once
            * + - one or more characters in a row
            * ? - optional preceding character match
            * \ - escape character
            * \n - New line
            * \d - Digit
            * \D - Non-digit
            * \s - White space
            * \S - non-white space
            * \w - alphanumeric/underscore character (word chars)
            * \W - non-word characters
            * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
            * (x|y) - Alternative - x or y
            * 
            * [^x] - Anything but x (where x is whatever character you want)
            */
            Console.Write("str kiriting : ");
            string InputString = Console.ReadLine() ??"No text";

            //Enter character which exists between a-g ?
            //Console.Write("Enter character which exists between a-g ? : ");
            //Console.WriteLine(Regex.IsMatch(InputString, "[a-g]"));
            //Console.WriteLine(Regex.IsMatch(InputString,"[a-h]{4}"));
            //Console.WriteLine(Regex.IsMatch(InputString,"[0-9]"));
            //Console.WriteLine(Regex.IsMatch(InputString, "[0-9]{7}"));
            //Console.WriteLine(Regex.IsMatch(InputString, "[0-9]{7,10}"));
            //Console.WriteLine(Regex.IsMatch(InputString,"45|54"));
            //Console.WriteLine(Regex.IsMatch(InputString,"^45"));
            //Console.WriteLine(Regex.IsMatch(InputString,"(45)"));
            //Console.WriteLine(Regex.IsMatch(InputString,@"\d"));
            //Console.WriteLine(Regex.IsMatch(InputString, @"\n"));
            Console.WriteLine(Regex.IsMatch(InputString, @"\D"));





        }



    }
}
