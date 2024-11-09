namespace Projeto_ar_condicionado
{
    partial class frm_alterar_contrato
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
            this.data_novo_contrato = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_codigo_contrato = new System.Windows.Forms.TextBox();
            this.txb_cliente_contrato = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_salvar_contrato = new System.Windows.Forms.Button();
            this.txb_descricao_contrato = new System.Windows.Forms.TextBox();
            this.txb_valor_contrato = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox_final = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_tipo_contrato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // data_novo_contrato
            // 
            this.data_novo_contrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_novo_contrato.Location = new System.Drawing.Point(28, 44);
            this.data_novo_contrato.Name = "data_novo_contrato";
            this.data_novo_contrato.Size = new System.Drawing.Size(103, 20);
            this.data_novo_contrato.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(404, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "codigo do serviço";
            // 
            // txb_codigo_contrato
            // 
            this.txb_codigo_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_codigo_contrato.Location = new System.Drawing.Point(413, 44);
            this.txb_codigo_contrato.Name = "txb_codigo_contrato";
            this.txb_codigo_contrato.ReadOnly = true;
            this.txb_codigo_contrato.Size = new System.Drawing.Size(110, 26);
            this.txb_codigo_contrato.TabIndex = 43;
            // 
            // txb_cliente_contrato
            // 
            this.txb_cliente_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cliente_contrato.Location = new System.Drawing.Point(137, 44);
            this.txb_cliente_contrato.Name = "txb_cliente_contrato";
            this.txb_cliente_contrato.Size = new System.Drawing.Size(232, 26);
            this.txb_cliente_contrato.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = " Cliente";
            // 
            // btn_salvar_contrato
            // 
            this.btn_salvar_contrato.Location = new System.Drawing.Point(442, 284);
            this.btn_salvar_contrato.Name = "btn_salvar_contrato";
            this.btn_salvar_contrato.Size = new System.Drawing.Size(97, 23);
            this.btn_salvar_contrato.TabIndex = 38;
            this.btn_salvar_contrato.Text = "Salvar";
            this.btn_salvar_contrato.UseVisualStyleBackColor = true;
            this.btn_salvar_contrato.Click += new System.EventHandler(this.btn_salvar_contrato_Click);
            // 
            // txb_descricao_contrato
            // 
            this.txb_descricao_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descricao_contrato.Location = new System.Drawing.Point(28, 131);
            this.txb_descricao_contrato.Multiline = true;
            this.txb_descricao_contrato.Name = "txb_descricao_contrato";
            this.txb_descricao_contrato.Size = new System.Drawing.Size(408, 205);
            this.txb_descricao_contrato.TabIndex = 37;
            this.txb_descricao_contrato.Text = "Descrição";
            // 
            // txb_valor_contrato
            // 
            this.txb_valor_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_contrato.Location = new System.Drawing.Point(28, 91);
            this.txb_valor_contrato.Name = "txb_valor_contrato";
            this.txb_valor_contrato.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_contrato.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Valor contrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data do contrato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(149, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Data Final ";
            // 
            // maskedTextBox_final
            // 
            this.maskedTextBox_final.Location = new System.Drawing.Point(151, 97);
            this.maskedTextBox_final.Mask = "99/99/9999";
            this.maskedTextBox_final.Name = "maskedTextBox_final";
            this.maskedTextBox_final.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox_final.TabIndex = 47;
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
            this.comboBox_tipo_contrato.Location = new System.Drawing.Point(367, 97);
            this.comboBox_tipo_contrato.Name = "comboBox_tipo_contrato";
            this.comboBox_tipo_contrato.Size = new System.Drawing.Size(172, 28);
            this.comboBox_tipo_contrato.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tipo contrato";
            // 
            // frm_alterar_contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 364);
            this.Controls.Add(this.comboBox_tipo_contrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox_final);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.data_novo_contrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_codigo_contrato);
            this.Controls.Add(this.txb_cliente_contrato);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salvar_contrato);
            this.Controls.Add(this.txb_descricao_contrato);
            this.Controls.Add(this.txb_valor_contrato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frm_alterar_contrato";
            this.Text = "frm_alterar_contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker data_novo_contrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_codigo_contrato;
        private System.Windows.Forms.TextBox txb_cliente_contrato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salvar_contrato;
        private System.Windows.Forms.TextBox txb_descricao_contrato;
        private System.Windows.Forms.TextBox txb_valor_contrato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_final;
        private System.Windows.Forms.ComboBox comboBox_tipo_contrato;
        private System.Windows.Forms.Label label3;
    }
}