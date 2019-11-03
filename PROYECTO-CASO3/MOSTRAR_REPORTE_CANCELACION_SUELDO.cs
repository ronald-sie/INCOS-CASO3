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
    public partial class MOSTRAR_REPORTE_CANCELACION_SUELDO : Form
    {
        public MOSTRAR_REPORTE_CANCELACION_SUELDO()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }
        public int id { get; set; }

        private void MOSTRAR_REPORTE_CANCELACION_SUELDO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetPrincipalReporteHoras.SUELDO_CANCELAR' Puede moverla o quitarla según sea necesario.
            this.SUELDO_CANCELARTableAdapter.Fill(this.DataSetPrincipalReporteHoras.SUELDO_CANCELAR,fecha,id);

            this.reportViewer1.RefreshReport();
        }
    }
}
