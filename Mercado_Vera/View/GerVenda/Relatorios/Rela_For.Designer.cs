namespace Mercado_Vera.View.GerVenda.Relatorios
{
    partial class Rela_For
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rela_For));
            this.tBLFORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMercado = new Mercado_Vera.DataS.DataSetMercado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBL_FORNECEDORTableAdapter = new Mercado_Vera.DataS.DataSetMercadoTableAdapters.TBL_FORNECEDORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLFORNECEDORBindingSource
            // 
            this.tBLFORNECEDORBindingSource.DataMember = "TBL_FORNECEDOR";
            this.tBLFORNECEDORBindingSource.DataSource = this.dataSetMercado;
            // 
            // dataSetMercado
            // 
            this.dataSetMercado.DataSetName = "DataSetMercado";
            this.dataSetMercado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFor";
            reportDataSource1.Value = this.tBLFORNECEDORBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mercado_Vera.View.GerVenda.Relatorios.Rela_Fornecedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(550, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tBL_FORNECEDORTableAdapter
            // 
            this.tBL_FORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // Rela_For
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(584, 489);
            this.Name = "Rela_For";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Fornecedores Cadastrados";
            this.Load += new System.EventHandler(this.Rela_For_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLFORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataS.DataSetMercado dataSetMercado;
        private System.Windows.Forms.BindingSource tBLFORNECEDORBindingSource;
        private DataS.DataSetMercadoTableAdapters.TBL_FORNECEDORTableAdapter tBL_FORNECEDORTableAdapter;
    }
}