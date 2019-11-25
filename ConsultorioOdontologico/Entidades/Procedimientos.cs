using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.Entidades
{
    public class Procedimientos
    {
        [Key]
        public int ProcedimientoId { get; set; }
        public int PacienteId { get; set; }
        public int TipoProcedimientoId { get; set; }
        public string Estado { get; set; }
        public decimal Monto { get; set; }
        public bool Cobrado { get; set; } //Si esta cobrado o no
        public int UsuarioId { get; set; }

        public virtual List<ProcedimientosDetalles> ProcedimientoDetalle { get; set; }

        public Procedimientos()
        {
            ProcedimientoId = 0;
            PacienteId = 0;
            TipoProcedimientoId = 0;
            Estado = string.Empty;
            Monto = 0;
            Cobrado = false;
            UsuarioId = 0;
            ProcedimientoDetalle = new List<ProcedimientosDetalles>();

        }
    }
}
