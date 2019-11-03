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
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            REGISTRO_PERSONA SIGUIENTE = new REGISTRO_PERSONA();
            SIGUIENTE.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            MODIFICAR_PERSONAL SIGUIENTE = new MODIFICAR_PERSONAL();
            SIGUIENTE.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            LISTAR_PERSONA SIGUIENTE = new LISTAR_PERSONA();
            SIGUIENTE.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            CAMBIO_DE_ESTADO SIGUIENTE = new CAMBIO_DE_ESTADO();
            SIGUIENTE.Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            CAMBIO_DE_ESTADO_ACTIVO SIGUIENTE = new CAMBIO_DE_ESTADO_ACTIVO();
            SIGUIENTE.Show();
        }
    }
}
