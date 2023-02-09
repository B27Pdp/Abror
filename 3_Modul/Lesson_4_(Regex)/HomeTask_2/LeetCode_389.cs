using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_4__Regex_.HomeTask_2
{
    internal class LeetCode_389
    {
        public char FindTheDifference(string s, string t)
        {
            List<char> str = new List<char>(t);
            for (int i = 0; i < s.Length; i++)
                str.Remove(s[i]);
            return str[0];
        }

    }
}
