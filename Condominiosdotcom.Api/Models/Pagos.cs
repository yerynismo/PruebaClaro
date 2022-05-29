using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Models
{
    public class Pagos
    {
     
        [Key]
        public int PagoID { get; set; }
        public int? ClienteID { get; set; }
        [ForeignKey("ClienteID")]
        public virtual Cliente ClienteE { get; set; }
        public int? ConceptoID { get; set; }
        [ForeignKey("ConceptoID")]
        public virtual Concepto ConceptoE { get; set; }
        public int Pendiente { get; set; }
        public int Mora { get; set; }
        public int Monto { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }


    }
}
//Id
//moton
//si el pago es igual  al monto cuota paga
//si el mago es menor al monto pendiente cuota - pago = pendiente