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
    public partial class AGREGAR_USUARIOS : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;



        public AGREGAR_USUARIOS()
        {
            InitializeComponent();
        }

        private void AGREGAR_USUARIOS_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string nombre, usuario, password,tipo_usuario;
            nombre = this.nombre.Text;
            usuario = this.usuario.Text;
            password = this.password.Text;
            tipo_usuario = this.comboBox1.Text;


            if (nombre!="" || usuario!="" || password!="" || tipo_usuario!="")
            {

                sql = "INSERT INTO USUARIO(NOMBRE,USUARIO,PASSWORD,TIPO_USUARIO)" + " VALUES ('" +nombre + "','" + usuario + "','" + password + "','" + tipo_usuario + "')";
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("REGISTRO EXITOSO");
                con.Close();                
                
            }
            else
            {
                MessageBox.Show("ERROR EN LA VERIFICACION DE LA CONTRASEÑA");
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
