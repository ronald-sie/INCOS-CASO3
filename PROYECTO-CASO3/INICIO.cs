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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INICIO_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            video_tutorial siguiente = new video_tutorial();
            siguiente.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            LOGIN SIGUIENTE = new LOGIN();
            SIGUIENTE.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            REGISTRO_MANUAL SIGUIENTE = new REGISTRO_MANUAL();
            SIGUIENTE.Show();
        }
    }
}
