using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Sastanak
    {
        public int Id { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string Zapisnik { get; set; }
        public bool Odrzan { get; set; }
        public int OsobljeId { get; set; }
        public bool? Zakazan { get; set; }
        public string Naslov { get; set; }
        public virtual Osoblje Osoblje { get; set; }
    }
}
