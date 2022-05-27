using Condominiosdotcom.Api.Models;
using Condominiosdotcom.Api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class CuotasService : ICuotaService
    {
        private readonly DataContext _context;
        public CuotasService(DataContext context)
        {
            _context = context;
        }
        public Cuotas Add(Cuotas newCuota)
        {
            var nuevo = _context.Cuotas.Add(newCuota);
            _context.SaveChanges();
            return nuevo.Entity;
        }

        public void Delete(int id)
        {
            try
            {
                var registrado = _context.Cuotas.Find(id);
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

        public IEnumerable<Cuotas> Get()
        {
            var Cuota = _context.Cuotas.ToList();
            return Cuota;
        }

        public Cuotas Get(int id)
        {
            var unCuota = _context.Cuotas.FirstOrDefault(x => x.CuotaID == id);
            return unCuota;
        }

        public Cuotas Modify(Cuotas updateCuota)
        {
            _context.Entry(updateCuota).State = EntityState.Modified;
            _context.SaveChanges();
            return updateCuota;
        }
    }
}
