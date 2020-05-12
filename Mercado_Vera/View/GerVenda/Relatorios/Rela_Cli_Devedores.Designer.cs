namespace Mercado_Vera.View.GerVenda.Relatorios
{
    partial class Rela_Cli_Devedores
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rela_Cli_Devedores));
            this.tBLCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMercado = new Mercado_Vera.DataS.DataSetMercado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBL_CLIENTETableAdapter = new Mercado_Vera.DataS.DataSetMercadoTableAdapters.TBL_CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLCLIENTEBindingSource
            // 
            this.tBLCLIENTEBindingSource.DataMember = "TBL_CLIENTE";
            this.tBLCLIENTEBindingSource.DataSource = this.dataSetMercado;
            // 
            // dataSetMercado
            // 
            this.dataSetMercado.DataSetName = "DataSetMercado";
            this.dataSetMercado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataCliDevedor";
            reportDataSource1.Value = this.tBLCLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mercado_Vera.View.GerVenda.Relatorios.Rela_Cli_Devedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(495, 361);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tBL_CLIENTETableAdapter
            // 
            this.tBL_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // Rela_Cli_Devedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 361);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(527, 400);
            this.Name = "Rela_Cli_Devedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Clientes em Aberto";
            this.Load += new System.EventHandler(this.Rela_Cli_Devedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataS.DataSetMercado dataSetMercado;
        private System.Windows.Forms.BindingSource tBLCLIENTEBindingSource;
        private DataS.DataSetMercadoTableAdapters.TBL_CLIENTETableAdapter tBL_CLIENTETableAdapter;
    }
}