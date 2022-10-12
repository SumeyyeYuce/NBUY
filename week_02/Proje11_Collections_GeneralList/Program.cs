namespace Proje11_Collections_GeneralList //genericlist olucak 
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //List<int> sayılar = new List<int>();//int tipinde bir list var
            //sayılar.Add(12);
            //sayılar.Add(120);
            //sayılar.Add(69);
            //sayılar.Add(43);
            //sayılar.Add(32);

            //List<string>isimler =new List<string>();
            //isimler.Add("ali");
            //isimler.Add("begum");
            //isimler.Add("ahmet");

            //foreach (var sayı in sayılar)//sayılar dziinde tek tek dolaş ve her birine sayı de ve yazdır 
            //{
            //    Console.WriteLine(sayı);
            //}
            //sayılar.Sort();
            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}



            //Product product1 = new Product() { Id = 1, Name = "Bilgisayar", Price = 2800 };
            //Product product2 = new Product() { Id = 2, Name = "Telefon", Price = 280 };
            //Product product3 = new Product() { Id = 3, Name = "masa", Price = 280 };

            //List<Product> products =new List<Product> { product1, product2, product3 };

            //yukarıdaki satırla aynı işi görüyor.
            //List<Product> products = new List<Product>();
            //products.Add(product1);
            //products.Add(product2);
            //products.Add(product3);


            ////yukarıda yapılanlarla aynı
            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=1,Name="Telefon",Price=1900},
            //    new Product(){Id=2,Name="Bilgisayar",Price=3000},
            //    new Product(){Id=3,Name="Masa Sandalye",Price=1700}
            //};


            ////yeni bir liste yaratın adı da new proudct olsun.içine tıpkı yukarıdaki gibi 3 yeni ürün bilgsini griin

            //List<Product> newproduct = new List<Product>()
            //{
            //    new Product(){Id=4,Name="KAZAK",Price=200},
            //    new Product(){Id=5,Name="pantolon",Price=300},
            //    new Product(){Id=6,Name="gömlek",Price=150}
            //};

            ////foreach (var nwproduct in newproduct)
            ////{
            ////    Console.WriteLine($"{nwproduct.Name}-{nwproduct.Price}");
            ////}


            ////newproduct içindekileri productları peoduct içine ekledik
            //products.AddRange(newproduct);


            ////prodct içinde dönüceksin her döndüğünde sıradakine prodct diceksiin
            ////products.ForEach(p=>{
            ////    Console.WriteLine($"{p.Name} - {p.Price}");
            ////    Console.WriteLine();
            ////});

            //int elemanSayısı = products.Count;
            //products.Insert(0,new Product() { Id=21,Name="gözlk",Price=344});
            //products.InsertRange(3,newproduct);

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name} - {product.Price}");
            //}


            //List<Product> products = new List<Product>()
            //{
            //    new Product(){Id=1,Name="Telefon",Price=1900},
            //    new Product(){Id=2,Name="Bilgisayar",Price=3000},
            //    new Product(){Id=3,Name="Masa Sandalye",Price=1700}
            //};


            //ProductModel productModel = new ProductModel()
            //{
            //    Id = 1,
            //    CategoryName = "First Category",
            //    Products = products

            //};

            //Console.WriteLine(productModel.CategoryName);
            //foreach (var product in productModel.Products)
            //{
            //    Console.WriteLine($"\t {product.Name}");
            //}



            //içinde 3 adet productmodel tipinde veri barındıran bir list oluşturun
            //herbir productmodel içinde ise product özelliğğne 3'er adet product koyun

            List<ProductModel> productModels = new List<ProductModel>()
            {
                //burası 1 tane
                new ProductModel(){Id=1,CategoryName="bilgisayr",Products=new List<Product>()
                {
                    new Product(){Id=1,Name="ürün1",Price=5000},
                    new Product(){Id=2,Name="ürün1",Price=5000},
                    new Product(){Id=3,Name="ürün1",Price=5000},
                }

                },

                //bursı 2.
                 new ProductModel(){Id=21,CategoryName="telefon",Products=new List<Product>()
                 { 
                        new Product(){Id=1,Name="ürün1",Price=5000},
                        new Product(){Id=2,Name="ürün1",Price=5000},
                        new Product(){Id=3,Name="ürün1",Price=5000},
                        }

                 },
                 //burası 3.
                  new ProductModel(){Id=31,CategoryName="mobilya",Products=new List<Product>()
                    {
                        new Product(){Id=1,Name="ürün1",Price=5000},
                        new Product(){Id=2,Name="ürün1",Price=5000},
                        new Product(){Id=3,Name="ürün1",Price=5000},
                    }

                },
            };

            foreach (var productModel in productModels)
            {
                Console.WriteLine($"Product Model Id:{productModel.Id} - Category Name:{productModel.CategoryName}");
                foreach (var product in productModel.Products)
                {
                    Console.WriteLine($"\t Product Id:{product.Id}-Product Name:{product.Name} -Product Price:{product.Price}");
                }
                Console.WriteLine("********************************************");
            }


            Console.ReadLine();
        }
    }
}