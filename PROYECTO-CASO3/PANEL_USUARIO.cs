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
    public partial class PANEL_USUARIO : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;

        private string sql2;
        private SqlCommand cmd2;

        private string sql3;
        private SqlCommand cmd3;
        public PANEL_USUARIO( string nombre, string codigo)
        {
            InitializeComponent();
            labelmensaje.Text = nombre;
            label2.Text = codigo;
        }

        private void PANEL_USUARIO_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string hora, fecha;
            int codigo;
            codigo = int.Parse(label2.Text);
            hora = DateTime.Now.ToLongTimeString();
            fecha = DateTime.Now.ToShortDateString();


            sql = "INSERT INTO ENTRADA (HORA,FECHA,ID_PERSONA)" + " VALUES ('" + hora + "','" + fecha + "','" + codigo + "')";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            sql2 = "INSERT INTO HORARIO (HORA_ENTRADA,FECHA,ID_PERSONA)" + " VALUES ('" + hora + "','" + fecha + "','" + codigo + "')";
            cmd2 = new SqlCommand(sql2, con);
            cmd2.CommandType = CommandType.Text;
            con.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("MARCACION HORARIO DE ENTRADA EXITOSO");
            con.Close();



            bunifuFlatButton1.Enabled = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            string hora, fecha, codigo;
            codigo = label2.Text;
            hora = DateTime.Now.ToLongTimeString();
            fecha = DateTime.Now.ToShortDateString();




            sql = "INSERT INTO SALIDA (HORA,FECHA,ID_PERSONA)" + " VALUES ('" + hora + "','" + fecha + "','" + codigo + "')";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();


            //ALMACENAMOS EN UNA VARIABLE LASRID  EL ULTIMO ID_HORARIO PARA PODER LUEGO ACTUALIZAR EL HORARION DE SALIDA
            string query = "SELECT TOP 1 ID_HORARIO AS LASTID from HORARIO WHERE ID_PERSONA='" + codigo+ "' ORDER BY ID_HORARIO DESC";
            SqlCommand command = new SqlCommand(query, con);
            int lastId = Convert.ToInt32(command.ExecuteScalar());


            con.Close();



           
            sql3 = "UPDATE HORARIO SET HORA_SALIDA = '"+hora+"' WHERE ID_HORARIO='"+lastId+ "' ";
            cmd3 = new SqlCommand(sql3, con);
            cmd3.CommandType = CommandType.Text;
            con.Open();
            cmd3.ExecuteNonQuery();
            MessageBox.Show("MARCACION HORARIO DE SALIDA EXITOSO");
            con.Close();



            bunifuFlatButton2.Enabled = false;
        }
    }
}
