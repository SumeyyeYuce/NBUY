namespace Proje09_InterFace
{
    /*
     * interfaceler için belirtilmediğinde defaoult erişim belirleyici public'tir.
     * interfaceler protected private ya da static olarak işaretlenemzler.
     * interfaceler içinde çalışabilir kodlar olamaz. yani metotların sadece imzası bulunur
     * bir interface bir ya da dah çok inerfaceden miras alabilri
     * bir interface classda miras alamaz
     * eger bir class bir interface den miras alıyorsa miras aldığı interfacedki tüm metotları imlplemete etmek zorundadır
     * (implemente:mirs alıınan interface de imzası bulunan tüm metotların içi dolu halleri.)*/

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
    public class Program
    {
        static void Main(string[] args)
        {
            /*Bir abstract classtan, miras alan classtaki
             * eger base class da absctrt bir metot varsa,mutlaka ovirride edilmeli
             * eger base classta abstract olmayan methodlar varsa onlar aynen kullanıılır
             * ancak bazen miras alınan clastaki bir methodun içinin dolu hallerini yazmak zorunlu olsun isteriz
             * yani bir nevi hepsi absctrt olsunisteriz. Bunu yapmak yerine miras alınan classı, class değil
             * interface şeklinde tanımlarız.
            // * */
            //Yonetıcı yonetıcı1 = new Yonetıcı();
            //Yonetıcı yonetıcı2 = new Yonetıcı("Alex de souza","fgfgfgfg","54646","fbgfhfgf");

            //Console.WriteLine();

            Product product1 = new Product()
            {
                Id = 1,
                Name = "iphone 13",
                Price = 59000,
                Properties = "8 gb ram",
                Ratio = 0.5m,
                CreatedDate = DateTime.Now

            };

            Console.WriteLine($"Product Name:{product1.Name} (Büyük harf:{product1.NameToUpper(product1.Name)}) " +
                $"Properties:{product1.Properties}");

            Category category1 = new Category()
            {
                Id = 1,
                Name = "telefon",
                CreatedDate = DateTime.Now,
                Description = "",
            };
            Console.WriteLine($"Category Name:{category1.Name} (büyük harf: {category1.NameToUpper(category1.Name)}) " +
                $"Description:{category1.Description}");
            Console.ReadLine();
        }
    }
}