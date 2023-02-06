using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Modul.Lesson_3__Event_.Try_end_Catch._2_vazifa
{
    internal class Card
    { /*2. Card class(Id, Owner, Balance va CardType) va CardType enum(UZCARD, HUMO,VISA, UNIONPAY)
       * toifalarini yarating. Ularga mos ravishda cutom CardTypeNotMatch(cartalar tiofasi mos
       * bo’lmagan holat) va NotEnoughMoney(pul yetarli bo’lmagan holat) exceptionlari orqali
       * kartadan kartaga pul o’tkazuvchi dastur tuzing. Uzcard va humo kartalari pul birligi
       * so’m hamda Visa va Unionpay kartalari pul birligi dollar. Pul birligi bir xil bo’lgan
       * kartalardan bir-biriga pul o’tkazish tartibi o’rnatilgan. Agarda bunday tartibdan boshqa
       * tarzda pul o’tkazishga urinish bo’lsa CardTypeNotMatch exceptioni chaqirilsin.
       * Agarda hisobdagi pul ko’chirilayotgan summadan kam bo’lsa NotEnoughMoney exceptioni
       * chaqirilsin. (Qiyin)*/
        public int Id { get; set; }
        public string Owner { get; set; }
        public double Balance { get; set; }
        public CardType _Card { get; set; }
        public Valyuta Valyuta { get; }

        public Card(double balance, CardType _Card, Valyuta Valyuta)
        {
            Balance = balance;
            this._Card = _Card;
            this.Valyuta = Valyuta;
        }

    }
    enum CardType
    {
        UZCARD,
        HUMO,
        VISA,
        UNIONPAY
    }
    enum Valyuta
    {
        Dollar,
        Som
    }

}
