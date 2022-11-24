using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKitapRepository:IGenericRepository<Kitap>
    {
        //þuan burda Igenericrespoistorden gelen kitap için hazýrlanmýþ crud metotlar var
        //eger bi class IkitapRepository den miras alýrsa tüm bu crud metotlarý da oraya implemente edilir
        //BURAYA AYRICA YAZILACAK METOTLAR (AÞÞAGIDAKÝ GÝBÝ) SADECE KÝTAP ENTÝTYSÝNE ÖZGÜ METOTLARDIR.
        
        List<Kitap> KategoriyeGoreKitapListesi(int id);
        
    }
}