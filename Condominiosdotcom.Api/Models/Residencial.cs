using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Models
{
    public class Residencial
    {
        [Key]
        public int ResidencialID { get; set; }
        public string NombreResidencial { get; set; }
    }
}
