using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Projeto_ar_condicionado
{
    public partial class form1 : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public form1()
        {
            InitializeComponent();
            ListarClientes();
            //ConfigurarDataGrid();

        }


        private void ListarClientes()
        {
            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

            string busca = txb_buscar_cadastro.Text.ToString();
            DataSet dsCliente = new DataSet();
            dsCliente = clientecrud.BuscarCliente(busca);
        }


        //------------------------------------------------------------//
        //focus

        private void txb_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                maskedTextBox_telefone.Focus();
            }
        }

        private void maskedTextBox_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox_cpf.Focus();
            }
        }

        private void maskedTextBox_cpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_gmail.Focus();
            }
        }

        private void txb_gmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox_cep.Focus();
            }
        }

        private void maskedTextBox_cep_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txb_rua.Focus();
            }
        }

        private void txb_rua_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                maskedTextBox_numero.Focus();
            }
        }

        private void maskedTextBox_numero_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txb_bairro.Focus();
            }
        }

        private void txb_bairro_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txb_cidade.Focus();
            }
        }

        private void txb_cidade_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }
        //--------------------------------------------------------------------//


        private void button2_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

           
               

            


            if ((txb_nome.Text=="") || (comboBox_tipo.Text=="") || (maskedTextBox_numero.Text == "" ) 
              || (maskedTextBox_telefone.Text=="") || (maskedTextBox_cpf.Text=="") || (txb_gmail.Text=="") 
              || (txb_rua.Text=="") || (txb_bairro.Text == "")|| (txb_cidade.Text== "")) 
           {                             
                MessageBox.Show("algum campo necessario esta vazio","erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
               
                // Try = tente
                // Atribui os valores dos campos no objeto Cliente
                cliente.nome_cliente = txb_nome.Text;
                cliente.endereco_cliente = txb_rua.Text;
                cliente.cpf_clienete = maskedTextBox_cpf.Text;
                cliente.gmail_cliente = txb_gmail.Text;
                cliente.CEP_cliente = maskedTextBox_cep.Text;
                cliente.bairro_cliente = txb_bairro.Text;
                cliente.numero_casa = maskedTextBox_numero.Text;
                cliente.complemento_cliente = txb_complemento.Text;
                cliente.cidade_cliente = txb_cidade.Text;
                cliente.telefone_cliente = maskedTextBox_telefone.Text;

                // Executa o comando de inclusão do cliente 
                clientecrud.IncluirCliente(cliente);

                // Exibe uma Mensagem se deu certo
                MessageBox.Show("Cadastro bem sucedido", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha a Tela
                this.Close();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txb_bairro.Clear();
            txb_cidade.Clear();
            txb_nome.Clear();
            txb_gmail.Clear();
            txb_rua.Clear();
            txb_cidade.Clear();
            txb_complemento.Clear();
            txb_bairro.Clear();
            maskedTextBox_cep.Clear();
            maskedTextBox_telefone.Clear();
            maskedTextBox_cpf.Clear();
            maskedTextBox_numero.Clear();
            comboBox_tipo = null;
                
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = maskedTextBox_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";
                // Criar um dataset para enviar e receber os dados
                DataSet dados = new DataSet();

                // ler o xml
                dados.ReadXml(xml);

                txb_rua.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txb_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txb_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
               
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_dastro_busca_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox_tipo.Text=="Funcionario")
            {
                maskedTextBox_cep.ReadOnly = true;
                maskedTextBox_cep.BackColor = Color.LightGray;

                txb_bairro.ReadOnly = true;
                txb_bairro.BackColor = Color.LightGray;

                txb_cidade.ReadOnly = true;
                txb_cidade.BackColor = Color.LightGray;

                txb_rua.ReadOnly = true;
                txb_rua.BackColor = Color.LightGray;

                txb_complemento.ReadOnly = true;
                txb_complemento.BackColor = Color.LightGray;

                maskedTextBox_numero.ReadOnly = true;
                maskedTextBox_numero.BackColor = Color.LightGray;
            }
           // else
            {
                maskedTextBox_cep.ReadOnly = false;
                maskedTextBox_cep.BackColor = Color.White;

                txb_bairro.ReadOnly = false;
                txb_bairro.BackColor = Color.White;

                txb_cidade.ReadOnly = false;
                txb_cidade.BackColor = Color.White;

                txb_rua.ReadOnly = false;
                txb_rua.BackColor = Color.White;

                txb_complemento.ReadOnly = false;
                txb_complemento.BackColor = Color.White;

                maskedTextBox_numero.ReadOnly = false;
                maskedTextBox_numero.BackColor = Color.White;
            }
        }

        private void btn_buscar_cadastro_Click(object sender, EventArgs e)
        {
            if (txb_buscar_cadastro.Text == "")
            {
                MessageBox.Show("digite algum nome", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_buscar_cadastro.Focus();
                return;
            }
            ListarClientes();
        }

        private void ConfigurarDataGrid()
        {
            dgv_cliente.DefaultCellStyle.Font = new Font("Ariel", 9, FontStyle.Bold);

            dgv_cliente.RowHeadersWidth = 25;

            dgv_cliente.Columns["clienteID"].Visible = false;

            dgv_cliente.Columns["endereco_cliente"].HeaderText = "Endereço";

            dgv_cliente.Columns["teleone_cliente"].HeaderText = "Tel";

            dgv_cliente.Columns["nome_cliente"].HeaderText = "Nome Completo";

            dgv_cliente.Columns["cpf_cliente"].HeaderText ="CPF";
            
            dgv_cliente.Columns["gmail_cliente"].HeaderText= "Email";

            dgv_cliente.Columns["CEP"].HeaderText = "CEP";

            dgv_cliente.Columns["cidade_cliente"].HeaderText = "Cidade";

            dgv_cliente.Columns["bairro"].HeaderText = "Bairro";

            dgv_cliente.Columns["Numero_casa"].HeaderText = "Nº";

            dgv_cliente.Columns["compelemento_cliente"].HeaderText = "Complemento";          

        }

        private void txb_buscar_cadastro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btn_buscar_Click(sender, e);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_cliente.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dgv_cliente.CurrentRow.Cells["clienteID"].Value);

                var resultado = MessageBox.Show("Deseja Excluir Esse Registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (resultado == DialogResult.Yes)
                {
                    ClienteCRUD CliCrud = new ClienteCRUD(_conexao);
                    CliCrud.ExcluirCliente(codigo);
                    ListarClientes();
                }
            }
            else
            {
                MessageBox.Show("Selece um cadastro");
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
           // if (dgv_cliente.SelectedRows.Count > 0)
            //{
                //int codigo = Convert.ToInt32(dgv_cliente.CurrentRow.Cells["clienteID"].Value);
               // var frm_Alterar_Cadastro = new = frm_servico_contrato(codigo);
               // frm_Alterar_Cadastro.ShowDialog();
              //  ListarClientes();
           // }
           // else
            //{
                MessageBox.Show("Selecione um Registro para ser alterado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }
    }
}
