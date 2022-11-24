using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Business.Abstract
{
    public interface IKategoriService
    {
        //dışardan gelen istekleri karşılıcak metot burası
        //busines datayı kullanıyor data da entity yi
        List<Kategori> KategoriListele();
        void KategoriEkle(Kategori kategori);
        void KategoriGuncelle(Kategori kategori);
        void KategoriSil(Kategori kategori);
        Kategori KategoriGetir (int id);

    }
}