using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.Entidades
{
    public class Citas
    {
        [Key]
        public int CitaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int PacienteId { get; set; }
        public string Estado { get; set; }
        public string Observacion { get; set; }
        public int UsuarioId { get; set; }

        public Citas()
        {
            CitaId = 0;
            Fecha = DateTime.Now;
            Hora = string.Empty;
            PacienteId = 0;
            Estado = string.Empty;
            Observacion = string.Empty;
            UsuarioId = 0;
        }
    }
}
