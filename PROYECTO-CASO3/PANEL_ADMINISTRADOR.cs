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
    public partial class PANEL_ADMINISTRADOR : Form
    {
        public PANEL_ADMINISTRADOR(string nombre)
        {
            InitializeComponent();
            labelmensaje.Text = nombre;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (sidebar.Width == 183)
            {
                sidebar.Visible = false;
                sidebar.Width = 45;
                aside.Width = 70;
                lineasidebar.Width = 20;
                animationsidebar.Show(sidebar);

            }
            else
            {
                sidebar.Visible = false;
                sidebar.Width = 183;
                aside.Width = 220;
                lineasidebar.Width = 146;
                animationsidebar2.Show(sidebar);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBox2.Visible = true;
            pictureBox5.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pictureBox2.Visible = false;
            pictureBox5.Visible = true;
        }

        private void abrirformulariodatospersonales(object formhija)
        {
            if (this.PanelChart.Controls.Count > 0)
                this.PanelChart.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelChart.Controls.Add(fh);
            this.PanelChart.Tag = fh;
            fh.Show();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            abrirformulariodatospersonales(new REGISTRO());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            abrirformulariodatospersonales(new MENU_CARGO());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            abrirformulariodatospersonales(new AGREGAR_USUARIOS());
        }

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"D:\INCOS 2019\PROGRAMACION 3\2DO BIMESTRE\PROYECTO-CASO3\IMG\giphy.gif");
            pictureBox6.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void labelmensaje_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            abrirformulariodatospersonales(new PANEL_REPORTES());
        }

        private void label2_Click(object sender, EventArgs e)
        {

            
        }
    }
}
