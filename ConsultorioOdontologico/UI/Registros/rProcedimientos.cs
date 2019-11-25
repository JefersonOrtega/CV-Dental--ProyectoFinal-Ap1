using ConsultorioOdontologico.BLL;
using ConsultorioOdontologico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioOdontologico.UI.Registros
{
    public partial class rProcedimientos : Form
    {
        public List<ProcedimientosDetalles> Detalle { get; set; }
        public rProcedimientos()
        {
            InitializeComponent();
            this.Detalle = new List<ProcedimientosDetalles>();
        }

        private void rProcedimientos_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = Login.UsuarioActivo.Nombre;

            RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();

            RepositorioBase<Citas> repositorioCitas = new RepositorioBase<Citas>();
            var ListaCitas = repositorioCitas.GetList(p => p.Estado.ToLower() == "programada" || p.Estado.ToLower() == "reprogramada"); //Para sacar las citas que estan pendientes

            var ListaPacientes = repositorioPacientes.GetList(p => true);
            /*foreach (var item in ListaCitas)
            {
                ListaPacientes = repositorioPacientes.GetList(p => p.PacienteId == item.PacienteId);
                
            }*/



            PacienteComboBox.ValueMember = "PacienteId";
            PacienteComboBox.DisplayMember = "Nombres";
            PacienteComboBox.DataSource = ListaPacientes;

            PacienteComboBox.SelectedIndex = -1;

            RepositorioBase<TiposProcedimientos> repositorioProcedimientos = new RepositorioBase<TiposProcedimientos>();
            var ListaProcedimientos = repositorioProcedimientos.GetList(p => true);
            TipoProcedimientoComboBox.ValueMember = "TipoProcedimientoId";
            TipoProcedimientoComboBox.DisplayMember = "NombreProcedimiento";
            TipoProcedimientoComboBox.DataSource = ListaProcedimientos;

            TipoProcedimientoComboBox.SelectedIndex = -1;

        }

        
        /*private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }*/

        private void CargarGrid(List<ProcedimientosDetalles> ProcedimientoDetalle)
        {
            RepositorioBase<Citas> repositorioCitas = new RepositorioBase<Citas>();
            RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
            //RepositorioBase<Procedimientos> repositorioProcedimientos = new RepositorioBase<Procedimientos>();
            RepositorioBase<TiposProcedimientos> repositorioTiposProcedimientos = new RepositorioBase<TiposProcedimientos>();



            RepositorioBase<ProcedimientosDetalles> repositorioDetalle = new RepositorioBase<ProcedimientosDetalles>();

        
            DetalleDataGridView.Rows.Clear();
           
            foreach (var item in ProcedimientoDetalle)
            {
                Citas cita = repositorioCitas.Buscar(item.CitaId);
                Pacientes paciente = repositorioPacientes.Buscar(cita.PacienteId);
                //Procedimientos procedimiento = repositorioProcedimientos.Buscar(item.ProcedimientoId);
                TiposProcedimientos tipoProcedimiento = repositorioTiposProcedimientos.Buscar(Convert.ToInt32(TipoProcedimientoComboBox.SelectedValue));
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////EstadoComboBox.SelectedItem,
                DetalleDataGridView.Rows.Add(item.ProcedimientoId, item.CitaId, paciente.Nombres, tipoProcedimiento.NombreProcedimiento, item.Descripcion);
            }
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            ProcedimientoIdNumericUpDown.Value = 0;
            CitaIdNumericUpDown.Value = 0;
            PacienteComboBox.Text = string.Empty;
            TipoProcedimientoComboBox.SelectedIndex=-1;
            EstadoComboBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            MontoTextBox.Text = string.Empty;

            this.Detalle = new List<ProcedimientosDetalles>();
            CargarGrid(this.Detalle);

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (EstadoComboBox.SelectedIndex < 0)
            {
                MyErrorProvider.SetError(EstadoComboBox, "Debe seleccionar un estado");
                EstadoComboBox.Focus();
                paso = false;
            }
            if (TipoProcedimientoComboBox.SelectedIndex < 0)
            {
                MyErrorProvider.SetError(TipoProcedimientoComboBox, "Debe haber un procedimiento seleccionado");
                TipoProcedimientoComboBox.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe agregar algun elemento al Detalle");
                AgregarButton.Focus();
                paso = false;
            }

            return paso;
        }
        private void LlenarCampos(Procedimientos procedimiento)
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();

            ProcedimientoIdNumericUpDown.Value = procedimiento.ProcedimientoId;
            PacienteComboBox.SelectedValue = procedimiento.PacienteId;
            TipoProcedimientoComboBox.SelectedValue = procedimiento.TipoProcedimientoId;
            EstadoComboBox.Text = procedimiento.Estado;
            MontoTextBox.Text = Convert.ToString(procedimiento.Monto);

            RepositorioBase<Usuarios> repositorioUsuarios = new RepositorioBase<Usuarios>();
            UsuarioLabel.Text = repositorioUsuarios.Buscar(procedimiento.UsuarioId).Nombre;

            this.Detalle = procedimiento.ProcedimientoDetalle;
            CargarGrid(this.Detalle);

        }

        private Procedimientos LlenarClase()
        {
            Procedimientos Procedimiento = new Procedimientos();

            Procedimiento.ProcedimientoId = Convert.ToInt32(ProcedimientoIdNumericUpDown.Value);
            Procedimiento.PacienteId = Convert.ToInt32(PacienteComboBox.SelectedValue);
            Procedimiento.TipoProcedimientoId = Convert.ToInt32(TipoProcedimientoComboBox.SelectedValue);
            Procedimiento.Estado = EstadoComboBox.Text;
            Procedimiento.Monto = Convert.ToDecimal(MontoTextBox.Text);
            Procedimiento.Cobrado = false;
            Procedimiento.UsuarioId = Login.UsuarioActivo.UsuarioId;

            Procedimiento.ProcedimientoDetalle = this.Detalle;

            return Procedimiento;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();
            Procedimientos Procedimiento = repositorio.Buscar((int)ProcedimientoIdNumericUpDown.Value);
            return (Procedimiento != null);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Procedimientos Procedimiento;
            bool paso = false;

            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();
            ProcedimientosBLL procedimientosBLL = new ProcedimientosBLL();
            
            if (!Validar())
                return;

            Procedimiento = LlenarClase();

            if (ProcedimientoIdNumericUpDown.Value == 0)
                paso = procedimientosBLL.Guardar(Procedimiento);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = procedimientosBLL.Modificar(Procedimiento);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RepositorioBase<Citas> repositorioCitas = new RepositorioBase<Citas>();
                var Lista = repositorioCitas.GetList(p => p.PacienteId == PacienteComboBox.SelectedIndex+1 && (p.Estado.ToLower() == "programada" || p.Estado.ToLower() == "reprogramada"));

                Citas cita;
                
                foreach (var item in Lista)
                {
                    cita= repositorioCitas.Buscar(item.CitaId);
                    cita.Estado = "Cumplida";
                    repositorioCitas.Modificar(cita);
                    break;
                }

                

            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool ValidarDetalle()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (EstadoComboBox.SelectedIndex < 0)
            {
                MyErrorProvider.SetError(EstadoComboBox, "Debe seleccionar un estado");
                EstadoComboBox.Focus();
                paso = false;
            }
            if (TipoProcedimientoComboBox.SelectedIndex < 0)
            {
                MyErrorProvider.SetError(TipoProcedimientoComboBox, "Debe haber un procedimiento seleccionado");
                TipoProcedimientoComboBox.Focus();
                paso = false;
            }
            if (CitaIdNumericUpDown.Value < 1)
            {
                MyErrorProvider.SetError(CitaIdNumericUpDown, "Debe seleccionar una Cita");
                CitaIdNumericUpDown.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Debe agregar una descripción");
                DescripcionTextBox.Focus();
                paso = false;
            }


            return paso;
        }


        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<ProcedimientosDetalles>)DetalleDataGridView.DataSource;

            if (!ValidarDetalle())
                return;

            this.Detalle.Add(
                new ProcedimientosDetalles(
                        ProcedimientosDetalleId: 0,
                        ProcedimientoId: (int)ProcedimientoIdNumericUpDown.Value,
                        CitaId : (int)CitaIdNumericUpDown.Value,
                        Descripcion : DescripcionTextBox.Text
                    )
                );
            CargarGrid(this.Detalle);
            DescripcionTextBox.Text = string.Empty;
            CitaIdNumericUpDown.Value = 0;
        }

        private void PacienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
        }

        private void TipoProcedimientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoProcedimientoComboBox.SelectedIndex < 0)
                return;
            if (ProcedimientoIdNumericUpDown.Value == 0)
            {
                RepositorioBase<TiposProcedimientos> repositorio = new RepositorioBase<TiposProcedimientos>();
                TiposProcedimientos TipoProcedimiento = repositorio.Buscar(Convert.ToInt32(TipoProcedimientoComboBox.SelectedValue));

                MontoTextBox.Text = Convert.ToString(TipoProcedimiento.Precio);
            }
            
        }

        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            if(DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargarGrid(this.Detalle);
            }
        }

        private void BuscarProcedimientoButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(ProcedimientoIdNumericUpDown.Text, out id);

            Procedimientos procedimiento = new Procedimientos();

            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();

            Limpiar();

            procedimiento = repositorio.Buscar(id);

            if (procedimiento != null)
            {
                LlenarCampos(procedimiento);
                TipoProcedimientoComboBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }

        private void BuscarCitasButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(CitaIdNumericUpDown.Text, out id);

            Citas cita = new Citas();

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();

            cita = repositorio.Buscar(id);

            RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();



            if (cita != null) 
            {
                if (ProcedimientoIdNumericUpDown.Value == 0)//Si no es modificando
                {
                    if (cita.Estado.ToLower() == "programada" || cita.Estado.ToLower() == "reprogramada")
                    {
                        PacienteComboBox.Text = repositorioPacientes.Buscar(cita.PacienteId).Nombres;
                    }
                    else
                    {

                        if (cita.Estado.ToLower() == "vencida")
                            MessageBox.Show("Esta Cita está vencida");
                        else
                            MessageBox.Show("Esta Cita ha sido cumplida");
                    }

                }
                else //Si es modificando
                {

                    RepositorioBase<Procedimientos> repositorioProcedimientos = new RepositorioBase<Procedimientos>();
                    Procedimientos procedimiento = repositorioProcedimientos.Buscar(Convert.ToInt32(ProcedimientoIdNumericUpDown.Value));
                    if (cita.PacienteId != procedimiento.PacienteId)
                    {
                        MessageBox.Show("Esta cita no corresponde al paciente de este procedimiento");
                    }
                    else
                    {
                        if (cita.Estado.ToLower() == "vencida")
                            MessageBox.Show("Esta Cita está vencida");
                    }
                }
            }
            else
            {
                MessageBox.Show("Cita no encontrada");
               
            }
            
        }
    }
}
