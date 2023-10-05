using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCadastroDeClientes.Models;
using TrabalhoCadastroDeClientes.Repository;

namespace TrabalhoCadastroDeClientes.Services
{
    public class ClienteService
    {
        private readonly ClienteRepository _clienteRepositore;

        public ClienteService(ClienteRepository clienteRepositore)
        {
            _clienteRepositore = clienteRepositore;
        }

        public List<Cliente> ListarClientes() => _clienteRepositore.GetAllClientesBy();

        public Cliente? GetClienteById(int id) => _clienteRepositore.GetClientesBy(x => x.Id == id);

        public Cliente UpdateCliente(Cliente cliente) => _clienteRepositore.UpdateCliente(cliente);

        public Cliente AddClinete(Cliente cliente) => _clienteRepositore.AddCliente(cliente);
        public void DeleteCliente(int id) => _clienteRepositore.DeleteClientes(x => x.Id == id);

    }
}
