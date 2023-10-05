using System.Windows.Forms;
using TrabalhoCadastroDeClientes.Models;
using TrabalhoCadastroDeClientes.Services;

namespace TrabalhoCadastroDeClientes
{
    public partial class Principal : Form
    {
        public ClienteService ClienteService;

        public Principal()
        {
            InitializeComponent();
            ClienteService = new ClienteService(new Repository.ClienteRepository(new Context.ClienteContext()));
            CarregarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        public void CarregarClientes()
        {
            GridData.Rows.Clear();


            var clientes = ClienteService.ListarClientes();

            foreach (var cliente in clientes)
            {
                GridData.Rows.Add(cliente.Nome, cliente.Email, cliente.Telefone, cliente.Id);
            }
        }

        private void AdicionarClienteBtn_Click(object sender, EventArgs e)
        {
            var form = new AdicionarCliente();
            form.Show();
            form.TopMost = true;
            form.Activate();
        }

        private void VisualizacãoAvanCadaBtn_Click(object sender, EventArgs e)
        {
            if (GridData.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = GridData.SelectedRows[0];

                string? valorDaColuna1 = selectedRow?.Cells["Id"]?.Value?.ToString();

                if(valorDaColuna1 == null)
                {
                    MessageBox.Show($"PorFavor Selecione uma linha primeiro");
                    return;
                }

                var form = new AdicionarCliente(Convert.ToInt32(valorDaColuna1));
                form.Show();
                form.TopMost = true;
                form.Activate();

            }
            else
            {
                MessageBox.Show($"PorFavor Selecione uma linha primeiro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }
    }
}