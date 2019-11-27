using ConsultorioOdontologico.BLL;
using ConsultorioOdontologico.Entidades;
using ConsultorioOdontologico.UI.Reportes;
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
    public partial class rCobros : Form
    {
        private List<Cobros> ListaCobros;
        public rCobros()
        {
            InitializeComponent();
        }
        
        private void Limpiar()
        {
            MyErrorProvider.Clear();
            CobroIdnumericUpDown.Value = 0;
            ProcedimientoIdNumericUpDown.Value = 0;
            MontoTextBox.Text = string.Empty;
            AbonoNumericUpDown.Value = 0;
            
            CargarGrid();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

            Limpiar();

        }

        private void CargarGrid()
        {
            PorCobrarDataGridView.Rows.Clear();
            PorCobrarDataGridView.Refresh();
            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();
            var ListaProcedimientos = repositorio.GetList(p => p.Cobrado == false);

            RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
            RepositorioBase<TiposProcedimientos> repositorioTipoProcedimiento = new RepositorioBase<TiposProcedimientos>();


            
            Pacientes paciente;
            TiposProcedimientos tipoProcedimiento;

            foreach (var item in ListaProcedimientos)
            {
                paciente = repositorioPacientes.Buscar(item.PacienteId);
                tipoProcedimiento = repositorioTipoProcedimiento.Buscar(item.TipoProcedimientoId);

                PorCobrarDataGridView.Rows.Add(paciente.Nombres, item.ProcedimientoId, tipoProcedimiento.NombreProcedimiento, item.Estado, item.Monto );
            }
            
            //PorCobrarDataGridView.DataSource = ListaProcedimientos;
        }
        private void rCobros_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = Login.UsuarioActivo.Nombre;
            CargarGrid();
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (ProcedimientoIdNumericUpDown.Value==0)
            {
                MyErrorProvider.SetError(ProcedimientoIdNumericUpDown, "Debe seleccionar un procedimiento");
                ProcedimientoIdNumericUpDown.Focus();
                paso = false;

            }
            else
            {
                if (AbonoNumericUpDown.Value == 0)
                {
                    MyErrorProvider.SetError(AbonoNumericUpDown, "Este campo no debe dejarse en 0");
                    AbonoNumericUpDown.Focus();
                    paso = false;
                }
                else
                {

                    RepositorioBase<Procedimientos> repositorioProcedimieno = new RepositorioBase<Procedimientos>();
                    Procedimientos procedimiento = repositorioProcedimieno.Buscar(Convert.ToInt32(ProcedimientoIdNumericUpDown.Value));


                    RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
                    Pacientes paciente = repositorioPacientes.Buscar(procedimiento.PacienteId);


                    if (AbonoNumericUpDown.Value > paciente.Balance)
                    {
                        MyErrorProvider.SetError(AbonoNumericUpDown, "El monto abonado supera la deuda del paciente");
                        AbonoNumericUpDown.Focus();
                        paso = false;
                    }
                }
            }
            

            return paso;
        }


        private void LlenarCampos(Cobros cobros)
        {
            CobroIdnumericUpDown.Value = cobros.CobroId;
            ProcedimientoIdNumericUpDown.Value = cobros.ProcedimientoId;
            FechaDateTimePicker.Value = cobros.Fecha;
            AbonoNumericUpDown.Value = cobros.Abono;

            RepositorioBase<Procedimientos> repositorioProcedimieno = new RepositorioBase<Procedimientos>();
            Procedimientos procedimiento = repositorioProcedimieno.Buscar(Convert.ToInt32(ProcedimientoIdNumericUpDown.Value));

            RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
            Pacientes pacientes = repositorioPacientes.Buscar(procedimiento.PacienteId);

            PacientetextBox.Text = pacientes.Nombres + " "+ pacientes.Apellidos;


            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            UsuarioLabel.Text = repositorio.Buscar(cobros.UsuarioId).Nombre;
        }

        private Cobros LlenarClase()
        {
            Cobros cobro = new Cobros();

            cobro.CobroId = Convert.ToInt32(CobroIdnumericUpDown.Value);
            cobro.ProcedimientoId = Convert.ToInt32(ProcedimientoIdNumericUpDown.Value);
            cobro.Fecha = FechaDateTimePicker.Value;
            cobro.Abono = AbonoNumericUpDown.Value;
            cobro.UsuarioId = Login.UsuarioActivo.UsuarioId;

            return cobro;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            Cobros cobro = repositorio.Buscar((int)CobroIdnumericUpDown.Value);
            return (cobro != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cobros cobro;
            bool paso = false;

            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();
            CobrosBLL cobrosBLL = new CobrosBLL();

            if (!Validar())
                return;

            cobro = LlenarClase();

            if (CobroIdnumericUpDown.Value == 0)
                paso = cobrosBLL.Guardar(cobro);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = repositorio.Modificar(cobro);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ///
                /// Imprimir reporte
                ///
                BLL.RepositorioBase<Cobros> repositorioBase = new RepositorioBase<Cobros>();
                ListaCobros = repositorioBase.GetList(p=> p.CobroId == cobro.CobroId);
                if (ListaCobros.Count == 0)
                {
                    MessageBox.Show("No hay datos para imprimir");
                    return;
                }
                ReciboCobroReportViewer reciboCobroReportViewer = new ReciboCobroReportViewer(ListaCobros);
                reciboCobroReportViewer.ShowDialog();
                ///

                Limpiar();
                
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarPacienteButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(ProcedimientoIdNumericUpDown.Text, out id);

            Procedimientos procedimiento = new Procedimientos();

            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();
          
            procedimiento = repositorio.Buscar(id);

            if (procedimiento != null)
            {

                MontoTextBox.Text = Convert.ToString(procedimiento.Monto);

                RepositorioBase<Pacientes> repositorioPacientes = new RepositorioBase<Pacientes>();
                Pacientes paciente = repositorioPacientes.Buscar(procedimiento.PacienteId);

                PacientetextBox.Text = paciente.Nombres + " " + paciente.Apellidos;

            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }

        private void SaldarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int id;
            int.TryParse(ProcedimientoIdNumericUpDown.Text, out id);

            RepositorioBase<Procedimientos> repositorio = new RepositorioBase<Procedimientos>();

            Procedimientos procedimiento = repositorio.Buscar(id);

            if (SaldarCheckBox.Checked == true)
            {
                AbonoNumericUpDown.Value = procedimiento.Monto;
            }
        }

        private void PacientetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(CobroIdnumericUpDown.Text, out id);

            Cobros cobro = new Cobros();

            RepositorioBase<Cobros> repositorio = new RepositorioBase<Cobros>();

            Limpiar();

            cobro = repositorio.Buscar(id);

            if (cobro != null)
            {
                LlenarCampos(cobro);
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
