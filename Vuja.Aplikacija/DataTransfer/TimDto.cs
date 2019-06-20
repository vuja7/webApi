using System;
using System.Collections.Generic;
using System.Text;

namespace Vuja.Aplikacija.DataTransfer
{
   public class TimDto
    {
        public TimDto()
        {
            Igraci = new List<IgracDto>();
        }
        public int TimId { get; set; }
        public string TimIme { get; set; }
        public byte[] TimGrb { get; set; }
        public string TimVlasnik { get; set; }
        public int? ArenaId { get; set; }
        public int? IgracId { get; set; }

        public List<IgracDto> Igraci { get; set; }
    }
}
