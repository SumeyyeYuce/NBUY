namespace Proje12_OOP_Work_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            




           

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("1.ID GİR");
                int ıd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1.Adı GİR");
                string ad=Convert.ToString(Console.ReadLine());
                Console.WriteLine("1.Açıklamayı gir");
                string acıklama = Convert.ToString(Console.ReadLine());

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ögrenci Adı:");
                    string adı=Convert.ToString(Console.ReadLine());    
                    Console.WriteLine("Ögrenci Soyadı:");
                    string soyad=Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Ögrenci Yaşı:");
                    int yas=Convert.ToInt32(Console.ReadLine());    
                    Console.WriteLine("Ögrenci Numarası:");
                    int numara=Convert.ToInt32(Console.ReadLine()); 
                }

                Bolum bolum = new Bolum() { Id =ıd, Adı=ad, Acıklama=acıklama,OgrencıListe=liste};

            }







            Console.ReadLine();
        }
    }
}