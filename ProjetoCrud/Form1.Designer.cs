namespace ProjetoCrud
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.endereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Cadastro,
            this.endereçoToolStripMenuItem,
            this.excluirClienteToolStripMenuItem,
            this.excluirEndereçoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Cadastro
            // 
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(112, 21);
            this.Cadastro.Text = "CadastroCliente";
            this.Cadastro.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // endereçoToolStripMenuItem
            // 
            this.endereçoToolStripMenuItem.Name = "endereçoToolStripMenuItem";
            this.endereçoToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.endereçoToolStripMenuItem.Text = "Endereço";
            this.endereçoToolStripMenuItem.Click += new System.EventHandler(this.endereçoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // excluirClienteToolStripMenuItem
            // 
            this.excluirClienteToolStripMenuItem.Name = "excluirClienteToolStripMenuItem";
            this.excluirClienteToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.excluirClienteToolStripMenuItem.Text = "Excluir Cliente";
            this.excluirClienteToolStripMenuItem.Click += new System.EventHandler(this.excluirClienteToolStripMenuItem_Click);
            // 
            // excluirEndereçoToolStripMenuItem
            // 
            this.excluirEndereçoToolStripMenuItem.Name = "excluirEndereçoToolStripMenuItem";
            this.excluirEndereçoToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.excluirEndereçoToolStripMenuItem.Text = "Excluir Endereço";
            this.excluirEndereçoToolStripMenuItem.Click += new System.EventHandler(this.excluirEndereçoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 312);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Cadastro;
        private System.Windows.Forms.ToolStripMenuItem endereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirEndereçoToolStripMenuItem;
    }
}

