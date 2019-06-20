using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vuja.Aplikacija.DataTransfer
{
    public class CreateModelDto
    {
        [RegularExpression("^[A-Z][a-z]{2,20}$", ErrorMessage = "Ime modela nije u ispravnom formatu.")]
        public string ModelIme { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Samo su brojevi dozvoljeni")]
        public string ModelCena { get; set; }
        [Required]
        public DateTime ModelDatumIzlaska { get; set; }
        [Required]
        public int BrendId { get; set; }
        [Required]
        public int IgracId { get; set; }
    }
}
