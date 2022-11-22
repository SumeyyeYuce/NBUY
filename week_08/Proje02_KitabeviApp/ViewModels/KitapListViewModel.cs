using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje02_KitabeviApp.Models;

namespace Proje02_KitabeviApp.ViewModels
{
    public class KitapListViewModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int BasimYili { get; set; }
        public int SayfaSayisi { get; set; }
        public string YazarAd { get; set; }
        public string KategoriAd { get; set; }
    }
}