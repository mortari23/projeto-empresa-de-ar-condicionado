using Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_ar_condicionado
{
    public partial class procurar_cliente : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public procurar_cliente()
        {
            InitializeComponent();
        }

        private void ListarClientes()
        {
            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

            string busca = txb_buscar_cadastro.Text.ToString();
            DataSet dsCliente = clientecrud.BuscarCliente(busca);

            if (dsCliente != null && dsCliente.Tables.Contains("clientes") && dsCliente.Tables["clientes"].Rows.Count > 0)
            {
                dataGridView_cliente.DataSource = dsCliente;
                dataGridView_cliente.DataMember = "clientes";

                // Configurar as colunas somente se houver dados
                ConfigurarDataGrid();
            }
            else
            {
                MessageBox.Show("Nenhum cliente encontrado.");
                dataGridView_cliente.DataSource = null;
            }
        }

        private void ConfigurarDataGrid()
        {
            dataGridView_cliente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView_cliente.RowHeadersWidth = 25;

            // Verificar se as colunas existem antes de configurá-las
            if (dataGridView_cliente.Columns["clienteID"] != null)
                dataGridView_cliente.Columns["clienteID"].Visible = false;

            if (dataGridView_cliente.Columns["endereco_cliente"] != null)
                dataGridView_cliente.Columns["endereco_cliente"].HeaderText = "Endereço";

            if (dataGridView_cliente.Columns["telefone_cliente"] != null)
                dataGridView_cliente.Columns["telefone_cliente"].HeaderText = "Tel";

            if (dataGridView_cliente.Columns["nome_cliente"] != null)
                dataGridView_cliente.Columns["nome_cliente"].HeaderText = "Nome Completo";

            if (dataGridView_cliente.Columns["cpf_cliente"] != null)
                dataGridView_cliente.Columns["cpf_cliente"].HeaderText = "CPF";

            if (dataGridView_cliente.Columns["gmail_cliente"] != null)
                dataGridView_cliente.Columns["gmail_cliente"].HeaderText = "Email";

            if (dataGridView_cliente.Columns["CEP_cliente"] != null)
                dataGridView_cliente.Columns["CEP_cliente"].HeaderText = "CEP";

            if (dataGridView_cliente.Columns["cidade_cliente"] != null)
                dataGridView_cliente.Columns["cidade_cliente"].HeaderText = "Cidade";

            if (dataGridView_cliente.Columns["bairro_cliente"] != null)
                dataGridView_cliente.Columns["bairro_cliente"].HeaderText = "Bairro";

            if (dataGridView_cliente.Columns["Numero_casa"] != null)
                dataGridView_cliente.Columns["Numero_casa"].HeaderText = "Nº";

            if (dataGridView_cliente.Columns["complemento_cliente"] != null)
                dataGridView_cliente.Columns["complemento_cliente"].HeaderText = "Complemento";
        }

        private void procurar_cliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}
