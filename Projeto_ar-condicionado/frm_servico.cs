﻿using Data;
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
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public frm_servico_contrato()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            ListarServico();
        }
        //------------------------------------------------------------------------------//
        //focus
        private void ListarClientes()
        {
            ServicoCrud servicoCrud = new ServicoCrud(_conexao);

            string busca = txb_buscar_cadastro.Text.ToString();
            DataSet dsServico = new DataSet();
            dsServico = servicoCrud.BuscarServico(busca);

            dataGridView_consultar.DataSource = dsServico;
            dataGridView_consultar.DataMember = "servico";

        }

        private void ListarContrato()
        {
            contratoCRUD contratoCrud = new contratoCRUD(_conexao);

            string busca = txb_buscar_cadastro.Text.ToString();
            DataSet dscontrato = new DataSet();
            dscontrato = contratoCrud.BuscarContrato(busca);

            dataGridView_consultar.DataSource = dscontrato;
            dataGridView_consultar.DataMember = "contrato";
        }

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
            servico servico = new servico();
            ServicoCrud servicoCrud = new ServicoCrud(_conexao);


           

            
            
               

                if ((maskedTextBox_Data_servico.Text == "") || (txb_valor_servico.Text == "") || (txb_descricao_servico.Text == "Descrição") || (txb_descricao_servico.Text == "") || (txb_cliente_ser.Text=="")|| (txb_funcionario_ser.Text=="") )
                {
                    MessageBox.Show("Algum campo essencial não preenchido", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    servico.clienteID = Convert.ToInt32(txb_cliente_ser.Text);
                    servico.funcionarioID = Convert.ToInt32(txb_funcionario_ser.Text);
                    servico.data_servico = Convert.ToDateTime(maskedTextBox_Data_servico.Text);
                    servico.valor_servico = Convert.ToDecimal(txb_valor_servico.Text);
                    servico.descricao_servico = txb_descricao_servico.Text;
                    

                   

                    servicoCrud.IncluiServico(servico);
                    MessageBox.Show("Serviço cadastrado", "Sucesso", MessageBoxButtons.OK);

                    txb_descricao_servico.Clear();
                    txb_valor_servico.Clear();
                    maskedTextBox_Data_servico.Clear();
                    txb_funcionario_ser.Clear();
                    txb_cliente_ser.Clear();
                }
            
           
            

           


            

            maskedTextBox_Data_servico.Text = DateTime.Now.ToString("dd/MM/yyyy");

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
            contrato contrato = new contrato();
            contratoCRUD contratoCRUD = new contratoCRUD(_conexao);

            if ((maskedTextBox_data_contrato.Text == "") || (txb_descricao_contrato.Text == "") || (txb_valor_contrato.Text == "") || (comboBox_tipo_contrato.Text == ""))
            {
                MessageBox.Show("Algum campo essencial não preenchido", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                contrato.data_contrato = Convert.ToDateTime (maskedTextBox_data_contrato.Text);
                contrato.valor_contrato = Convert.ToDecimal (txb_valor_servico.Text);
                contrato.descricao_contrato = txb_descricao_contrato.Text;
                contrato.tipo_contrato = comboBox_tipo_contrato.Text;
                contrato.final_contrato = Convert.ToDateTime (maskedTextBox_final.Text);


                contratoCRUD.IncluiContrato(contrato);
                MessageBox.Show("Contrato cadastrado", "Sucesso", MessageBoxButtons.OK);

                txb_descricao_contrato.Clear();
                txb_valor_contrato.Clear();
                maskedTextBox_data_contrato.Clear();

            }


            maskedTextBox_Data_servico.Text = DateTime.Now.ToString("dd/MM/yyyy");


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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (comboBox_buscar_tipo.Text == "Serviço")
            {
                if (dataGridView_consultar.Rows.Count > 0)
                {
                    int codigo = Convert.ToInt32(dataGridView_consultar.CurrentRow.Cells["servicoID"].Value);

                    var resultado = MessageBox.Show("Deseja Excluir esse Registro", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        ServicoCrud serCrud = new ServicoCrud(_conexao);
                        serCrud.ExcluirServico(codigo);

                        ListarServico();

                    }
                }
            }
            else if(comboBox_buscar_tipo.Text == "Contrato")
            {
                if (dataGridView_consultar.Rows.Count > 0)
                {
                    int codigo = Convert.ToInt32(dataGridView_consultar.CurrentRow.Cells["contratoID"].Value);

                    var resultado = MessageBox.Show("Deseja Excluir esse Registro", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (resultado == DialogResult.Yes)
                    {
                        contratoCRUD conCrud = new contratoCRUD(_conexao);
                        conCrud.ExcluirContrato(codigo);

                        ListarServico();

                    }
                }
            }
        }



        private void btn_buscar_cadastro_Click(object sender, EventArgs e)
        {
            if (btn_buscar_cadastro.Text == "")
            {
                MessageBox.Show("Digite algum nome","erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_buscar_cadastro.Focus();
                return;
            }
            ListarServico();
        }

       

        

        private void ListarServico()
        {
           
            ServicoCrud servicoCrud = new ServicoCrud(_conexao);
            string busca = txb_buscar_cadastro.Text.ToString();
            DataSet dsservico = new DataSet();
            dsservico = servicoCrud.BuscarServico(busca);

            dataGridView_consultar.DataSource = dsservico;
            dataGridView_consultar.DataMember = "servico";
        }

        private void comboBox_buscar_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox_buscar_tipo.Text == "servico")
            {
                ListarServico();
            }
            else if (comboBox_buscar_tipo.Text == "contrato")
            {
                ListarContrato();
            }
        }

        private void dataGridView_consultar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_servico_contrato_Load(object sender, EventArgs e)
        {
            maskedTextBox_data_contrato.Text = DateTime.Now.ToString("dd/MM/yyyy");
            maskedTextBox_Data_servico.Text = DateTime.Now.ToString("dd/MM/yyyy");

           
        }

        private void tabPage_servico_Click(object sender, EventArgs e)
        {
            maskedTextBox_Data_servico.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Contrato_Click(object sender, EventArgs e)
        {
            maskedTextBox_data_contrato.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView_consultar.SelectedRows.Count > 0)
            {
                int codigo = Convert.ToInt32(dataGridView_consultar.CurrentRow.Cells["servicoID"].Value);
                var frm_Alterar_servico = new frm_alterar_serviço(codigo);
                frm_Alterar_servico.ShowDialog();
                ListarServico();
            }
            else
            {
                MessageBox.Show("Selecione um Registro para ser alterado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AtualizarDataGridView()
        {
            ServicoCrud servicoCrud = new ServicoCrud(_conexao);
            var dataset = servicoCrud.BuscarServico();  // Supondo que `BuscarServico` retorna um `DataSet`

            // Assumindo que o DataGridView chama-se "dataGridViewServicos"
            dataGridView_consultar.DataSource = dataset.Tables[0];
        }

        private void ConfigurarDataGrid()
        {
            if (comboBox_buscar_tipo.Text == "Serviço")
            {
                dataGridView_consultar.DefaultCellStyle.Font = new Font("Ariel", 9, FontStyle.Bold);
                dataGridView_consultar.RowHeadersWidth = 25;
                dataGridView_consultar.Columns["servicoID"].Visible = false;
                dataGridView_consultar.Columns["clienteID"].Visible = false;
                dataGridView_consultar.Columns["funcionarioID"].Visible = false;
                dataGridView_consultar.Columns["descricao_serviço"].HeaderText = "Descrição";
                dataGridView_consultar.Columns["data_serviço"].HeaderText = "Data";
                dataGridView_consultar.Columns["valor_servico"].HeaderText = "Valor";
            }
            else if (comboBox_buscar_tipo.Text == "Contrato")
            {
                dataGridView_consultar.DefaultCellStyle.Font = new Font("Ariel", 9, FontStyle.Bold);
                dataGridView_consultar.RowHeadersWidth =25;
                dataGridView_consultar.Columns["contratoID"].Visible =false;
                dataGridView_consultar.Columns["clienteID"].Visible =false;
                dataGridView_consultar.Columns["descricao_contrato"].HeaderText = "Descrição";
                dataGridView_consultar.Columns["valor_contrato"].HeaderText= "Valor";
                dataGridView_consultar.Columns["data_contrato"].HeaderText = "Data Contrato";
                dataGridView_consultar.Columns["tipo_contrato"].HeaderText = "Tipo Contrato";
                dataGridView_consultar.Columns["final_contrato"].HeaderText = "Final do Contrato";
            }

            
        }
    }
}
