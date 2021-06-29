using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class Obavijest
    {

        public int Id { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime VrijediDo { get; set; }
        public bool Aktivna { get; set; }
        public int OsobljeId { get; set; }
        public int Ocjena { get; set; }
        public string Sadržaj { get; set; }
        public string Naslov { get; set; }
        public string Kategorija { get; set; }
        public int KategorijaId { get; set; }
        public List<byte[]> Fotografije { get; set; }



    }
}
