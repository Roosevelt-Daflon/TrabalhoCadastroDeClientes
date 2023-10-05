using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabalhoCadastroDeClientes.Context;
using TrabalhoCadastroDeClientes.Models;

namespace TrabalhoCadastroDeClientes.Repository
{
    public class ClienteRepository
    {
        private readonly ClienteContext _context;

        public ClienteRepository(ClienteContext clienteContext)
        {
            _context = clienteContext;
        }

        public List<Cliente> GetAllClientesBy(params Expression<Func<Cliente, bool>>[] predicates)
        {
            IQueryable<Cliente> clientes = _context.Clientes;

            foreach (var predicate in predicates)
            {
                clientes = clientes.Where(predicate);
            }

            return clientes.AsNoTracking().ToList();
        }

        public Cliente? GetClientesBy(params Expression<Func<Cliente, bool>>[] predicates)
        {
            IQueryable<Cliente> clientes = _context.Clientes;

            foreach (var predicate in predicates)
            {
                clientes = clientes.Where(predicate);
            }

            return clientes.AsNoTracking().FirstOrDefault();
        }

        public void DeleteClientes(params Expression<Func<Cliente, bool>>[] predicates)
        {
            IQueryable<Cliente> clientes = _context.Clientes;

            foreach (var predicate in predicates)
            {
                clientes = clientes.Where(predicate);
            }

            _context.Clientes.RemoveRange(clientes);

            _context.SaveChanges();
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
         
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public Cliente AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return cliente;
        }





    }
}
