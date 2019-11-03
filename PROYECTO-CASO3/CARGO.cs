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
    public partial class CARGO : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;


        private void LIMPIAR()
        {
            nombre_cargo.Text="";
            descripcion.Text = "";
            sueldo_fijo.Value = 0;
        }



        public CARGO()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            nombre_cargo.Enabled = true;
            descripcion.Enabled = true;
            sueldo_fijo.Enabled = true;
            cancelar.Enabled = true;
            guardar.Enabled = true;
            nuevo.Enabled = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ////USANDO EL QUERY PARA REGISTRAR A LA PERSONA
            sql = "INSERT INTO CARGO(NOMBRE_CARGO,DESCRIPCION,SUELDO_FIJO)" +
                " VALUES ('" + nombre_cargo.Text + "','" + descripcion.Text + "','" + sueldo_fijo.Text + "')";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("El nuevo cargo se guardados con exito!!!", "Datos Guardados...");
            con.Close();
            nombre_cargo.Enabled = false;
            descripcion.Enabled = false;
            sueldo_fijo.Enabled = false;
            nuevo.Enabled = true;
            cancelar.Enabled = false;
            guardar.Enabled = false;
            LIMPIAR();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            nombre_cargo.Enabled = false;
            descripcion.Enabled = false;
            sueldo_fijo.Enabled = false;
            nuevo.Enabled = true;
            cancelar.Enabled = false;
            guardar.Enabled = false;
        }

        private void nombre_cargo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
