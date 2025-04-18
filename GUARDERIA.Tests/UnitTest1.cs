using Xunit;
using GUARDERIA;

namespace GUARDERIA.Tests
{
    public class EmpleadoServiceTests
    {
        [Fact]
        public void GuardarEmpleado_DatosValidos_RetornaTrue()
        {
            // Arrange
            var service = new EmpleadoService();

            // Datos de prueba
            string idEmpleado = "100";
            string nombre = "Juan";
            string especialidad = "Psicología";
            string rfc = "JUAN123456";
            string edad = "30";
            string curp = "CURP12345678";
            string salario = "8000";
            string puesto = "Psicólogo";
            string telefono = "5551234567";
            string direccion = "Calle Falsa 123";
            string horario = "7:00-15:00";

            // Act
            bool resultado = service.GuardarEmpleado(idEmpleado, nombre, especialidad, rfc, edad, curp, salario, puesto, telefono, direccion, horario);

            // Assert
            Assert.True(resultado);
        }
    }
}
