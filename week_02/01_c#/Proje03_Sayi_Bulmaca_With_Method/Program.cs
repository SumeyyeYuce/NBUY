namespace Proje03_Sayi_Bulmaca_With_Method
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //Sayı bulmaca oyununu, yeni öğrendiğiniz methods konusu bağlamında yeniden hazırlayınız.
            /*
             * 1) 5 tercih hakkı olsun.
             * 2) Puan sistemi olsun. (1.tercihinde bildiyse 50, bilmedikçe 10'ar 10'ar düşsün.)
             * 3) Oyunu kaybettiğinde ya da kazandığında YENİDEN OYNAMAK İSTİYOR ise OYNAYABİLSİN!
             */
            string tercih;
            do
            {
                Console.Clear();
                Oyun.Oyna();
                do
                {
                    //Console.Clear();
                    Console.Write("Yeniden oynamak ister misiniz?[E/H]");
                    tercih = Console.ReadLine().ToUpper();
                } while (tercih != "H" && tercih != "E");
            } while (tercih != "H");
            Console.ReadLine();

        }
    }
}