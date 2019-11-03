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
    public partial class MODIFICAR_CARGO : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;



        public MODIFICAR_CARGO()
        {
            InitializeComponent();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            ///USANDO EL QUERY PARA MODIFICAR LOS DATOS DEL CARGO
            sql = "UPDATE CARGO SET NOMBRE_CARGO='" + nombre_cargo.Text + "',DESCRIPCION='" + descripcion.Text + "',SUELDO_FIJO='" + Convert.ToInt32(sueldo_fijo.Text) + "'WHERE ID_CARGO=@codigo";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@Codigo", SqlDbType.NChar).Value = buscar_modicar_cargo.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Se actualizo el registro con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nombre_cargo.Enabled = false;
            descripcion.Enabled = false;
            sueldo_fijo.Enabled = false;
            cancelar.Enabled = false;
            actualizar.Enabled = false;
            nombre_cargo.Text = "";
            descripcion.Text = "";
            sueldo_fijo.Value = 0;
            buscar_modicar_cargo.Text = "";
        }
        private void LIMPIAR()
        {
            nombre_cargo.Text="";
            descripcion.Text="";
            sueldo_fijo.Value = 0;
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            nombre_cargo.Enabled = false;
            descripcion.Enabled = false;
            sueldo_fijo.Enabled = false;
            cancelar.Enabled = false;
            buscar_modicar_cargo.Clear();
        }

        private void buscar_modificar_cargo_Click(object sender, EventArgs e)
        {
            //USANDO EL DATAVIEW PARA MOSTRAR LA BUSQUEDA MEDIANTE EL CARGO
            SqlDataAdapter dap = new SqlDataAdapter("select *  from CARGO where ID_CARGO=" + buscar_modicar_cargo.Text, con);
            DataSet dst = new DataSet();
            dap.Fill(dst);
            DataView dvw = new DataView(dst.Tables[0]);
            nombre_cargo.Text = (string)dst.Tables[0].Rows[0][1];
            descripcion.Text = (string)dst.Tables[0].Rows[0][2];
            sueldo_fijo.Text = Convert.ToString(dst.Tables[0].Rows[0][3]);
            nombre_cargo.Enabled = true;
            descripcion.Enabled = true;
            sueldo_fijo.Enabled = true;
            cancelar.Enabled = true;
            actualizar.Enabled = true;
        }

        private void nombre_cargo_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nombre_cargo_TextChanged(object sender, EventArgs e)
        {
            //MUESTRA EN MAYUSCULAS
            nombre_cargo.Text = nombre_cargo.Text.ToUpper();
            nombre_cargo.SelectionStart = nombre_cargo.TextLength + 1;
        }

        private void descripcion_TextChanged(object sender, EventArgs e)
        {
            descripcion.Text = descripcion.Text.ToUpper();
            descripcion.SelectionStart = descripcion.TextLength + 1;
        }

        private void buscar_modicar_cargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MODIFICAR_CARGO_Load(object sender, EventArgs e)
        {

        }
    }
}
