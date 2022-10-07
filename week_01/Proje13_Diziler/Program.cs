namespace Proje13_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //içinde birden fazla veri tuttugumuz yapılara dizi diyoruz.

            //string ad;
            //ad = "Sümeyye";

            //string adSoyad = "Fatih Candan , cemal Gündem, Selin Dilci";
            //Console.WriteLine(adSoyad);

            //string[] adlar = new string[7];//içinde 3 adet string bilgi tutabilecek dizi. 
            //adlar[0] = "Fatih Candan";
            //adlar[1] = "cemal Gündem";
            //adlar[2] = "Selin Dilci";
            //adlar[3] = "kemal kurt";
            //adlar[4] = "begüm yancı";
            //adlar[5] = "Selma Halıcı";
            //adlar[6] = "emre mor";
            ////Console.WriteLine(adlar[0]);
            ////Console.WriteLine(adlar[0] + adlar[1] + adlar[2]);

            //for (int i = 0; i < adlar.Length; i++)//adlar dizisinin uzunluğu demek(adlar.length)
            //{
            //    Console.WriteLine(adlar[i]);
            //}

            //int[] yaslar = new int[3];

            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //int toplam = 0;
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    toplam +=rakamlar[i];//döngüdeki rakamları sırasıyla toplicak.
            //}
            //Console.WriteLine(toplam);


            //string okul = "Wissen Akademie";
            //Console.WriteLine(okul[8]);

            //ÇALIŞMA:Klavyeden kullanıcının adını soyadını girmesini isteyiniz
            //girilen ad soyadı aşşagıya doğru BÜYÜK HARFLERLE yazdırınız
            //Sümeyye
            /*
             * s
             * ü
             * m
             * e
             * y
             * y
             * e
             */

            //Console.WriteLine("Adınızı Girin");
            //string ad = Console.ReadLine().ToUpper();


            //for (int i = 0; i <ad.Length; i++)
            //{
            //    Console.WriteLine(ad[i]);

            //}

            //Console.WriteLine("Bir Metin Giriniz");
            //string girilenMetin = Console.ReadLine().ToLower();
            //Console.Write("Hangi karakterin sırasını bulmamı istersiniz?");
            //string karakter =Console.ReadLine().ToLower();
            //int sıraNo = girilenMetin.IndexOf(karakter)+1;//sıfırdan başladıgı için kullanıcı görebilmesi için karkater sırasını bir atrrırıyoruz.
            //Console.Clear();
            //Console.WriteLine($"Girilen Metin: {girilenMetin}\n Aradığınız karakter:{karakter}\n Aradığınız karka" +
            //    $"terin girilen metindeki sırası:{sıraNo}");
            //Console.WriteLine("Dizinin Orjinal hali");
            //Console.WriteLine("********************");
            //int[] rakamlar = { 56, 89, 90, 45, 33, 55 };
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}.elaman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Kendimiz en büyük sayıyı bulunuz

            //int enBuyuk = rakamlar[0];
            //int enKucuk = rakamlar[0];
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    if (rakamlar[i]>enBuyuk)
            //    {
            //        enBuyuk = rakamlar[i];
            //    }
            //    if (rakamlar[i]<enKucuk)
            //    {
            //        enKucuk = rakamlar[i];

            //    }
            //}
            //Console.WriteLine(enBuyuk);
            //Console.WriteLine(enKucuk);

            //istege baglı ödev: bu diziiyi küçükten büyüye doğru sıralayınız.(yukarı)




            //Console.WriteLine($"En küçük:\t{rakamlar.Min()}");
            //Console.WriteLine($"En büyük:\t{rakamlar.Max()}");

            //Console.WriteLine("Dizinin ters çevrilmiş hali");
            //Console.WriteLine("****************************");
            // Array.Reverse(rakamlar);//diziyi ters çeviriyor.
            //for (int i = 0; i < rakamlar.Length; i++)
            //{ 
            //    Console.WriteLine($"{i + 1}.elaman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();


            //Console.WriteLine("Dizinin küçükten büyüğe sıralanmış hali");
            //Console.WriteLine("****************************");
            //Array.Sort(rakamlar);// sort default olarak  küçükten büyüğe sıralar .
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.elaman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Dizinin büyükten küçüge sıralanmış hali");
            //Console.WriteLine("****************************");
            //Array.Sort(rakamlar);// sort default olarak  küçükten büyüğe sıralar .
            //Array.Reverse(rakamlar);//reverse büyüktebn küçüge sıralar.
            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.elaman:\t{rakamlar[i]}");
            //}
            //Console.WriteLine();




            //ÖRNEKLER:
            //Örnek1:satlar dizisinin elemanlarının ortalamasını bulup ekrana yazan program

            // int[] sayılar = { 5, -16, 8, 12, -15, 78, 90, 0 };
            //int toplam = sayılar.Sum();
            //Console.WriteLine($"Toplam {toplam}");

            //ÖRNEK2:sayılar dizisindeki çift sayıları ekrana yazdıralım.
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    if (sayılar[i]%2==0)
            //    {
            //        Console.WriteLine(sayılar[i]);
            //    }
            //}

            //ÖRNEK3:Sayılar dizisindeki sayıları yanlarında pozitif negatif ya da işaretsiz olma bilgileiryle yazdıralım
            //string tip = "";
            //for (int i = 0; i < sayılar.Length; i++)
            //{

            //    tip = sayılar[i] > 0 ? "POZİTİF:" :
            //          sayılar[i] < 0 ? "NEGATİF" : 
            //          "işaretsiz";
            //    Console.WriteLine($"{i+1}.SAYI: {sayılar[i]} - TİPİ: {tip}");
            //}


            //ÖRNEK4:Kullanıcının girecegi bir metnin içindeki sesli harf sayısını ekran yazdır

            //char[] sesliHarfler = {'a','e','ı','i','o','ö','u','ü' };
            //int sesliHarfAdedi = 0;
            //Console.Write("Bir metin giriniz:");
            //string girilenMetin = Console.ReadLine().ToLower();
            //for (int i = 0; i < girilenMetin.Length; i++)
            //{
            //    if (sesliHarfler.Contains(girilenMetin[i]))
            //    {
            //        sesliHarfAdedi++;
            //    }
            //}
            //Console.WriteLine(sesliHarfAdedi);

            //ÖRNEK5:Klavyeden girilen bir cümledeki yine klavyeden girilecek bir kelimenin kaç kez geçtiğini bulduralım

            //string ornekMetin = "Ayşe Fatma Ünal";
            //string[] sozcukDizisi=ornekMetin.Split(" ");//split parçalama(her boşluk gördüğün yeri parçala,harf de verilebilir)
            //for (int i = 0; i < sozcukDizisi.Length; i++)
            //{
            //    Console.WriteLine(sozcukDizisi[i]);
            //}

            int sozcukAdedi = 0;
            Console.WriteLine("Cümleyi Giriniz:");
            string girilenCumle = Console.ReadLine();
            Console.WriteLine("Adedini bulmak istediğiniz sözcüğü giriniz");
            string sayılacakSozcuk = Console.ReadLine();
            string[] girilenCumlenınDızıHalı = girilenCumle.Split(" ");
            for (int i = 0; i < girilenCumlenınDızıHalı.Length; i++)
            {
                if (sayılacakSozcuk.ToLower() == girilenCumlenınDızıHalı[i].ToString().ToLower())
                {
                    sozcukAdedi++;
                }
            }
            Console.WriteLine($"'{girilenCumle}' Cümlesi içinde '{sayılacakSozcuk}' sözcüğü {sozcukAdedi} kez geçmektedir.");


            //Araştırma Ödevi: çok boyutlu dizileri araştırın.
            //PROJE ÖDEVİ:İçinde türkçe karakterler hariç tüm küçük harfler, 0-9 arası rakamlar, nokta(.), virgül(,)
            //artı(+),eksi(-) karakterleri bulunabilecek toplam uzunluğu 6 karakter olacak şekilde RASTGELE ŞİFRE
            //üreten program yazınız
            //engin.ergul@wissenakademie.com
            //bir dizi yap içine harfleri yaz //

        }
    }
}