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

        private void dgv_procurar_cliente_DoubleClick(object sender, EventArgs e)
        {
            if(dgv_procurar_cliente.CurrentRow != null)
            {
                // Obtém o valor da célula "nome_cliente" da linha selecionada
                string nomeCliente = dgv_procurar_cliente.CurrentRow.Cells["nome_cliente"].Value.ToString();

                // Procura por uma instância aberta do formulário que contém o TextBox
                frm_servico_contrato frmServicoContratoAberto = Application.OpenForms.OfType<frm_servico_contrato>().FirstOrDefault();

                if (frmServicoContratoAberto != null)
                {
                    // Se já estiver aberto, traz o formulário para frente e passa o valor
                    frmServicoContratoAberto.BringToFront();
                    frmServicoContratoAberto.SetClienteInfo(nomeCliente);  // Passa a informação para o método no formulário
                }
                else
                {
                    // Se o formulário não estiver aberto, cria e abre uma nova instância
                    frm_servico_contrato frmServicoContratoNovo = new frm_servico_contrato();
                    frmServicoContratoNovo.SetClienteInfo(nomeCliente);  // Passa a informação para o método no formulário
                    frmServicoContratoNovo.Show();
                }
            }

            this.Close();
        }

        private void ListarClientes()
        {
            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

            string busca = txb_procurar_contrato.Text.ToString();
            DataSet dsCliente = clientecrud.BuscarCliente(busca);

            if (dsCliente != null && dsCliente.Tables.Contains("clientes") && dsCliente.Tables["clientes"].Rows.Count > 0)
            {
                dgv_procurar_cliente.DataSource = dsCliente;
                dgv_procurar_cliente.DataMember = "clientes";

                // Configurar as colunas somente se houver dados
                ConfigurarDataGrid();
            }
            else
            {
                MessageBox.Show("Nenhum cliente encontrado.");
                dgv_procurar_cliente.DataSource = null;
            }
        }
        private void ConfigurarDataGrid()
        {
            dgv_procurar_cliente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgv_procurar_cliente.RowHeadersWidth = 25;

            // Verificar se as colunas existem antes de configurá-las
            if (dgv_procurar_cliente.Columns["clienteID"] != null)
                dgv_procurar_cliente.Columns["clienteID"].Visible = false;

            if (dgv_procurar_cliente.Columns["endereco_cliente"] != null)
                dgv_procurar_cliente.Columns["endereco_cliente"].HeaderText = "Endereço";

            if (dgv_procurar_cliente.Columns["telefone_cliente"] != null)
                dgv_procurar_cliente.Columns["telefone_cliente"].HeaderText = "Tel";

            if (dgv_procurar_cliente.Columns["nome_cliente"] != null)
                dgv_procurar_cliente.Columns["nome_cliente"].HeaderText = "Nome Completo";

            if (dgv_procurar_cliente.Columns["cpf_cliente"] != null)
                dgv_procurar_cliente.Columns["cpf_cliente"].HeaderText = "CPF";

            if (dgv_procurar_cliente.Columns["gmail_cliente"] != null)
                dgv_procurar_cliente.Columns["gmail_cliente"].HeaderText = "Email";

            if (dgv_procurar_cliente.Columns["CEP_cliente"] != null)
                dgv_procurar_cliente.Columns["CEP_cliente"].HeaderText = "CEP";

            if (dgv_procurar_cliente.Columns["cidade_cliente"] != null)
                dgv_procurar_cliente.Columns["cidade_cliente"].HeaderText = "Cidade";

            if (dgv_procurar_cliente.Columns["bairro_cliente"] != null)
                dgv_procurar_cliente.Columns["bairro_cliente"].HeaderText = "Bairro";

            if (dgv_procurar_cliente.Columns["Numero_casa"] != null)
                dgv_procurar_cliente.Columns["Numero_casa"].HeaderText = "Nº";

            if (dgv_procurar_cliente.Columns["complemento_cliente"] != null)
                dgv_procurar_cliente.Columns["complemento_cliente"].HeaderText = "Complemento";
        }

        private void btn_procurar_contrato_Click(object sender, EventArgs e)
        {

            if (txb_procurar_contrato.Text == "")
            {
                MessageBox.Show("digite algum nome", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_procurar_contrato.Focus();
                return;
            }
            ListarClientes();
        }
    }
}
