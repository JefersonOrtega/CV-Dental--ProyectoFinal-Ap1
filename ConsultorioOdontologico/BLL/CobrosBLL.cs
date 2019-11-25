using ConsultorioOdontologico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.BLL
{
    class CobrosBLL : RepositorioBase<Cobros>
    {
        public override bool Guardar(Cobros entity)
        {
            RepositorioBase<Procedimientos> repositorioProcedimientos = new RepositorioBase<Procedimientos>();
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();

            Procedimientos procedimiento = repositorioProcedimientos.Buscar(entity.ProcedimientoId);
            Pacientes paciente = repositorio.Buscar(procedimiento.PacienteId);
            paciente.Balance -= entity.Abono;
            _contexto.Entry(paciente).State = EntityState.Modified;

           
            
            if (procedimiento.Monto == entity.Abono)
            {
                procedimiento.Cobrado = true;
                
            }
            ProcedimientosBLL procedimientosBLL = new ProcedimientosBLL();
            procedimiento.Monto -= entity.Abono;
            procedimientosBLL.Modificar(procedimiento);
            //_contexto.Entry(procedimiento).State = EntityState.Modified;

            return base.Guardar(entity);
        }

    }
}
