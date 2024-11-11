namespace Projeto_ar_condicionado
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_busca = new System.Windows.Forms.TabControl();
            this.tabPage_cadastro = new System.Windows.Forms.TabPage();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox_endereço = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_cep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_numero = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_cidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txb_bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_complemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_rua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_gmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_consulta = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.comboBox_buscar_tipo = new System.Windows.Forms.ComboBox();
            this.txb_buscar_cadastro = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_buscar_cadastro = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.tabControl_busca.SuspendLayout();
            this.tabPage_cadastro.SuspendLayout();
            this.groupBox_endereço.SuspendLayout();
            this.tabPage_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_busca
            // 
            this.tabControl_busca.Controls.Add(this.tabPage_cadastro);
            this.tabControl_busca.Controls.Add(this.tabPage_consulta);
            this.tabControl_busca.Location = new System.Drawing.Point(12, 12);
            this.tabControl_busca.Name = "tabControl_busca";
            this.tabControl_busca.SelectedIndex = 0;
            this.tabControl_busca.Size = new System.Drawing.Size(639, 419);
            this.tabControl_busca.TabIndex = 0;
            // 
            // tabPage_cadastro
            // 
            this.tabPage_cadastro.Controls.Add(this.btn_limpar);
            this.tabPage_cadastro.Controls.Add(this.btn_salvar);
            this.tabPage_cadastro.Controls.Add(this.groupBox_endereço);
            this.tabPage_cadastro.Controls.Add(this.txb_gmail);
            this.tabPage_cadastro.Controls.Add(this.label5);
            this.tabPage_cadastro.Controls.Add(this.maskedTextBox_cpf);
            this.tabPage_cadastro.Controls.Add(this.label4);
            this.tabPage_cadastro.Controls.Add(this.maskedTextBox_telefone);
            this.tabPage_cadastro.Controls.Add(this.label3);
            this.tabPage_cadastro.Controls.Add(this.comboBox_tipo);
            this.tabPage_cadastro.Controls.Add(this.label2);
            this.tabPage_cadastro.Controls.Add(this.txb_nome);
            this.tabPage_cadastro.Controls.Add(this.label1);
            this.tabPage_cadastro.Location = new System.Drawing.Point(4, 22);
            this.tabPage_cadastro.Name = "tabPage_cadastro";
            this.tabPage_cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cadastro.Size = new System.Drawing.Size(631, 393);
            this.tabPage_cadastro.TabIndex = 0;
            this.tabPage_cadastro.Text = "Cadastro";
            this.tabPage_cadastro.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(443, 356);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 12;
            this.btn_limpar.Text = "limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(524, 356);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 11;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox_endereço
            // 
            this.groupBox_endereço.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox_endereço.Controls.Add(this.maskedTextBox_cep);
            this.groupBox_endereço.Controls.Add(this.maskedTextBox_numero);
            this.groupBox_endereço.Controls.Add(this.btn_buscar);
            this.groupBox_endereço.Controls.Add(this.label11);
            this.groupBox_endereço.Controls.Add(this.txb_cidade);
            this.groupBox_endereço.Controls.Add(this.label10);
            this.groupBox_endereço.Controls.Add(this.txb_bairro);
            this.groupBox_endereço.Controls.Add(this.label9);
            this.groupBox_endereço.Controls.Add(this.txb_complemento);
            this.groupBox_endereço.Controls.Add(this.label8);
            this.groupBox_endereço.Controls.Add(this.label7);
            this.groupBox_endereço.Controls.Add(this.txb_rua);
            this.groupBox_endereço.Controls.Add(this.label6);
            this.groupBox_endereço.Location = new System.Drawing.Point(30, 147);
            this.groupBox_endereço.Name = "groupBox_endereço";
            this.groupBox_endereço.Size = new System.Drawing.Size(569, 203);
            this.groupBox_endereço.TabIndex = 10;
            this.groupBox_endereço.TabStop = false;
            this.groupBox_endereço.Text = "Endereço";
            // 
            // maskedTextBox_cep
            // 
            this.maskedTextBox_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_cep.Location = new System.Drawing.Point(52, 19);
            this.maskedTextBox_cep.Mask = "99999-999";
            this.maskedTextBox_cep.Name = "maskedTextBox_cep";
            this.maskedTextBox_cep.Size = new System.Drawing.Size(85, 26);
            this.maskedTextBox_cep.TabIndex = 21;
            this.maskedTextBox_cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_cep_KeyDown);
            // 
            // maskedTextBox_numero
            // 
            this.maskedTextBox_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_numero.Location = new System.Drawing.Point(257, 81);
            this.maskedTextBox_numero.Mask = "9999";
            this.maskedTextBox_numero.Name = "maskedTextBox_numero";
            this.maskedTextBox_numero.Size = new System.Drawing.Size(42, 26);
            this.maskedTextBox_numero.TabIndex = 20;
            this.maskedTextBox_numero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_numero_KeyDown);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(143, 22);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "CEP";
            // 
            // txb_cidade
            // 
            this.txb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cidade.Location = new System.Drawing.Point(305, 130);
            this.txb_cidade.Name = "txb_cidade";
            this.txb_cidade.Size = new System.Drawing.Size(235, 26);
            this.txb_cidade.TabIndex = 18;
            this.txb_cidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_cidade_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(306, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cidade";
            // 
            // txb_bairro
            // 
            this.txb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_bairro.Location = new System.Drawing.Point(14, 129);
            this.txb_bairro.Name = "txb_bairro";
            this.txb_bairro.Size = new System.Drawing.Size(285, 26);
            this.txb_bairro.TabIndex = 16;
            this.txb_bairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_bairro_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Bairro";
            // 
            // txb_complemento
            // 
            this.txb_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_complemento.Location = new System.Drawing.Point(305, 81);
            this.txb_complemento.Name = "txb_complemento";
            this.txb_complemento.Size = new System.Drawing.Size(235, 26);
            this.txb_complemento.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Complemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nº";
            // 
            // txb_rua
            // 
            this.txb_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_rua.Location = new System.Drawing.Point(14, 81);
            this.txb_rua.Name = "txb_rua";
            this.txb_rua.Size = new System.Drawing.Size(237, 26);
            this.txb_rua.TabIndex = 12;
            this.txb_rua.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_rua_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rua";
            // 
            // txb_gmail
            // 
            this.txb_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gmail.Location = new System.Drawing.Point(313, 96);
            this.txb_gmail.Name = "txb_gmail";
            this.txb_gmail.Size = new System.Drawing.Size(286, 26);
            this.txb_gmail.TabIndex = 9;
            this.txb_gmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_gmail_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(166, 96);
            this.maskedTextBox_cpf.Mask = "999,999,999-99";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(127, 26);
            this.maskedTextBox_cpf.TabIndex = 7;
            this.maskedTextBox_cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_cpf_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF";
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(30, 96);
            this.maskedTextBox_telefone.Mask = "(99)99999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(121, 26);
            this.maskedTextBox_telefone.TabIndex = 5;
            this.maskedTextBox_telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_telefone_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.comboBox_tipo.Location = new System.Drawing.Point(478, 36);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 28);
            this.comboBox_tipo.TabIndex = 3;
            this.comboBox_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox_tipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo";
            // 
            // txb_nome
            // 
            this.txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome.Location = new System.Drawing.Point(30, 36);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(427, 26);
            this.txb_nome.TabIndex = 1;
            this.txb_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_nome_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPage_consulta
            // 
            this.tabPage_consulta.Controls.Add(this.label12);
            this.tabPage_consulta.Controls.Add(this.dgv_cliente);
            this.tabPage_consulta.Controls.Add(this.comboBox_buscar_tipo);
            this.tabPage_consulta.Controls.Add(this.txb_buscar_cadastro);
            this.tabPage_consulta.Controls.Add(this.btn_excluir);
            this.tabPage_consulta.Controls.Add(this.btn_editar);
            this.tabPage_consulta.Controls.Add(this.btn_buscar_cadastro);
            this.tabPage_consulta.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consulta.Name = "tabPage_consulta";
            this.tabPage_consulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consulta.Size = new System.Drawing.Size(631, 393);
            this.tabPage_consulta.TabIndex = 1;
            this.tabPage_consulta.Text = "Consultar cadastros";
            this.tabPage_consulta.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tipo";
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(-4, 72);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cliente.Size = new System.Drawing.Size(639, 321);
            this.dgv_cliente.TabIndex = 7;
            this.dgv_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellContentClick);
            // 
            // comboBox_buscar_tipo
            // 
            this.comboBox_buscar_tipo.FormattingEnabled = true;
            this.comboBox_buscar_tipo.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.comboBox_buscar_tipo.Location = new System.Drawing.Point(177, 18);
            this.comboBox_buscar_tipo.Name = "comboBox_buscar_tipo";
            this.comboBox_buscar_tipo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_buscar_tipo.TabIndex = 6;
            this.comboBox_buscar_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox_buscar_tipo_SelectedIndexChanged);
            // 
            // txb_buscar_cadastro
            // 
            this.txb_buscar_cadastro.Location = new System.Drawing.Point(177, 45);
            this.txb_buscar_cadastro.Name = "txb_buscar_cadastro";
            this.txb_buscar_cadastro.Size = new System.Drawing.Size(367, 20);
            this.txb_buscar_cadastro.TabIndex = 5;
            this.txb_buscar_cadastro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_buscar_cadastro_KeyDown);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(6, 13);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(94, 23);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(6, 42);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 23);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_buscar_cadastro
            // 
            this.btn_buscar_cadastro.Location = new System.Drawing.Point(550, 43);
            this.btn_buscar_cadastro.Name = "btn_buscar_cadastro";
            this.btn_buscar_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_cadastro.TabIndex = 1;
            this.btn_buscar_cadastro.Text = "Buscar";
            this.btn_buscar_cadastro.UseVisualStyleBackColor = true;
            this.btn_buscar_cadastro.Click += new System.EventHandler(this.btn_buscar_cadastro_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(576, 437);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 13;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 465);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.tabControl_busca);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ar Ecologico";
            this.Load += new System.EventHandler(this.frm_dastro_busca_Load);
            this.tabControl_busca.ResumeLayout(false);
            this.tabPage_cadastro.ResumeLayout(false);
            this.tabPage_cadastro.PerformLayout();
            this.groupBox_endereço.ResumeLayout(false);
            this.groupBox_endereço.PerformLayout();
            this.tabPage_consulta.ResumeLayout(false);
            this.tabPage_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_busca;
        private System.Windows.Forms.TabPage tabPage_cadastro;
        private System.Windows.Forms.TabPage tabPage_consulta;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_endereço;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_cidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txb_bairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_complemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_rua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_gmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numero;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cep;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_buscar_cadastro;
        private System.Windows.Forms.TextBox txb_buscar_cadastro;
        private System.Windows.Forms.ComboBox comboBox_buscar_tipo;
        private System.Windows.Forms.DataGridView dgv_cliente;
        private System.Windows.Forms.Label label12;
    }
}

