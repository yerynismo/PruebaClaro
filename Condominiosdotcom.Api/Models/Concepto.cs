using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Models
{
    public class Concepto
    {
        [Key]
        public int ConceptoID { get; set; }
        public string Elconcepto { get; set; }

        public bool Recurrencia { get; set; }
    }
}
