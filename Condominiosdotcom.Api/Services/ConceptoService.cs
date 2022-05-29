using Condominiosdotcom.Api.Interfaces;
using Condominiosdotcom.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class ConceptoService : IConceptoService
    {
        private readonly DataContext _context;

        public ConceptoService(DataContext context)
        {
            _context = context;
        }

        public Concepto Add(Concepto newConcept)
        {
            var nuevo = _context.Concepto.Add(newConcept);
            _context.SaveChanges();
            return nuevo.Entity;


        }

        public void Delete(int id)
        {
            try
            {
                var registrado = _context.Concepto.Find(id);
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

        public IEnumerable<Concepto> Get()
        {
            var concepto = _context.Concepto.ToList();
            return concepto;
        }

        public Concepto Get(int id)
        {
            var unConcepto = _context.Concepto.FirstOrDefault(x => x.ConceptoID == id);
            return unConcepto;
        }

        public Concepto Modify(Concepto updateConcept)
        {
            _context.Entry(updateConcept).State = EntityState.Modified;
            _context.SaveChanges();
            return updateConcept;
        }
    }
}
