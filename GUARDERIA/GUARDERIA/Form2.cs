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
    public partial class Form2 : Form
    {

        public void InsertarEmpleado(string codigo, string nombre, string especialidad, string rfc, int edad, string curp, decimal salario, string puesto, string telefono, string direccion, string horario)
        {
            //bloque try
            try
            {
                // Lógica de inserción en la base de datos
                SqlCommand altas = new SqlCommand
                    ("INSERT INTO EMPLEADO (ID_EMPLEADO, NOMBRE_EMP, ESPECIALIDAD_EMP, RFC_EMP, EDAD_EMP, CURP_EMP, SALARIO_EMP, PUESTO_EMP, TELEFONO_EMP, DIRECCION_EMP, HORARIO_EMP) " +
                     "VALUES (@ID_EMPLEADO, @NOMBRE_EMP, @ESPECIALIDAD_EMP, @RFC_EMP, @EDAD_EMP, @CURP_EMP, @SALARIO_EMP, @PUESTO_EMP, @TELEFONO_EMP, @DIRECCION_EMP, @HORARIO_EMP)", conexion);
                //prueba
                altas.Parameters.AddWithValue("@ID_EMPLEADO", codigo);
                altas.Parameters.AddWithValue("@NOMBRE_EMP", nombre);
                altas.Parameters.AddWithValue("@ESPECIALIDAD_EMP", especialidad);
                altas.Parameters.AddWithValue("@RFC_EMP", rfc);
                altas.Parameters.AddWithValue("@EDAD_EMP", edad);
                altas.Parameters.AddWithValue("@CURP_EMP", curp);
                altas.Parameters.AddWithValue("@SALARIO_EMP", salario);
                altas.Parameters.AddWithValue("@PUESTO_EMP", puesto);
                altas.Parameters.AddWithValue("@TELEFONO_EMP", telefono);
                altas.Parameters.AddWithValue("@DIRECCION_EMP", direccion);
                altas.Parameters.AddWithValue("@HORARIO_EMP", horario);

                conexion.Open();
                altas.ExecuteNonQuery();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al insertar el empleado en la base de datos:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true");
        public class Empleado
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Puesto { get; set; }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlCommand altas = new SqlCommand
                ("insert into EMPLEADO (ID_EMPLEADO,NOMBRE_EMP,ESPECIALIDAD_EMP,RFC_EMP,EDAD_EMP,CURP_EMP,SALARIO_EMP,PUESTO_EMP,TELEFONO_EMP,DIRECCION_EMP,HORARIO_EMP) values(@ID_EMPLEADO,@NOMBRE_EMP,@ESPECIALIDAD_EMP,@RFC_EMP,@EDAD_EMP,@CURP_EMP,@SALARIO_EMP,@PUESTO_EMP,@TELEFONO_EMP,@DIRECCION_EMP,@HORARIO_EMP) ", conexion);
            // se pasan los valores de los text box a las variables temporales
            altas.Parameters.AddWithValue("ID_EMPLEADO", txtcodigo.Text);
            altas.Parameters.AddWithValue("NOMBRE_EMP", txtnombre.Text);
            altas.Parameters.AddWithValue("ESPECIALIDAD_EMP", txtespecialidad.Text);
            altas.Parameters.AddWithValue("RFC_EMP", txtrfc.Text);
            altas.Parameters.AddWithValue("EDAD_EMP", txtedad.Text);
            altas.Parameters.AddWithValue("CURP_EMP", txtcurp.Text);
            altas.Parameters.AddWithValue("SALARIO_EMP", txtsalario.Text);
            altas.Parameters.AddWithValue("PUESTO_EMP", txtpuesto.Text);
            altas.Parameters.AddWithValue("TELEFONO_EMP", txttelefono.Text);
            altas.Parameters.AddWithValue("DIRECCION_EMP", txtdireccion.Text);
            altas.Parameters.AddWithValue("HORARIO_EMP", txthorario.Text);
            conexion.Open();// se abre la conexion

            altas.ExecuteNonQuery();

            conexion.Close();// se cierra la conexion
            MessageBox.Show("SE GUARDARON DATOS DE EMPLEADO");

            // limpiar los textbox
            txtcodigo.Clear();
            txtnombre.Clear();
            txtespecialidad.Clear();
            txtrfc.Clear();
            txtedad.Clear();
            txtcurp.Clear();
            txtsalario.Clear();
            txtpuesto.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txthorario.Clear();
            txtcodigo.Focus();

            var empleado = new Empleado
            {
                Nombre = txtnombre.Text,
                Edad = int.Parse(txtedad.Text),
                Puesto = txtpuesto.Text
            };

            var repo = new EmpleadoRepository(); // conexión interna
            repo.InsertarEmpleado(empleado);

            Form2_Load(0, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string consulta = "select * from EMPLEADO";

            SqlDataAdapter a = new SqlDataAdapter(consulta, conexion);

            DataTable tabla = new DataTable();
            a.Fill(tabla);
            DataView.DataSource = tabla;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE EMPLEADO SET ID_EMPLEADO=@ID_EMPLEADO,NOMBRE_EMP=@NOMBRE_EMP,ESPECIALIDAD_EMP=@ESPECIALIDAD_EMP,RFC_EMP=@RFC_EMP,EDAD_EMP=@EDAD_EMP,CURP_EMP=@CURP_EMP,SALARIO_EMP=@SALARIO_EMP,PUESTO_EMP=@PUESTO_EMP,TELEFONO_EMP=@TELEFONO_EMP,DIRECCION_EMP=@DIRECCION_EMP,HORARIO_EMP=@HORARIO_EMP " +
                "WHERE ID_EMPLEADO=@ID_EMPLEADO", conexion);






            comando.Parameters.AddWithValue("ID_EMPLEADO", txtcodigo.Text);
            comando.Parameters.AddWithValue("NOMBRE_EMP", txtnombre.Text);
            comando.Parameters.AddWithValue("ESPECIALIDAD_EMP", txtespecialidad.Text);
            comando.Parameters.AddWithValue("RFC_EMP", txtrfc.Text);
            comando.Parameters.AddWithValue("EDAD_EMP", txtedad.Text);
            comando.Parameters.AddWithValue("CURP_EMP", txtcurp.Text);
            comando.Parameters.AddWithValue("SALARIO_EMP", txtsalario.Text);
            comando.Parameters.AddWithValue("PUESTO_EMP", txtpuesto.Text);
            comando.Parameters.AddWithValue("TELEFONO_EMP", txttelefono.Text);
            comando.Parameters.AddWithValue("DIRECCION_EMP", txtdireccion.Text);
            comando.Parameters.AddWithValue("HORARIO_EMP", txthorario.Text);

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
            Form2_Load(0, e);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand("SELECT * FROM EMPLEADO WHERE ID_EMPLEADO=@ID_EMPLEADO", conexion);
            conexion.Open();


            consulta.Parameters.AddWithValue("ID_EMPLEADO", txtcodigo.Text);

            SqlDataReader reader = consulta.ExecuteReader();
            while (reader.Read())
            {
             


                txtcodigo.Text = reader[0].ToString();
                txtnombre.Text = reader[1].ToString();
                txtespecialidad.Text = reader[2].ToString();
                txtrfc.Text = reader[3].ToString();
                txtedad.Text = reader[4].ToString();
                txtcurp.Text = reader[5].ToString();
                txtsalario.Text = reader[6].ToString();
                txtpuesto.Text = reader[7].ToString();
                txttelefono.Text = reader[8].ToString();
                txtdireccion.Text = reader[9].ToString();
                txthorario.Text = reader[10].ToString();

            }
            MessageBox.Show("CONSULTA COMPLETA");
            conexion.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //prueba

            conexion.Open();
            string baja = "DELETE FROM EMPLEADO WHERE ID_EMPLEADO=@ID_EMPLEADO";



            SqlCommand cmdIns = new SqlCommand(baja, conexion);


            cmdIns.Parameters.AddWithValue("ID_EMPLEADO", txtcodigo.Text);


            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;


            conexion.Close();
            MessageBox.Show("Empleado eliminado");

            Form2_Load(0, e);
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
