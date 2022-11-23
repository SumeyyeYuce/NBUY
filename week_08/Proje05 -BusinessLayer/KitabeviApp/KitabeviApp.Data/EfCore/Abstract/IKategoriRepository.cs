using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKategoriRepository
    {
        List<Kategori> KategoriListele();
        void KategoriEkle(Kategori kategori);
        void KategoriGuncelle(Kategori kategori);
        void KategoriSil(Kategori kategori);
        Kategori KategoriAl (int id);
    }
}