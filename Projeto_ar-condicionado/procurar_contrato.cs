using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ar_condicionado
{
    public partial class procurar_contrato : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public procurar_contrato()
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

        private void dgv_procurar_cliente_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView_cliente.CurrentRow != null)
            {

                string nomeCliente = dataGridView_cliente.CurrentRow.Cells["nome_cliente"].Value.ToString();
                string idCliente = dataGridView_cliente.CurrentRow.Cells["clienteID"].Value.ToString();


                frm_servico_contrato frmServicoContratoAberto = Application.OpenForms.OfType<frm_servico_contrato>().FirstOrDefault();

                if (frmServicoContratoAberto != null)
                {
                    
                    frmServicoContratoAberto.BringToFront();
                    frmServicoContratoAberto.SetClienteInfo_contrato(nomeCliente);
                    frmServicoContratoAberto.SetClienteInfo_contratoID(idCliente);
                }
               
            }

            this.Close();
        }

       private void procurar_contrato_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }


        private void btn_procurar_contrato_Click(object sender, EventArgs e)
        {

            if (txb_buscar_cadastro.Text == "")
            {
                MessageBox.Show("digite algum nome", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_buscar_cadastro.Focus();
                return;
            }
            ListarClientes();
        }

        
    }
}
