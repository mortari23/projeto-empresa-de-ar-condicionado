using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Projeto_ar_condicionado
{
    public partial class frm_tela_inicial : Form
    {
        public frm_tela_inicial()
        {
            InitializeComponent();
        }

        private void cadastroDePessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new form1();          
            form1.Show();
        }

        private void cadastroDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_servico = new frm_servico_contrato();
            frm_servico.Show();
        }
    }
}
