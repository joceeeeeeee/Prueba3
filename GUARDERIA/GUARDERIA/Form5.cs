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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true");//k

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand
              ("insert into EXPEDIENTE (ID_EXPEDIENTE,ALERGIAS_EXP,MEDICAMENTO_EXP,TRATAMIENTO_EXP,CUIDADO_EXP,DIETA_EXP,TIPO_SANGRE_EXP,EDAD_EXP) values (@ID_EXPEDIENTE,@ALERGIAS_EXP,@MEDICAMENTO_EXP,@TRATAMIENTO_EXP,@CUIDADO_EXP,@DIETA_EXP,@TIPO_SANGRE_EXP,@EDAD_EXP) ", conexion);
            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("ID_EXPEDIENTE", txtcodigo.Text);
            altas.Parameters.AddWithValue("ALERGIAS_EXP", txtalergias.Text);
            altas.Parameters.AddWithValue("MEDICAMENTO_EXP", txtmedicamento.Text);
            altas.Parameters.AddWithValue("TRATAMIENTO_EXP", txttratamiento.Text);
            altas.Parameters.AddWithValue("CUIDADO_EXP", txtcuidado.Text);
            altas.Parameters.AddWithValue("DIETA_EXP", txtdieta.Text);
            altas.Parameters.AddWithValue("TIPO_SANGRE_EXP", txtsangre.Text);
            altas.Parameters.AddWithValue("EDAD_EXP", txtedad.Text);


            conexion.Open();// se abre la conexion

            altas.ExecuteNonQuery();

            conexion.Close();// se cierra la conexion
            MessageBox.Show("SE GUARDARON DATOS DEL EXPEDIENTE");

            // limpiar los textbox
            txtcodigo.Clear();
            txtalergias.Clear();
            txtmedicamento.Clear();
            txttratamiento.Clear();
            txtcuidado.Clear();
            txtdieta.Clear();
            txtsangre.Clear();

            txtedad.Clear();
            txtcodigo.Focus();

            Form5_Load(0, e);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            string consulta = "select * from EXPEDIENTE";

            SqlDataAdapter a = new SqlDataAdapter(consulta, conexion);

            DataTable tabla = new DataTable();
            a.Fill(tabla);
            DataView.DataSource = tabla;
           

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE EXPEDIENTE SET ID_EXPEDIENTE=@ID_EXPEDIENTE,ALERGIAS_EXP=@ALERGIAS_EXP,MEDICAMENTO_EXP=@MEDICAMENTO_EXP,TRATAMIENTO_EXP=@TRATAMIENTO_EXP,CUIDADO_EXP=@CUIDADO_EXP,DIETA_EXP=@DIETA_EXP,TIPO_SANGRE_EXP=@TIPO_SANGRE_EXP,EDAD_EXP=@EDAD_EXP " +
                "WHERE ID_EXPEDIENTE=@ID_EXPEDIENTE", conexion);

            comando.Parameters.AddWithValue("ID_EXPEDIENTE", txtcodigo.Text);
            comando.Parameters.AddWithValue("ALERGIAS_EXP", txtalergias.Text);
            comando.Parameters.AddWithValue("MEDICAMENTO_EXP", txtmedicamento.Text);
            comando.Parameters.AddWithValue("TRATAMIENTO_EXP", txttratamiento.Text);
            comando.Parameters.AddWithValue("CUIDADO_EXP", txtcuidado.Text);
            comando.Parameters.AddWithValue("DIETA_EXP", txtdieta.Text);
            comando.Parameters.AddWithValue("TIPO_SANGRE_EXP", txtsangre.Text);
            comando.Parameters.AddWithValue("EDAD_EXP", txtedad.Text);

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
            Form5_Load(0, e);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string baja = "DELETE FROM EXPEDIENTE WHERE ID_EXPEDIENTE=@ID_EXPEDIENTE";



            SqlCommand cmdIns = new SqlCommand(baja, conexion);


            cmdIns.Parameters.AddWithValue("ID_EXPEDIENTE", txtcodigo.Text);


            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;



            conexion.Close();
            MessageBox.Show("Expediente eliminado");
            Form5_Load(0, e);
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM EXPEDIENTE WHERE ID_EXPEDIENTE=@ID_EXPEDIENTE", conexion);
            conexion.Open();

            consulta.Parameters.AddWithValue("ID_EXPEDIENTE", txtcodigo.Text);

            SqlDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
             
                txtcodigo.Text = reader[0].ToString();
                txtalergias.Text = reader[1].ToString();
                txtmedicamento.Text = reader[2].ToString();
                txttratamiento.Text = reader[3].ToString();
                txtcuidado.Text = reader[4].ToString();
                txtdieta.Text = reader[5].ToString();
                txtsangre.Text = reader[6].ToString();
                txtedad.Text = reader[7].ToString();



            }
            MessageBox.Show("CONSULTA COMPLETA");
            conexion.Close();
           
        }


    }
}
