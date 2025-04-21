using System;
using System.Data.SqlClient;
using GUARDERIA;
using static GUARDERIA.Form2;

public class EmpleadoRepository
{
    private readonly SqlConnection conexion;

    public EmpleadoRepository()
    {
        conexion = new SqlConnection(@"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true");
    }

    public void InsertarEmpleado(Empleado empleado)
    {
        try
        {
            conexion.Open();
            string query = "INSERT INTO EMPLEADO (Nombre, Edad, Puesto) VALUES (@Nombre, @Edad, @Puesto)";
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Nombre", empleado.Nombre);
            comando.Parameters.AddWithValue("@Edad", empleado.Edad);
            comando.Parameters.AddWithValue("@Puesto", empleado.Puesto);
            //comando.ExecuteNonQuery();  <-- Puedes comentar esto para evitar ejecución real
        }
        finally
        {
            conexion.Close();
        }
    }
}


