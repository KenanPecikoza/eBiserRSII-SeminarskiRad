using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class IzlaznaSredstva
    {
        public IzlaznaSredstva()
        {
            IzlaznaSredstvaPhotos = new HashSet<IzlaznaSredstvaPhoto>();
        }

        public int Id { get; set; }
        public double Količina { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public string Naslov { get; set; }
        public int OsobljeId { get; set; }

        public virtual Osoblje Osoblje { get; set; }
        public virtual ICollection<IzlaznaSredstvaPhoto> IzlaznaSredstvaPhotos { get; set; }
    }
}
