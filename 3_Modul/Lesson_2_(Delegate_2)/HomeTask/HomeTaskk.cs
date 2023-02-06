using System.Security.Cryptography.X509Certificates;

namespace _3_Modul.Lesson_2__Event_.HomeTask
{
    public delegate double Mathh(Double a);
    public class HomeTaskk
    {
        public static void Home()
        {
            // LambdaExpation
            Console.WriteLine("LambdaExpation");
            int a = 16;
            Mathh MathPow = pow => (double)Math.Pow(2, pow);
            Console.WriteLine(a + " Pow() => " + MathPow(a));
            Mathh MathSqrt = Sqrt => (double)Math.Sqrt(Sqrt);
            Console.WriteLine(a + " Sqrt() => " + MathSqrt(a));
            Mathh MathAbs = Abs => Math.Abs(Abs);
            Console.WriteLine(a + " Abs() => " + MathAbs(a));
            Console.WriteLine("AnonymExpation");
            //AnonymExpation
            Mathh MathSin = delegate (Double a) { return Math.Sin(a); };
            Console.WriteLine(a + " Math.Sin => " + MathSin(a));
            Mathh MathCos = delegate (double a) { return Math.Cos(a); };
            Console.WriteLine(a + " Math.Cos => " + MathCos(a));
            Mathh MathLog = delegate (double a) { return Math.Log(a); };
            Console.WriteLine(a + " Math.Log => " + MathLog(a));
            Console.WriteLine("Functoin");
            // Functoin
            Func<List<int>, double> List = (List<int> a) => a.Count;
            Func<Queue<int>, int> Queue = (Queue<int> a) => a.Max();
            Func<int, int> array = (int a) => a.CompareTo(0);
            Func<string, bool> str = (string a) => a.IsNormalized();
            Console.WriteLine("Action");
            //Action
            Action<int> action = a =>
            {
                Console.WriteLine(a + " Length => " + a.ToString().Length);
            };
            action(79879799);
            Action<string> txt = a =>
            {
                Console.WriteLine(a.TrimStart().TrimEnd());
            };
            txt("    hello World  ");
            Action<char> charr = a =>
            {
                Console.WriteLine(a + " <= GetHashCode => " + a.GetHashCode());
            };
            charr('4');
            Action<List<int>> list = list =>
            {
                Console.WriteLine(list.Capacity);
            };
            Console.WriteLine("Predicate");
            // Predicate
            Predicate<string> isEmailAddres = email => email.Contains('@');
            List<string> emails = new();
            Console.WriteLine(isEmailAddres("nabiddinovabror8@gmail.com"));
            Predicate<int> number = num => num.Equals(1);
            Console.WriteLine(number(4554));
            Predicate<Array> arr = k => k.IsReadOnly;
            //Dictionary
            Dictionary<string ,int> dict = new Dictionary<string ,int>();


        }
    }
}
