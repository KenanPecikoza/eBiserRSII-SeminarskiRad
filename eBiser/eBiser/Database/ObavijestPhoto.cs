using System;
using System.Collections.Generic;


namespace eBiser.Database
{
    public partial class ObavijestPhoto
    {
        public int Id { get; set; }
        public int ObavijestId { get; set; }
        public byte[] Photo { get; set; }

        public virtual Obavijesti Obavijest { get; set; }
    }
}
