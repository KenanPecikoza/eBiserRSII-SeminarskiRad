using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data.Requests
{
    public class ObavijestSearchRequest
    {
        public string PretragaPoNaslovu { get; set; }
        public string PretragaPoSadrzaju { get; set; }
        public DateTime? PretragaPoDatumuOd { get; set; }
        public DateTime? PretragaPoDatumuDo { get; set; }
        public int? KategorijaId { get; set; }

    }
}
