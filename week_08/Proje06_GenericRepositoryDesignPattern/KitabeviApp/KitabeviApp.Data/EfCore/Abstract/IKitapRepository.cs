using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository:IGenericRepository<Kitap>
    {
        //�uan burda Igenericrespoistorden gelen kitap i�in haz�rlanm�� crud metotlar var
        //eger bi class IkitapRepository den miras al�rsa t�m bu crud metotlar� da oraya implemente edilir
        //BURAYA AYRICA YAZILACAK METOTLAR (A��AGIDAK� G�B�) SADECE K�TAP ENT�TYS�NE �ZG� METOTLARDIR.
        
        List<Kitap> KategoriyeGoreKitapListesi(int id);
        
    }
}