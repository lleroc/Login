
namespace Login.Views.Bodega
{
    partial class frm_reportes_bodega
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsTodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsProductos = new Login.Reportes.DsProductos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsTodosTableAdapter = new Login.Reportes.DsProductosTableAdapters.DsTodosTableAdapter();
            this.dSUnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSUnoTableAdapter = new Login.Reportes.DsProductosTableAdapters.DSUnoTableAdapter();
            this.lstFiltro = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsTodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSUnoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsTodosBindingSource
            // 
            this.dsTodosBindingSource.DataMember = "DsTodos";
            this.dsTodosBindingSource.DataSource = this.dsProductos;
            // 
            // dsProductos
            // 
            this.dsProductos.DataSetName = "DsProductos";
            this.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.dSUnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Login.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsTodosTableAdapter
            // 
            this.dsTodosTableAdapter.ClearBeforeFill = true;
            // 
            // dSUnoBindingSource
            // 
            this.dSUnoBindingSource.DataMember = "DSUno";
            this.dSUnoBindingSource.DataSource = this.dsProductos;
            // 
            // dSUnoTableAdapter
            // 
            this.dSUnoTableAdapter.ClearBeforeFill = true;
            // 
            // lstFiltro
            // 
            this.lstFiltro.FormattingEnabled = true;
            this.lstFiltro.ItemHeight = 16;
            this.lstFiltro.Location = new System.Drawing.Point(866, 55);
            this.lstFiltro.Name = "lstFiltro";
            this.lstFiltro.Size = new System.Drawing.Size(245, 180);
            this.lstFiltro.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(897, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cargar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_reportes_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstFiltro);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_reportes_bodega";
            this.Text = "frm_reportes_bodega";
            this.Load += new System.EventHandler(this.frm_reportes_bodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsTodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSUnoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DsProductos dsProductos;
        private System.Windows.Forms.BindingSource dsTodosBindingSource;
        private Reportes.DsProductosTableAdapters.DsTodosTableAdapter dsTodosTableAdapter;
        private System.Windows.Forms.BindingSource dSUnoBindingSource;
        private Reportes.DsProductosTableAdapters.DSUnoTableAdapter dSUnoTableAdapter;
        private System.Windows.Forms.ListBox lstFiltro;
        private System.Windows.Forms.Button button1;
    }
}