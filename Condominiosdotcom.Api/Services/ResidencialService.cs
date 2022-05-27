using Condominiosdotcom.Api.Models;
using Condominiosdotcom.Api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class ResidencialService : IResidencialService
    {
        private readonly DataContext _context;
        public ResidencialService(DataContext context)
        {
            _context = context;
        }
        public Residencial Add(Residencial newResidencial)
        {
            var nuevo = _context.Residencial.Add(newResidencial);
            _context.SaveChanges();
            return nuevo.Entity;
        }

        public void Delete(int id)
        {
            try
            {
                var registrado = _context.Residencial.Find(id);
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

        public IEnumerable<Residencial> Get()
        {
            var residencial = _context.Residencial.ToList();
            return residencial;
        }

        public Residencial Get(int id)
        {
            var unResidencial = _context.Residencial.FirstOrDefault(x => x.ResidencialID == id);
            return unResidencial;
        }

        public Residencial Modify(Residencial updateResidencial)
        {
            _context.Entry(updateResidencial).State = EntityState.Modified;
            _context.SaveChanges();
            return updateResidencial;
        }
    }
}
