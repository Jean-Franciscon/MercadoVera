namespace Mercado_Vera.View.GerVenda
{
    partial class Rel_Fechamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rel_Fechamento));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetMercado = new Mercado_Vera.DataS.DataSetMercado();
            this.tBLFECHAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_FECHAMENTOTableAdapter = new Mercado_Vera.DataS.DataSetMercadoTableAdapters.TBL_FECHAMENTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFECHAMENTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFecha";
            reportDataSource1.Value = this.tBLFECHAMENTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mercado_Vera.View.GerVenda.Rela_Fechamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(647, 261);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dataSetMercado
            // 
            this.dataSetMercado.DataSetName = "DataSetMercado";
            this.dataSetMercado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLFECHAMENTOBindingSource
            // 
            this.tBLFECHAMENTOBindingSource.DataMember = "TBL_FECHAMENTO";
            this.tBLFECHAMENTOBindingSource.DataSource = this.dataSetMercado;
            // 
            // tBL_FECHAMENTOTableAdapter
            // 
            this.tBL_FECHAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // Rel_Fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 261);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(663, 335);
            this.Name = "Rel_Fechamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fechamento de Caixa";
            this.Load += new System.EventHandler(this.Rel_Fechamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMercado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFECHAMENTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataS.DataSetMercado dataSetMercado;
        private System.Windows.Forms.BindingSource tBLFECHAMENTOBindingSource;
        private DataS.DataSetMercadoTableAdapters.TBL_FECHAMENTOTableAdapter tBL_FECHAMENTOTableAdapter;
    }
}