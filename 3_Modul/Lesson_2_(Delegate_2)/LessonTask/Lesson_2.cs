using _3_Modul.Lesson_2__Event_.HomeTask;
using System;

namespace _3_Modul.Lesson_2__Event_.LessonTask
{
    public delegate int Math(int num);
    public delegate int Math2(int num);

    public class Lesson_2
    {
        public static void Main2()
        {
            // Lessonn();
            HomeTaskk Homework = new();
            HomeTaskk.Home();

            
        }

        public static void Lessonn()
        {

            Console.WriteLine("Lesson 2");
            // LambdaExpation
            Console.Write("LambdaExpation : ");
            Math Lambda = num => num * num;
            Math2 lambda2 = num => num + num;
            int res = lambda2(40);
            Console.WriteLine(res);

            // AnonymExpation
            Console.Write("AnonymExpation : ");
            Math2 Anoynm = delegate (int num) { return num * num; };
            Math Anonym = a => a * a;
            Console.WriteLine(Anonym(4));

            // Functoin
            Console.Write("Func : ");
            Func<int, double> func = (int num) => (num + num);
            double s = func(45);
            Console.WriteLine(s);
            string k = "hello";
            //Action
            Console.Write("Action : ");
            Action<int, double> Action = (a, b) =>
            {
                Console.WriteLine(a + b);
            };
            Action(4, 5);
            Console.Write("Action kiruvchi parametrsiz : ");
            Func<int> funcc = () => k.Length;
            Action<int> actionn = k =>
            {
                Console.WriteLine(k);
            };
            actionn(k.Length);
        }

    }
}







