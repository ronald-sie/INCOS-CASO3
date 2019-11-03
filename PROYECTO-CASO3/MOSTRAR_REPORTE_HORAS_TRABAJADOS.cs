using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_CASO3
{
    public partial class MOSTRAR_REPORTE_HORAS_TRABAJADOS : Form
    {
        public MOSTRAR_REPORTE_HORAS_TRABAJADOS()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }
        public int id { get; set; }

        private void MOSTRAR_REPORTE_HORAS_TRABAJADOS_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipalReporteHoras.reporte_horas' Puede moverla o quitarla según sea necesario.
            this.reporte_horasTableAdapter.Fill(this.DataSetPrincipalReporteHoras.reporte_horas,fecha,id);

            this.reportViewer1.RefreshReport();
        }
    }
}
