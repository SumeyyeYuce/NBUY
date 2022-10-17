namespace Proje04_TipDönüştürme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte a = 5;
            //short b = 10;
            //sbyte c = 30;
            //int d = a + b + c;//implicit convert - Örtülü dönüştürme
            //Console.WriteLine($"sonuç(d) ={d}");

            //string metin = "NBUY";
            //char karakter = 'k';
            //object e = metin + karakter + d;//implicit convert -Örtülü Dönüştürme
            //Console.WriteLine($"Object={e}");

            //byte a = 155;
            //byte b = 101;
            ////byte c = Convert.ToByte(a + b);//Explicit convert -Bilinçli dönüşüm
            ////Console.WriteLine($"sonuç(c): {c}");

            //byte d = (byte)(a + b);//burada demek istedği a + b yi çıkar ve bayta dönüştür(unboxing)
            //Console.WriteLine($"sonuç(d):{d}");

            //int a = 511;
            //byte b = (byte)a;
            //Console.WriteLine(b);

            byte a = 155;
            byte b = 111;
            int c = a + b;
            Console.WriteLine(c);

            Convert.ToDouble(c);
            Convert.ToInt64(c);       
        
        }
    }
}