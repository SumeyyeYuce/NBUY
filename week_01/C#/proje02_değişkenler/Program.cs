namespace proje02_değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir değişkene isim verirken 
            //1)alfanumerik kareakter kullanılmaz(altire hariç)
            //2)türkçe karakter kullanılmaz
            //3)Özel ya da ayrılmış sözcükler kullanılmaz.
            //4)Değişken isimleri küçük büyük harf duyarlıdır.

            //BURASI COMMENT
            /* string adSoyad;
             adSoyad = "SümeyyeYüce";
             Console.WriteLine(adSoyad);
             Console.WriteLine("adSoyad");*/

            //int yas;
            //yas = 19;
            //Console.WriteLine(yas);

            //string adSoyad = "Ahmet Candan";
            //Console.WriteLine(adSoyad);
            //Console.WriteLine("Adı:" +adSoyad + ", Yaş:" +yas);//yaşın oldugu yere , ve boşluk koyduk ki daha düzgün gözüksün diye.

            //TAM SAYI
            //Console.WriteLine(byte.MinValue + "-" + byte.MaxValue);//değişkenin deger aralıgını bulabiliirz.
            byte say1 = 255;//byte 0 ile 255 sayısı arasında deger alır.
            int sayi2 = 45;
            long sayi3 = 167232343235455;

            //string sayi4 = "15";
            //Console.WriteLine(sayi4 + 2);

            //ONDALIKLI
            float a = 10.5f;//float ta sonuna f koy
            double b = 20.6;
            decimal c = 100.65m;//desimalde sonuna m koy

            //Karakter ve Metin
            string name = "Sümeyye Yüce";
            char cinsiyet = 'E';//içinde sadece tek bir karakter tutar

            //Mantıksal
            bool evliMi = true;
            evliMi = false;










        }
    }
}