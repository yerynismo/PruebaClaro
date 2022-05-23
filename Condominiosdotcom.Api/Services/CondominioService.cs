using Condominiosdotcom.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class CondominioService : ICondominioData
    {
        private readonly DataContext _context;
        public CondominioService(DataContext context)
        {
            _context = context;
        }
        public Condominio AddCondominio(Condominio newCondominio)
        {
            var nuevo = _context.Condominio.Add(newCondominio);
            _context.SaveChanges();
            return nuevo.Entity;
        }

        public void DeleteCondominio(int id)
        {
            try
            {
                var registrado = _context.Condominio.Find(id);
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

        public IEnumerable<Condominio> GetCondominio()
        {
            var condominio = _context.Condominio.ToList();
            return condominio;
        }

        public Condominio GetCondominio(int id)
        {
            var unCondominio = _context.Condominio.FirstOrDefault(x => x.CondominioID == id);
            return unCondominio;
        }

        public Condominio ModifyCondominio(Condominio updateCondominio)
        {
            _context.Entry(updateCondominio).State = EntityState.Modified;
            _context.SaveChanges();
            return updateCondominio;
        }
    }
}
