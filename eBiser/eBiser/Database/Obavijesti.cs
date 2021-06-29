using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class Obavijesti
    {
        public Obavijesti()
        {
            ObavijestOcjenas = new HashSet<ObavijestOcjena>();
            ObavijestPhotos = new HashSet<ObavijestPhoto>();
        }

        public int Id { get; set; }
        public DateTime DatumObjave { get; set; }
        public DateTime VrijediDo { get; set; }
        public bool Aktivna { get; set; }
        public int OsobljeId { get; set; }
        public string Naslov { get; set; }
        public string Sadržaj { get; set; }
        public int KategorijaId { get; set; }

        public virtual ObavijestKategorija Kategorija { get; set; }
        public virtual Osoblje Osoblje { get; set; }
        public virtual ICollection<ObavijestOcjena> ObavijestOcjenas { get; set; }
        public virtual ICollection<ObavijestPhoto> ObavijestPhotos { get; set; }
    }
}
