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
            this.btn_salvar_servico = new System.Windows.Forms.Button();
            this.btn_limpar_servico = new System.Windows.Forms.Button();
            this.txb_descricao_servico = new System.Windows.Forms.TextBox();
            this.txb_valor_servico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox_Data_servico = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_Contrato = new System.Windows.Forms.TabPage();
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
            // 
            // tabPage_servico
            // 
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
            this.txb_descricao_servico.Location = new System.Drawing.Point(21, 75);
            this.txb_descricao_servico.Multiline = true;
            this.txb_descricao_servico.Name = "txb_descricao_servico";
            this.txb_descricao_servico.Size = new System.Drawing.Size(408, 252);
            this.txb_descricao_servico.TabIndex = 11;
            this.txb_descricao_servico.Text = "Descrição";
            // 
            // txb_valor_servico
            // 
            this.txb_valor_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_servico.Location = new System.Drawing.Point(142, 33);
            this.txb_valor_servico.Name = "txb_valor_servico";
            this.txb_valor_servico.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_servico.TabIndex = 10;
            this.txb_valor_servico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_valor_servico_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 13);
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
            this.comboBox_tipo_contrato.Location = new System.Drawing.Point(263, 33);
            this.comboBox_tipo_contrato.Name = "comboBox_tipo_contrato";
            this.comboBox_tipo_contrato.Size = new System.Drawing.Size(166, 28);
            this.comboBox_tipo_contrato.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 13);
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
            this.txb_descricao_contrato.Location = new System.Drawing.Point(21, 75);
            this.txb_descricao_contrato.Multiline = true;
            this.txb_descricao_contrato.Name = "txb_descricao_contrato";
            this.txb_descricao_contrato.Size = new System.Drawing.Size(408, 252);
            this.txb_descricao_contrato.TabIndex = 19;
            this.txb_descricao_contrato.Text = "Descrição";
            // 
            // txb_valor_contrato
            // 
            this.txb_valor_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_contrato.Location = new System.Drawing.Point(142, 33);
            this.txb_valor_contrato.Name = "txb_valor_contrato";
            this.txb_valor_contrato.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_contrato.TabIndex = 18;
            this.txb_valor_contrato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_valor_contrato_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 13);
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
            this.dataGridView_consultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_consultar.Location = new System.Drawing.Point(0, 64);
            this.dataGridView_consultar.Name = "dataGridView_consultar";
            this.dataGridView_consultar.Size = new System.Drawing.Size(554, 287);
            this.dataGridView_consultar.TabIndex = 10;
            // 
            // btn_buscar_cadastro
            // 
            this.btn_buscar_cadastro.Location = new System.Drawing.Point(456, 32);
            this.btn_buscar_cadastro.Name = "btn_buscar_cadastro";
            this.btn_buscar_cadastro.Size = new System.Drawing.Size(88, 23);
            this.btn_buscar_cadastro.TabIndex = 9;
            this.btn_buscar_cadastro.Text = "Buscar";
            this.btn_buscar_cadastro.UseVisualStyleBackColor = true;
            // 
            // comboBox_buscar_tipo
            // 
            this.comboBox_buscar_tipo.FormattingEnabled = true;
            this.comboBox_buscar_tipo.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.comboBox_buscar_tipo.Location = new System.Drawing.Point(129, 8);
            this.comboBox_buscar_tipo.Name = "comboBox_buscar_tipo";
            this.comboBox_buscar_tipo.Size = new System.Drawing.Size(101, 21);
            this.comboBox_buscar_tipo.TabIndex = 8;
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
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(6, 35);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(94, 23);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
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
            this.Text = "Serviço Contrato ";
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
    }
}