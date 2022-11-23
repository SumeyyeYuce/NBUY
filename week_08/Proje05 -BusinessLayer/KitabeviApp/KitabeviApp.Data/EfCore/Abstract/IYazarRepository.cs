using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IYazarRepository
    {
        List<Yazar> YazarListesi();
        void YazarEkle (Yazar yazar);
        void YazarGuncelle(Yazar yazar);
        void YazarSil(Yazar yazar);
        Yazar YazarGetir(int id);
    }
}