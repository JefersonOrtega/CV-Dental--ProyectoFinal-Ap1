using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.Entidades
{
    public class Cobros
    {
        [Key]
        public int CobroId { get; set; }
        public int ProcedimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }
        public int UsuarioId { get; set; }

        public Cobros()
        {
            CobroId = 0;
            ProcedimientoId = 0;
            Fecha = DateTime.Now;
            Abono = 0;
            UsuarioId = 0;
        }
    }
}
