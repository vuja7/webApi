using System;
using System.Collections.Generic;

namespace Vuja.KomunikacijaSaBazom.Domains
{
    public partial class Tim
    {
        public int TimId { get; set; }
        public string TimIme { get; set; }
        public byte[] TimGrb { get; set; }
        public string TimVlasnik { get; set; }
        public int? ArenaId { get; set; }
        public int? IgracId { get; set; }
    }
}
