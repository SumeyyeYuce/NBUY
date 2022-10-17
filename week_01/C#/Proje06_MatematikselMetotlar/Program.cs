namespace Proje06_MatematikselMetotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 43;
            //int sayi2 = 55;
            //int minimum=Math.Min(sayi1, sayi2); //iki sayıyı karşılaştırıp hangisinin küçük oldugunu bulucak.
            //Console.WriteLine(minimum);
            //int maximum=Math.Max(sayi1, sayi2);
            //Console.WriteLine($"maximum:{ maximum} \n minmum:{minimum}");


            //int taban = 4;
            //int us = 3;
            //double sonuc= Math.Pow(taban, us);
            //Console.WriteLine(sonuc);

            //Console.Write("Taban:");   
            //int taban =Convert.ToInt32(Console.ReadLine());// string olan ifadeyi toınt32 ile inte çevirdi
            //Console.Write("üs:");
            //int us =int.Parse(Console.ReadLine());//stringi inte çevirdi (parse)
            //double sonuc = Math.Pow(taban, us);
            //Console.WriteLine($"Sonuç:{sonuc}");

            double sayi = 5.493486;
            Console.WriteLine(Math.Ceiling(sayi));//ceiling sayıyı bir üstteki en küçük sayıya yuvarlıyor
            Console.WriteLine(Math.Floor(sayi));// floor sayıyı tabana yuvarlıyor

            Console.WriteLine(Math.Round(sayi,0));//virgülden sonra hangi basamaga yuvarlamsı gerektiğini söylüyor



        }
    }
}