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
                txb_cidade.Text = funcionario.cidade_funcionario.ToString();
                maskedTextBox_numero.Text = funcionario.numero_funcionario.ToString();
            }

        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            funcionario funcionario = new funcionario();
            funcionarioCrud funcionarioCrud = new funcionarioCrud(_conexao);

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
                funcionario.cidade_funcionario = txb_cidade.Text;
                funcionario.numero_funcionario = maskedTextBox_numero.Text;

                funcionarioCrud.AlterarFuncionario(funcionario);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex);
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
