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
    //prueba
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true");

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand
               ("insert into TUTOR (ID_TUTOR,NOMBRE_TUT,OCUPACION_TUT,TELEFONO_TUT,EDAD_TUT,DIRECCION_TUT) values (@ID_TUTOR,@NOMBRE_TUT,@OCUPACION_TUT,@TELEFONO_TUT,@EDAD_TUT,@DIRECCION_TUT) ", conexion);
            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("ID_TUTOR", txtcodigo.Text);
            altas.Parameters.AddWithValue("NOMBRE_TUT", txtnombre.Text);
            altas.Parameters.AddWithValue("OCUPACION_TUT", txtocupacion.Text);
            altas.Parameters.AddWithValue("TELEFONO_TUT", txttelefono.Text);
            altas.Parameters.AddWithValue("EDAD_TUT", txtedad.Text);
            altas.Parameters.AddWithValue("DIRECCION_TUT", txtdireccion.Text);
          
            conexion.Open();// se abre la conexion

            altas.ExecuteNonQuery();

            conexion.Close();// se cierra la conexion
            MessageBox.Show("SE GUARDARON DATOS DEL TUTOR");

            // limpiar los textbox
            txtcodigo.Clear();
            txtnombre.Clear();
            txtocupacion.Clear();
            txttelefono.Clear();
            txtedad.Clear();
            txtdireccion.Clear();
            txtcodigo.Focus();

            Form4_Load(0, e);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string consulta = "select * from TUTOR";

            SqlDataAdapter a = new SqlDataAdapter(consulta, conexion);

            DataTable tabla = new DataTable();
            a.Fill(tabla);
            DataView.DataSource = tabla;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE TUTOR SET ID_TUTOR=@ID_TUTOR,NOMBRE_TUT=@NOMBRE_TUT,OCUPACION_TUT=@OCUPACION_TUT,TELEFONO_TUT=@TELEFONO_TUT,EDAD_TUT=@EDAD_TUT,DIRECCION_TUT=@DIRECCION_TUT " +
                "WHERE ID_TUTOR=@ID_TUTOR", conexion);






         
            comando.Parameters.AddWithValue("ID_TUTOR", txtcodigo.Text);
            comando.Parameters.AddWithValue("NOMBRE_TUT", txtnombre.Text);
            comando.Parameters.AddWithValue("OCUPACION_TUT", txtocupacion.Text);
            comando.Parameters.AddWithValue("TELEFONO_TUT", txttelefono.Text);
            comando.Parameters.AddWithValue("EDAD_TUT", txtedad.Text);
            comando.Parameters.AddWithValue("DIRECCION_TUT", txtdireccion.Text);

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
            Form4_Load(0, e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM TUTOR WHERE ID_TUTOR=@ID_TUTOR";



            SqlCommand cmdIns = new SqlCommand(baja, conexion);


            cmdIns.Parameters.Add("ID_TUTOR", txtcodigo.Text);


            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;



            conexion.Close();
            MessageBox.Show("Tutor eliminado");
            Form4_Load(0, e);
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM TUTOR WHERE ID_TUTOR=@ID_TUTOR", conexion);
            conexion.Open();

            consulta.Parameters.AddWithValue("ID_TUTOR", txtcodigo.Text);

            SqlDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
         

                txtcodigo.Text = reader[0].ToString();
                txtnombre.Text = reader[1].ToString();
                txtocupacion.Text = reader[2].ToString();
                txttelefono.Text = reader[3].ToString();
                txtedad.Text = reader[4].ToString();
                txtdireccion.Text = reader[5].ToString();
                

            }
            MessageBox.Show("CONSULTA COMPLETA");
            conexion.Close();
        }


    }
}
