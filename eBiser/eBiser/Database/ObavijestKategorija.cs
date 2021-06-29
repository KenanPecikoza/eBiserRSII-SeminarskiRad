using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class ObavijestKategorija
    {
        public ObavijestKategorija()
        {
            Obavijestis = new HashSet<Obavijesti>();
        }

        public int Id { get; set; }
        public string NazivKategorije { get; set; }

        public virtual ICollection<Obavijesti> Obavijestis { get; set; }
    }
}
