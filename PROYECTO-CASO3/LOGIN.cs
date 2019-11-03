using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_CASO3
{
    public partial class LOGIN : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        

        public void logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT NOMBRE, TIPO_USUARIO ,ID_PERSONA FROM USUARIO WHERE USUARIO = @usuario AND PASSWORD=@pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);


                if (dt.Rows.Count==1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString()=="ADMINISTRADOR")
                    {
                        new PANEL_ADMINISTRADOR(dt.Rows[0][0].ToString()).Show();
                    }
                    else 
                    {
                        new PANEL_USUARIO(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("usuario y contraseña incorrectas");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public LOGIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
        }

       

      
       

        private void button1_Click(object sender, EventArgs e)
        {
            logear(this.bunifuTextbox1.text, this.bunifuTextbox2.text);
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
