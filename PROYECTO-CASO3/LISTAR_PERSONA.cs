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
    public partial class LISTAR_PERSONA : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
       // SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");

        public LISTAR_PERSONA()
        {
            InitializeComponent();
        }

        private void listar_personas_Click(object sender, EventArgs e)
        {
            //BOTON LISTAR USAR EL DATAVIEW USANDO UNA VISTA
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM VISTA_LISTA_PERSONAS2", con);
            DataSet dst = new DataSet();
            dap.Fill(dst, "VISTA_LISTA_PERSONAS");
            DataView dvw = new DataView(dst.Tables[0]);
            dataGridView2.DataSource = dvw;
            dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue;
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
