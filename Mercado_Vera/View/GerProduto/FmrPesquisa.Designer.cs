﻿namespace Mercado_Vera.View.GerProduto
{
    partial class FmrPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPesquisa));
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMarcaPes = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgPesquisa = new System.Windows.Forms.DataGridView();
            this.PROD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_COD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_VALOR_VENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_QTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_QTD_MIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROD_MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOR_NOME_FANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgPesquisa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Marca";
            // 
            // cbxMarcaPes
            // 
            this.cbxMarcaPes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarcaPes.FormattingEnabled = true;
            this.cbxMarcaPes.Items.AddRange(new object[] {
            "\"\""});
            this.cbxMarcaPes.Location = new System.Drawing.Point(530, 34);
            this.cbxMarcaPes.Name = "cbxMarcaPes";
            this.cbxMarcaPes.Size = new System.Drawing.Size(140, 21);
            this.cbxMarcaPes.TabIndex = 25;
            this.cbxMarcaPes.SelectedIndexChanged += new System.EventHandler(this.cbxMarcaPes_SelectedIndexChanged);
            this.cbxMarcaPes.Click += new System.EventHandler(this.cbxMarcaPes_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(163, 34);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(349, 24);
            this.txtNome.TabIndex = 24;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomePes_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomePes_KeyPress);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNomePes_KeyUp);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(13, 34);
            this.txtCodigo.MaxLength = 15;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(134, 24);
            this.txtCodigo.TabIndex = 23;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoPes_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoPes_KeyPress);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigoPes_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Cód. Barra:";
            // 
            // DgPesquisa
            // 
            this.DgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PROD_ID,
            this.PROD_COD,
            this.PROD_NOME,
            this.PROD_VALOR,
            this.PROD_VALOR_VENDA,
            this.PROD_QTD,
            this.PROD_QTD_MIN,
            this.PROD_MARCA,
            this.FOR_NOME_FANT});
            this.DgPesquisa.Location = new System.Drawing.Point(13, 25);
            this.DgPesquisa.Name = "DgPesquisa";
            this.DgPesquisa.RowHeadersWidth = 30;
            this.DgPesquisa.Size = new System.Drawing.Size(799, 319);
            this.DgPesquisa.TabIndex = 27;
            this.DgPesquisa.DoubleClick += new System.EventHandler(this.DgPesquisa_DoubleClick);
            // 
            // PROD_ID
            // 
            this.PROD_ID.DataPropertyName = "PROD_ID";
            this.PROD_ID.HeaderText = "ID";
            this.PROD_ID.Name = "PROD_ID";
            this.PROD_ID.Width = 32;
            // 
            // PROD_COD
            // 
            this.PROD_COD.DataPropertyName = "PROD_COD";
            this.PROD_COD.HeaderText = "Cód.Barra";
            this.PROD_COD.Name = "PROD_COD";
            // 
            // PROD_NOME
            // 
            this.PROD_NOME.DataPropertyName = "PROD_NOME";
            this.PROD_NOME.HeaderText = "Nome";
            this.PROD_NOME.Name = "PROD_NOME";
            this.PROD_NOME.Width = 180;
            // 
            // PROD_VALOR
            // 
            this.PROD_VALOR.DataPropertyName = "PROD_VALOR";
            this.PROD_VALOR.HeaderText = "P.Custo";
            this.PROD_VALOR.Name = "PROD_VALOR";
            this.PROD_VALOR.Width = 60;
            // 
            // PROD_VALOR_VENDA
            // 
            this.PROD_VALOR_VENDA.DataPropertyName = "PROD_VALOR_VENDA";
            this.PROD_VALOR_VENDA.HeaderText = "P.Venda";
            this.PROD_VALOR_VENDA.Name = "PROD_VALOR_VENDA";
            this.PROD_VALOR_VENDA.Width = 60;
            // 
            // PROD_QTD
            // 
            this.PROD_QTD.DataPropertyName = "PROD_QTD";
            this.PROD_QTD.HeaderText = "Qtd.Total";
            this.PROD_QTD.Name = "PROD_QTD";
            this.PROD_QTD.Width = 55;
            // 
            // PROD_QTD_MIN
            // 
            this.PROD_QTD_MIN.DataPropertyName = "PROD_QTD_MIN";
            this.PROD_QTD_MIN.HeaderText = "Qtd.Minima";
            this.PROD_QTD_MIN.Name = "PROD_QTD_MIN";
            this.PROD_QTD_MIN.Width = 65;
            // 
            // PROD_MARCA
            // 
            this.PROD_MARCA.DataPropertyName = "PROD_MARCA";
            this.PROD_MARCA.HeaderText = "Marca";
            this.PROD_MARCA.Name = "PROD_MARCA";
            // 
            // FOR_NOME_FANT
            // 
            this.FOR_NOME_FANT.DataPropertyName = "FOR_NOME_FANT";
            this.FOR_NOME_FANT.HeaderText = "Fornecedor";
            this.FOR_NOME_FANT.Name = "FOR_NOME_FANT";
            this.FOR_NOME_FANT.Width = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxMarcaPes);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 69);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 90);
            this.panel1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Mercado_Vera.Properties.Resources.arrow_refresh;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(728, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Atualizar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.DgPesquisa);
            this.panel2.Controls.Add(this.BtnNovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 438);
            this.panel2.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Mercado_Vera.Properties.Resources.package_delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(234, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 31;
            this.button2.Text = "Excluir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Mercado_Vera.Properties.Resources.folder_edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(128, 376);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Image = global::Mercado_Vera.Properties.Resources.package_add1;
            this.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNovo.Location = new System.Drawing.Point(28, 377);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 25);
            this.BtnNovo.TabIndex = 29;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // FmrPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(839, 567);
            this.Name = "FmrPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.FmrPesquisa_Load);
            this.DoubleClick += new System.EventHandler(this.FmrPesquisa_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.DgPesquisa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMarcaPes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgPesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_COD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_VALOR_VENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_QTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_QTD_MIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROD_MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOR_NOME_FANT;
    }
}