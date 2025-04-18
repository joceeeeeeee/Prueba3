using NUnit.Framework;

namespace GUARDERIA.Tests
{
    [TestFixture]
    public class EmpleadoServiceTests
    {
        private EmpleadoService empleadoService;

        [SetUp]
        public void SetUp()
        {
            string connectionString = @"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true";
            empleadoService = new EmpleadoService(connectionString);
        }

        [Test]
        public void AltaEmpleado_DeberiaInsertarYRetornarTrue()
        {
            // Arrange: datos ficticios para alta
            int idEmpleado = 9999; // ID único para no generar conflicto
            string nombre = "Prueba Unit";
            string especialidad = "Testing";
            string rfc = "PRU010101ABC";
            int edad = 30;
            string curp = "PRU010101HBCMNRA9";
            float salario = 5000;
            string puesto = "QA";
            string telefono = "1234567890";
            string direccion = "Calle Prueba 123";
            string horario = "Lunes a Viernes";

            // Act
            bool resultado = empleadoService.AltaEmpleado(
                idEmpleado, nombre, especialidad, rfc, edad, curp,
                salario, puesto, telefono, direccion, horario);

            // Assert
            Assert.IsTrue(resultado, "El método debería retornar true si el registro fue exitoso.");
        }
    }
}
