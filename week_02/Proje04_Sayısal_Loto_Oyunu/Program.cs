using System.Collections;

namespace Proje04_Sayısal_Loto_Oyunu
{
    
    internal class Program
    {
       static int[] SayıUret()
        {
            Random rnd=new Random();//yanında new yazan bir satır gördüğümüzda kafamızda ram'ın iki tarafı(heap,stack) oluşsun ,   //ramdom tipinde yeni bir değişken yaratıyor
            int[] loto = new int[6];//sayılar adındda bir dizi oluşturup sayıları burda tutucaz
            int sayı;
            for (int i = 0; i < 6; i++)
            {
                sayı = 0;
                do
                {
                    sayı = rnd.Next(1, 50);//1-50 arasında sayı üret.sayılar diziisnin i.ninci elamaına ata

                } while (loto.Contains(sayı));//sayı dizide varmı?//while de ture dönüyosa do ya çık demek
                loto[i] = sayı;//lotonun i.ninci elamınıa sayıyı ata
               
            }
            return loto;//lotonun tipiyle methodun tipi aynı olmalı
        }

        static void Hile(int[]loto)//lotoyu tanıması içinde parametre koyduk (int[] loto) loto dizi oldugu için parantez içine dizi dedik.Parantez içine ne yollicaksan ona göre yazıyoruz
        {
            Console.WriteLine("Hile:");
            Console.WriteLine("*******");
            foreach (var sıradakıSayı in loto)//loto dizisindeki saylarda dolaşıcak ve her dolaştığında sıradakisayı dicek
            {
                Console.WriteLine(sıradakıSayı);
            }

        }
        static int TahminYap(int tahminSıraNo)//Kullanıcının her tahmin yapışını burası saglicak
        {
            int tahmin;
            Console.Write($"{tahminSıraNo}.tahmininizi giriniz: ");
            tahmin = int.Parse(Console.ReadLine());
            return tahmin;
        }
        static void Main(string[] args)
        {
            /*
             * 1)sistem  1-49 arasında 6 tane farklı sayı üretsin.
             * 2)Kullanıcıdan 6 tane tahmin alalım
             * 3)Sonuç OLARak kullanıcının kaç tane doğru tahmin yaptığını, tahminleriyle birlikte yazdıralım
             * 4)NOT:Hiç doğru tahmin yapamassa KAYBETTİNİZ yazsın
             */

            int[] loto = SayıUret();
            int[] tahminler = new int[6];//kullanıcıdan aldığımız 6 tane sayıyı tutar.
            Hile(loto);//hileyi çagırdık amalotoyu tanımıypr.
            int tahmin;
            for (int i = 0; i < 6; i++)
            {
                do
                {
                   tahmin= TahminYap(i + 1);//tahmin yapı çagırıcak

                } while (tahmin<0 || tahmin>49);//eger tahmin 0 dan küçük ya da büyükse o zaman do'nun içine gir ve döngüyü tekrar döndür diyoruz.

                tahminler[i] = tahmin;//kullanıcının girdiği tahminleri yazıcak

            }
            ArrayList bilinenler = new ArrayList();//Arraylistlerin kaç elamanlı olacagı söylenmez,içinde her bir eleman istenilen tipte deger tutabilir,int,char,string vs..
            foreach (var sıradakıTahmin in tahminler)
            {
                if (loto.Contains(sıradakıTahmin))//loto dizisinin içinde sıradakitahmin varmı
                {
                    bilinenler.Add(sıradakıTahmin);
                }

            }
            if (bilinenler.Count==0)//bilinenler arraylisinde kaç tane elamn var (count)
                                     //sıfır tane eleman varsa
            {
                Console.WriteLine("Kaybettiniz.Hiç bilemediniz");
            }
            else
            {
                Console.WriteLine($"Tebrikler,{bilinenler.Count} adet doğru tahmi yaptınız");
                foreach (var sıradakiBilinen in bilinenler)
                {
                    Console.WriteLine(sıradakiBilinen);
                }
            }
            Console.ReadLine();
        }
    }
}