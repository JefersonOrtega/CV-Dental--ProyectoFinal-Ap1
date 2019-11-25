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
        public void EliminarTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Assert.IsTrue(repositorio.Eliminar(2));
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
        public void GetListTest()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var lista = new List<Usuarios>();
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