using _3_Modul.Lesson_1__Delegate_.HomeTask._1_vazifa;
using _3_Modul.Lesson_1__Delegate_.HomeTask._2_vazifa;

namespace _3_Modul.Lesson_1__Delegate_.LessonTask
{
    //public delegate void Del(string message);
    //public delegate void Delegat();
    public delegate void Del(double a, double b);

    internal class Lesson_1
    {

        public static void Main1()
        {
            Console.WriteLine("lesson 1");
            //Del start = MyClass.DelegateMethod;
            //Console.Write("Message : ");
            //string? a = Console.ReadLine();
            //start(a);
            //Delegat start2 = MyClass.delegateMethod;

            //Vazifa_1();
            Vazifa_2();

        }
        public static void Vazifa_1()
        {
            // 1_vazifa 
            Del math = Mathematics.Sum;
            math += Mathematics.Substract;
            math += Mathematics.Multiply;
            math += Mathematics.Divide;
            math.Invoke(4, 6);
        }
        public static void Vazifa_2()
        {
            // 2_vazifa
            MaxMin.Start(new List<int> { 4, 8, 1, 6, 74, 54, 12, 0, 68 });
        }

    }

    static class MyClass
    {
        public static void DelegateMethod()
        {
            Console.WriteLine("DelegateMethod(); ");
        }
        public static void DelegateStop()
        {
            Console.WriteLine("DelegateStop();");
        }
        public static void DelegateStart()
        {
            Console.WriteLine("DelegateStart();");
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine("Send sms " + message);
        }
    }

}
