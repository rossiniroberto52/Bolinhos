namespace project_mama
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarUmJáExistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoOrçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelDePreçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bolinhos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.orçamentoToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.itensToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarUmJáExistenteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // editarUmJáExistenteToolStripMenuItem
            // 
            this.editarUmJáExistenteToolStripMenuItem.Name = "editarUmJáExistenteToolStripMenuItem";
            this.editarUmJáExistenteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.editarUmJáExistenteToolStripMenuItem.Text = "Editar um já existente";
            // 
            // itensToolStripMenuItem
            // 
            this.itensToolStripMenuItem.Name = "itensToolStripMenuItem";
            this.itensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itensToolStripMenuItem.Text = "Produtos";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoOrçamentoToolStripMenuItem,
            this.tabelDePreçosToolStripMenuItem});
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // novoOrçamentoToolStripMenuItem
            // 
            this.novoOrçamentoToolStripMenuItem.Name = "novoOrçamentoToolStripMenuItem";
            this.novoOrçamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoOrçamentoToolStripMenuItem.Text = "Novo orçamento";
            // 
            // tabelDePreçosToolStripMenuItem
            // 
            this.tabelDePreçosToolStripMenuItem.Name = "tabelDePreçosToolStripMenuItem";
            this.tabelDePreçosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabelDePreçosToolStripMenuItem.Text = "Tabel de preços";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoPedidoToolStripMenuItem,
            this.editarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // novoPedidoToolStripMenuItem
            // 
            this.novoPedidoToolStripMenuItem.Name = "novoPedidoToolStripMenuItem";
            this.novoPedidoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novoPedidoToolStripMenuItem.Text = "Novo pedido";
            // 
            // editarPedidosToolStripMenuItem
            // 
            this.editarPedidosToolStripMenuItem.Name = "editarPedidosToolStripMenuItem";
            this.editarPedidosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editarPedidosToolStripMenuItem.Text = "Editar pedidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOLINHOS - GERENCIAMENTO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoOrçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelDePreçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarUmJáExistenteToolStripMenuItem;
    }
}

