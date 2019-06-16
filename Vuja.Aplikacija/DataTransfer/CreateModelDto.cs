using System;
using System.Collections.Generic;
using System.Text;

namespace Vuja.Aplikacija.DataTransfer
{
    public class CreateModelDto
    {
       
        public string ModelIme { get; set; }
        public string ModelCena { get; set; }
        public DateTime ModelDatumIzlaska { get; set; }
        public int BrendId { get; set; }
        public int IgracId { get; set; }
    }
}
