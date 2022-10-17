namespace Proje01_Class_Field_Property_Uygulama
{

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        
         
        {
            //product classımız olacak:Name,price,description
            //istenildiği kadar product bilgisinin girilmesini saglayacagız.
            //kaç adet product bilgisini giriliecegini kullanıcı belirlesin
            //product ekleme işi btince eklenmiş productlar listelensim

            //Console.WriteLine("kaç adet ürün gireceksiniz");
            //int adet = int.Parse(Console.ReadLine());
            //Product[] products = new Product[adet];//bu kadar adet dizi içerisinde product tanımla diyoruz.
            //Product product;//buraya almamızdaki neden her sferinde yeni bir product tanımlamamak içinburaya tanımladık
            //for (int i = 0; i < adet; i++)
            //{

            //    product = new Product();                    //Product product = new Product();//yeni bir product oluştur //burdakinin farklısını yukarı oluşturduk
            //    Console.Write("Product Name:");
            //    product.Name = Console.ReadLine();

            //    Console.Write("Price:");
            //    product.Price = decimal.Parse(Console.ReadLine());

            //    Console.WriteLine("Description:");
            //    product.Description= Console.ReadLine();    

            //    products[i] = product; //yukarıdaki product'ın i.nincisine nesneesine git ve onun içine yeni oluşturudğumuz product'ı gir


            //}
            //Console.WriteLine("Prodct Name\t Price \t Description");
            //foreach (var prd in products)
            //{
            //    Console.WriteLine($"{prd.Name}\t{prd.Price}\t{prd.Description}");

            //}

            #region RastgeleDegerUreterek
            //rastgele degerler üretilmesini sagladık.
            Product[] products = new Product[5];
            Product product;
            string[] nameArray = { "Galaxy A50", "HP Notbook", "Macbook Air", "İphone 11", "LG 27 inç monitör" };//namearray adında bir dizi oluşturduk
            string[] descArray = { "iyidir", "şaşırtıcı", "mükemmmel", "heycan verici", "tırıt" };//descarray adında bir dizi oluşturduk
            decimal[] eskıFıyatlar = new decimal[5];
            Random random = new Random();   //random tanımladık
            Console.WriteLine("Yapılacak zam oranının giriniz:");
            decimal oran = decimal.Parse(Console.ReadLine());
            
            for (int i = 0; i < 5; i++)//5 kez dönsün dedik
            {
                product = new Product()//yeni bir product oluşturduk
                {
                    //oluşturudgum prodcta şunları koy
                    Name = nameArray[random.Next(0,5)],
                    Description=descArray[random.Next(0,5)],
                    Price=random.Next(100,1000)
                };
                eskıFıyatlar[i] = product.Price;
                product.Price = product.Price * (1 + oran / 100);
             // product.Price*= (1 + oran / 100); yukarıdaki satırla aynı
                

                ////yukarıdaki kodlarla aynı işi görüyor
                //product = new Product();
                //product.Name = nameArray[random.Next(0, 5)];
                //product.Description = descArray[random.Next(0, 5)];
                //product.Price = random.Next(100, 1000);

                


                products[i] = product;  

            }
            Console.WriteLine("Prodct Name".PadRight(30) + "Eski Fiyat".PadRight(10) + "Price".PadRight(10) + "Description");
            int j = 0;
            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.Name.PadRight(30)}{eskıFıyatlar[j].ToString().PadRight(10)}" +
                    $"{prd.Price.ToString().PadRight(10)}{prd.Description}");

                j++;
            }
            
            #endregion


        }

    }
}