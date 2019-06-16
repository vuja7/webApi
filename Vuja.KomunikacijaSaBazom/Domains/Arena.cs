using System;
using System.Collections.Generic;

namespace Vuja.KomunikacijaSaBazom.Domains
{
    public partial class Arena
    {
        public int ArenaId { get; set; }
        public string ArenaIme { get; set; }
        public string ArenaGrad { get; set; }
        public int? TimId { get; set; }
        public string ArenaBrojMesta { get; set; }
    }
}
