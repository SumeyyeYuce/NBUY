namespace Proje09_InterFace
{
    interface IPersonel
    {
        public string Departman { get; set; }
    }
    interface IKısı
    {
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
       
        public string Maas { get; set; }

        public void Bilgi();//interfaceler içindeki metotlarda sadece İMZA bulunur,methotun gövdesi olmaz
                            //metotun gövdesi,bu interfacei miras alan CLASS  içinde doldurulur
                            //interface new yapılamaz

    }
    class Yonetıcı : IKısı,IPersonel//kişi interfacinden miras alıcaksak kişinin içindeki herşey gelicek buraya.
    {
        /// <summary>
        /// bu metot herhangi bir yönetici bilgisi girmeden yönetici oluşturu
        /// </summary>
        public Yonetıcı()
        {
            //Kimi zaman AdSoyad adres
        }
        /// <summary>
        /// bu metot AdSOYAD,adres,maas ve departman bilgileri girilerek yonetici oluşturu.
        /// </summary>
        /// <param name="adSoyad">buraya adsoyad girin</param>
        /// <param name="adres">buraya adres girin</param>
        /// <param name="maas">buraya maas girin</param>
        /// <param name="departman">buraya departman girin</param>
        public Yonetıcı(string adSoyad,string adres,string maas,string departman)
        {
            AdSoyad = adSoyad;
            Adres = adres;
            Maas = maas;
            Departman = departman;
        }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Maas { get;set; }
        public string Departman { get; set; }

        public void Bilgi()
        {
            Console.WriteLine($"AdSoyad:{AdSoyad} Adres:{Adres} Maas:{Maas}");
        }
    }
    //herşeyin absctrt olmasını istiyoask interface kullanırız.
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstract classtan, miras alan classtaki
             * eger base class da absctrt bir metot varsa,mutlaka ovirride edilmeli
             * eger base classta abstract olmayan methodlar varsa onlar aynen kullanıılır
             * ancak bazen miras alınan clastaki bir methodun içinin dolu hallerini yazmak zorunlu olsun isteriz
             * yani bir nevi hepsi absctrt olsunisteriz. Bunu yapmak yerine miras alınan classı, class değil
             * interface şeklinde tanımlarız.
             * */
            Yonetıcı yonetıcı1 = new Yonetıcı();
            Yonetıcı yonetıcı2 = new Yonetıcı("Alex de souza","fgfgfgfg","54646","fbgfhfgf");
            
            Console.WriteLine();
        }
    }
}