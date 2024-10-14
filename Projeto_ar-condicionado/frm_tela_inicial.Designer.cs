namespace Projeto_ar_condicionado
{
    partial class frm_tela_inicial
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDePessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDePessoasToolStripMenuItem,
            this.cadastroDeServiçoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDePessoasToolStripMenuItem
            // 
            this.cadastroDePessoasToolStripMenuItem.Name = "cadastroDePessoasToolStripMenuItem";
            this.cadastroDePessoasToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.cadastroDePessoasToolStripMenuItem.Text = "Cadastros de pessoas";
            this.cadastroDePessoasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDePessoasToolStripMenuItem_Click);
            // 
            // cadastroDeServiçoToolStripMenuItem
            // 
            this.cadastroDeServiçoToolStripMenuItem.Name = "cadastroDeServiçoToolStripMenuItem";
            this.cadastroDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.cadastroDeServiçoToolStripMenuItem.Text = "Serviços e Contratos";
            this.cadastroDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeServiçoToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ar_condicionado.Properties.Resources.ar_ecologico_ar_condicionado_logo_sem_fundo_;
            this.pictureBox1.Location = new System.Drawing.Point(281, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 523);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_tela_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_tela_inicial";
            this.Text = "frm_tela_inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDePessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}