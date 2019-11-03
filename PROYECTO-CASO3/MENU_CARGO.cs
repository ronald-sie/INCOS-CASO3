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
    public partial class MENU_CARGO : Form
    {
        public MENU_CARGO()
        {
            InitializeComponent();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            CARGO SIGUIENTE = new CARGO();
            SIGUIENTE.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            MODIFICAR_CARGO SIGUIENTE = new MODIFICAR_CARGO();
            SIGUIENTE.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            LISTAR_CARGO SIGUIENTE = new LISTAR_CARGO();
            SIGUIENTE.Show();
        }
    }
}
