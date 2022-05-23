using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
 
    }
}
