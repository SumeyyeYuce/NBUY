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

        string aranacakİfade = "Şehit ali";

        int sıraNo = adres.ToLower().IndexOf(aranacakİfade.ToLower());//kuçukharfe döndğr sonra ara.

        Console.WriteLine($"{aranacakİfade} ifadesi {adres} içinde,{sıraNo}.sıradadır");


    }
}
