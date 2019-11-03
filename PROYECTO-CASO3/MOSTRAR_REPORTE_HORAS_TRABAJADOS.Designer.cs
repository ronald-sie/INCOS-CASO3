namespace PROYECTO_CASO3
{
    partial class MOSTRAR_REPORTE_HORAS_TRABAJADOS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte_horasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPrincipalReporteHoras = new PROYECTO_CASO3.DataSetPrincipalReporteHoras();
            this.reporte_horasTableAdapter = new PROYECTO_CASO3.DataSetPrincipalReporteHorasTableAdapters.reporte_horasTableAdapter();
            this.TOTAL_HORASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_horasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipalReporteHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOTAL_HORASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.reporte_horasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_CASO3.ReportHorasTrabajados.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(740, 603);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporte_horasBindingSource
            // 
            this.reporte_horasBindingSource.DataMember = "reporte_horas";
            this.reporte_horasBindingSource.DataSource = this.DataSetPrincipalReporteHoras;
            // 
            // DataSetPrincipalReporteHoras
            // 
            this.DataSetPrincipalReporteHoras.DataSetName = "DataSetPrincipalReporteHoras";
            this.DataSetPrincipalReporteHoras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_horasTableAdapter
            // 
            this.reporte_horasTableAdapter.ClearBeforeFill = true;
            // 
            // TOTAL_HORASBindingSource
            // 
            this.TOTAL_HORASBindingSource.DataMember = "TOTAL_HORAS";
            this.TOTAL_HORASBindingSource.DataSource = this.DataSetPrincipalReporteHoras;
            // 
            // MOSTRAR_REPORTE_HORAS_TRABAJADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 603);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MOSTRAR_REPORTE_HORAS_TRABAJADOS";
            this.Text = "MOSTRAR_REPORTE_HORAS_TRABAJADOS";
            this.Load += new System.EventHandler(this.MOSTRAR_REPORTE_HORAS_TRABAJADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporte_horasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPrincipalReporteHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TOTAL_HORASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_horasBindingSource;
        private DataSetPrincipalReporteHoras DataSetPrincipalReporteHoras;
        private DataSetPrincipalReporteHorasTableAdapters.reporte_horasTableAdapter reporte_horasTableAdapter;
        private System.Windows.Forms.BindingSource TOTAL_HORASBindingSource;
    }
}