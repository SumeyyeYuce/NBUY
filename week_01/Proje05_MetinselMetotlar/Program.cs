namespace Proje05_MetinselMetotlar;
class Program
{
    static void Main(string[] args)
    {
        ////bu projede metinsel işlemlere dair bazı metodlar ögrenecegiz
        //string metin = "Wissen Akademie";
        //int uzunluk = metin.Length;
        //Console.WriteLine($"{metin} metni {uzunluk} karakterdir");

        //string metin = "WİSSEN";
        //string kucuMetin = metin.ToLower();
        //Console.WriteLine(kucuMetin);
        //string buyukMetin = kucuMetin.ToUpper();
        ////Console.WriteLine(buyukMetin);

        //string m1 = "Wissen ";
        //string m2 = "Wissen ";
        //int sonuc = String.Compare(m1, m2);
        //Console.WriteLine(m1);
        //Console.WriteLine(m2);
        //Console.WriteLine(sonuc);

        //Console.Write("Birinci Metni Giriniz:");
        //string m1 = Console.ReadLine();
        //Console.Write("İkinci Metni Giriniz:");
        //string m2 = Console.ReadLine(); 
        //int sonuc=String.Compare(m1, m2);
        //if (sonuc==0)
        //{
        //    Console.WriteLine("Girilen iki metin birbirine Eşittir.");
        //}
        //else
        //{
        //    Console.WriteLine("Girilen iki metin birbirinden farklıdır");
        //}

        //string m1 = "İşkur";
        //string m2 = "Eğitimleri";
        //string m3 = "Wissen";
        //// string sonuc= m1+ m2;
        //string sonuc = String.Concat(m1, m2,m3);
        //Console.WriteLine(sonuc);

        //string ad = "Sümeyye";
        //int yas = 22;
        //string okul = "BAU";
        //Console.WriteLine($"Benim adım {ad}, {yas} yasındayım, Okulumun adı{okul}");

        //string metin1 = "Benim ADIM SÜMEYYE";
        //string metin2 = "yasım 22";
        //string metin3 = "okulum bau";
        ////string sonuc = ad + yas + okul;
        //string sonuc = String.Concat(metin1, metin2, metin3);
        //Console.WriteLine(sonuc);


        //string sonuc1 = "benim adım" + ad + "." + yas + "yasındayım";

        //string metin = "Merhaba bu hafta bu eğitime başladık.";
        //bool sonuc = metin.Contains("e");
        //Console.WriteLine(sonuc);

        string adres = "Selami şehit Ali Mahallesi Can Sokak No:6 Kadıköy/Ankara";
        //bool sonuc = adres.EndsWith("İstanbul");
        //bool sonuc2 = adres.StartsWith("istanbul");
        //Console.WriteLine(sonuc+" ,"+sonuc2);

        //adres içindeki c harfi kaçıncı sıradadır.
        //string aranacakİfade = "Ş";

        //int sıraNo = adres.ToLower().IndexOf(aranacakİfade.ToLower());//kuçukharfe döndğr sonra ara.

        //Console.WriteLine($"C harfi {adres} içinde,{sıraNo}.sıradadır");

        //string aranacakİfade = "Şehit ali";

        //int sıraNo = adres.ToLower().IndexOf(aranacakİfade.ToLower());//kuçukharfe döndğr sonra ara.

        //Console.WriteLine($"{aranacakİfade} ifadesi {adres} içinde,{sıraNo}.sıradadır");

        //string ad = "Engin";
        //int yas = 47;
        //string okul = "BAU";
        /*
         * Benim adım Engin. 47 yaşındayım. Okuduğum okulun adı BAU.
         * 1) + operatörü ile
         * 2) Concat ile
         * 3) $"" ile 
         */

        ////Çözüm-1
        //string sonuc1 = "Benim adım " + ad + ". " + yas + " yaşındayım. Okuduğum okulun adı " + okul;
        //Console.WriteLine(sonuc1);
        ////Çözüm-2
        //string sonuc2 = String.Concat("Benim adım ", ad, ". ", yas, " yaşındayım. Okuduğum okulun adı ", okul); 
        //Console.WriteLine(sonuc2);
        ////Çözüm-3
        //string sonuc3 = $"Benim adım {ad}. {yas} yaşındayım. Okuduğum okulun adı {okul}";
        //Console.WriteLine(sonuc3);
        //string metin = "Merhaba. Bu hafta eğitime başladık.";
        //bool sonuc = metin.Contains(" ");
        //Console.WriteLine(sonuc);

        //string ad = "Sümeyye";
        //int yas = 22;
        //string okul = "BAU";

        //string sonuc1 = "Benim adım" + ad + "," + yas + "yasındayım. Okulumun adı:" + okul;
        //Console.WriteLine(sonuc1);

        //string sonuc2 = String.Concat("Benim adım", ad, ".", yas, "yasındayım. Okulumun adı", okul);
        //Console.WriteLine(sonuc2);

        //string sonuc3 = $"Benim adım {ad}. {yas} yaşındayım. okulumun adı {okul}";
        //Console.WriteLine(sonuc3);


        //string metin = "Wissen Akademie";
        //Console.WriteLine($"Metnin ilk hali:{metin}");
        //Console.WriteLine($"Akademie ifadesi silindikten sonraki hali:{metin.Remove(7)}");//remove silme işlemi yapar
        //Console.WriteLine($"Aka ifadesi silindikten sonraki hali:{metin.Remove(7,3)}");//7 ile 3 arasındakileri siliyor


        string urunAd = "Iphone 13 Pro";
        //iphone-13-pro bu haline dönüştürmek istiyoruz.
        //string sonuc = (urunAd.Replace(" ","-")).ToLower();
        string sonuc = urunAd.ToLower().Replace(" ", "-");//yukarıdali kod satırıyla aynı işlevi görüyor
        Console.WriteLine(sonuc);

        string sonuc2 = urunAd.Replace("Iphone", "Samsung");//iphonu samsunga dönüştür dedik
        Console.WriteLine(sonuc2);






    }
}
