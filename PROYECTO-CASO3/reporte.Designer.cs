namespace PROYECTO_CASO3
{
    partial class reporte
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PERSONABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetempleados = new PROYECTO_CASO3.DataSetempleados();
            this.PERSONATableAdapter = new PROYECTO_CASO3.DataSetempleadosTableAdapters.PERSONATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PERSONABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetempleados)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PERSONABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_CASO3.Reportempleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1011, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // PERSONABindingSource
            // 
            this.PERSONABindingSource.DataMember = "PERSONA";
            this.PERSONABindingSource.DataSource = this.DataSetempleados;
            // 
            // DataSetempleados
            // 
            this.DataSetempleados.DataSetName = "DataSetempleados";
            this.DataSetempleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PERSONATableAdapter
            // 
            this.PERSONATableAdapter.ClearBeforeFill = true;
            // 
            // reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 490);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reporte";
            this.Load += new System.EventHandler(this.reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PERSONABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetempleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PERSONABindingSource;
        private DataSetempleados DataSetempleados;
        private DataSetempleadosTableAdapters.PERSONATableAdapter PERSONATableAdapter;
    }
}