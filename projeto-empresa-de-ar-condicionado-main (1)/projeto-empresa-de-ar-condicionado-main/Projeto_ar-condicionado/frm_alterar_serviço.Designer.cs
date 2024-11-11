namespace Projeto_ar_condicionado
{
    partial class frm_alterar_serviço
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
            this.txb_funcionario_ser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_cliente_ser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvar_servico = new System.Windows.Forms.Button();
            this.txb_descricao_servico = new System.Windows.Forms.TextBox();
            this.txb_valor_servico = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_novo_ser = new System.Windows.Forms.DateTimePicker();
            this.txb_idfuncionario = new System.Windows.Forms.TextBox();
            this.txb_idcliente = new System.Windows.Forms.TextBox();
            this.btn_ = new System.Windows.Forms.Button();
            this.btn_pesquisa_ser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_funcionario_ser
            // 
            this.txb_funcionario_ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_funcionario_ser.Location = new System.Drawing.Point(135, 74);
            this.txb_funcionario_ser.Name = "txb_funcionario_ser";
            this.txb_funcionario_ser.ReadOnly = true;
            this.txb_funcionario_ser.Size = new System.Drawing.Size(232, 26);
            this.txb_funcionario_ser.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Funcionario";
            // 
            // txb_cliente_ser
            // 
            this.txb_cliente_ser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cliente_ser.Location = new System.Drawing.Point(135, 25);
            this.txb_cliente_ser.Name = "txb_cliente_ser";
            this.txb_cliente_ser.ReadOnly = true;
            this.txb_cliente_ser.Size = new System.Drawing.Size(232, 26);
            this.txb_cliente_ser.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = " Cliente";
            // 
            // btn_salvar_servico
            // 
            this.btn_salvar_servico.Location = new System.Drawing.Point(426, 296);
            this.btn_salvar_servico.Name = "btn_salvar_servico";
            this.btn_salvar_servico.Size = new System.Drawing.Size(97, 23);
            this.btn_salvar_servico.TabIndex = 26;
            this.btn_salvar_servico.Text = "Salvar";
            this.btn_salvar_servico.UseVisualStyleBackColor = true;
            this.btn_salvar_servico.Click += new System.EventHandler(this.btn_salvar_servico_Click);
            // 
            // txb_descricao_servico
            // 
            this.txb_descricao_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descricao_servico.Location = new System.Drawing.Point(12, 114);
            this.txb_descricao_servico.Multiline = true;
            this.txb_descricao_servico.Name = "txb_descricao_servico";
            this.txb_descricao_servico.Size = new System.Drawing.Size(408, 205);
            this.txb_descricao_servico.TabIndex = 24;
            this.txb_descricao_servico.Text = "Descrição";
            // 
            // txb_valor_servico
            // 
            this.txb_valor_servico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_servico.Location = new System.Drawing.Point(12, 74);
            this.txb_valor_servico.Name = "txb_valor_servico";
            this.txb_valor_servico.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_servico.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Valor serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data do serviço";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_codigo.Location = new System.Drawing.Point(467, 24);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.ReadOnly = true;
            this.txb_codigo.Size = new System.Drawing.Size(56, 26);
            this.txb_codigo.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(472, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "codigo";
            // 
            // data_novo_ser
            // 
            this.data_novo_ser.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_novo_ser.Location = new System.Drawing.Point(12, 27);
            this.data_novo_ser.Name = "data_novo_ser";
            this.data_novo_ser.Size = new System.Drawing.Size(103, 20);
            this.data_novo_ser.TabIndex = 33;
            // 
            // txb_idfuncionario
            // 
            this.txb_idfuncionario.Location = new System.Drawing.Point(426, 140);
            this.txb_idfuncionario.Name = "txb_idfuncionario";
            this.txb_idfuncionario.ReadOnly = true;
            this.txb_idfuncionario.Size = new System.Drawing.Size(40, 20);
            this.txb_idfuncionario.TabIndex = 35;
            this.txb_idfuncionario.Visible = false;
            // 
            // txb_idcliente
            // 
            this.txb_idcliente.Location = new System.Drawing.Point(426, 114);
            this.txb_idcliente.Name = "txb_idcliente";
            this.txb_idcliente.ReadOnly = true;
            this.txb_idcliente.Size = new System.Drawing.Size(40, 20);
            this.txb_idcliente.TabIndex = 34;
            this.txb_idcliente.Visible = false;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(373, 75);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(63, 26);
            this.btn_.TabIndex = 37;
            this.btn_.Text = "pesquisar_ser";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // btn_pesquisa_ser
            // 
            this.btn_pesquisa_ser.Location = new System.Drawing.Point(373, 25);
            this.btn_pesquisa_ser.Name = "btn_pesquisa_ser";
            this.btn_pesquisa_ser.Size = new System.Drawing.Size(63, 26);
            this.btn_pesquisa_ser.TabIndex = 36;
            this.btn_pesquisa_ser.Text = "pesquisar_ser";
            this.btn_pesquisa_ser.UseVisualStyleBackColor = true;
            this.btn_pesquisa_ser.Click += new System.EventHandler(this.btn_pesquisa_ser_Click);
            // 
            // frm_alterar_serviço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 328);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.btn_pesquisa_ser);
            this.Controls.Add(this.txb_idfuncionario);
            this.Controls.Add(this.txb_idcliente);
            this.Controls.Add(this.data_novo_ser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.txb_funcionario_ser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_cliente_ser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salvar_servico);
            this.Controls.Add(this.txb_descricao_servico);
            this.Controls.Add(this.txb_valor_servico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frm_alterar_serviço";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_alterar_serviço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_funcionario_ser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_cliente_ser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salvar_servico;
        private System.Windows.Forms.TextBox txb_descricao_servico;
        private System.Windows.Forms.TextBox txb_valor_servico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker data_novo_ser;
        private System.Windows.Forms.TextBox txb_idfuncionario;
        private System.Windows.Forms.TextBox txb_idcliente;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button btn_pesquisa_ser;
    }
}