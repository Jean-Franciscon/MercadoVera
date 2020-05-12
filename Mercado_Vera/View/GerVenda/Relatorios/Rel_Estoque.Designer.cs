namespace Mercado_Vera.View.GerVenda.Relatorios
{
    partial class Rel_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rel_Estoque));
            this.tBLPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMercado = new Mercado_Vera.DataS.DataSetMercado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBL_PRODUTOTableAdapter = new Mercado_Vera.DataS.DataSetMercadoTableAdapters.TBL_PRODUTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLPRODUTOBindingSource
            // 
            this.tBLPRODUTOBindingSource.DataMember = "TBL_PRODUTO";
            this.tBLPRODUTOBindingSource.DataSource = this.dataSetMercado;
            // 
            // dataSetMercado
            // 
            this.dataSetMercado.DataSetName = "DataSetMercado";
            this.dataSetMercado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetProds";
            reportDataSource1.Value = this.tBLPRODUTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mercado_Vera.View.GerVenda.Relatorios.Rela_Prod_Estoque.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(787, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tBL_PRODUTOTableAdapter
            // 
            this.tBL_PRODUTOTableAdapter.ClearBeforeFill = true;
            // 
            // Rel_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(851, 489);
            this.Name = "Rel_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Estoque";
            this.Load += new System.EventHandler(this.Rel_Estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLPRODUTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataS.DataSetMercado dataSetMercado;
        private System.Windows.Forms.BindingSource tBLPRODUTOBindingSource;
        private DataS.DataSetMercadoTableAdapters.TBL_PRODUTOTableAdapter tBL_PRODUTOTableAdapter;
    }
}