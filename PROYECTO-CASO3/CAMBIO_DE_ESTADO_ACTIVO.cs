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
    public partial class CAMBIO_DE_ESTADO_ACTIVO : Form
    {
        DataSet resultado = new DataSet();
        DataView mifiltro;
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string Codigo;
        private string sql;
        private SqlCommand cmd;
        public CAMBIO_DE_ESTADO_ACTIVO()
        {
            InitializeComponent();
        }

        private void CAMBIO_DE_ESTADO_ACTIVO_Load(object sender, EventArgs e)
        {
            this.leer_datos("SELECT * FROM PERSONA WHERE DL=0 ", ref resultado, "PERSONA");
            this.mifiltro = ((DataTable)resultado.Tables["PERSONA"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
        }

        public void leer_datos(string query, ref DataSet dataGridView1, string tabla)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dataGridView1, tabla);
                da.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void eliminar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.eliminar.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(NOMBRE LIKE '%" + palabra + "%' OR CODIGO LIKE '%" + palabra + "%')";

                }
                else
                {
                    salida_datos += "AND(NOMBRE LIKE '%" + palabra + "%'OR CODIGO LIKE '%" + palabra + "%')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

            //Supongamos que tengo el campo nombre en mi DataGridView
            Codigo = Convert.ToString(fila.Cells["ID_PERSONA"].Value);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ///USANDO EL QUERY PARA MODIFICAR LOS DATOS DEL CARGO
            int DL = 1;
            sql = "UPDATE PERSONA SET DL='" + DL + "'WHERE ID_PERSONA=@codigo";
            //"INSERT INTO DESEMPLEADOS(FECHA,DESCRIPCION, ID_PERSONA) VALUES ('" + DateTime.Parse(fecha) + "','" + descripcion + "','" + Codigo + "')"; 
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@Codigo", SqlDbType.NChar).Value = Codigo;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Se actualizo el registro con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bunifuFlatButton1.Enabled = false;
            dataGridView1.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
