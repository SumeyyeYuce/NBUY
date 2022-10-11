using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje02_Methods
{
   public class MethodOverload
    {
       
          
        //public void DenemeMetodu()
        //{
        //    Console.WriteLine("Merhaba ben methodOverload clasındayım.");
        //    Console.WriteLine(Program.Topla(3, 5));
        //}


        public int Topla(int s1,int s2,int s3=0)
        {
            return s1 + s2 +s3; 
        }

      //  public int Islem(bool ıslemTuru,int s1, int s2, int s3 = 0,bool ıslemTuru =true)
        //{
        //    if (ıslemTuru==true)
        //    {
        //        return s1 + s2 + s3;
        //    }
        //    else
        //    {
        //        if (s3 == 0) s3 = 1;
        //        return s1 * s2 * s3;
        //    }
           
        //}

        public int Topla(int[] sayılar)
        {
            int sonuc = sayılar.Sum();//Sayıları topla
            return sonuc;
        }
        

    }


}
