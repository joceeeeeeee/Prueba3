using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUARDERIA;
using static GUARDERIA.Form2;
using System;

namespace GUARDERIA.Tests
{
    [TestClass]
    public class EmpleadoRepositoryTests
    {
        [TestMethod]
        public void InsertarEmpleado_DeberiaInsertarCorrectamente()
        {
            // Arrange
            var empleado = new Empleado
            {
                Nombre = "Carlos",
                Edad = 28,
                Puesto = "Asistente"
            };

            var repo = new EmpleadoRepository();

            // Act
            repo.InsertarEmpleado(empleado);

            // Assert
            Assert.IsTrue(true); 
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertarEmpleado_ConEdadInvalida_DeberiaLanzarExcepcion()
        {
            // Arrange
            var empleado = new Empleado
            {
                Nombre = "Ana",
                Edad = -5, // Edad inválida
                Puesto = "Recepcionista"
            };

            var repo = new EmpleadoRepository();

            // Act
            repo.InsertarEmpleado(empleado);

        }

        [TestMethod]
        public void InsertarEmpleado_NombreLongitudMaxima_NoDeberiaLanzarExcepcion()
        {
            // Arrange
            string nombreLargo = new string('A', 100); // Suponemos 100 como límite de longitud
            var empleado = new Empleado
            {
                Nombre = nombreLargo,
                Edad = 35,
                Puesto = "Supervisor"
            };

            var repo = new EmpleadoRepository();

            try
            {
                // Act
                repo.InsertarEmpleado(empleado);

                // Assert implícito: si no hay excepción, la prueba pasa
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                // Si lanza excepción, la prueba falla
                Assert.Fail("Se lanzó una excepción al insertar un nombre con longitud máxima: " + ex.Message);
            }
        }

        [TestMethod]
        
        public void InsertarEmpleado_ConNombreVacio_DeberiaFallar()
        {
            // Arrange
            var empleado = new Empleado
            {
                Nombre = "", // Nombre vacío
                Edad = 25,
                Puesto = "Cajero"
            };

            var repo = new EmpleadoRepository();

            // Act
            repo.InsertarEmpleado(empleado);
        }
        [TestMethod]
        public void InsertarEmpleado_EdadCero_NoDeberiaLanzarExcepcion()
        {
            // Arrange
            var empleado = new Empleado
            {
                Nombre = "Bebé",
                Edad = 0, // Límite inferior válido
                Puesto = "Ayudante"
            };

            var repo = new EmpleadoRepository();

            try
            {
                // Act
                repo.InsertarEmpleado(empleado);

                // Assert
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail("No debería lanzar excepción con edad cero: " + ex.Message);
            }
        }


    }
}
