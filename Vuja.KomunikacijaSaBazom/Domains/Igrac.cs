using System;
using System.Collections.Generic;

namespace Vuja.KomunikacijaSaBazom.Domains
{
    public partial class Igrac
    {
        public int IgracId { get; set; }
        public string ImeIgrac { get; set; }
        public string PrezimeIgrac { get; set; }
        public DateTime? GodisteIgrac { get; set; }
        public int TimId { get; set; }
        public int? ModelId { get; set; }
        public int? BrojDresaIgrac { get; set; }
    }
}
