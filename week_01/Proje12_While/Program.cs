namespace Proje12_While;
class Program
{
    static void Main(string[] args)
    {
    //    int sayac=1;
    //    while (sayac<=5)//döngüler için kullanılır. 
    //    {
    //          Console.WriteLine("Hello, World!");
    //          sayac++;
    //    }

            // int toplam=0;
            // string girilenDeger="";
            // int sayac=1;
            // while (girilenDeger !="exit")//girilendeger eşit olmasın exit'e
            //  {
            //        Console.WriteLine($"{sayac}.sayıyı giriniz(çıkış için exit):");
            //         girilenDeger=Console.ReadLine();
            //         //if (girilenDeger!="exit")
            //         try
            //         {
            //              toplam+=Convert.ToInt32(girilenDeger); 
            //         }
            //         catch (System.Exception)
            //         {
            //             Console.WriteLine(toplam);
            //             break;   
                       
            //         }
                   
            //         sayac++;
            //  }
             

             //Soru:Klavyeden exit yazılana kadar isim girilmesini yazan uygulama
             //ÇÖZÜM1
            //      string isim="";
            //      int sayac=1;
            //      while (isim!="exit")
            //      {
            //       Console.WriteLine("İsim Giriniz:");  
            //       isim=Console.ReadLine();
            //      }
            //    Console.WriteLine("Program sona erdi.");


            //ÇÖZÜM2:
            // string isim;
            // do
            // {
            //     Console.WriteLine("İsim Giriniz:");
            //     isim=Console.ReadLine();
                
            // } while (isim!="exit");//do while da kontrol sonda oluyor. yani altaki while da
            // Console.WriteLine("Program sona erdi");


            //Klavyeden exit yazana kadar sayı almaya devam eden ve bu sayıların toplamını exit yazılınca ekrana yazan program

            // string girilenDeger;
            // int sayac=1;
            // int toplam=0;

            // do
            // {
            //     Console.WriteLine($"{sayac}.sayıyı giriniz:");
            //     girilenDeger=Console.ReadLine();
            //     if(girilenDeger!="exit")
            //     toplam+=Convert.ToInt32(girilenDeger);

            // } while (girilenDeger!="exit");

            // Random rastgele=new Random();//rastgele bir sayı üretmekiçin random kullanılıyor.
            // int rastgeleSayı=rastgele.Next();
            // Console.WriteLine(rastgeleSayı);
            // int rastgeleSayı2=rastgele.Next(100);//0-100 arasında rastgele sayı üretir 0 dahil ancak 100 dahil değildir.
            // Console.WriteLine(rastgeleSayı2);
            // int rastgeleSayı3=rastgele.Next(1000,2000);//1000-2000 arsında rastgele sayı üretir 1000 dahil ancak 2000 dahil değiil.
            // Console.WriteLine(rastgeleSayı3);

            //OYUN:Uygulamanın rastgele üretecegi bir sayıyı kullanıcının tahmin etmesini isteyecegiz
            //rastgele üretilicek sayı 1-100 arsında olsun.
            //kullanıcı rastgele sayıdan küçük ya da büyük bir sayı girildiğinde kullanııcya uygun bir şekilde mesaj verilsin.
            //doğru sayıyı tahmin edene kadar uygulama çalışsın.(x)
            //kullanıcı dopru sayıyı tahmin ettiyse ya da 5 hakkını kullandıysa uygulama sona ersin


            // Random rnd=new Random();
            // int uretılenSayı=rnd.Next(1,101);
            // Console.WriteLine($"Hile:{uretılenSayı}");//Ekranda rastgele üretilen sayıyı gösterdi.
            // int tahminEdilenSayı;
            // do
            // {
            //      Console.Write("Tahmininizi Girin (1-100 arasında):");
            //      tahminEdilenSayı=Convert.ToInt32(Console.ReadLine());
            //      if (tahminEdilenSayı>uretılenSayı)
            //      {
            //         Console.WriteLine("Büyük bir deger giridiniz dah küçük bir deger girerek deneyiniz");
            //      }
            //      else if (tahminEdilenSayı<uretılenSayı)
            //      {
            //         Console.WriteLine("küçük bir deger giridiniz dah büyük bir deger girerek deneyiniz");
            //      }
            //      else
            //      {
            //         Console.WriteLine("tebrikler");
            //      }
            // }
            //  while (tahminEdilenSayı!=uretılenSayı);



            //Random rnd=new Random();
            //int uretılenSayı=rnd.Next(1,101);
            //Console.WriteLine($"Hile:{uretılenSayı}");//Ekranda rastgele üretilen sayıyı gösterdi.
            //int tahminEdilenSayı;
            //int hak=1;//buaraya 5 de yazıp alt tarafta -- yapabilirsin.(kullanıcının hak değişkeni)
            //int hakSınırı=5;//kullanıcının toplam kaç hakka sahip oldugu bilgisi.
            //string Mesaj="";

            //do
            //{
            //        Console.Write($"{hak}Tahmininizi Girin (1-100 arasında):");
            //        tahminEdilenSayı=Convert.ToInt32(Console.ReadLine());
            //        if (tahminEdilenSayı>uretılenSayı)
            //        {
            //           Mesaj="Büyük Girdin";
                        
            //        }
            //       else if (tahminEdilenSayı<uretılenSayı)
            //       {
            //            Mesaj="Küçük Girdin";
                        
            //       }
            //       if (tahminEdilenSayı!=uretılenSayı)
            //       {
            //            hak++;
            //            if (hak<=hakSınırı) Console.WriteLine(Mesaj);
                       

                       
            //       }
                  
            //} while (tahminEdilenSayı!=uretılenSayı && hak<=hakSınırı);


            //Mesaj=tahminEdilenSayı==uretılenSayı? "Kazandınız" : "Kaybettiniz";
            //Console.WriteLine(Mesaj); //turnry if kullanımı


        // if (tahminEdilenSayı==uretılenSayı)
        // {
        //     Console.WriteLine("Kazandınız");
        // }
        // else
        // {
        //         Console.WriteLine("Kaybettiniz.");
        // }
        // Console.WriteLine("Oyun bitti");//ya doğru tercihde buraya geliyor ya da hakkı bittiğinde
        //eger program bu satıra gelmiş ise ya doğru tahmin de bulunulmuştur ya da hak sona ermiştir.



        // do
        // {
        //      Console.Write($"{hak}Tahmininizi Girin (1-100 arasında):");
        //      tahminEdilenSayı=Convert.ToInt32(Console.ReadLine());

        //         if (hak==hakSınırı && uretılenSayı!=tahminEdilenSayı)
        //         {
        //                 Console.WriteLine("Kaybettiniz");
        //                 break;
        //         }
        //          if (tahminEdilenSayı>uretılenSayı)
        //          {
        //             Console.WriteLine("Büyük bir deger giridiniz dah küçük bir deger girerek deneyiniz");
        //          }
        //          else if (tahminEdilenSayı<uretılenSayı)
        //          {
        //             Console.WriteLine("küçük bir deger giridiniz dah büyük bir deger girerek deneyiniz");
        //          }
        //          else
        //          {
        //             Console.WriteLine("tebrikler");
        //          }
        //         hak++;

        // }
        // while (tahminEdilenSayı!=uretılenSayı && hak<=hakSınırı);


        /************************************************************************************************/

        // int toplam=0;
        // string girilenDeger="";
        // int sayac=1;
        // while (girilenDeger !="exit")//girilendeger eşit olmasın exit'e
        //  {
        //        Console.WriteLine($"{sayac}.sayıyı giriniz(çıkış için exit):");
        //         girilenDeger=Console.ReadLine();
        //         //if (girilenDeger!="exit")
        //         try
        //         {
        //              toplam+=Convert.ToInt32(girilenDeger); 
        //         }
        //         catch (System.Exception)
        //         {
        //             Console.WriteLine(toplam);
        //             break;   

        //         }

        //         sayac++;
        //  }


        int toplam = 0;
        string gırılenDeger = "";
        int sayac = 1;
        while (gırılenDeger!="exit")
        {
            Console.WriteLine($"{sayac} sayıyı giriniz(çıkış için exit):");
            gırılenDeger = Console.ReadLine();
            if (gırılenDeger!="exit")
                try
                {
                    toplam += Convert.ToInt31(gırılenDeger);
                }
                catch (System.Exception)
                {
                    Console.WritLine(toplam);
                    break;
                    
                }
                  sayac++;

        }

    }
}
