using System.Globalization;
namespace Deneme
{
    interface IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }

    }

    class Bolum : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Acıklama { get; set; }
        public List<Ogrencı> Ogrenciler  { get; set; }

    }

    class Ogrencı : IBase
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int OgrNo { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

    }

    
    internal class Program
    {
        static string GirisYap(string baslık)
        {
            Console.Write(baslık);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Bolum> bolumler = new List<Bolum>();
            for (int i = 0; i < 2; i++)
            {
                Bolum bolum = new Bolum()
                {
                    Id=int.Parse(GirisYap($"{i+1}.Bölüm İd:")),
                    Ad=GirisYap($"{i+1}.Bölümün adı:"),
                    Acıklama=GirisYap($"{i+1}.Bölümün Açıklaması")
                };
                List<Ogrencı> ogrencıler = new List<Ogrencı>();
                Console.WriteLine($"{bolum.Ad} Bölümü Ögrencleri");
                Console.WriteLine("***********************");
            }
        }
    }
}