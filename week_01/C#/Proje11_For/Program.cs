namespace Proje11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <5; i++)
            //{
            //    Console.WriteLine($"{i+1}.Hello World");
            //}
            //int toplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{

            //    // toplam = toplam + i;
            //    toplam += i;//üsttekinin aynısı
            //}
            //Console.WriteLine($"toplam:{toplam}");

            //1 ile 10 arsındaki çift sayıların toplamı

            //int TOPLAM = 0;
            //for (int i = 0; i <= 10; i=i+2)
            //{
            //    TOPLAM += i;

            //}
            //Console.WriteLine(TOPLAM);



            //int TOPLAM = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i%2==0)
            //    {
            //        TOPLAM += i;
            //    }


            //}
            //Console.WriteLine(TOPLAM);

            // 1ile 10 arasındaki çift sayıların toplamı ve tek sayıların toplamı
            //int tektoplam = 0;
            //int çifttoplam = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        çifttoplam += i;
            //    }
            //    else
            //    {
            //        tektoplam += i;
            //    }


            //}
            //Console.WriteLine($"Tek sayıların toplamı{çifttoplam} tek sayıların toplamı{tektoplam}");


            //Soru:klavyeden iki sayı girilsin,Bu sayıların arasındaki sayıların toplamını ekrana yazdır.

            //Console.WriteLine("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam += i;


            //}
            //Console.WriteLine($"toplam:{toplam}");

            //Console.WriteLine("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //if (sayi2>sayi1)
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam += i;


            //    }
            //}
            //else
            //{
            //    for (int i = sayi1; i >= sayi2; i--)
            //    {
            //        toplam += i;


            //    }
            //}

            //Console.WriteLine($"toplam:{toplam}");


            //Console.WriteLine("1.sayıyı giriniz");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;
            //int min = Math.Min(sayi1, sayi2);//burada sayı1 ile sayı2 arasındaki minumum olanı bul
            //int max = Math.Max(sayi1, sayi2);//burada sayı1 ile sayı2 arasındaki maximum olanı bul
            //for (int i = min; i <= max; i++)
            //{
            //    toplam += i;


            //}
            //Console.WriteLine($"toplam:{toplam}");


            //Soru: Program kullancıdan bir sayı girmesini istesin.ancak kullanıcı sayı girmeye devam ettikçe
            //girilen sayıların toplmaı.sayı adedi belirsiz
            //uygulamanın gidip ekrana toplamı yazdırması için kullanıcının ekranı sayı yerine exit yazmasını 
            //kontrol edicez.


            //int toplam = 0;
            //string girilenDeger = "";

            //for (int i = 1; i < 1000000; i++)
            //{
            //    Console.Write($"{i}.sayıyı giriniz (Çıkış için exit):");
            //    girilenDeger = Console.ReadLine();
            //    if (girilenDeger.ToLower()=="exit")//İf küçük büyük harf duyarlı//burada tolower diyerek girilen harf büyükse bile küçüge çevir öyle yaz
            //    {
            //        break;//içinde bulunulan döngünün tamamlanmsı beklenilmeden istenilen bir anda durdurulur

            //    }
            //    toplam += Convert.ToInt32(girilenDeger);

            //}
            //Console.WriteLine(toplam);


            //    int toplam = 0;
            //    string girilenDeger = "";
            //    string sonucMetin = "";
            //    string sonEk = "+";
            //    for (int i = 1; i < 1000000; i++)
            //    {
            //        Console.Write($"{i}.sayıyı giriniz (Çıkış için exit):[Geçerli  toplam: {toplam}]:");
            //        girilenDeger = Console.ReadLine();
            //        if (girilenDeger.ToLower() == "exit")//İf küçük büyük harf duyarlı//burada tolower diyerek girilen harf büyükse bile küçüge çevir öyle yaz
            //        {

            //            break;//içinde bulunulan döngünün tamamlanmsı beklenilmeden istenilen bir anda durdurulur

            //        }
            //        sonucMetin = sonucMetin +girilenDeger + sonEk;//girilen sayıları 150+20+.... gibi göstericek
            //        toplam += Convert.ToInt32(girilenDeger);

            //    }
            //    int alınacakKısmınUzunluğu = sonucMetin.Length - sonEk.Length;//burada sondaki boşluk ve + yı koymamasını sagladık.
            //    sonucMetin = sonucMetin.Substring(0, alınacakKısmınUzunluğu);//substring bir metnin içinden istedğimiz kadar olan alana kadar alıyor
            //    Console.WriteLine( $"{sonucMetin}= {toplam}");


            //SORU:5x5 lik bir kare biçimini * işaretleriyle oluşturan uygulamayı yazınız
            //int satır = 5;
            //int sutun=5;

            //for (int i = 0; i <satır; i++)
            //{
            //    for (int j = 0; j <sutun; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //5x5 lik karenin içi boş olması
            int satır = 5;
            int sutun = 5;

            for (int i = 1; i <= satır; i++)
            {
                for (int j = 1; j <= sutun; j++)
                {
                    if (i==1 || i==satır )//eger 1.veya son satırdaysan
                    {
                        Console.Write("*");
                    }
                    else if (j==1 || j==sutun)//eger 1. veya son sutundaysan
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                            
                }
                Console.WriteLine();       
            }

            //ÖDEV:Üstteki içiboş kareyi oluşturan uygulamayı adım adım çalıştırarak anlamaya çalıştırın.

            //ÖDEV-1:1-100 ARASINDAKİ SAYILARIN ORTALAMSINI BULDURAN PROGRAM
            //ÖDEV2:1-100 ARASINDAKİ ÇİFT,TEK VE 5'İN KATI OLAN SAYILARIN ADETLERİ VE TOPLAMLAINI EKRANA YAZDIRAN PROGRAM
            //ÖDEV3:AŞŞAGIDAKİ YÜKSEKLİĞİ 5 TABANI 9 BR OLAN YILDIZLARDAN OLUŞAN DİK ÜÇGENİ ÇİZDİREN PROGRAM
            
          /* 
            *
            * *
            * ***
            * ****
            * *******
            * *********
            * 
            
           */

            //Console.WriteLine("selam");

        }
    }
}