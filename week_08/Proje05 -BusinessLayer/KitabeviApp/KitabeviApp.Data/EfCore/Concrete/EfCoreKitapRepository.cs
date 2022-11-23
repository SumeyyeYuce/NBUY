using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreKitapRepository : IKitapRepository
    {
        public void KitapEkle(Kitap kitap)
        {
            using (var context=new KitabeviContext())
            {
                context.Kitaplar.Add(kitap);
                context.SaveChanges();
            }
        }

        public Kitap KitapGetir(int id)
        {
           using (var context=new KitabeviContext())
           {
                return context.Kitaplar.Find(id);
           }
        }

        public void KitapGuncelle(Kitap kitap)
        {
             using (var context=new KitabeviContext())
            {
                context.Kitaplar.Update(kitap);
                context.SaveChanges();
            }
        }

        public List<Kitap> KitapListesi(int? id = null)
        {
            using (var context=new KitabeviContext())
            {
                    if (id==null)
                    {
                        return context
                        .Kitaplar
                        .Include(kitap=>kitap.Kategori)
                        .Include(kitap=>kitap.Yazar)
                        .ToList();
                    }
                
                         return context
                        .Kitaplar
                        .Where(kitap=>kitap.KategoriId==id)
                        .Include(kitap=>kitap.Kategori)
                        .Include(kitap=>kitap.Yazar)
                        .ToList();
                    
            }
          
        }

        public void KitapSil(Kitap kitap)
        {
             using (var context=new KitabeviContext())
            {
                context.Kitaplar.Remove(kitap);
                context.SaveChanges();
            }
        }
    }
}