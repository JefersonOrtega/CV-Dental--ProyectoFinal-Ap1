using ConsultorioOdontologico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Pacientes> Paciente { get; set; }
        public DbSet<TiposProcedimientos> TipoProcedimiento { get; set; }
        public DbSet<Citas> Cita { get; set; }
        public DbSet<Procedimientos> Procedimiento { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<Cobros> Cobros { get; set; }

        public Contexto() : base("ConStr")
        { }

    }
}
