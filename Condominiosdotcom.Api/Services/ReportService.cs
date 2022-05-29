using Condominiosdotcom.Api.Interfaces;
using Condominiosdotcom.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class ReportService : IReportService
    {
        private readonly DataContext _context;
        public ReportService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<ReporteClienteDTO> Report(int id)
        {

            var queryReport = (from c in _context.Cuotas
                               join p in _context.Pagos on c.ClienteID equals p.ClienteID where c.ClienteID == id
                               select new ReporteClienteDTO
                               {
                                   Nombre = c.ClienteE.Nombre,
                                   Apellido = c.ClienteE.Apellido,
                                   MoraCuota = c.Mora,
                                   MoraPago = p.Mora,
                                   PendienteCuota = c.Pendiente,
                                   PendientePago = p.Pendiente

                               }).ToList();



            return queryReport;
        }
    }
}
