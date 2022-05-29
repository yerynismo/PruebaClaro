using Condominiosdotcom.Api.Models;
using Condominiosdotcom.Api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class PagosService : IPagosService
    {
        private readonly DataContext _context;
        public PagosService(DataContext context)
        {
            _context = context;
        }
        public Pagos Add(Pagos newPagos)
        {
            var nuevo = _context.Pagos.Add(newPagos);
            _context.SaveChanges();
            return nuevo.Entity;
        }

        public void Delete(int id)
        {
            try
            {
                var registrado = _context.Pagos.Find(id);
                if (registrado != null)
                {
                    _context.Remove(registrado);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Pagos> Get()
        {
            var Pagos = _context.Pagos
                                .Include(p => p.ClienteE)
                                .Include(p => p.ConceptoE)
                                .ToList();
            return Pagos;
        }

        public Pagos Get(int id)
        {
            var unPago = _context.Pagos.FirstOrDefault(x => x.PagoID == id);
            return unPago;
        }

        public Pagos Modify(Pagos updatePagos)
        {
            _context.Entry(updatePagos).State = EntityState.Modified;
            _context.SaveChanges();
            return updatePagos;
        }
    }
}
