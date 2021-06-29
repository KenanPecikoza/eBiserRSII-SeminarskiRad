using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class UlaznaSredstvaPhoto
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public int UlaznaSredstvaId { get; set; }

        public virtual UlaznaSredstva UlaznaSredstva { get; set; }
    }
}
