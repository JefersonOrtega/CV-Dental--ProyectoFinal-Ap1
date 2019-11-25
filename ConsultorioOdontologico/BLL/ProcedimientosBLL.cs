using ConsultorioOdontologico.DAL;
using ConsultorioOdontologico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioOdontologico.BLL
{
    public class ProcedimientosBLL : RepositorioBase<Procedimientos>
    {
        public override bool Guardar(Procedimientos entity)
        {
            
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Pacientes paciente = repositorio.Buscar(entity.PacienteId);
            paciente.Balance += entity.Monto;
            _contexto.Entry(paciente).State = EntityState.Modified;



            return base.Guardar(entity);
        }
        public override bool Modificar(Procedimientos entity)
        {

            foreach (var item in entity.ProcedimientoDetalle)
            {
                var procedimiento = _contexto.Procedimiento.Find(item.ProcedimientoId);
                if (item.ProcedimientosDetalleId == 0)
                {
                    _contexto.Entry(item).State = EntityState.Added;
                    
                }
                else
                {
                    //foreach (var item2 in procedimiento.ProcedimientoDetalle)
                    //{
                        if (!entity.ProcedimientoDetalle.Exists(d => d.ProcedimientosDetalleId == item.ProcedimientosDetalleId))
                            _contexto.Entry(item).State = EntityState.Deleted;
                   // }
                    _contexto.Entry(item).State = EntityState.Modified;
                }
            }
          
            return base.Modificar(entity);
        }
        

        


    }
}
