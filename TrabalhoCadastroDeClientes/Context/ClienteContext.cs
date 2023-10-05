using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabalhoCadastroDeClientes.Models;

namespace TrabalhoCadastroDeClientes.Context
{
    public class ClienteContext : DbContext
    {

        public ClienteContext()
        {
            
        }

        public virtual DbSet<Cliente> Clientes { get; set;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase.db;");
        }
    }
}
