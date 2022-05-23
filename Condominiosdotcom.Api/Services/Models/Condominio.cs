using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Models
{
    public class Condominio
    {
        [Key]
        public int CondominioID { get; set; }
    
        public string NombreCondominio { get; set; }
        public string Apart_casa { get; set; }
        public int ResidencialID { get; set; }
        [ForeignKey("ResidencialID")]
        public virtual Residencial ResidencialE { get; set; }
        public int ClienteID { get; set; }
        [ForeignKey("ClienteID")]
        public virtual Cliente ClienteE { get; set; }
        public int Valor { get; set; }

       

    }
}
