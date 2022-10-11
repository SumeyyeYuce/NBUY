using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje03_Sayi_Bulmaca_With_Method
{
    public static class Oyun
    {
        public static int SayiUret()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 101);
            return sayi;
        }

        public static int TahminGir(int tahminSiraNo)
        {
            Console.Write($"{tahminSiraNo}.tahmininizi giriniz: ");
            return int.Parse(Console.ReadLine());
            //return Convert.ToInt32(Console.ReadLine());//bu benim yaptığım satır.Bir üstteki satırla aynı işi yapıyor.
        }

        public static string TespitEt(int tahmin, int sayi)
        {
            if (tahmin > sayi)
            {
                return "Daha küçük bir sayı gir!";
            }
            return "Daha büyük bir sayı gir";
        }

        public static void Oyna()
        {
            int sayi = SayiUret();
            int tahmin = 0;
            int puan = 50;
            string mesaj = "";
            bool sonuc = false;

            Console.WriteLine($"HİLE|Üretilen Sayı: {sayi}");
            for (int i = 1; i <= 5; i++)
            {
                tahmin = TahminGir(i);
                if (tahmin == sayi)
                {
                    sonuc = true;
                    break;
                }
                mesaj = TespitEt(tahmin, sayi);
                if (i != 5) Console.WriteLine(mesaj);
                puan -= 10;
            }
            mesaj = sonuc == true ? $"Kazandınız, puanınız: {puan}" : "Kaybettiniz";
            Console.WriteLine(mesaj);
        }
    }
}
