using _3_Modul.Lesson_3__Event_.HomeTask._1_vazifa;
using _3_Modul.Lesson_3__Event_.HomeTask._2_vazifa;
using _3_Modul.Lesson_3__Event_.Try_end_Catch._1_vazifa;
using _3_Modul.Lesson_3__Event_.Try_end_Catch._2_vazifa;
using System.ComponentModel;


namespace _3_Modul.Lesson_3__Event_.LessonTask
{
    delegate void ClickSendSms(object? sender, string smsText);

    internal class Lesson_3
    {
        public void Main3()
        {
            // vazifa_2();
            //TryCatchVazifa_2();
            vazifa_1();

        }

        public void vazifa_1()
        {

            OnEvenNumberFount Number = new OnEvenNumberFount();
            Number.OnEvenNumberFound += CoupleNumberFound;

            Number.ListOfElement = new() { 87,89,43,55,21,33,99,77,45,25,52,45 }; ;

        }
        private void CoupleNumberFound(object sender, EventArgs e)
        {
            Console.WriteLine("Juft Raqam bor ");
        }

        /* public  void vazifa_2()
         {
             Subscriber KosmikStansiyaAppollon = new();//oy
             // Subscriber KosmikStansiya1 = new();//oy
             // Subscriber KosmikStansiya2 = new();//oy
             EventPublisher Yer = new() { Country = "O`zbekiston" };//yer


             // Yer.OnClickSendSms += new ClickSendSms(KosmikStansiyaAppollon.OnClickGetSms);
             Yer.OnClickSendSms += new HomeTask._2_vazifa.ClickSendSms(KosmikStansiyaAppollon.OnClickGetSms);
             //Yer.OnClickSendSms += KosmikStansiya1.OnClickGetSms;
             //Yer.OnClickSendSms += KosmikStansiya2.OnClickGetSms;


              Yer.SendSmsMessage();
               KosmikStansiyaAppollon.ShowAllMessages();


         }*/
        public void TryCatchVazifa_1()
        {
            TryCatch tryCatch = new TryCatch();
            tryCatch.TxtLength();
        }

        public void TryCatchVazifa_2()
        {
            Card Humo = new Card(9898, CardType.HUMO, Valyuta.Som);

            Card Visa = new Card(97987, CardType.VISA, Valyuta.Dollar);

            Card Uzcard = new Card(4597987, CardType.UZCARD, Valyuta.Som);

            Card UNIONPAY = new Card(65478977, CardType.UNIONPAY, Valyuta.Dollar);

        }

    }
}

