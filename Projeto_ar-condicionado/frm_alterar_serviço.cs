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
    public partial class frm_alterar_serviço : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public frm_alterar_serviço(int codigo)
        {
            InitializeComponent();

            if (codigo > 0)
            {
                ServicoCrud servicoCrud = new ServicoCrud(_conexao);
                var servico = servicoCrud.ObtemServico(codigo);

                // Verificação se o serviço foi encontrado
                if (servico == null)
                {
                    MessageBox.Show("Serviço não encontrado!");
                    this.Close();
                    return;
                }

                // Preenchendo os campos do formulário com os valores do objeto `servico`
                txb_cliente_ser.Text = servico.clienteID?.ToString() ?? string.Empty;
                txb_funcionario_ser.Text = servico.funcionarioID?.ToString() ?? string.Empty;
                data_novo_ser.Text = servico.data_servico?.ToString("dd/MM/yyyy") ?? string.Empty;
                txb_valor_servico.Text = servico.valor_servico?.ToString() ?? string.Empty;
                txb_descricao_servico.Text = servico.descricao_servico ?? string.Empty;
                txb_codigo.Text = servico.servicoID?.ToString() ?? string.Empty;
                // Atribua outros campos, se necessário.
            }
        }

        private void btn_salvar_servico_Click(object sender, EventArgs e)
        {
            servico servico = new servico();
            ServicoCrud servicoCrud = new ServicoCrud(_conexao);

            if ((txb_cliente_ser.Text == "") || (txb_descricao_servico.Text == "") || (txb_valor_servico.Text == "") || (txb_funcionario_ser.Text == "") || (data_novo_ser.Text
                == ""))
            {
                MessageBox.Show("algum campo necessario esta vazio", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    servico.servicoID = int.Parse(txb_codigo.Text);
                    servico.clienteID = int.Parse(txb_cliente_ser.Text);
                    //servico.data_servico = data_novo_ser.;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO" + ex);
                }
            }
        }
    }
}
