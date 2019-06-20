using System;
using System.Collections.Generic;
using System.Text;

namespace Vuja.Aplikacija.DataTransfer
{
    public class BrendDto
    {
        public BrendDto()
        {
            Modeli = new List<ModelDto>();
        }
        public int BrendId { get; set; }
        public string BrendIme { get; set; }
        public string BrendZemlja { get; set; }
        public byte[] BrendSlika { get; set; }
        public int ModelId { get; set; }

        public List<ModelDto> Modeli { get; set; }
    }
}
