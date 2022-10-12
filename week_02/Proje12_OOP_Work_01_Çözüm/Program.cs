namespace Proje12_OOP_Work_01_Çözüm
{
    interface IBase//hepsinin atsı olsun.hep bolumde hemde ögrencide olanlar olsun
    {
        public int ıd { get; set; }
        public string Ad { get; set; }
    }

    class Bolum : IBase
    {
        public int ıd { get; set; }
        public string Ad { get; set; }
        public string Acıklama { get; set; }
        public List<Ogrencı> Ogrencıler { get; set; }
    }
    class Ogrencı : IBase
    {
        public int ıd { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    internal class Program
    {
        //burası sadee string alır ve geriye string geriye döner
        static string GırısYap(string baslık)//metot
        {
            Console.Write(baslık);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i <2; i++)
            {

                Bolum bolum = new Bolum();
                bolum.ıd=int.Parse(GırısYap($"{i + 1}.Bölüm id:"));//id'yi bir atrrtır.
                bolum.ıd = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i + 1}.Bölümun adı:");
                bolum.Ad = Console.ReadLine();
                Console.WriteLine($"{i + 1}.Bölümun acıklaması:");
                bolum.Acıklama = Console.ReadLine();


                //Bolum bolum = new Bolum();
                //Console.Write($"{i+1}.Bölüm id:");//id'yi bir atrrtır.
                //bolum.ıd=int.Parse(Console.ReadLine());
                //Console.WriteLine($"{i+1}.Bölümun adı:");
                //bolum.Ad = Console.ReadLine();
                //Console.WriteLine($"{i + 1}.Bölümun acıklaması:");
                //bolum.Acıklama = Console.ReadLine();


                List<Ogrencı> ogrencıler = new List<Ogrencı>();                                              //bolumler.Add(bolum);//bölümleri listeye ekle.
                for (int j = 0; j < 3; j++)
                {
                    







                    //Ogrencı ogrencı = new Ogrencı();
                    //Console.Write($"{j + 1}.Ögrenci id:");
                    //ogrencı.ıd=int.Parse(Console.ReadLine());
                    //Console.Write($"{j + 1}.Ögrenci No:");
                    //ogrencı.OgrNo = int.Parse(Console.ReadLine());
                    //Console.Write($"{j + 1}.Ögrenci AD:");
                    //ogrencı.Ad = (Console.ReadLine());
                    //Console.Write($"{j + 1}.Ögrenci Soyad:");
                    //ogrencı.Soyad = (Console.ReadLine());
                    //Console.Write($"{j + 1}.Ögrenci yaş:");
                    //ogrencı.Yas = int.Parse(Console.ReadLine());
                    //ogrencıler.Add(ogrencı);

                }
                bolum.Ogrencıler = ogrencıler;
                bolumler.Add(bolum);

            }
            foreach (var bolum in bolumler)
            {
                Console.WriteLine($"Bölüm id:{bolum.ıd}-Bölüm Adı:{bolum.Ad}-Bölüm Açıklaması:{bolum.Acıklama}");

                foreach (var ogrencı in bolum.Ogrencıler)
                {
                    Console.WriteLine($"ögrenci ıd:{ogrencı.ıd}-ogrenci No:{ogrencı.OgrNo}-öhrenci ad soyad:{ogrencı.Ad}" +
                        $"{ogrencı.Soyad}-ögrenci yaş:{ogrencı.Yas}");
                }
            }
           
            Console.ReadLine();
        }
    }
}

//Bolum bolum = new Bolum();
//Console.Write($"{i + 1}.Bölüm id:");//id'yi bir atrrtır.
//bolum.ıd = int.Parse(Console.ReadLine());
//Console.WriteLine($"{i + 1}.Bölümun adı:");
//bolum.Ad = Console.ReadLine();
//Console.WriteLine($"{i + 1}.Bölümun acıklaması:");
//bolum.Acıklama = Console.ReadLine();
