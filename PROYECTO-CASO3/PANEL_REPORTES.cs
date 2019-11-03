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
    public partial class PANEL_REPORTES : Form
    {
        public PANEL_REPORTES()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            reporte siguiente = new reporte();
            siguiente.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            REPORTE_HORAS_TRABAJADOS SIGUIENTE = new REPORTE_HORAS_TRABAJADOS();
            SIGUIENTE.Show();
        }
    }
}
