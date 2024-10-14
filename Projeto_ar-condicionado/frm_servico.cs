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
    public partial class frm_servico_contrato : Form
    {
        public frm_servico_contrato()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------//
        //focus

        private void maskedTextBox_Data_servico_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txb_valor_servico.Focus();
            }
        }

        private void txb_valor_servico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_descricao_servico.Focus();
            }
        }

       

        private void btn_salvar_servico_Click(object sender, EventArgs e)
        {
            if((maskedTextBox_Data_servico.Text=="") || (txb_valor_servico.Text=="") || (txb_descricao_servico.Text == "Descrição") || (txb_descricao_servico.Text == ""))
            {
                MessageBox.Show("Algum campo essencial não preenchido","erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Serviço cadastrado", "Sucesso", MessageBoxButtons.OK);
            }
        }

        //--------------//

        private void maskedTextBox_data_contrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_valor_contrato.Focus();
            }
        }

        private void txb_valor_contrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_descricao_servico.Focus();
            }
        }

        private void btn_salvar_contrato_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox_data_contrato.Text == "") || (txb_valor_contrato.Text == "") || (txb_descricao_contrato.Text == "Descrição") || (txb_descricao_contrato.Text == "") || (comboBox_tipo_contrato.Items==null))
            {
                MessageBox.Show("Algum campo essencial não preenchido", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Contrato cadastrado", "Sucesso", MessageBoxButtons.OK);
            }
        }
        //--------------------------------------------------------------------------------------------------------//
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpar_servico_Click(object sender, EventArgs e)
        {
            txb_descricao_servico.Clear();
            txb_valor_servico.Clear();
            maskedTextBox_Data_servico.Clear();
            
        }

        private void btn_limpar_contrato_Click(object sender, EventArgs e)
        {
            txb_descricao_contrato.Clear();
            txb_valor_contrato.Clear();
            maskedTextBox_data_contrato.Clear();            
        }
    }
}
