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
    public class ProcedimientosBLLTests
    {
       
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            ProcedimientosBLL procedimientosBLL = new ProcedimientosBLL();
            Procedimientos procedimiento = new Procedimientos();
            List<ProcedimientosDetalles> detalle = new List<ProcedimientosDetalles>();

            procedimiento.ProcedimientoId = 0;
            procedimiento.PacienteId = 1;
            procedimiento.TipoProcedimientoId = 1;
            procedimiento.Estado = "En Proceso";
            procedimiento.Monto = 1000;
            procedimiento.Cobrado = false;
            procedimiento.UsuarioId = 1;

            procedimiento.ProcedimientoDetalle = detalle;
            paso = procedimientosBLL.Guardar(procedimiento);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Procedimientos procedimiento = new Procedimientos();
            ProcedimientosBLL procedimientosBLL = new ProcedimientosBLL();
            List<ProcedimientosDetalles> detalle = new List<ProcedimientosDetalles>();

            procedimiento.ProcedimientoId = 1;
            procedimiento.Estado = "Terminado";
            procedimiento.ProcedimientoDetalle = detalle;

            paso = procedimientosBLL.Modificar(procedimiento);
            Assert.AreEqual(paso, true);
        }
    }
}