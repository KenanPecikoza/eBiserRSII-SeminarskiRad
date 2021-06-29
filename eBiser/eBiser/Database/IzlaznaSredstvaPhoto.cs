using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class IzlaznaSredstvaPhoto
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public int IzlaznaSredstvaId { get; set; }

        public virtual IzlaznaSredstva IzlaznaSredstva { get; set; }
    }
}
