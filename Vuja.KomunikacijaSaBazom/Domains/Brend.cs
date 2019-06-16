using System;
using System.Collections.Generic;

namespace Vuja.KomunikacijaSaBazom.Domains
{
    public partial class Brend
    {
        public int BrendId { get; set; }
        public string BrendIme { get; set; }
        public string BrendZemlja { get; set; }
        public byte[] BrendSlika { get; set; }
        public int ModelId { get; set; }
    }
}
