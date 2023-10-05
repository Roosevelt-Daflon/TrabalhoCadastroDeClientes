using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoCadastroDeClientes.Models;
using TrabalhoCadastroDeClientes.Services;

namespace TrabalhoCadastroDeClientes
{
    public partial class AdicionarCliente : Form
    {
        public ClienteService ClienteService;
        Cliente Cliente = new Cliente();

        public AdicionarCliente()
        {
            InitializeComponent();
            ClienteService = new ClienteService(new Repository.ClienteRepository(new Context.ClienteContext()));

            comboBox1.DataSource = Estados.GetEstados();
        }

        public AdicionarCliente(int id)
        {
            InitializeComponent();
            ClienteService = new ClienteService(new Repository.ClienteRepository(new Context.ClienteContext()));
            comboBox1.Items.Add(Estados.GetEstados());
            Cliente = ClienteService.GetClienteById(id);
            ShowCliente();
        }


        public void ShowCliente()
        {
            textBox1.Text = Cliente.Nome;
            textBox2.Text = Cliente.Telefone;
            textBox3.Text = Cliente.Email;
            textBox4.Text = Cliente.Logradouro;
            textBox5.Text = Cliente.Numero;
            textBox6.Text = Cliente.Complemento;
            textBox7.Text = Cliente.Bairro;
            textBox8.Text = Cliente.Cidade;
            comboBox1.Text = Cliente.Estado;
            textBox10.Text = Cliente.Cep;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente.Nome = textBox1.Text;
            Cliente.Telefone = textBox2.Text;
            Cliente.Email = textBox3.Text;
            Cliente.Logradouro = textBox4.Text;
            Cliente.Numero = textBox5.Text;
            Cliente.Complemento = textBox6.Text;
            Cliente.Bairro = textBox7.Text;
            Cliente.Cidade = textBox8.Text;
            Cliente.Estado = comboBox1.Text;
            Cliente.Cep = textBox10.Text;

            if (Cliente.Id == 0 && !string.IsNullOrEmpty(Cliente.Nome))
            {
                ClienteService.AddClinete(Cliente);
                Close();
                return;
            }
            else if (!string.IsNullOrEmpty(Cliente.Nome))
            {
                ClienteService.UpdateCliente(Cliente);
                Close();
                return;
            }


            MessageBox.Show($"Porfavor Digite valores Validos");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
