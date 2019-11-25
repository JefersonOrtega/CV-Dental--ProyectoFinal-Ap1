using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.Entidades
{
    public class Pacientes
    {
        [Key]
        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public bool Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string SeguroMedico { get; set; }
        public string Alergias { get; set; }
        public decimal Balance { get; set; }
        public int UsuarioId { get; set; }

        public Pacientes()
        {
            PacienteId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Email = string.Empty;
            Genero = false;
            FechaNacimiento = DateTime.Now;
            FechaRegistro = DateTime.Now;
            SeguroMedico = string.Empty;
            Alergias = string.Empty;
           // UsuarioId = 0;
        }
    }
}
