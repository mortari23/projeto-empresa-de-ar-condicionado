namespace Projeto_ar_condicionado
{
    partial class frm_alterar_funcionario
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
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_codigo = new System.Windows.Forms.TextBox();
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
            this.groupBox_endereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(466, 359);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(129, 25);
            this.btn_salvar.TabIndex = 38;
            this.btn_salvar.Text = "alterar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 360);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Codigo";
            // 
            // txb_codigo
            // 
            this.txb_codigo.Location = new System.Drawing.Point(78, 359);
            this.txb_codigo.Name = "txb_codigo";
            this.txb_codigo.ReadOnly = true;
            this.txb_codigo.Size = new System.Drawing.Size(100, 20);
            this.txb_codigo.TabIndex = 36;
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
            this.groupBox_endereço.Location = new System.Drawing.Point(26, 150);
            this.groupBox_endereço.Name = "groupBox_endereço";
            this.groupBox_endereço.Size = new System.Drawing.Size(569, 203);
            this.groupBox_endereço.TabIndex = 35;
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
            // 
            // maskedTextBox_numero
            // 
            this.maskedTextBox_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_numero.Location = new System.Drawing.Point(257, 81);
            this.maskedTextBox_numero.Mask = "9999";
            this.maskedTextBox_numero.Name = "maskedTextBox_numero";
            this.maskedTextBox_numero.Size = new System.Drawing.Size(42, 26);
            this.maskedTextBox_numero.TabIndex = 20;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(143, 22);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
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
            this.txb_gmail.Location = new System.Drawing.Point(309, 108);
            this.txb_gmail.Name = "txb_gmail";
            this.txb_gmail.Size = new System.Drawing.Size(286, 26);
            this.txb_gmail.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // maskedTextBox_cpf
            // 
            this.maskedTextBox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_cpf.Location = new System.Drawing.Point(164, 108);
            this.maskedTextBox_cpf.Mask = "999,999,999-99";
            this.maskedTextBox_cpf.Name = "maskedTextBox_cpf";
            this.maskedTextBox_cpf.Size = new System.Drawing.Size(127, 26);
            this.maskedTextBox_cpf.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "CPF";
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(26, 108);
            this.maskedTextBox_telefone.Mask = "(99)99999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(121, 26);
            this.maskedTextBox_telefone.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Telefone";
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.comboBox_tipo.Location = new System.Drawing.Point(474, 43);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(121, 28);
            this.comboBox_tipo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tipo";
            // 
            // txb_nome
            // 
            this.txb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome.Location = new System.Drawing.Point(26, 45);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(442, 26);
            this.txb_nome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome";
            // 
            // frm_alterar_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 400);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txb_codigo);
            this.Controls.Add(this.groupBox_endereço);
            this.Controls.Add(this.txb_gmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox_cpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.label1);
            this.Name = "frm_alterar_funcionario";
            this.Text = "Alterar Funcionario";
            this.groupBox_endereço.ResumeLayout(false);
            this.groupBox_endereço.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_codigo;
        private System.Windows.Forms.GroupBox groupBox_endereço;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cep;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numero;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Label label1;
    }
}