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
            this.txb_idcliente2 = new System.Windows.Forms.TextBox();
            this.btn_procurar_contrato = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_cliente_con = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_tipo_contrato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_salvar_contrato = new System.Windows.Forms.Button();
            this.txb_descricao_contrato = new System.Windows.Forms.TextBox();
            this.txb_valor_contrato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
            this.data_novo_con = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txb_idcliente2
            // 
            this.txb_idcliente2.Location = new System.Drawing.Point(426, 115);
            this.txb_idcliente2.Name = "txb_idcliente2";
            this.txb_idcliente2.ReadOnly = true;
            this.txb_idcliente2.Size = new System.Drawing.Size(40, 20);
            this.txb_idcliente2.TabIndex = 44;
            this.txb_idcliente2.Visible = false;
            // 
            // btn_procurar_contrato
            // 
            this.btn_procurar_contrato.Location = new System.Drawing.Point(369, 27);
            this.btn_procurar_contrato.Name = "btn_procurar_contrato";
            this.btn_procurar_contrato.Size = new System.Drawing.Size(63, 26);
            this.btn_procurar_contrato.TabIndex = 43;
            this.btn_procurar_contrato.Text = "pesquisar_ser";
            this.btn_procurar_contrato.UseVisualStyleBackColor = true;
            this.btn_procurar_contrato.Click += new System.EventHandler(this.btn_procurar_contrato_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Data Final";
            // 
            // txb_cliente_con
            // 
            this.txb_cliente_con.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_cliente_con.Location = new System.Drawing.Point(131, 26);
            this.txb_cliente_con.Name = "txb_cliente_con";
            this.txb_cliente_con.ReadOnly = true;
            this.txb_cliente_con.Size = new System.Drawing.Size(232, 26);
            this.txb_cliente_con.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 39;
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
            this.comboBox_tipo_contrato.Location = new System.Drawing.Point(131, 78);
            this.comboBox_tipo_contrato.Name = "comboBox_tipo_contrato";
            this.comboBox_tipo_contrato.Size = new System.Drawing.Size(172, 28);
            this.comboBox_tipo_contrato.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo contrato";
            // 
            // btn_salvar_contrato
            // 
            this.btn_salvar_contrato.Location = new System.Drawing.Point(425, 297);
            this.btn_salvar_contrato.Name = "btn_salvar_contrato";
            this.btn_salvar_contrato.Size = new System.Drawing.Size(97, 23);
            this.btn_salvar_contrato.TabIndex = 36;
            this.btn_salvar_contrato.Text = "Salvar";
            this.btn_salvar_contrato.UseVisualStyleBackColor = true;
            this.btn_salvar_contrato.Click += new System.EventHandler(this.btn_salvar_contrato_Click_1);
            // 
            // txb_descricao_contrato
            // 
            this.txb_descricao_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_descricao_contrato.Location = new System.Drawing.Point(12, 115);
            this.txb_descricao_contrato.Multiline = true;
            this.txb_descricao_contrato.Name = "txb_descricao_contrato";
            this.txb_descricao_contrato.Size = new System.Drawing.Size(408, 205);
            this.txb_descricao_contrato.TabIndex = 34;
            this.txb_descricao_contrato.Text = "Descrição";
            // 
            // txb_valor_contrato
            // 
            this.txb_valor_contrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valor_contrato.Location = new System.Drawing.Point(12, 78);
            this.txb_valor_contrato.Name = "txb_valor_contrato";
            this.txb_valor_contrato.Size = new System.Drawing.Size(87, 26);
            this.txb_valor_contrato.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Valor Contrato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Data do Contrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(472, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "codigo";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_codigo.Location = new System.Drawing.Point(467, 26);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.ReadOnly = true;
            this.txb_codigo.Size = new System.Drawing.Size(56, 26);
            this.txb_codigo.TabIndex = 45;
            // 
            // data_novo_con
            // 
            this.data_novo_con.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_novo_con.Location = new System.Drawing.Point(12, 26);
            this.data_novo_con.Name = "data_novo_con";
            this.data_novo_con.Size = new System.Drawing.Size(103, 20);
            this.data_novo_con.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(333, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // frm_alterar_contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 328);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.data_novo_con);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.txb_idcliente2);
            this.Controls.Add(this.btn_procurar_contrato);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txb_cliente_con);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_tipo_contrato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salvar_contrato);
            this.Controls.Add(this.txb_descricao_contrato);
            this.Controls.Add(this.txb_valor_contrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frm_alterar_contrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_alterar_contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_idcliente2;
        private System.Windows.Forms.Button btn_procurar_contrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_cliente_con;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_tipo_contrato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_salvar_contrato;
        private System.Windows.Forms.TextBox txb_descricao_contrato;
        private System.Windows.Forms.TextBox txb_valor_contrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.DateTimePicker data_novo_con;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}