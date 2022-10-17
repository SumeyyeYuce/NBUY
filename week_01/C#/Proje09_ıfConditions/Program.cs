namespace Proje09_ıfConditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * if(bool)
             * {
             *     bool true ise yapılacak işler
             * }
             
             */
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //if (sayı>=0)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //}

            //Kullanıcıdan yaşını girmesini iste
            //18 yaşından küçüklere "GİRİŞ YASAK" yazısı yazsın
            //Console.Write("Bir Sayı Giriniz:");
            //byte yas = Convert.ToByte(Console.ReadLine());
            //if (yas< 18)
            //{
            //    Console.WriteLine("Giriş Yasak");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş Serbest");
            //}

            //Girilen iki sayıdan büyük olanı yazdır
            //Console.Write("1.Sayıyı gir:");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı gir:");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //if (sayı1>sayı2)
            //{
            //    Console.WriteLine($"Büyüy sayı:{sayı1}");
            //}
            //else if (sayı2>sayı1)
            //{
            //    Console.WriteLine($"Büyük sayı: {sayı2}");
            //}
            //else
            //{
            //    Console.WriteLine($"sayı 1({sayı1}) ve sayı2 ({sayı2}) birbirlerine eşittir");

            //}

            //girilen 3 sayıda büyük olanı yazdır


            //Console.Write("1.Sayıyı gir:");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı gir:");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3.Sayıyı gir:");
            //int sayı3 = Convert.ToInt32(Console.ReadLine());

            //if (sayı1>=sayı2 && sayı1>=sayı3)
            //{
            //    Console.WriteLine(sayı1);
            //}
            //else if (sayı2>=sayı1 && sayı2>=sayı3)
            //{
            //    Console.WriteLine(sayı2);
            //}
            //else if (sayı3>=sayı1 && sayı3>=sayı2)
            //{
            //    Console.WriteLine(sayı3);
            //}














            //doğru olmayan algoritma
            //Console.Write("1.Sayıyı gir:");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı gir:");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("3.Sayıyı gir:");
            //int sayı3 = Convert.ToInt32(Console.ReadLine());

            //if (sayı1>sayı2)
            //{
            //    if (sayı1>sayı3)
            //    {
            //        Console.WriteLine(sayı1);
            //    }
            //}
            // if(sayı2>sayı1)
            //{
            //    if (sayı2>sayı3)
            //    {
            //        Console.WriteLine(sayı2);
            //    }
            //}
            // if (sayı3>sayı1)
            //{
            //    if (sayı3>sayı2)
            //    {
            //        Console.WriteLine(sayı3);
            //    }

            //}


            //Console.Write("1.Sayıyı gir:");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı gir:");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //int buyukSayı=0;//default  değeri ver (başlangıç değeri)
            //if (sayı1 > sayı2)
            //{
            //    buyukSayı = sayı1;
            //}
            //else if (sayı2 > sayı1)
            //{
            //    buyukSayı = sayı2;
            //}
            ////else
            ////{
            ////    buyukSayı = sayı2;
            ////}
            //Console.WriteLine(buyukSayı);

            //Console.Write("1.Sayıyı gir:");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("2.Sayıyı gir:");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());
            //int buyukSayı = sayı1 > sayı2 ? sayı1 : sayı2;//bu satırda sayı1, sayı1 sayı2 den buyukse sayı1 i yaz değilse sayı2 yi yaz


            Console.Write("1.Sayıyı gir:");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı gir:");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayı1 > sayı2 ? "1.Sayı 2.Sayıdan büyüktür" : 
                                sayı2 > sayı1 ? "2.sayı 1. sayıdan büyüktür":
                                    "iki sayı birbirine eşittir";
            Console.WriteLine(sonuc);


            


        }
    }
}