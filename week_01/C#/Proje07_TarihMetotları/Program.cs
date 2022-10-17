namespace Proje07_TarihMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);//geçerli tarih ve saati alır
            //Console.WriteLine(DateTime.Today);//sadece tarihi getiriyor.

            //DateTime dogumTarihi = new DateTime(2000, 07, 17);//17/07/2000 demek
            //DateTime bugun = DateTime.Now;//şimdiki tarih
            //TimeSpan span= bugun.Subtract(dogumTarihi);//subtract istediğimiz tarihi çıkartıyor
            //Console.WriteLine($"topla{Math.Ceiling(span.TotalDays)}gündür yaşıyorsunuz");//toplam gün sayıyı totaldays

            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun.ToLongDateString());//5 ekim 2022 çarşamba diye yazar
            //Console.WriteLine(bugun.ToLongTimeString());//sadece saati yazdı 15:35:30
            //Console.WriteLine(bugun.ToShortDateString());//5/10/2022 diye yazıyor
            //Console.WriteLine(bugun.ToShortTimeString());//13:35 yazıyor

            //Bir sonraki yılın ilk gününün tarihini buldursun
            //DateTime bugun = DateTime.Now;
            //int yıl = bugun.Year +1;
            //DateTime sonuc = new DateTime(yıl,1,1);
            //Console.WriteLine(sonuc.ToLongDateString());

            //bir sonraki ayın ilk günün tarihi 1/11/2022

            //DateTime bugun = DateTime.Now;
            //int yıl = bugun.Year;
            //int ay = bugun.Month + 1;
            //DateTime sonuc = new DateTime(yıl, ay, 1);
            //Console.WriteLine(sonuc.ToLongDateString());

            //DateTime bugun = DateTime.Now;
            //Console.WriteLine(bugun+1);

            /*  ÖDEVVVV  ertesi günün tarihini bulup ekrana yazdıran programı yazınız.*/

            DateTime bugun = DateTime.Now;
            Console.WriteLine(bugun.ToLongDateString());
            int gelecekgün = bugun.Day+1;
            Console.WriteLine(gelecekgün);


        }
    }
}