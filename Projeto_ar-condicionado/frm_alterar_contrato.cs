using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace Projeto_ar_condicionado
{
    public partial class frm_alterar_contrato : Form
    {
        public frm_alterar_contrato()
        {
            InitializeComponent();
        }
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public frm_alterar_contrato(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {
               contratoCRUD contratoCRUD = new contratoCRUD(_conexao);
                var contrato = contratoCRUD.ObtemContrato(codigo);

                // Verificação se o serviço foi encontrado
                if (contrato == null)
                {
                    MessageBox.Show("contrato não encontrado!");
                    this.Close();
                    return;
                }

                // Preenchendo os campos do formulário com os valores do objeto `servico`
                txb_cliente_contrato.Text = contrato.clienteID?.ToString() ?? string.Empty;
                txb_cliente_contrato.Text = contrato.data_contrato?.ToString("dd/MM/yyyy") ?? string.Empty;
                txb_cliente_contrato.Text = contrato.valor_contrato?.ToString() ?? string.Empty;
                txb_descricao_contrato.Text = contrato.descricao_contrato ?? string.Empty;
                txb_cliente_contrato.Text = contrato.contratoID.ToString() ?? string.Empty;
                txb_codigo_contrato.Text = contrato.contratoID.ToString() ?? string.Empty;
                comboBox_tipo_contrato.Text = contrato.tipo_contrato?.ToString() ?? string.Empty;
                maskedTextBox_final.Text = contrato.final_contrato?.ToString() ?? string.Empty; 

                
                // Atribua outros campos, se necessário.
            }
        }

        private void btn_salvar_contrato_Click(object sender, EventArgs e)
        {
            {
                contrato contrato = new contrato();
                contratoCRUD contratoCrud = new contratoCRUD(_conexao);

                if ((txb_cliente_contrato.Text == "") || (txb_descricao_contrato.Text == "") || (txb_valor_contrato.Text == "") || (comboBox_tipo_contrato.Text == "") || (maskedTextBox_final.Text == "") || (data_novo_contrato.Text == ""))
                {
                    MessageBox.Show("algum campo necessario esta vazio", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        contrato.contratoID = int.Parse(txb_codigo_contrato.Text);
                        contrato.clienteID = int.Parse(txb_cliente_contrato.Text);
                        contrato.data_contrato = Convert.ToDateTime(data_novo_contrato.Text);
                        contrato.valor_contrato = Convert.ToDecimal(txb_valor_contrato.Text);
                        contrato.descricao_contrato = txb_descricao_contrato.Text;
                        contrato.tipo_contrato = comboBox_tipo_contrato.Text;
                        contrato.final_contrato = Convert.ToDateTime(maskedTextBox_final.Text);



                        contratoCrud.AlterarContrato(contrato);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO" + ex);
                    }
                }
            }
        }
    }
}
