namespace Projeto_ar_condicionado
{
    partial class frm_servico_contrato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_servico = new System.Windows.Forms.TabPage();
            this.btn_ = new System.Windows.Forms.Button();
            this.btn_pesquisa_ser = new System.Windows.Forms.Button();
            this.txb_funcionario_ser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_cliente_ser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvar_servico = new System.Windows.Forms.Button();
            this.btn_limpar_servico = new System.Windows.Forms.Button();
            this.txb_descricao_servico = new System.Windows.Forms.TextBox();
            this.txb_valor_servico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_Data_servico = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_Contrato = new System.Windows.Forms.TabPage();
            this.maskedTextBox_final = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_cliente_con = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_tipo_contrato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salvar_contrato = new System.Windows.Forms.Button();
            this.btn_limpar_contrato = new System.Windows.Forms.Button();
            this.txb_descricao_contrato = new System.Windows.Forms.TextBox();
            this.txb_valor_contrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox_data_contrato = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_consultar = new System.Windows.Forms.TabPage();
            this.dataGridView_consultar = new System.Windows.Forms.DataGridView();
            this.btn_buscar_cadastro = new System.Windows.Forms.Button();
            this.comboBox_buscar_tipo = new System.Windows.Forms.ComboBox();
            this.txb_buscar_cadastro = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_servico.SuspendLayout();
            this.tabPage_Contrato.SuspendLayout();
            this.tabPage_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consultar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_servico);
            this.tabControl1.Controls.Add(this.tabPage_Contrato);
            this.tabControl1.Controls.Add(this.tabPage_consultar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 373);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage_servico
            // 
            this.tabPage_servico.Controls.Add(this.btn_);
            this.tabPage_servico.Controls.Add(this.btn_pesquisa_ser);
            this.tabPage_servico.Controls.Add(this.txb_funcionario_ser);
            this.tabPage_servico.Controls.Add(this.label7);
            this.tabPage_servico.Controls.Add(this.txb_cliente_ser);
            this.tabPage_servico.Controls.Add(this.label6);
            this.tabPage_servico.Controls.Add(this.btn_salvar_servico);
            this.tabPage_servico.Controls.Add(this.btn_limpar_servico);
            this.tabPage_servico.Controls.Add(this.txb_descricao_servico);
            this.tabPage_servico.Controls.Add(this.txb_valor_servico);
            this.tabPage_servico.Controls.Add(this.label5);
            this.tabPage_servico.Controls.Add(this.maskedTextBox_Data_servico);
            this.tabPage_servico.Controls.Add(this.label4);
            this.tabPage_servico.Location = new System.Drawing.Point(4, 22);
            this.tabPage_servico.Name = "tabPage_servico";
            this.tabPage_servico.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_servico.Size = new System.Drawing.Size(550, 347);
            this.tabPage_servico.TabIndex = 0;
            this.tabPage_servico.Text = "Cadastro Serviço";
            this.tabPage_servico.UseVisualStyleBackColor = true;
            this.tabPage_servico.Click += new System.EventHandler(this.tabPage_servico_Click);
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(382, 82);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(63, 26);
            this.btn_.TabIndex = 20;
            this.btn_.Text = "pesquisar_ser";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisa_ser
            // 
            this.btn_pesquisa_ser.Location = new System.Drawing.Point(382, 32);
            this.btn_pesquisa_ser.Name = "btn_pesquisa_ser";
            this.btn_pesquisa_ser.Size = new System.Drawing.Size(63, 26);
            this.btn_pesquisa_ser.TabIndex = 19;
            this.btn_pesquisa_ser.Text = "pesquisar_ser";
            this.btn_pesquisa_ser.UseVisualStyleBackColor = true;
            this.btn_pesquisa_ser.Click += new System.EventHandler(this.btn_pesquisa_ser_Click);
            // 
            // txb_funcionario_ser
            // 
            this.txb_funcionario_ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_funcionario_ser.Location = new System.Drawing.Point(144, 82);
            this.txb_funcionario_ser.Name = "txb_funcionario_ser";
            this.txb_funcionario_ser.Size = new System.Drawing.Size(232, 26);
            this.txb_funcionario_ser.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Funcionario";
            // 
            // txb_cliente_ser
            // 
            this.txb_cliente_ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cliente_ser.Location = new System.Drawing.Point(144, 33);
            this.txb_cliente_ser.Name = "txb_cliente_ser";
            this.txb_cliente_ser.Size = new System.Drawing.Size(232, 26);
            this.txb_cliente_ser.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = " Cliente";
            // 
            // btn_salvar_servico
            // 
            this.btn_salvar_servico.Location = new System.Drawing.Point(435, 275);
            this.btn_salvar_servico.Name = "btn_salvar_servico";
            this.btn_salvar_servico.Size = new System.Drawing.Size(97, 23);
            this.btn_salvar_servico.TabIndex = 14;
            this.btn_salvar_servico.Text = "Salvar";
            this.btn_salvar_servico.UseVisualStyleBackColor = true;
            this.btn_salvar_servico.Click += new System.EventHandler(this.btn_salvar_servico_Click);
            // 
            // btn_limpar_servico
            // 
            this.btn_limpar_servico.Location = new System.Drawing.Point(435, 304);
            this.btn_limpar_servico.Name = "btn_limpar_servico";
            this.btn_limpar_servico.Size = new System.Drawing.Size(97, 23);
            this.btn_limpar_servico.TabIndex = 13;
            this.btn_limpar_servico.Text = "Limpar";
            this.btn_limpar_servico.UseVisualStyleBackColor = true;
            this.btn_limpar_servico.Click += new System.EventHandler(this.btn_limpar_servico_Click);
            // 
            // txb_descricao_servico
            // 
            this.txb_descricao_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descricao_servico.Location = new System.Drawing.Point(21, 122);
            this.txb_descricao_servico.Multiline = true;
            this.txb_descricao_servico.Name = "txb_descricao_servico";
            this.txb_descricao_servico.Size = new System.Drawing.Size(408, 205);
            this.txb_descricao_servico.TabIndex = 11;
            this.txb_descricao_servico.Text = "Descrição";
            // 
            // txb_valor_servico
            // 
            this.txb_valor_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_servico.Location = new System.Drawing.Point(21, 82);
            this.txb_valor_servico.Name = "txb_valor_servico";
            this.txb_valor_servico.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_servico.TabIndex = 10;
            this.txb_valor_servico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_valor_servico_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor serviço";
            // 
            // maskedTextBox_Data_servico
            // 
            this.maskedTextBox_Data_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_Data_servico.Location = new System.Drawing.Point(21, 33);
            this.maskedTextBox_Data_servico.Mask = "99/99/9999";
            this.maskedTextBox_Data_servico.Name = "maskedTextBox_Data_servico";
            this.maskedTextBox_Data_servico.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBox_Data_servico.TabIndex = 8;
            this.maskedTextBox_Data_servico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_Data_servico_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data do serviço";
            // 
            // tabPage_Contrato
            // 
            this.tabPage_Contrato.Controls.Add(this.maskedTextBox_final);
            this.tabPage_Contrato.Controls.Add(this.label8);
            this.tabPage_Contrato.Controls.Add(this.txb_cliente_con);
            this.tabPage_Contrato.Controls.Add(this.label9);
            this.tabPage_Contrato.Controls.Add(this.comboBox_tipo_contrato);
            this.tabPage_Contrato.Controls.Add(this.label3);
            this.tabPage_Contrato.Controls.Add(this.btn_salvar_contrato);
            this.tabPage_Contrato.Controls.Add(this.btn_limpar_contrato);
            this.tabPage_Contrato.Controls.Add(this.txb_descricao_contrato);
            this.tabPage_Contrato.Controls.Add(this.txb_valor_contrato);
            this.tabPage_Contrato.Controls.Add(this.label1);
            this.tabPage_Contrato.Controls.Add(this.maskedTextBox_data_contrato);
            this.tabPage_Contrato.Controls.Add(this.label2);
            this.tabPage_Contrato.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Contrato.Name = "tabPage_Contrato";
            this.tabPage_Contrato.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Contrato.Size = new System.Drawing.Size(550, 347);
            this.tabPage_Contrato.TabIndex = 1;
            this.tabPage_Contrato.Text = "Cadastro Contrato";
            this.tabPage_Contrato.UseVisualStyleBackColor = true;
            this.tabPage_Contrato.Click += new System.EventHandler(this.tabPage_Contrato_Click);
            // 
            // maskedTextBox_final
            // 
            this.maskedTextBox_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_final.Location = new System.Drawing.Point(342, 85);
            this.maskedTextBox_final.Mask = "99/99/9999";
            this.maskedTextBox_final.Name = "maskedTextBox_final";
            this.maskedTextBox_final.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBox_final.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(339, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Data Final";
            // 
            // txb_cliente_con
            // 
            this.txb_cliente_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cliente_con.Location = new System.Drawing.Point(140, 33);
            this.txb_cliente_con.Name = "txb_cliente_con";
            this.txb_cliente_con.Size = new System.Drawing.Size(232, 26);
            this.txb_cliente_con.TabIndex = 25;
            this.txb_cliente_con.TextChanged += new System.EventHandler(this.txb_cliente_con_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(140, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cliente";
            // 
            // comboBox_tipo_contrato
            // 
            this.comboBox_tipo_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo_contrato.FormattingEnabled = true;
            this.comboBox_tipo_contrato.Items.AddRange(new object[] {
            "1º Mensal",
            "2º Bimestral + Mensal",
            "3º Trimestral + Mensal",
            "4° Mensal. Bimenstral.",
            "5º Mensal. Trimestral.",
            "6º Semestral + Mensal",
            "7º Mensal.",
            "2º Bimestral + Mensal",
            "3º Trimestral +Mensal",
            "4º Mensal + Bimestral",
            "5º Mensal + Trimestral",
            "6º Anual"});
            this.comboBox_tipo_contrato.Location = new System.Drawing.Point(140, 85);
            this.comboBox_tipo_contrato.Name = "comboBox_tipo_contrato";
            this.comboBox_tipo_contrato.Size = new System.Drawing.Size(172, 28);
            this.comboBox_tipo_contrato.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo contrato";
            // 
            // btn_salvar_contrato
            // 
            this.btn_salvar_contrato.Location = new System.Drawing.Point(435, 275);
            this.btn_salvar_contrato.Name = "btn_salvar_contrato";
            this.btn_salvar_contrato.Size = new System.Drawing.Size(97, 23);
            this.btn_salvar_contrato.TabIndex = 21;
            this.btn_salvar_contrato.Text = "Salvar";
            this.btn_salvar_contrato.UseVisualStyleBackColor = true;
            this.btn_salvar_contrato.Click += new System.EventHandler(this.btn_salvar_contrato_Click);
            // 
            // btn_limpar_contrato
            // 
            this.btn_limpar_contrato.Location = new System.Drawing.Point(435, 304);
            this.btn_limpar_contrato.Name = "btn_limpar_contrato";
            this.btn_limpar_contrato.Size = new System.Drawing.Size(97, 23);
            this.btn_limpar_contrato.TabIndex = 20;
            this.btn_limpar_contrato.Text = "Limpar";
            this.btn_limpar_contrato.UseVisualStyleBackColor = true;
            this.btn_limpar_contrato.Click += new System.EventHandler(this.btn_limpar_contrato_Click);
            // 
            // txb_descricao_contrato
            // 
            this.txb_descricao_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descricao_contrato.Location = new System.Drawing.Point(21, 122);
            this.txb_descricao_contrato.Multiline = true;
            this.txb_descricao_contrato.Name = "txb_descricao_contrato";
            this.txb_descricao_contrato.Size = new System.Drawing.Size(408, 205);
            this.txb_descricao_contrato.TabIndex = 19;
            this.txb_descricao_contrato.Text = "Descrição";
            // 
            // txb_valor_contrato
            // 
            this.txb_valor_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_contrato.Location = new System.Drawing.Point(21, 85);
            this.txb_valor_contrato.Name = "txb_valor_contrato";
            this.txb_valor_contrato.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_contrato.TabIndex = 18;
            this.txb_valor_contrato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_valor_contrato_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor Contrato";
            // 
            // maskedTextBox_data_contrato
            // 
            this.maskedTextBox_data_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_data_contrato.Location = new System.Drawing.Point(21, 33);
            this.maskedTextBox_data_contrato.Mask = "99/99/9999";
            this.maskedTextBox_data_contrato.Name = "maskedTextBox_data_contrato";
            this.maskedTextBox_data_contrato.Size = new System.Drawing.Size(87, 26);
            this.maskedTextBox_data_contrato.TabIndex = 16;
            this.maskedTextBox_data_contrato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox_data_contrato_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data do Contrato";
            // 
            // tabPage_consultar
            // 
            this.tabPage_consultar.Controls.Add(this.dataGridView_consultar);
            this.tabPage_consultar.Controls.Add(this.btn_buscar_cadastro);
            this.tabPage_consultar.Controls.Add(this.comboBox_buscar_tipo);
            this.tabPage_consultar.Controls.Add(this.txb_buscar_cadastro);
            this.tabPage_consultar.Controls.Add(this.btn_excluir);
            this.tabPage_consultar.Controls.Add(this.btn_editar);
            this.tabPage_consultar.Location = new System.Drawing.Point(4, 22);
            this.tabPage_consultar.Name = "tabPage_consultar";
            this.tabPage_consultar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_consultar.Size = new System.Drawing.Size(550, 347);
            this.tabPage_consultar.TabIndex = 2;
            this.tabPage_consultar.Text = "Consultar";
            this.tabPage_consultar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_consultar
            // 
            this.dataGridView_consultar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_consultar.Location = new System.Drawing.Point(0, 64);
            this.dataGridView_consultar.Name = "dataGridView_consultar";
            this.dataGridView_consultar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_consultar.Size = new System.Drawing.Size(554, 287);
            this.dataGridView_consultar.TabIndex = 10;
            this.dataGridView_consultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_consultar_CellContentClick);
            // 
            // btn_buscar_cadastro
            // 
            this.btn_buscar_cadastro.Location = new System.Drawing.Point(456, 32);
            this.btn_buscar_cadastro.Name = "btn_buscar_cadastro";
            this.btn_buscar_cadastro.Size = new System.Drawing.Size(88, 23);
            this.btn_buscar_cadastro.TabIndex = 9;
            this.btn_buscar_cadastro.Text = "Buscar";
            this.btn_buscar_cadastro.UseVisualStyleBackColor = true;
            this.btn_buscar_cadastro.Click += new System.EventHandler(this.btn_buscar_cadastro_Click);
            // 
            // comboBox_buscar_tipo
            // 
            this.comboBox_buscar_tipo.FormattingEnabled = true;
            this.comboBox_buscar_tipo.Items.AddRange(new object[] {
            "Serviço",
            "Contrato"});
            this.comboBox_buscar_tipo.Location = new System.Drawing.Point(129, 8);
            this.comboBox_buscar_tipo.Name = "comboBox_buscar_tipo";
            this.comboBox_buscar_tipo.Size = new System.Drawing.Size(101, 21);
            this.comboBox_buscar_tipo.TabIndex = 8;
            this.comboBox_buscar_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox_buscar_tipo_SelectedIndexChanged);
            // 
            // txb_buscar_cadastro
            // 
            this.txb_buscar_cadastro.Location = new System.Drawing.Point(129, 35);
            this.txb_buscar_cadastro.Name = "txb_buscar_cadastro";
            this.txb_buscar_cadastro.Size = new System.Drawing.Size(321, 20);
            this.txb_buscar_cadastro.TabIndex = 7;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(6, 6);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(94, 23);
            this.btn_excluir.TabIndex = 6;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(6, 35);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 23);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(576, 358);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_fechar.TabIndex = 12;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // frm_servico_contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 411);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_servico_contrato";
            this.Text = "8";
            this.Load += new System.EventHandler(this.frm_servico_contrato_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_servico.ResumeLayout(false);
            this.tabPage_servico.PerformLayout();
            this.tabPage_Contrato.ResumeLayout(false);
            this.tabPage_Contrato.PerformLayout();
            this.tabPage_consultar.ResumeLayout(false);
            this.tabPage_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_consultar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_servico;
        private System.Windows.Forms.TabPage tabPage_Contrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Data_servico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_valor_servico;
        private System.Windows.Forms.Button btn_salvar_servico;
        private System.Windows.Forms.Button btn_limpar_servico;
        private System.Windows.Forms.TextBox txb_descricao_servico;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar_contrato;
        private System.Windows.Forms.Button btn_limpar_contrato;
        private System.Windows.Forms.TextBox txb_descricao_contrato;
        private System.Windows.Forms.TextBox txb_valor_contrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_data_contrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_tipo_contrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage_consultar;
        private System.Windows.Forms.DataGridView dataGridView_consultar;
        private System.Windows.Forms.Button btn_buscar_cadastro;
        private System.Windows.Forms.ComboBox comboBox_buscar_tipo;
        private System.Windows.Forms.TextBox txb_buscar_cadastro;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txb_funcionario_ser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_cliente_ser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_cliente_con;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_final;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_pesquisa_ser;
        private System.Windows.Forms.Button btn_;
    }
}