﻿namespace Projeto_ar_condicionado
{
    partial class procurar_cliente
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
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.txb_buscar_cadastro = new System.Windows.Forms.TextBox();
            this.btn_buscar_cadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Location = new System.Drawing.Point(12, 41);
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.ReadOnly = true;
            this.dataGridView_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cliente.Size = new System.Drawing.Size(451, 293);
            this.dataGridView_cliente.TabIndex = 0;
            this.dataGridView_cliente.DoubleClick += new System.EventHandler(this.dataGridView_cliente_DoubleClick);
            // 
            // txb_buscar_cadastro
            // 
            this.txb_buscar_cadastro.Location = new System.Drawing.Point(12, 15);
            this.txb_buscar_cadastro.Name = "txb_buscar_cadastro";
            this.txb_buscar_cadastro.Size = new System.Drawing.Size(370, 20);
            this.txb_buscar_cadastro.TabIndex = 9;
            // 
            // btn_buscar_cadastro
            // 
            this.btn_buscar_cadastro.Location = new System.Drawing.Point(388, 14);
            this.btn_buscar_cadastro.Name = "btn_buscar_cadastro";
            this.btn_buscar_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_cadastro.TabIndex = 11;
            this.btn_buscar_cadastro.Text = "Buscar";
            this.btn_buscar_cadastro.UseVisualStyleBackColor = true;
            this.btn_buscar_cadastro.Click += new System.EventHandler(this.btn_buscar_cadastro_Click);
            // 
            // procurar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 347);
            this.Controls.Add(this.btn_buscar_cadastro);
            this.Controls.Add(this.txb_buscar_cadastro);
            this.Controls.Add(this.dataGridView_cliente);
            this.Name = "procurar_cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "procurar_cliente";
            this.Load += new System.EventHandler(this.procurar_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.TextBox txb_buscar_cadastro;
        private System.Windows.Forms.Button btn_buscar_cadastro;
    }
}