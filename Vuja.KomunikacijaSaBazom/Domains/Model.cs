using System;
using System.Collections.Generic;

namespace Vuja.KomunikacijaSaBazom.Domains
{
    public partial class Model
    {
        public int ModelId { get; set; }
        public string ModelIme { get; set; }
        public string ModelCena { get; set; }
        public DateTime ModelDatumIzlaska { get; set; }
        public int BrendId { get; set; }
        public int IgracId { get; set; }
    }
}
