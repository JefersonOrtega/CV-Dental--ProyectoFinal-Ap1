using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.Entidades
{
    public class TiposProcedimientos
    {
        [Key]
        public int TipoProcedimientoId { get; set; }
        public string NombreProcedimiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int UsuarioId { get; set; }

        public TiposProcedimientos()
        {
            TipoProcedimientoId = 0;
            NombreProcedimiento = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
            UsuarioId = 0;
        }
    }
}
