using System;
using System.Collections.Generic;
using System.Text;

namespace eBiser.Data
{
    public class AkcijePomoci
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public double TraženaCifra { get; set; }
        public double Skupljeno { get; set; }
        public bool Aktivno { get; set; }
        public double Progres { get; set; }
        public byte[] Fotografija{ get; set; }

    }
}
