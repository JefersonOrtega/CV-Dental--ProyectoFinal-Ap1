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
    public class CobrosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;

            CobrosBLL cobrosBLL = new CobrosBLL();
            Cobros cobros = new Cobros();

            cobros.CobroId = 0;
            cobros.ProcedimientoId = 1;
            cobros.Fecha = DateTime.Now;
            cobros.Abono = 500;
            cobros.UsuarioId = 1;

            paso = cobrosBLL.Guardar(cobros);

            Assert.AreEqual(paso, true);
        }
    }
}