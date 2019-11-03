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
    public partial class REPORTE_HORAS_TRABAJADOS : Form
    {
        SqlConnection con = BDComun.ObtenerConexion();
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=PROYECTO_PROGRAMACION;Integrated Security=True");

        public REPORTE_HORAS_TRABAJADOS()
        {
            InitializeComponent();
        }

        private void listar_personas_Click(object sender, EventArgs e)
        {
            //BOTON LISTAR USAR EL DATAVIEW USANDO UNA VISTA
            SqlDataAdapter dap = new SqlDataAdapter("SELECT * FROM VISTA_LISTA_PERSONAS", con);
            DataSet dst = new DataSet();
            dap.Fill(dst, "VISTA_LISTA_PERSONAS");
            DataView dvw = new DataView(dst.Tables[0]);
            dataGridView2.DataSource = dvw;
            dataGridView2.DefaultCellStyle.BackColor = Color.Beige;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.CadetBlue;
        }

        private void GENERAR_Click(object sender, EventArgs e)
        {
            MOSTRAR_REPORTE_HORAS_TRABAJADOS MOSTRAR = new MOSTRAR_REPORTE_HORAS_TRABAJADOS();
            MOSTRAR.fecha = DTPFECHA.Value;
            MOSTRAR.id = int.Parse(ID_PERSONA.Text);

            MOSTRAR.Show();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MOSTRAR_REPORTE_CANCELACION_SUELDO MOSTRAR = new MOSTRAR_REPORTE_CANCELACION_SUELDO();
                MOSTRAR.fecha = DTPFECHA.Value;
                MOSTRAR.id = int.Parse(ID_PERSONA.Text);

                MOSTRAR.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("FALTA RELLENAR ALGUN CAMPO");
            }
            
        }

        private void REPORTE_HORAS_TRABAJADOS_Load(object sender, EventArgs e)
        {

        }
    }
}
