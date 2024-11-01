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
                servico servico = new servico();
                ServicoCrud servicoCrud = new ServicoCrud(_conexao);
                servico = servicoCrud.ObtemServico(codigo);

                if (servico == null)
                {
                    MessageBox.Show("Cade o Serviço ?? não temos");
                    this.Close();
                }

                     servico.clienteID = Convert.ToInt32(txb_cliente_ser.Text);
                    servico.funcionarioID = Convert.ToInt32(txb_funcionario_ser.Text);
                    servico.data_servico = Convert.ToDateTime(maskedTextBox_Data_servico.Text);
                    servico.valor_servico = Convert.ToDecimal(txb_valor_servico.Text);
                    servico.descricao_servico = txb_descricao_servico.Text;
                    servico.data_contrato = Convert.ToDateTime(maskedTextBox_data_contrato.Text);
                    servico.valor_contrato = Convert.ToDecimal(txb_valor_servico.Text);
                    servico.descricao_contrato = txb_descricao_contrato.Text;

            }
        }
    }
}
