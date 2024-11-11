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
    public partial class frm_alterar_funcionario : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

      


        public frm_alterar_funcionario(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {
                funcionario funcionario = new funcionario();
                funcionarioCrud funcionarioCrud = new funcionarioCrud(_conexao);
                funcionario = funcionarioCrud.ObtemFuncionario(codigo);

                if (funcionario == null)
                {
                    MessageBox.Show("Cade o Cliente ?? não temos");
                    this.Close();
                }

                txb_codigo.Text = funcionario.funcionarioID.ToString();
                maskedTextBox_cpf.Text = funcionario.cpf_funcionario.ToString();
                txb_nome.Text = funcionario.nome_funcionario;
                maskedTextBox_telefone.Text = funcionario.telefone_funcionario.ToString();
                maskedTextBox_cep.Text = funcionario.CEP_funcionario.ToString();
                txb_rua.Text = funcionario.endereco_funcionario.ToString();
                txb_bairro.Text = funcionario.bairro_funcionario.ToString();
                txb_complemento.Text = funcionario.complemento_funcionario.ToString();
                maskedTextBox_numero.Text = funcionario.numero_funcionario.ToString();
            }

        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteCRUD clientecrud = new ClienteCRUD(_conexao);

            funcionario funcionario = new funcionario();
            funcionarioCrud funcionarioCrud = new funcionarioCrud(_conexao);

            if ((txb_nome.Text == "") || (comboBox_tipo.Text == "") || (comboBox_tipo.Text == null) || (maskedTextBox_numero.Text == "")
            || (maskedTextBox_telefone.Text == "") || (maskedTextBox_cpf.Text == "")
            || (txb_rua.Text == "") || (txb_bairro.Text == "") || (txb_cidade.Text == ""))
            {
                MessageBox.Show("algum campo necessario esta vazio", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {



                if (comboBox_tipo.Text == "Funcionario")
                {



                    try
                    {
                        funcionario.funcionarioID = int.Parse(txb_codigo.Text);
                        funcionario.nome_funcionario = txb_nome.Text;
                        funcionario.telefone_funcionario = maskedTextBox_telefone.Text;
                        funcionario.cpf_funcionario = maskedTextBox_cpf.Text;
                        funcionario.CEP_funcionario = maskedTextBox_cep.Text;
                        funcionario.endereco_funcionario = txb_rua.Text;
                        funcionario.bairro_funcionario = txb_bairro.Text;
                        funcionario.complemento_funcionario = txb_complemento.Text;
                        funcionario.numero_funcionario = maskedTextBox_numero.Text;

                        funcionarioCrud.AlterarFuncionario(funcionario);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO" + ex);
                    }

                }
                else if (comboBox_tipo.Text == "Cliente")
                {
                    if ((txb_nome.Text == "") || (comboBox_tipo.Text == "") || (comboBox_tipo.Text == null) || (maskedTextBox_numero.Text == "")
                 || (maskedTextBox_telefone.Text == "") || (maskedTextBox_cpf.Text == "") || (txb_gmail.Text == "")
                 || (txb_rua.Text == "") || (txb_bairro.Text == "") || (txb_cidade.Text == ""))
                    {
                        MessageBox.Show("algum campo necessario esta vazio", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

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

                      
                    }



                }
            }
        }

        private void comboBox_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBox_tipo.Text == "Funcionario")
            {
                txb_gmail.ReadOnly = true;
                txb_gmail.BackColor = Color.LightGray;
            }
            else
            {


                txb_gmail.ReadOnly = false;
                txb_gmail.BackColor = Color.White;


            }
        }
    }
}
