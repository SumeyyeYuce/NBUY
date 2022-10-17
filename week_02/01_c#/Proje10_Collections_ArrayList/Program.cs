using System.Collections;

namespace Proje10_Collections_ArrayList
{
    internal class Program
    {
        static void Yazdır(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {

            ArrayList sayılar = new ArrayList()
            {
                54,
                12,
                66,
                34,
                19
            };
            Console.WriteLine("Defalut sıra");
            Yazdır(sayılar);
            sayılar.Sort();//Sıralmak
            Console.WriteLine("**********");
            Console.WriteLine("Küçükten büyüye");
            Yazdır(sayılar);
            sayılar.Sort();
            Console.WriteLine("*********");
            Console.WriteLine("büyükten küçüge");
            sayılar.Reverse();


            for (int i = 0; i < sayılar.Count; i++)//arraylistelde length yerine count kullan
            {
                Console.WriteLine(sayılar[i]);
            }
           
          


            //YUKARIDAKİYLE AYNI
            //foreach (var item in sayılar)
            //{
            //    Console.WriteLine(item);
            //}






















            //ArrayList mylist = new ArrayList();

            //mylist.Add(120);//listemin 0. elamnı
            //mylist.Add("120");
            //mylist.Add("zeynep");
            //mylist.Add(11.5);
            //mylist.Add(DateTime.Now);
            //mylist.Add(true);


            //mylist.Insert(0, "Yeni Eleman");//ınsert ile ilk sıraya girdi

            //ArrayList addedList = new ArrayList()
            //{
            //    "Ayşen Umay",
            //    "SÜMEYYE YÜCE",
            //    "selda bayır",
            //};

            //mylist.InsertRange(4, addedList);//bu komutla birden fazla listeyi istediğim yere ekledim
            //mylist.AddRange(addedList);//sonuuna ekle

            //mylist.Remove("zeynep");//Silme
            ////mylist.RemoveAt(0);//listenin içindeki kaçıncı elamanı silmek istediğimiz söylüyoruz
            ////mylist.RemoveRange(0, 3);


            //foreach (var item in mylist)
            //{
            //    Console.WriteLine(item);
            //}
            //if (mylist.Contains("zeynep")==true)//listede zeynep varsa
            //{
            //    Console.WriteLine("Evey zeynep listede var");
            //}
            //else
            //{
            //    Console.WriteLine("zeynepe haber ver listede yok");
            //}
            //Console.WriteLine();
            ////Console.WriteLine(mylist[3]);//3.sıradaki elamanı ver



            Console.ReadLine();
        }
    }
}