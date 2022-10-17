namespace Proje08_HataKontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //buraya normalde çalışmasını istediğimiz kodları yazıyoruz
                //try bloğunda herhangi bir hata varmı yokmu kontrol ediliyor
                //eger bir hata oluşursa, CATCH bloguna yönlendiriliyor

                //birinci sayıyı ikinci sayıya bölen kod
                Console.Write("1.Sayıyı giriniz:");
                int sayı1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2.Sayıyı giriniz:");
                int sayı2 = Convert.ToInt32(Console.ReadLine());
               // byte sonuc = Convert.ToByte(sayı1 / sayı2);
                int sonuc = sayı1 / sayı2;
                Console.WriteLine(sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("0'a bölünme hatası");
                //Console.WriteLine("işelmde bir hata oluştu");
                //Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)//taşma hatası
            {
                Console.WriteLine("fazla sayı girdiniz");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bilinmeyen bir hata oluştu");
            }
            finally
            {
                //try ya da catch bloklarından hangisi çalışırsa çalışsın her harükarda 
                //çalışmasını istediğimiz kodları yazarız
                Console.WriteLine("Program Sona Ermiştir");
            }
           


        }
    }
}