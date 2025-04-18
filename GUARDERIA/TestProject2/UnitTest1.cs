using NUnit.Framework;
using System.Data.SqlClient;
using System;

namespace Tests
{
    [TestFixture]
    public class ConexionBDTests
    {
        private string connectionString = @"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true";
        private SqlConnection conexion;

        [SetUp]
        public void Setup()
        {
            // Inicializamos la conexión
            conexion = new SqlConnection(connectionString);
        }

        [Test]
        public void Conexion_SeAbreYCierraCorrectamente()
        {
            try
            {
                // Abrir la conexión
                conexion.Open();

                // Verificar que la conexión esté abierta
                Assert.Equals(System.Data.ConnectionState.Open, conexion.State);

                // Cerrar la conexión
                conexion.Close();

                // Verificar que la conexión esté cerrada
                Assert.Equals(System.Data.ConnectionState.Closed, conexion.State);
            }
            catch (Exception ex)
            {
                // Si ocurre una excepción, la prueba fallará
                Assert.Fail("La conexión a la base de datos falló: " + ex.Message);
            }
        }
    }
}