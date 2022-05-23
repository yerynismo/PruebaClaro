using Condominiosdotcom.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class PagosService : IPagosData
    {
        private readonly DataContext _context;
        public PagosService(DataContext context)
        {
            _context = context;
        }
        public Pagos AddPagos(Pagos newPagos)
        {
            var nuevo = _context.Pagos.Add(newPagos);
            _context.SaveChanges();
            return nuevo.Entity;
        }

        public void DeletePagos(int id)
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

        public IEnumerable<Pagos> GetPagos()
        {
            var Pagos = _context.Pagos.ToList();
            return Pagos;
        }

        public Pagos GetPagos(int id)
        {
            var unPago = _context.Pagos.FirstOrDefault(x => x.PagoID == id);
            return unPago;
        }

        public Pagos ModifyPagos(Pagos updatePagos)
        {
            _context.Entry(updatePagos).State = EntityState.Modified;
            _context.SaveChanges();
            return updatePagos;
        }
    }
}
