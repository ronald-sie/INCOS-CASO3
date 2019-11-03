namespace PROYECTO_CASO3
{
    partial class MOSTRAR_REPORTE_CANCELACION_SUELDO
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
            this.SUELDO_CANCELARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipalReporteHoras = new PROYECTO_CASO3.DataSetPrincipalReporteHoras();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SUELDO_CANCELARTableAdapter = new PROYECTO_CASO3.DataSetPrincipalReporteHorasTableAdapters.SUELDO_CANCELARTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SUELDO_CANCELARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipalReporteHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // SUELDO_CANCELARBindingSource
            // 
            this.SUELDO_CANCELARBindingSource.DataMember = "SUELDO_CANCELAR";
            this.SUELDO_CANCELARBindingSource.DataSource = this.DataSetPrincipalReporteHoras;
            // 
            // DataSetPrincipalReporteHoras
            // 
            this.DataSetPrincipalReporteHoras.DataSetName = "DataSetPrincipalReporteHoras";
            this.DataSetPrincipalReporteHoras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SUELDO_CANCELARBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_CASO3.MOSTRAR_REPORTE_SUELDO.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // SUELDO_CANCELARTableAdapter
            // 
            this.SUELDO_CANCELARTableAdapter.ClearBeforeFill = true;
            // 
            // MOSTRAR_REPORTE_CANCELACION_SUELDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 479);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MOSTRAR_REPORTE_CANCELACION_SUELDO";
            this.Text = "MOSTRAR_REPORTE_CANCELACION_SUELDO";
            this.Load += new System.EventHandler(this.MOSTRAR_REPORTE_CANCELACION_SUELDO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SUELDO_CANCELARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipalReporteHoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SUELDO_CANCELARBindingSource;
        private DataSetPrincipalReporteHoras DataSetPrincipalReporteHoras;
        private DataSetPrincipalReporteHorasTableAdapters.SUELDO_CANCELARTableAdapter SUELDO_CANCELARTableAdapter;
    }
}