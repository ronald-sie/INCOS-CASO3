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
    public partial class MODIFICAR_PERSONAL : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;

        public MODIFICAR_PERSONAL()
        {
            InitializeComponent();
        }


        private void ACTIVAR()
        {
            nombre.Enabled = true;
            apmat.Enabled = true;
            appat.Enabled = true;
            ci.Enabled = true;
            ex.Enabled = true;
            fecha.Enabled = true;
            sexo.Enabled = true;
            telefono.Enabled = true;
            celular.Enabled = true;
            cargo.Enabled = true;
            estado_sub.Enabled = true;
            direccion.Enabled = true;
        }
        private void DESACTIVAR()
        {
            nombre.Enabled = false;
            appat.Enabled = false;
            apmat.Enabled = false;
            ci.Enabled = false;
            ex.Enabled = false;
            fecha.Enabled = false;
            sexo.Enabled = false;
            direccion.Enabled = false;
            cargo.Enabled = false;
            estado_sub.Enabled = false;
            telefono.Enabled = false;
            celular.Enabled = false;
        }

        private void LIMPIAR()
        {
            nombre.Clear();
            appat.Clear();
            apmat.Clear();
            ci.Clear();
            ex.Text = "";
            sexo.Text = "SELECCIONE";
            direccion.Clear();
            telefono.Clear();
            celular.Clear();
            sexo.Text = "SELECCIONE";
            estado_sub.Text = "SELECCIONE";
            fecha.Text = "";
            codigo.Clear();
            buscar_modicar.Clear();

        }




        private void MODIFICAR_PERSONAL_Load(object sender, EventArgs e)
        {
            ////USANDO EL DATA SET PARA OPTENER LOS CARGO QUE SE ENCUENTRAN EL LA TABLA CARGO
            SqlDataAdapter c1 = new SqlDataAdapter("select ID_CARGO,NOMBRE_CARGO from CARGO", con);
            DataSet dst = new DataSet();
            c1.Fill(dst, "CARGO");
            cargo.DataSource = dst.Tables["CARGO"];
            cargo.DisplayMember = "NOMBRE_CARGO";
            cargo.ValueMember = "ID_CARGO";
        }

        private void buscar_modificar_boton_Click(object sender, EventArgs e)
        {
            //USANDO EL DATAVIEW PARA LA BUSQUEDA POR ID_PERSONA
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM PERSONA,CARGO where ID_PERSONA='" + buscar_modicar.Text + "'and PERSONA.ID_CARGO=CARGO.ID_CARGO", con);
            DataSet dst = new DataSet();
            dap.Fill(dst);
            DataView dvw = new DataView(dst.Tables[0]);
            codigo.Text = (string)dst.Tables[0].Rows[0][1];
            nombre.Text = (string)dst.Tables[0].Rows[0][2];
            appat.Text = (string)dst.Tables[0].Rows[0][3];
            apmat.Text = (string)dst.Tables[0].Rows[0][4];
            ci.Text = Convert.ToString(dst.Tables[0].Rows[0][5]);
            ex.Text = (string)dst.Tables[0].Rows[0][6];
            direccion.Text = (string)dst.Tables[0].Rows[0][7];
            sexo.Text = (string)dst.Tables[0].Rows[0][8];
            telefono.Text = Convert.ToString(dst.Tables[0].Rows[0][9]);
            celular.Text = Convert.ToString(dst.Tables[0].Rows[0][10]);
            DateTime fecha = DateTime.Parse(dst.Tables[0].Rows[0][11].ToString());
            estado_sub.Text = (string)dst.Tables[0].Rows[0][12];
            cargo.Text = (string)dst.Tables[0].Rows[0]["NOMBRE_CARGO"];
            ACTIVAR();
            actualizar.Enabled = true;
            cancelar.Enabled = true;
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            String ap = appat.Text;
            String am = apmat.Text;
            String codigo;
            codigo = ap.Substring(0, 2) + am.Substring(0, 2) + "-" + ci.Text;
            sql = "UPDATE PERSONA SET  CODIGO='" + codigo + "', NOMBRE='" + nombre.Text + "', APE_PATERNO='" + appat.Text + "', APE_MATERNO='" + apmat.Text + "', CI='" + ci.Text + "', EX='" + ex.Text + "', DIRECION='" + direccion.Text + "',SEXO='" + sexo.Text + "', TELEFONO='" + telefono.Text + "', CELULAR='" + celular.Text + "', FECHA='" + DateTime.Parse(fecha.Text) + "',ESTADO_SUBSIDIO='" + estado_sub.Text + "',ID_CARGO='" + Convert.ToInt32(cargo.SelectedValue) + "'WHERE ID_PERSONA=@codigo";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Add("@Codigo", SqlDbType.NChar).Value = buscar_modicar.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Se actualizo la persona con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DESACTIVAR();
            LIMPIAR();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            DESACTIVAR();
            actualizar.Enabled = false;
            cancelar.Enabled = false;
            buscar_modicar.Clear();
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {
            nombre.Text = nombre.Text.ToUpper();
            nombre.SelectionStart = nombre.TextLength + 1;
        }

        private void appat_TextChanged(object sender, EventArgs e)
        {
            appat.Text = appat.Text.ToUpper();
            appat.SelectionStart = appat.TextLength + 1;
        }

        private void apmat_TextChanged(object sender, EventArgs e)
        {
            apmat.Text = apmat.Text.ToUpper();
            apmat.SelectionStart = apmat.TextLength + 1;
        }

        private void direccion_TextChanged(object sender, EventArgs e)
        {
            direccion.Text = direccion.Text.ToUpper();
            direccion.SelectionStart = direccion.TextLength + 1;
        }
    }
}
