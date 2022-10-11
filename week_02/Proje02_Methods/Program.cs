namespace Proje02_Methods
{
    //internal class Program
    //{
    //    ////kendi içindeki kodları çalıştırıp başka hiç birşey yapmasına gerek kalmicaksa void diyoruz.
    //    ////topla()  parantez aç kapa yaparsak metod oldugunu anlarız.
    //    //static void Topla(int sayı1,int sayı2)//sayı1=s1  sayı2=s2 oluyor
    //    //{
    //    //    int toplam = sayı1 + sayı2;
    //    //    Console.WriteLine();
    //    //    Console.WriteLine($"Toplam{toplam}");
    //    //}

    //    //eger bir methodda void yazıyorsa geriye deger döndürme diyoruz
    //    //static void Cıkar(int sayı1, int sayı2)//sayı1=s1  sayı2=s2 oluyor
    //    //{
    //    //    int fark = sayı1 - sayı2;
    //    //    Console.WriteLine();
    //    //    Console.WriteLine($"fark{fark}");
    //    //}

    //    //eger bir methodda int byt... gibi degerler yazıyorsa return yani geriye deger döndür diyoruz
    //    static int Topla(int sayı1,int sayı2)//bu methodun geriye döndürecegi deger int dir
    //    {
    //        return sayı1 + sayı2;//return geri döndürme
    //    }
    //    static int Cıkar(int sayı1, int sayı2)//bu methodun geriye döndürecegi deger int dir
    //    {

    //        return sayı1 - sayı2;//return geri döndürme
    //    }
    //    static int sıraNoBul(string metın1,string metın2)
    //    {



    //    }

    //    static void Main(string[] args)//METHOD
    //    {
    //        //  Console.Write("Birinci sayıyı giriniz:");
    //        //  int s1=int.Parse(Console.ReadLine());
    //        //  Console.Write("İkinci sayıyı giriniz:");
    //        //  int s2=int.Parse(Console.ReadLine());

    //        //int toplam=Topla(s1,s2);//yukarıdaki methodu çagırdık          
    //        //int fark= Cıkar(s1,s2);


    //        //  Console.WriteLine($"toplam:{toplam},FARK:{fark}");
    //        //  Console.WriteLine($"{toplam-fark}");



    //        //Kendisine verilen metnin içinde, aradığımız karekterin kaçıncı sırada oldugunu bulan methodu yazınız
    //        //Kendisine verilen metnin içinde aradığımız karakterin olup olmadıgını bize söyleyen bir methodu bulunuz

    //        Console.WriteLine(sıraNoBul("Wissen Akademie","A"));

    //        Console.WriteLine(VarMı("Wissen Akademie",'A')==true?"içinde geçiyor":"içinde geçmiyor");



    //    }
    //}


    public class Program
    {
        //static void Topla(int sayi1,int sayi2)
        //{
        //    int toplam = sayi1 + sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Toplam: {toplam}");
        //}
        //static void Cikar(int sayi1, int sayi2)
        //{
        //    int fark = sayi1 - sayi2;
        //    Console.WriteLine();
        //    Console.WriteLine($"Fark: {fark}");
        //}

        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Cikar(int sayi1, int sayi2)
        {
            int fark = sayi1 - sayi2;
            return fark;
        }

        static int SiraNoBul(string metin, char karakter)
        {
            int sonuc = metin.IndexOf(karakter);
            return sonuc;
        }

        static bool VarMi(string metin, char karakter)
        {
            bool sonuc = metin.Contains(karakter);
            return sonuc;
        }

        static void Main(string[] args) //METHOD
        {
            //#region ToplamaCikarma
            ////Console.Write("Birinci Sayı: ");
            ////int s1 = int.Parse(Console.ReadLine());
            ////Console.Write("İkinci Sayı: ");
            ////int s2 = int.Parse(Console.ReadLine());

            ////int toplam = Topla(s1, s2);
            ////int fark = Cikar(s1, s2);

            ////Console.WriteLine($"Toplam: {toplam}, Fark: {fark}");
            ////Console.WriteLine($"{toplam-fark}");
            //#endregion
            //#region IndexOfMuadiliMetot
            ////Kendisine verilen metnin içinde, aradığımız karakterin kaçıncı sırada olduğunu bulan metodu hazırlayınız.
            //Console.WriteLine(SiraNoBul("Wissen Akademie", 'A'));
            //#endregion
            //#region ContainsMuadiliMetot
            ////Kendisine verilen metnin içinde, aradığımız karakterin OLUP OLMADIĞINI bize söyleyen bir metodu hazırlayınız.
            //Console.WriteLine(VarMi("Wissen Akademie", 'A') == true ? "İçinde geçiyor" : "İçinde geçmiyor");
            //#endregion




            //#region MethodOverload

            MethodOverload methodOverload = new MethodOverload();
           // methodOverload.DenemeMetodu();

            Console.WriteLine(methodOverload.Topla(23, 34));
            //Console.WriteLine(methodOverload.Islem(true, 50, 10, 5));
            //#endregion
            int[] sayilar = { 56, 44, 66, 77, 89,100 };
            Console.WriteLine(methodOverload.Topla(sayilar));

        }
    }
}