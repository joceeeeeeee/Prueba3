using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Data.SqlClient; // ESTE ES EL CAMBIO CLAVE
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class ConexionBDTests
    {
        private string cadenaConexion = @"Server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; Integrated Security=True";

        [TestMethod]
        public void ConexionBD_SeAbreYCierraCorrectamente()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    Assert.AreEqual(System.Data.ConnectionState.Open, conexion.State);
                }
                catch (Exception ex)
                {
                    Assert.Fail("No se pudo abrir la conexión: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                        conexion.Close();

                    Assert.AreEqual(System.Data.ConnectionState.Closed, conexion.State);
                }
            }
        }

        [TestMethod]
        public void Consulta_SimpleEmpleados_NoFalla()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT COUNT(*) FROM EMPLEADO";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    int total = (int)comando.ExecuteScalar();
                    Assert.IsTrue(total >= 0);
                }
                catch (Exception ex)
                {
                    Assert.Fail("Error al ejecutar la consulta: " + ex.Message);
                }
            }
        }
    }
}
