namespace Proje15_Class_Property_Field
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Ogrenci ogrencı1 = new Ogrenci();
            
            ogrencı1.OgrNo = 20;
            ogrencı1.Ad = "Sümeyye";
            ogrencı1.Sınıf = "9/A";

            Ogrenci ogrencı2=new Ogrenci();
            ogrencı2.OgrNo = 22;
            ogrencı2.Ad = "Ahmet";
            ogrencı2.Sınıf = "10/C";

            //Aşşagıdaki gibi de yazabiliriz.
            Ogrenci ogrencı3 = new Ogrenci()
            {
                OgrNo = 15,
                Ad = "Umay",
                Sınıf = "10/C"
            };
            int[] sayılar = { 32, 54, 33 };
            Ogrenci[] ogrencıler = { ogrencı1, ogrencı2, ogrencı3 };
            //for (int i = 0; i < ogrencıler.Length; i++)
            //{
            //    Console.WriteLine($"AD:{ogrencıler[i].Ad}, SINIF:{ogrencıler[i].Sınıf}");

            //}

            foreach (var sıradakıOgrenci in ogrencıler)//neyin içinde dolaşmak istiyosak in'den sonra onu yazıyoruz
            {
                Console.WriteLine(sıradakıOgrenci.Ad + "," + sıradakıOgrenci.Sınıf);
            }

            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    Console.WriteLine(sayılar[i] * sayılar[i]);
            //}

            //foreach (var sıradakıSayı in sayılar)
            //{
            //    Console.WriteLine(sıradakıSayı*sıradakıSayı);
            //}



        }

        //bir classın içinde her ne varsa. her seferinde farklı bir kişi veya bir nesne için oluşturuluyor.
        class Ogrenci
        {
            private int ogrNo;

            public int OgrNo
            {
                get { return ogrNo; }
                set { ogrNo = value; }
            }

            //public int OgrNo { get; set; }
            //public string Ad { get; set; }

            private string ad;

            public string Ad
            {
                get { return ad.ToUpper(); }
                set { ad = value; }
            }

            public string Sınıf { get; set; }

        }
    }
}