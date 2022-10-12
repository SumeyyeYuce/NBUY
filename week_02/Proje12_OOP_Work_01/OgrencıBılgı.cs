using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje12_OOP_Work_01
{
    public class Bolum
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Acıklama { get; set; }
        public List<OgrencıBılgı> OgrencıListe { get; set; }


        //public List<Bolum> bolums { get; set; }

    }
    public class OgrencıBılgı
    {
        public int Id { get; set; }

        public int OgrNo { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public int Yas { get; set; }

        //public List<Bolum> bolums { get; set; }
    }



   


}
