using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class UlaznaSredstva
    {
        public UlaznaSredstva()
        {
            UlaznaSredstvaPhotos = new HashSet<UlaznaSredstvaPhoto>();
        }

        public int Id { get; set; }
        public double Količina { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string Naslov { get; set; }
        public int OsobljeId { get; set; }

        public virtual Osoblje Osoblje { get; set; }
        public virtual ICollection<UlaznaSredstvaPhoto> UlaznaSredstvaPhotos { get; set; }
    }
}
