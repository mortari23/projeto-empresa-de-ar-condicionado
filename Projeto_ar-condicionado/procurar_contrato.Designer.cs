namespace Projeto_ar_condicionado
{
    partial class procurar_contrato
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
            this.dgv_procurar_cliente = new System.Windows.Forms.DataGridView();
            this.btn_procurar_contrato = new System.Windows.Forms.Button();
            this.txb_procurar_contrato = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procurar_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_procurar_cliente
            // 
            this.dgv_procurar_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_procurar_cliente.Location = new System.Drawing.Point(28, 60);
            this.dgv_procurar_cliente.Name = "dgv_procurar_cliente";
            this.dgv_procurar_cliente.Size = new System.Drawing.Size(498, 295);
            this.dgv_procurar_cliente.TabIndex = 0;
            this.dgv_procurar_cliente.DoubleClick += new System.EventHandler(this.dgv_procurar_cliente_DoubleClick);
            // 
            // btn_procurar_contrato
            // 
            this.btn_procurar_contrato.Location = new System.Drawing.Point(451, 34);
            this.btn_procurar_contrato.Name = "btn_procurar_contrato";
            this.btn_procurar_contrato.Size = new System.Drawing.Size(85, 20);
            this.btn_procurar_contrato.TabIndex = 1;
            this.btn_procurar_contrato.Text = "buscar";
            this.btn_procurar_contrato.UseVisualStyleBackColor = true;
            this.btn_procurar_contrato.Click += new System.EventHandler(this.btn_procurar_contrato_Click);
            // 
            // txb_procurar_contrato
            // 
            this.txb_procurar_contrato.Location = new System.Drawing.Point(28, 34);
            this.txb_procurar_contrato.Name = "txb_procurar_contrato";
            this.txb_procurar_contrato.Size = new System.Drawing.Size(405, 20);
            this.txb_procurar_contrato.TabIndex = 2;
            // 
            // procurar_contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 367);
            this.Controls.Add(this.txb_procurar_contrato);
            this.Controls.Add(this.btn_procurar_contrato);
            this.Controls.Add(this.dgv_procurar_cliente);
            this.Name = "procurar_contrato";
            this.Text = "procurar_contrato";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_procurar_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_procurar_cliente;
        private System.Windows.Forms.Button btn_procurar_contrato;
        private System.Windows.Forms.TextBox txb_procurar_contrato;
    }
}