using System;
using System.Collections.Generic;
using System.Text;

namespace Vuja.Aplikacija.DataTransfer
{
   public class IgracDto
    {
        
        public int IgracId { get; set; }
        public string ImeIgrac { get; set; }
        public string PrezimeIgrac { get; set; }
        public DateTime? GodisteIgrac { get; set; }
        public int? BrojDresaIgrac { get; set; }
        public int TimId { get; set; }
        public int? ModelId { get; set; }
      
    }
}
