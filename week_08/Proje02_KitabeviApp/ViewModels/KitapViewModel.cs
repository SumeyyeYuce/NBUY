using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proje02_KitabeviApp.Models;

namespace Proje02_KitabeviApp.ViewModels
{
    public class KitapViewModel
    {
        public Kitap Kitap { get; set; }
        public List<Yazar> Yazarlar { get; set; }
        public List<Kategori> Kategoriler { get; set; }
    }
}