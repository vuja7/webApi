using System;
using System.Collections.Generic;
using System.Text;

namespace Vuja.Aplikacija.DataTransfer
{
    public class ArenaDto
    {
        public int ArenaId { get; set; }
        public string ArenaIme { get; set; }
        public string ArenaGrad { get; set; }
        public int? TimId { get; set; }
        public string ArenaBrojMesta { get; set; }
    }
}
