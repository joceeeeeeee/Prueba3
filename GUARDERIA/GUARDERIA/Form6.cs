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
namespace GUARDERIA
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true");

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand
             ("insert into SALON(ID_SALON, CAPACIDAD_SAL, DESCRIPCION_SAL) values (@ID_SALON,@CAPACIDAD_SAL,@DESCRIPCION_SAL) ", conexion);
            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("ID_SALON", txtcodigo.Text);
            altas.Parameters.AddWithValue("CAPACIDAD_SAL", txtcapacidad.Text);
            altas.Parameters.AddWithValue("DESCRIPCION_SAL", txtdescripcion.Text);
           


            conexion.Open();// se abre la conexion

            altas.ExecuteNonQuery();

            conexion.Close();// se cierra la conexion
            MessageBox.Show("SE GUARDARON DATOS DEL SALON");

            // limpiar los textbox
            txtcodigo.Clear();
            txtcapacidad.Clear();
            txtdescripcion.Clear();
           
            txtcodigo.Focus();

            Form6_Load(0, e);
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string consulta = "select * from SALON";

            SqlDataAdapter a = new SqlDataAdapter(consulta, conexion);

            DataTable tabla = new DataTable();
            a.Fill(tabla);
            DataView.DataSource = tabla;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
             conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE SALON SET ID_SALON=@ID_SALON, CAPACIDAD_SAL=@CAPACIDAD_SAL, DESCRIPCION_SAL=@DESCRIPCION_SAL " +
                "WHERE ID_SALON=@ID_SALON", conexion);

            
            comando.Parameters.AddWithValue("ID_SALON", txtcodigo.Text);
            comando.Parameters.AddWithValue("CAPACIDAD_SAL", txtcapacidad.Text);
            comando.Parameters.AddWithValue("DESCRIPCION_SAL", txtdescripcion.Text);

            comando.ExecuteNonQuery();



            MessageBox.Show("MODIFICACION COMPLETA");
            conexion.Close();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }

            }
            Form6_Load(0, e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM SALON WHERE ID_SALON=@ID_SALON";



            SqlCommand cmdIns = new SqlCommand(baja, conexion);


            cmdIns.Parameters.Add("ID_SALON", txtcodigo.Text);


            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;



            conexion.Close();
            MessageBox.Show("Salon eliminado");
            Form6_Load(0, e);
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM SALON WHERE ID_SALON=@ID_SALON", conexion);
            conexion.Open();

            consulta.Parameters.AddWithValue("ID_SALON", txtcodigo.Text);

            SqlDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
                txtcodigo.Clear();
                txtcapacidad.Clear();
                txtdescripcion.Clear();


                txtcodigo.Text = reader[0].ToString();
                txtcapacidad.Text = reader[1].ToString();
                txtdescripcion.Text = reader[2].ToString();
               



            }
            MessageBox.Show("CONSULTA COMPLETA");
            conexion.Close();
        }


    }
}
