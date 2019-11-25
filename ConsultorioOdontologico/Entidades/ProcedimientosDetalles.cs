using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.Entidades
{
    public class ProcedimientosDetalles
    {
        [Key]
        public int ProcedimientosDetalleId { get; set; }
        public int ProcedimientoId { get; set; }
        public int CitaId { get; set; }
        public string Descripcion { get; set; } //Lo que se ha hecho...


        public ProcedimientosDetalles()
        {
            ProcedimientosDetalleId = 0;
            ProcedimientoId = 0;
            CitaId = 0;
            Descripcion = string.Empty;
        }
        
        public ProcedimientosDetalles(int ProcedimientosDetalleId, int ProcedimientoId, int CitaId, string Descripcion)
        {
            this.ProcedimientosDetalleId = ProcedimientosDetalleId;
            this.ProcedimientoId = ProcedimientoId;
            this.CitaId = CitaId;
            this.Descripcion = Descripcion;
        }
    }
}
