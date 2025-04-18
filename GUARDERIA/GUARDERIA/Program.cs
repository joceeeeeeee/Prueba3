using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GUARDERIA
{
    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }


    }
    public class EmpleadoService
    {
        private readonly string connectionString;

        public EmpleadoService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AltaEmpleado(int idEmpleado, string nombreEmpleado, string especialidad, string rfc, int edad, string curp, float salario, string puesto, string telefono, string direccion, string horario)
        {
            if (idEmpleado <= 0 || string.IsNullOrEmpty(nombreEmpleado) || string.IsNullOrEmpty(especialidad) || string.IsNullOrEmpty(rfc))
            {
                throw new ArgumentException("Los valores de los campos no pueden ser nulos o vacíos.");
            }

            // Insertar el nuevo empleado en la base de datos
            using (SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true"))
            {
                try
                {
                    conexion.Open();
                    string query = @"
                    INSERT INTO EMPLEADO 
                    (ID_EMPLEADO, NOMBRE_EMP, ESPECIALIDAD_EMP, RFC_EMP, EDAD_EMP, CURP_EMP, SALARIO_EMP, PUESTO_EMP, TELEFONO_EMP, DIRECCION_EMP, HORARIO_EMP) 
                    VALUES 
                    (@ID_EMPLEADO, @NOMBRE_EMP, @ESPECIALIDAD_EMP, @RFC_EMP, @EDAD_EMP, @CURP_EMP, @SALARIO_EMP, @PUESTO_EMP, @TELEFONO_EMP, @DIRECCION_EMP, @HORARIO_EMP)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@ID_EMPLEADO", idEmpleado);
                        comando.Parameters.AddWithValue("@NOMBRE_EMP", nombreEmpleado);
                        comando.Parameters.AddWithValue("@ESPECIALIDAD_EMP", especialidad);
                        comando.Parameters.AddWithValue("@RFC_EMP", rfc);
                        comando.Parameters.AddWithValue("@EDAD_EMP", edad);
                        comando.Parameters.AddWithValue("@CURP_EMP", curp);
                        comando.Parameters.AddWithValue("@SALARIO_EMP", salario);
                        comando.Parameters.AddWithValue("@PUESTO_EMP", puesto);
                        comando.Parameters.AddWithValue("@TELEFONO_EMP", telefono);
                        comando.Parameters.AddWithValue("@DIRECCION_EMP", direccion);
                        comando.Parameters.AddWithValue("@HORARIO_EMP", horario);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Empleado creado exitosamente.");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Error al crear el empleado.");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error de conexión: {ex.Message}");
                    return false;
                }
            }
        }
    }
}
