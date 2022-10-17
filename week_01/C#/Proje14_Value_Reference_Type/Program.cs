namespace Proje14_Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 45;
            int b = a * 2;


            Random rnd=new Random();
            Kısı kısı1 = new Kısı();
            kısı1.Ad = "Sümeyye";
            kısı1.Yas = 22;
            kısı1.Meslek = "Ögrenci";

            Kısı kısı2 = new Kısı();
            kısı2.Ad = "Saliha";
            kısı2.Yas = 40;
            kısı2.Meslek = "Eğitmen";

            Kısı kısı3 = new Kısı();
            kısı3.Ad = "cemal";
            kısı3.Yas = 34;
            kısı3.Meslek = "Şair";

            Araba araba1 = new Araba();
            araba1.Marka = "Range Rover";
            araba1.Renk = "Siyah";

            DateTime bugun = DateTime.Now;
            Random rnd2= new Random();  

        }
        class Kısı//Kişi Sınıfı oluşturudk. tip kişi
        {
            //kişi clasından türtilen nesneler(emin değilim :))))
            public string? Ad { get; set; }
            public int Yas { get; set; }
            public string? Meslek { get; set; }//burdaki soru işareti yeşil çizgiyi yok etmeye yarıyor
        }

        class Araba
        {
            public string Marka { get; set; }//public olanlar dışarıdan erişilebilir.private olanlar dışarıdan erişilemez
            public string Renk { get; set; }
             string VıtesTuru { get; set; }
            //erişim belirleyici: Bir property'nin dışarıdan yani içinde bulundugu classsın dışından
            //erişim seviyesini belirleyen anahtar sözcüklere denir.Eger herhangi bir erişim belirleyici
            //kullanılmadıysa default erişim belirleyici private olarak kabul edilir.
            /*erişim belirleyiciler
             * 1)public
             * 2)private
             * 3)internal
             * 4)protected
             */
        }
    }
}