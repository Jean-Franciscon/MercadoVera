namespace Mercado_Vera
{
    partial class FmrPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_vendas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesDevedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_vendas);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 338);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Image = global::Mercado_Vera.Properties.Resources.wallet;
            this.button3.Location = new System.Drawing.Point(545, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 176);
            this.button3.TabIndex = 3;
            this.button3.Text = "Financeiro";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Image = global::Mercado_Vera.Properties.Resources.conference_call;
            this.button2.Location = new System.Drawing.Point(285, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 176);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cadastrar Cliente";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_vendas
            // 
            this.btn_vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vendas.ForeColor = System.Drawing.Color.Blue;
            this.btn_vendas.Image = global::Mercado_Vera.Properties.Resources.add_shopping_cart;
            this.btn_vendas.Location = new System.Drawing.Point(25, 96);
            this.btn_vendas.Name = "btn_vendas";
            this.btn_vendas.Size = new System.Drawing.Size(218, 176);
            this.btn_vendas.TabIndex = 1;
            this.btn_vendas.Text = "VENDAS";
            this.btn_vendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_vendas.UseVisualStyleBackColor = true;
            this.btn_vendas.Click += new System.EventHandler(this.btn_vendas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.pesquisarProdutosToolStripMenuItem});
            this.produtosToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.package;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.package_add;
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // pesquisarProdutosToolStripMenuItem
            // 
            this.pesquisarProdutosToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.zoom;
            this.pesquisarProdutosToolStripMenuItem.Name = "pesquisarProdutosToolStripMenuItem";
            this.pesquisarProdutosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.pesquisarProdutosToolStripMenuItem.Text = "Pesquisar Produtos";
            this.pesquisarProdutosToolStripMenuItem.Click += new System.EventHandler(this.pesquisarProdutosToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFornecedorToolStripMenuItem,
            this.pesquisarFornecedorToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.lorry_add;
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // novoFornecedorToolStripMenuItem
            // 
            this.novoFornecedorToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.lorry_add;
            this.novoFornecedorToolStripMenuItem.Name = "novoFornecedorToolStripMenuItem";
            this.novoFornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.novoFornecedorToolStripMenuItem.Text = "Novo Fornecedor";
            this.novoFornecedorToolStripMenuItem.Click += new System.EventHandler(this.novoFornecedorToolStripMenuItem_Click);
            // 
            // pesquisarFornecedorToolStripMenuItem
            // 
            this.pesquisarFornecedorToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.zoom1;
            this.pesquisarFornecedorToolStripMenuItem.Name = "pesquisarFornecedorToolStripMenuItem";
            this.pesquisarFornecedorToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pesquisarFornecedorToolStripMenuItem.Text = "Pesquisar Fornecedor";
            this.pesquisarFornecedorToolStripMenuItem.Click += new System.EventHandler(this.pesquisarFornecedorToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarClienteToolStripMenuItem,
            this.cadastrarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.user;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // pesquisarClienteToolStripMenuItem
            // 
            this.pesquisarClienteToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.zoom;
            this.pesquisarClienteToolStripMenuItem.Name = "pesquisarClienteToolStripMenuItem";
            this.pesquisarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pesquisarClienteToolStripMenuItem.Text = "Pesquisar Cliente";
            this.pesquisarClienteToolStripMenuItem.Click += new System.EventHandler(this.pesquisarClienteToolStripMenuItem_Click);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.add1;
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesDevedoresToolStripMenuItem,
            this.produtosEstoqueToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.page_white_stack;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // clientesDevedoresToolStripMenuItem
            // 
            this.clientesDevedoresToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.user_red;
            this.clientesDevedoresToolStripMenuItem.Name = "clientesDevedoresToolStripMenuItem";
            this.clientesDevedoresToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.clientesDevedoresToolStripMenuItem.Text = "Clientes Devedores";
            this.clientesDevedoresToolStripMenuItem.Click += new System.EventHandler(this.clientesDevedoresToolStripMenuItem_Click);
            // 
            // produtosEstoqueToolStripMenuItem
            // 
            this.produtosEstoqueToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.package1;
            this.produtosEstoqueToolStripMenuItem.Name = "produtosEstoqueToolStripMenuItem";
            this.produtosEstoqueToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.produtosEstoqueToolStripMenuItem.Text = "Produtos/Estoque";
            this.produtosEstoqueToolStripMenuItem.Click += new System.EventHandler(this.produtosEstoqueToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.user_suit1;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.sairToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sairToolStripMenuItem.Image = global::Mercado_Vera.Properties.Resources.door_out;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // FmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 377);
            this.Name = "FmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lojinha da Vera";
            this.Load += new System.EventHandler(this.FmrPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_vendas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesDevedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
    }
}