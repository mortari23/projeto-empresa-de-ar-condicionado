namespace Projeto_ar_condicionado
{
    partial class frm_procurar_funcionario
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
            this.btn_buscar_cadastro = new System.Windows.Forms.Button();
            this.txb_buscar_cadastro = new System.Windows.Forms.TextBox();
            this.dataGridView_funcionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar_cadastro
            // 
            this.btn_buscar_cadastro.Location = new System.Drawing.Point(388, 10);
            this.btn_buscar_cadastro.Name = "btn_buscar_cadastro";
            this.btn_buscar_cadastro.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar_cadastro.TabIndex = 14;
            this.btn_buscar_cadastro.Text = "Buscar";
            this.btn_buscar_cadastro.UseVisualStyleBackColor = true;
            this.btn_buscar_cadastro.Click += new System.EventHandler(this.btn_buscar_cadastro_Click);
            // 
            // txb_buscar_cadastro
            // 
            this.txb_buscar_cadastro.Location = new System.Drawing.Point(12, 12);
            this.txb_buscar_cadastro.Name = "txb_buscar_cadastro";
            this.txb_buscar_cadastro.Size = new System.Drawing.Size(370, 20);
            this.txb_buscar_cadastro.TabIndex = 13;
            // 
            // dataGridView_funcionario
            // 
            this.dataGridView_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funcionario.Location = new System.Drawing.Point(12, 38);
            this.dataGridView_funcionario.Name = "dataGridView_funcionario";
            this.dataGridView_funcionario.ReadOnly = true;
            this.dataGridView_funcionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_funcionario.Size = new System.Drawing.Size(451, 293);
            this.dataGridView_funcionario.TabIndex = 12;
            this.dataGridView_funcionario.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_funcionario_CellContentDoubleClick);
            // 
            // frm_procurar_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 347);
            this.Controls.Add(this.btn_buscar_cadastro);
            this.Controls.Add(this.txb_buscar_cadastro);
            this.Controls.Add(this.dataGridView_funcionario);
            this.Name = "frm_procurar_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "procurar_funcionario";
            this.Load += new System.EventHandler(this.frm_procurar_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar_cadastro;
        private System.Windows.Forms.TextBox txb_buscar_cadastro;
        private System.Windows.Forms.DataGridView dataGridView_funcionario;
    }
}