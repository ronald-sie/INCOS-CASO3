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
    public partial class REGISTRO_PERSONA : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");
        private string sql;
        private SqlCommand cmd;
        private SqlCommand cmd2;

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
            sexo.Text = "";
            estado_sub.Text = " ";
            fecha.Text = "";

        }

        public REGISTRO_PERSONA()
        {
            InitializeComponent();
        }

        private void REGISTRO_PERSONA_Load(object sender, EventArgs e)
        {

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            ACTIVAR();
            cancelar.Enabled = true;
            guardar.Enabled = true;
            nuevo.Enabled = false;
            ////USANDO EL DATA SET PARA OPTENER LOS CARGO QUE SE ENCUENTRAN EL LA TABLA CARGO
            SqlDataAdapter c1 = new SqlDataAdapter("select ID_CARGO,NOMBRE_CARGO from CARGO", con);
            DataSet dst = new DataSet();
            c1.Fill(dst, "CARGO");
            cargo.DataSource = dst.Tables["CARGO"];
            cargo.DisplayMember = "NOMBRE_CARGO";
            cargo.ValueMember = "ID_CARGO";
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            String ap = appat.Text;
            String am = apmat.Text;
            String codigo;
            int BL = 1;
            codigo = ap.Substring(0, 2) + am.Substring(0, 2) + "-" + ci.Text;
            sql = "INSERT INTO PERSONA(CODIGO,NOMBRE, APE_PATERNO,APE_MATERNO,CI,EX,DIRECION,SEXO,TELEFONO,CELULAR,FECHA,ESTADO_SUBSIDIO,ID_CARGO,DL)" +
                " VALUES ('" + codigo + "','" + nombre.Text + "','" + appat.Text + "','" + apmat.Text + "','" + ci.Text + "','" + ex.Text + "','" + direccion.Text + "','" + sexo.Text + "','" + telefono.Text + "','" + celular.Text + "','" + DateTime.Parse(fecha.Text) + "','" + estado_sub.Text + "','" + Convert.ToInt32(cargo.SelectedValue) + "','" + BL + "')";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            

            string query = "select ID_PERSONA AS LASTID from PERSONA WHERE CI='" + ci.Text + "'";
            SqlCommand command = new SqlCommand(query, con);
            int lastId = Convert.ToInt32(command.ExecuteScalar());

            con.Close();

            //EN UNA VARIABLE ALMACENAMOS LA CLAVE PRIMARIA DEL CLIENTE QUE REGISTRAMOS
            


            string sql2;            
            sql2 = "INSERT INTO USUARIO (NOMBRE,USUARIO,PASSWORD,TIPO_USUARIO,ID_PERSONA) VALUES ('"+nombre.Text+" "+appat.Text+"','"+nombre.Text+"','"+codigo+"','"+cargo.Text+"','"+lastId+"')";
            cmd2 = new SqlCommand(sql2, con);
            cmd2.CommandType = CommandType.Text;
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Los datos fueron guardados con exito!!!", "Datos Guardados...");

            LIMPIAR();
            DESACTIVAR();
            cancelar.Enabled = false;
            guardar.Enabled = false;
            nuevo.Enabled = true;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            DESACTIVAR();
            guardar.Enabled = false;
            cancelar.Enabled = false;
            nuevo.Enabled = true;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
