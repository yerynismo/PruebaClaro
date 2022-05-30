using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.DTOs
{
    public class ReporteClienteDTO
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int MoraPago { get; set; }
        public int MoraCuota { get; set; }
        public int PendientePago { get; set; }
        public int PendienteCuota { get; set; }

    }
}
