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
    public partial class frm_procurar_funcionario : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;


        public frm_procurar_funcionario()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            
        }

        private void ListarFuncionario()
        {
            funcionarioCrud funcionarioCrud = new funcionarioCrud(_conexao);

            string busca = txb_buscar_cadastro.Text.ToString();
            DataSet dsFuncionarios = funcionarioCrud.BuscarFuncionario(busca);

            if (dsFuncionarios != null && dsFuncionarios.Tables.Contains("funcionario") && dsFuncionarios.Tables["funcionario"].Rows.Count > 0)
            {
                dataGridView_funcionario.DataSource = dsFuncionarios;
                dataGridView_funcionario.DataMember = "funcionario";

                // Configurar as colunas somente se houver dados
                ConfigurarDataGrid();
            }
            else
            {
                MessageBox.Show("Nenhum funcionario encontrado.");
                dataGridView_funcionario.DataSource = null;
            }
        }
        private void ConfigurarDataGrid()
        {
            dataGridView_funcionario.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dataGridView_funcionario.RowHeadersWidth = 25;

            // Verificar se as colunas existem antes de configurá-las
            if (dataGridView_funcionario.Columns["funcionarioID"] != null)
                dataGridView_funcionario.Columns["funcionarioID"].Visible = false;

            if (dataGridView_funcionario.Columns["endereco_funcionario"] != null)
                dataGridView_funcionario.Columns["endereco_funcionario"].HeaderText = "Endereço";

            if (dataGridView_funcionario.Columns["telefone_funcionario"] != null)
                    dataGridView_funcionario.Columns["telefone_funcionario"].HeaderText = "Tel";

            if (dataGridView_funcionario.Columns["nome_funcionario"] != null)
                dataGridView_funcionario.Columns["nome_funcionario"].HeaderText = "Nome Completo";

            if (dataGridView_funcionario.Columns["cpf_funcionario"] != null)
                dataGridView_funcionario.Columns["cpf_funcionario"].HeaderText = "CPF";

            

            if (dataGridView_funcionario.Columns["CEP_funcionario"] != null)
                dataGridView_funcionario.Columns["CEP_funcionario"].HeaderText = "CEP";

            

            if (dataGridView_funcionario.Columns["bairro_funcionario"] != null)
                dataGridView_funcionario.Columns["bairro_funcionario"].HeaderText = "Bairro";

            if (dataGridView_funcionario.Columns["Numero_funcionario"] != null)
                dataGridView_funcionario.Columns["Numero_funcionario"].HeaderText = "Nº";

            if (dataGridView_funcionario.Columns["complemento_funcionario"] != null)
                dataGridView_funcionario.Columns["complemento_funcionario"].HeaderText = "Complemento";
        }

        private void procurar_cliente_Load(object sender, EventArgs e)
        {
            ListarFuncionario();
        }

        private void dataGridView_funcionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_funcionario.CurrentRow != null)
            {
               
                string nomeFuncionario = dataGridView_funcionario.CurrentRow.Cells["nome_funcionario"].Value.ToString();
                string idfuncionario = dataGridView_funcionario.CurrentRow.Cells["funcionarioID"].Value.ToString();

                frm_servico_contrato frmServicoContratoAberto = Application.OpenForms.OfType<frm_servico_contrato>().FirstOrDefault();
                frm_alterar_serviço frm_alterar_serviço = Application.OpenForms.OfType<frm_alterar_serviço>().FirstOrDefault();

                if (frmServicoContratoAberto != null)
                {
                    
                    frmServicoContratoAberto.BringToFront();
                    frmServicoContratoAberto.SetFuncionarioInfo(nomeFuncionario);
                    frmServicoContratoAberto.SetFuncionarioInfoID(idfuncionario);
                }

                if (frm_alterar_serviço != null)
                {

                    frm_alterar_serviço.BringToFront();
                    frm_alterar_serviço.SetFuncionarioInfo(nomeFuncionario);
                    frm_alterar_serviço.SetFuncionarioInfoID(idfuncionario);
                }


            }

            this.Close();
        }

        private void btn_buscar_cadastro_Click(object sender, EventArgs e)
        {
            if (txb_buscar_cadastro.Text == "")
            {
                MessageBox.Show("digite algum nome", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_buscar_cadastro.Focus();
                return;
            }
            ListarFuncionario();
        }

        private void frm_procurar_funcionario_Load(object sender, EventArgs e)
        {
            ListarFuncionario();
        }
    }
}
