using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsultorioOdontologico.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultorioOdontologico.Entidades;

namespace ConsultorioOdontologico.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;

            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = 0;
            usuario.Nombre = "Carmen Tejada";
            usuario.Tipo = "Doctora";
            usuario.NombreUsuario = "CarmenTB";
            usuario.Contraseña = "123";

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            paso = repositorio.Guardar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarPacientesTest()
        {
            bool paso;
            Pacientes paciente = new Pacientes();
            paciente.PacienteId = 0;
            paciente.Nombres = "Miguel";
            paciente.Apellidos = "Mercedes";
            paciente.Direccion = "Calle Duarte #25";
            paciente.Telefono = "809-555-6690";
            paciente.Celular = "809-999-9999";
            paciente.Email = "Miguel@gmail.com";
            paciente.Genero = Convert.ToBoolean(1);
            paciente.FechaRegistro = DateTime.Now;
            paciente.SeguroMedico = "Senasa";
            paciente.Alergias = "No tiene";
            paciente.UsuarioId = 1;

            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();

            paso = repositorio.Guardar(paciente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarCitasTest()
        {
            bool paso;
            Citas cita = new Citas();
            cita.CitaId = 0;
            cita.PacienteId = 1;
            cita.Fecha = DateTime.Now;
            cita.Hora = "14:45";
            cita.Estado = "Programada";
            cita.UsuarioId = 1;


            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();

            paso = repositorio.Guardar(cita);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GuardarCobrosTest()
        {
            bool paso;
            Cobros cobro = new Cobros();

            cobro.CobroId = 0;
            cobro.ProcedimientoId = 1;
            cobro.Fecha = DateTime.Now;
            cobro.Abono = 100;
            cobro.UsuarioId = 1;


            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();

            paso = repositorio.Guardar(cobro);
            Assert.AreEqual(paso, true);
        }




        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;

            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = 2;
            usuario.Nombre = "Carmen Tejada Brito";
            usuario.Contraseña = "C123";

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            paso = repositorio.Modificar(usuario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarPacientesTest()
        {
            bool paso;

            Pacientes paciente = new Pacientes();
            paciente.PacienteId = 2;
            paciente.Apellidos = "Mercedes Paredes";
            paciente.Direccion = "Calle Juan P Gonzales #25";
            paciente.Email = "MiguelMP@gmail.com";
            paciente.UsuarioId = 1;

            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();

            paso = repositorio.Modificar(paciente);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarCitasTest()
        {
            bool paso;

            Citas cita = new Citas();
            cita.CitaId = 3;
            cita.Hora = "16:45";
            cita.Estado = "Reprogramada";

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();

            paso = repositorio.Modificar(cita);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarCobrosTest()
        {
            bool paso;

            Cobros cobro = new Cobros();
            cobro.CobroId = 1;
            cobro.Abono = 105;
            cobro.UsuarioId = 1;

            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();

            paso = repositorio.Modificar(cobro);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Assert.IsTrue(repositorio.Eliminar(3));
        }

        [TestMethod()]
        public void EliminarPacientesTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Assert.IsTrue(repositorio.Eliminar(2));
        }

        [TestMethod()]
        public void EliminarCitasTest()
        {
            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();
            Assert.IsTrue(repositorio.Eliminar(2));
        }

        [TestMethod()]
        public void EliminarCobrosTest()
        {
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();
            usuario = repositorio.Buscar(3);
            Assert.IsNotNull(usuario);
        }

        [TestMethod()]
        public void BuscarPacientesTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Pacientes paciente = new Pacientes();
            paciente = repositorio.Buscar(1);
            Assert.IsNotNull(paciente);
        }

        [TestMethod()]
        public void BuscarCitasTest()
        {
            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();
            Citas cita = new Citas();
            cita = repositorio.Buscar(1);
            Assert.IsNotNull(cita);
        }

        [TestMethod()]
        public void BuscarCobrosTest()
        {
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            Cobros cobro = new Cobros();
            cobro = repositorio.Buscar(2);
            Assert.IsNotNull(cobro);
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var lista = new List<Usuarios>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void GetListPacientesTest()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            var lista = new List<Pacientes>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void GetListCitasTest()
        {
            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();
            var lista = new List<Citas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void GetListCobrosTest()
        {
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            var lista = new List<Cobros>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }


        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }
    }
}