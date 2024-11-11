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
                txb_idcliente2.Text = contrato.clienteID?.ToString() ?? string.Empty;
                data_novo_con.Text = contrato.data_contrato?.ToString("dd/MM/yyyy") ?? string.Empty;
                txb_valor_contrato.Text = contrato.valor_contrato?.ToString() ?? string.Empty;
                txb_descricao_contrato.Text = contrato.descricao_contrato ?? string.Empty;
       
                txb_codigo.Text = contrato.contratoID.ToString() ?? string.Empty;
                comboBox_tipo_contrato.Text = contrato.tipo_contrato?.ToString() ?? string.Empty;
                dateTimePicker1.Text = contrato.final_contrato?.ToString() ?? string.Empty; 

                
                // Atribua outros campos, se necessário.
            }
        }

        private void btn_salvar_contrato_Click(object sender, EventArgs e)
        {
            {
                contrato contrato = new contrato();
                contratoCRUD contratoCrud = new contratoCRUD(_conexao);

                if ((txb_idcliente2.Text == "") || (txb_descricao_contrato.Text == "") || (txb_valor_contrato.Text == "") || (comboBox_tipo_contrato.Text == "") || (dateTimePicker1.Text == "") || (data_novo_con.Text == ""))
                {
                    MessageBox.Show("algum campo necessario esta vazio", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        contrato.contratoID = int.Parse(txb_codigo.Text);
                        contrato.clienteID = int.Parse(txb_idcliente2.Text);
                        contrato.data_contrato = Convert.ToDateTime(data_novo_con.Text);
                        contrato.valor_contrato = Convert.ToDecimal(txb_valor_contrato.Text);
                        contrato.descricao_contrato = txb_descricao_contrato.Text;
                        contrato.tipo_contrato = comboBox_tipo_contrato.Text;
                        contrato.final_contrato = Convert.ToDateTime(dateTimePicker1.Text);



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

        public void SetClienteInfo_contrato(string clienteInfo)
        {
            // Aqui você pode atualizar o TextBox com o valor passado
            txb_cliente_con.Text = clienteInfo; // Supondo que txt_nome_cliente seja o nome do seu TextBox
        }
        public void SetClienteInfo_contratoID(string idcliente)
        {
            txb_idcliente2.Text = idcliente;
        }

        private void btn_procurar_contrato_Click(object sender, EventArgs e)
        {
            var procurar_contrato = new procurar_contrato();
            procurar_contrato.ShowDialog();
        }

        private void btn_salvar_contrato_Click_1(object sender, EventArgs e)
        {
            {
                contrato contrato = new contrato();
                contratoCRUD contratoCRUD = new contratoCRUD(_conexao);

                // Verificar se os campos essenciais estão preenchidos
                if ((data_novo_con.Text == "") || (txb_descricao_contrato.Text == "") || (txb_valor_contrato.Text == "") || (comboBox_tipo_contrato.Text == ""))
                {
                    MessageBox.Show("Algum campo essencial não preenchido", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        // Verificar se o campo contratoID é um número válido antes de tentar convertê-lo
                        int contratoID;
                        if (!int.TryParse(txb_codigo.Text, out contratoID))
                        {
                            MessageBox.Show("O código do contrato deve ser um número válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Interrompe a execução caso o código não seja válido
                        }
                        contrato.contratoID = contratoID; // Atribui o contratoID após a verificação

                        // Continuar com os outros dados
                        contrato.clienteID = int.Parse(txb_idcliente2.Text); // Verificar se o clienteID também é um número válido antes de parsear
                        contrato.data_contrato = Convert.ToDateTime(data_novo_con.Text);
                        contrato.valor_contrato = Convert.ToDecimal(txb_valor_contrato.Text);
                        contrato.descricao_contrato = txb_descricao_contrato.Text;
                        contrato.tipo_contrato = comboBox_tipo_contrato.Text;
                        contrato.final_contrato = Convert.ToDateTime(dateTimePicker1.Text);

                        // Chamar o método de alteração de contrato
                        contratoCRUD.AlterarContrato(contrato);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

        }
    }
}
