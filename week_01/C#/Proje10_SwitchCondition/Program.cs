namespace Proje10_SwitchCondition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen bir sayıyın 5 olması halinde 2 katını
            //10olmsı halinde 3 katı ya da 15 olmsı halinde 4 katı olup olmadıgını ekrana yazan programı hazırla
            //eger üçü de değilse tanınmayan değer.

            //Console.Write("bir sayı giriniz");
            //int sayı=Convert.ToInt32(Console.ReadLine());
            //if (sayı==5)
            //{
            //    Console.WriteLine(sayı*2);
            //}
            //else if (sayı==10)
            //{
            //    Console.WriteLine(sayı*3);
            //}
            //else if (sayı==15)
            //{
            //    Console.WriteLine(sayı*4);
            //}
            //else
            //{
            //    Console.WriteLine("tanınmayan değer");
            //}


            //Console.Write("bir sayı giriniz(5-10-15)");
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 0;

            //switch (sayı)
            //{
            //    case 5:
            //        sonuc = sayı * 2;
            //        break;

            //    case 10:
            //        sonuc = sayı * 3;
            //        break;
            //    case 15:
            //        sonuc = sayı * 4;
            //        break;

            //    default:
            //        sonuc = 0;
            //        break;
            //}
            //if (sonuc==0)
            //{
            //    Console.WriteLine("Tanımlanmamış deger");
            //}
            //else
            //{
            //    Console.WriteLine(sonuc);
            //}




            //x-><10 2 ile çarpsın
            //x 11 ile 20 arasındaysa 3 ile çarpsın
            //x 21 ile 50 arasındaysa 4 ile çarpsın
            //x 51 ile 100 arasındaysa 5 ile çarpsın
            //x-> >100 10 ile çarp


            //çözüm: İF İLE

            //int x = 25;
            //int sonuc = 0;
            //int katsayı = 0;
            //if (x<=10)
            //{
            //    //onuc = x * 2;
            //    katsayı = 2;
            //}
            //else if (x<=20)
            //{
            //    //sonuc = x * 3;
            //    katsayı = 3;
            //}
            //else if (x<=50)
            //{
            //    // sonuc = x * 4;
            //    katsayı = 4;
            //}
            //else if (x<=100)
            //{
            //    //sonuc = x * 5;
            //    katsayı = 5;
            //}
            //else
            //{
            //    // sonuc = x * 10;
            //    katsayı = 10;
            //}
            //Console.WriteLine($"X={x},sonuç:{sonuc}");
            //Console.WriteLine( $"x:{x},sonuç:{x} x {katsayı}:{sonuc}");


            //int x = 120;
            //int katsayı = 0;
            //switch (x)
            //{

            //    case (>= 0 and <= 10):
            //        katsayı = 2;
            //        break;

            //    case (>= 11 and <= 20):
            //        katsayı = 3;
            //        break;

            //    case (>= 21 and <= 50):
            //        katsayı = 4;
            //        break;

            //    case (>= 51 and <= 100):
            //        katsayı = 5;
            //        break;

            //    default:
            //        katsayı = 6;
            //        break;
            //}
            //int sonuc = x * katsayı;
            //Console.WriteLine($"X:{x},SONUÇ:{x} x {katsayı}: {sonuc}");


            //içinde bulundugumzu günün hafta içi mi yoksa haftasonu mu oldugunu bul

            //DateTime tarih = new DateTime(2022, 10, 8);
            //DayOfWeek gun = tarih.DayOfWeek;
            ////DayOfWeek gun = DateTime.Now.DayOfWeek;

            //if (gun==DayOfWeek.Sunday || gun==DayOfWeek.Saturday)
            //{
            //    Console.WriteLine("Hafta Sonundasın");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta İçindesin");
            //}


            DateTime tarih = new DateTime(2022, 10, 8);
            DayOfWeek gun = tarih.DayOfWeek;

            switch (gun)
            {
                //case DayOfWeek.Monday:
                //case DayOfWeek.Tuesday:
                //case DayOfWeek.Wednesday:
                //case DayOfWeek.Thursday:
                //case DayOfWeek.Friday:
                case DayOfWeek.Monday or
                DayOfWeek.Tuesday or
                DayOfWeek.Wednesday or
                DayOfWeek.Thursday or
                DayOfWeek.Friday:
                    Console.WriteLine("Hafta İçindesin");
                    break;
                case DayOfWeek.Saturday or DayOfWeek.Sunday:
                
                    Console.WriteLine(  "Haftasonu");
                    break;


                default:
                    break;
            }


        }
    }
}