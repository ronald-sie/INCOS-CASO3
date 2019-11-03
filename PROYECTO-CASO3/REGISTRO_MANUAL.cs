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
    public partial class REGISTRO_MANUAL : Form
    {

        SqlConnection con = BDComun.ObtenerConexion();

        private string sql;
        private SqlCommand cmd;
        private string sql2;
        private SqlCommand cmd2;



        public REGISTRO_MANUAL()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            string hora, fecha;
            int codigo;
            codigo = int.Parse(bunifuMaterialTextbox1.Text);
            hora = DateTime.Now.ToLongTimeString();
            fecha = DateTime.Now.ToShortDateString();

            con.Open();
            string query = "SELECT TOP 1 P.ID_PERSONA FROM PERSONA P INNER JOIN HORARIO H ON(P.ID_PERSONA = H.ID_PERSONA) WHERE CI = '"+codigo+"'"; 
            SqlCommand command = new SqlCommand(query, con);
            int lastId = Convert.ToInt32(command.ExecuteScalar());
            con.Close();
            


            sql2 = "INSERT INTO HORARIO (HORA_ENTRADA,FECHA,ID_PERSONA)" + " VALUES ('" + hora + "','" + fecha + "','" + lastId.ToString() + "')";
            cmd2 = new SqlCommand(sql2, con);
            cmd2.CommandType = CommandType.Text;
            con.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("MARCACION HORARIO DE ENTRADA EXITOSO");
            con.Close();

            bunifuMaterialTextbox1.Text = "";
            bunifuMaterialTextbox1.Focus();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
            




            
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string hora, fecha;
                int codigo;
                codigo = int.Parse(bunifuMaterialTextbox1.Text);
                hora = DateTime.Now.ToLongTimeString();
                fecha = DateTime.Now.ToShortDateString();


                con.Open();


                string query2 = "SELECT TOP 1 P.ID_PERSONA FROM PERSONA P INNER JOIN HORARIO H ON(P.ID_PERSONA = H.ID_PERSONA) WHERE CI = '" + codigo + "'";
                SqlCommand command2 = new SqlCommand(query2, con);
                int lastId2 = Convert.ToInt32(command2.ExecuteScalar());
                con.Close();

                con.Open();
                //ALMACENAMOS EN UNA VARIABLE LASRID  EL ULTIMO ID_HORARIO PARA PODER LUEGO ACTUALIZAR EL HORARION DE SALIDA
                string query = "SELECT TOP 1 ID_HORARIO AS LASTID from HORARIO WHERE ID_PERSONA='" + lastId2 + "' ORDER BY ID_HORARIO DESC";
                SqlCommand command = new SqlCommand(query, con);
                int lastId = Convert.ToInt32(command.ExecuteScalar());
                con.Close();




                sql = "UPDATE HORARIO SET HORA_SALIDA = '" + hora + "' WHERE ID_HORARIO='" + lastId + "' ";
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("MARCACION HORARIO DE SALIDA EXITOSO");
                con.Close();
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.Focus();
            }
            catch (Exception eRROR)
            {
                MessageBox.Show("ERROR" + eRROR);
            }
        }

        private void REGISTRO_MANUAL_Load(object sender, EventArgs e)
        {

        }
    }
}
