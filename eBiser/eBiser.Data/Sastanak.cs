using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class Sastanak
    {
        public int Id { get; set; }
        public string ImeIPrezime { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string Zapisnik { get; set; }
        public int OsobljeId { get; set; }
        public bool Odrzan { get; set; }
    }
}
