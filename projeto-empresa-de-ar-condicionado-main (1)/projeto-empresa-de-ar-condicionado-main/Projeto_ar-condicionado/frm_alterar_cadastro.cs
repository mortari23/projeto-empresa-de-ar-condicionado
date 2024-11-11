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
    public partial class frm_alterar_cliente : Form
    {
        string _conexao = Projeto_ar_condicionado.Properties.Settings.Default.conexao;

        public frm_alterar_cliente(int codigo)
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

                txb_codigo.Text = cliente.clienteID.ToString();
                maskedTextBox_cpf.Text = cliente.cpf_clienete.ToString();
                txb_nome.Text = cliente.nome_cliente;
                maskedTextBox_telefone.Text = cliente.telefone_cliente.ToString();
                txb_gmail.Text=cliente.gmail_cliente.ToString();
                maskedTextBox_cep.Text=cliente.CEP_cliente.ToString();
                txb_rua.Text=cliente.endereco_cliente.ToString();
                txb_bairro.Text=cliente.bairro_cliente.ToString();  
                txb_complemento.Text=cliente.complemento_cliente.ToString();
                txb_cidade.Text=cliente.cidade_cliente.ToString();
                maskedTextBox_numero.Text=cliente.numero_casa.ToString();



            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            

        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
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

                if (comboBox_tipo.Text == "Cliente")
                {


                    try
                    {
                        cliente.clienteID = int.Parse(txb_codigo.Text);
                        cliente.nome_cliente = txb_nome.Text;
                        cliente.telefone_cliente = maskedTextBox_telefone.Text;
                        cliente.cpf_clienete = maskedTextBox_cpf.Text;
                        cliente.gmail_cliente = txb_gmail.Text;
                        cliente.CEP_cliente = maskedTextBox_cep.Text;
                        cliente.endereco_cliente = txb_rua.Text;
                        cliente.bairro_cliente = txb_bairro.Text;
                        cliente.complemento_cliente = txb_complemento.Text;
                        cliente.cidade_cliente = txb_cidade.Text;
                        cliente.numero_casa = maskedTextBox_numero.Text;

                        clientecrud.AlterarCliente(cliente);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO" + ex);
                    }

                }
                else if (comboBox_tipo.Text == "Funcionario")
                {


                    funcionario.nome_funcionario = txb_nome.Text;
                    funcionario.endereco_funcionario = txb_rua.Text;
                    funcionario.cpf_funcionario = maskedTextBox_cpf.Text;
                    funcionario.CEP_funcionario = maskedTextBox_cep.Text;
                    funcionario.bairro_funcionario = txb_bairro.Text;
                    funcionario.numero_funcionario = maskedTextBox_numero.Text;
                    funcionario.complemento_funcionario = txb_complemento.Text;
                    funcionario.telefone_funcionario = maskedTextBox_telefone.Text;

                    funcionarioCrud.IncluirFuncionario(funcionario);

                    MessageBox.Show("Cadastro bem sucedido", "cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   

                }
            }
        }
    }
}