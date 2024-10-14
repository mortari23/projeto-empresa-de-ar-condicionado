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
    public partial class frm_alterar : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public frm_alterar(int codigo)
        {


            InitializeComponent();
            if (codigo > 0)
            {
                Cliente cliente = new Cliente();
                ClienteCRUD clienteCrud = new ClienteCRUD(_conexao);
                cliente = clienteCrud.ObtemCliente(codigo);

                if (cliente == null)
                {
                    MessageBox.Show("Cade o Cliente ?? não temos");
                    this.Close();
                }

                txb_clienteID.Text = cliente.clienteID.ToString();
               // maskedTextBox_cpf = cliente..ToString();
                txb_nome.Text = cliente.nome_cliente;
                maskedTextBox_telefone.Text = cliente.telefone_cliente.ToString();


            }
        }
    }
}
