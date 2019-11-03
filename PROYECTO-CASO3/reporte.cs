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
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetempleados.PERSONA' Puede moverla o quitarla según sea necesario.
            this.PERSONATableAdapter.Fill(this.DataSetempleados.PERSONA);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
