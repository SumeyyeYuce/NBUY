using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IGenericRepository<T>
    {
        T Getir(int id);
        List<T> Listele();
        void Ekle(T varlik);
        void Guncelle(T varlik);
        void Sil(T varlik);
    }
}