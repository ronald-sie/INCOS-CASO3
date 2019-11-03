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
    public partial class LISTAR_CARGO : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;
        public LISTAR_CARGO()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlDataReader drd;
            sql = "SELECT * FROM CARGO";
            cmd = new SqlCommand(sql, con);
            cmd.CommandText = "SELECT * FROM CARGO ";
            dataGridView1.Rows.Clear();
            con.Open();
            drd = cmd.ExecuteReader();
            while (drd.Read())
            {
                dataGridView1.Rows.Add(drd[0], drd[1], drd[2], drd[3]);
            }

            drd.Close();
            con.Close();
        }
    }
}
