using Condominiosdotcom.Api.Models;
using Condominiosdotcom.Api.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Services
{
    public class ClienteService : IClienteService
    {
        private readonly DataContext _context;
        public ClienteService(DataContext context)
        {
            _context = context;
        }

        public Cliente Add(Cliente newClient)
        {
            var nuevo = _context.Cliente.Add(newClient);
            _context.SaveChanges();
            return nuevo.Entity;
        }

        public void Delete(int id)
        {
            try
            {
                var registrado = _context.Cliente.Find(id);
                if (registrado != null) {
                    _context.Remove(registrado);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }      
        }

        public List<Cliente> GetClient()
        {
            var cliente = _context.Cliente.ToList();
            return cliente;
        }

        public Cliente Get(int id)
        {
            var unCliente = _context.Cliente.FirstOrDefault(x => x.ClienteID == id);
            return unCliente;
        }

        public Cliente Modify(Cliente updateClient)
        {
            _context.Entry(updateClient).State = EntityState.Modified;
            _context.SaveChanges();
            return updateClient;
        }
    }
}
