using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class DjelatnostOsoblje
    {
        public DjelatnostOsoblje()
        {
            Osobljes = new HashSet<Osoblje>();
        }

        public int Id { get; set; }
        public string NazivDjelatnosti { get; set; }

        public virtual ICollection<Osoblje> Osobljes { get; set; }
    }
}
