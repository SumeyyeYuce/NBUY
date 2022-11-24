using KitabeviApp.Data.EfCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreGenericRepository<T> : IGenericRepository<T> where T : class
        //BUARAYA VERİLECEK OLAN T MUTLAKA BİR CLASS OLMAK ZORUNDA
    {
        KitabeviContext context = new KitabeviContext();
        public List<T> Listele()
        {
            return context.Set<T>().ToList();
        }
        public T Getir(int id)
        {
            return context.Set<T>().Find(id);
        }
        public void Ekle(T varlik)
        {
            context.Set<T>().Add(varlik);
            context.SaveChanges();
        }
        public void Guncelle(T varlik)
        {
            context.Set<T>().Update(varlik);
            context.SaveChanges();
        }

        public void Sil(T varlik)
        {
            context.Set<T>().Remove(varlik);
            context.SaveChanges();
        }
    }
}
