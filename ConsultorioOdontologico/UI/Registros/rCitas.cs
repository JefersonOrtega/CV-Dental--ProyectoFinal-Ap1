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
    public partial class rCitas : Form
    {
        public rCitas()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            CitaIdNumericUpDown.Value = 0;
            PacienteComboBox.SelectedIndex=-1;
            FechaDateTimePicker.Value = DateTime.Now;
            HoraDateTimePicker.Value = DateTime.Now;
            EstadoComboBox.SelectedItem="";
            ObservacionTextBox.Text = string.Empty;

        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rCitas_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = Login.UsuarioActivo.Nombre;

            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            var Lista = repositorio.GetList(p => true);

            PacienteComboBox.ValueMember = "PacienteId";
            PacienteComboBox.DisplayMember = "Nombres"; //+" " + "Apellidos"

            PacienteComboBox.DataSource = Lista;
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(PacienteComboBox.Text))
            {
                MyErrorProvider.SetError(PacienteComboBox, "Debe Seleccionar un paciente");
                PacienteComboBox.Focus();
                paso = false;
            }

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();
            var Lista = repositorio.GetList(p => true);

            foreach (var item in Lista)
            {
                if ((item.Estado).ToLower() == "programada") //si la cita esta programada
                {
                    if (item.Fecha.Date == FechaDateTimePicker.Value.Date && item.Hora == HoraDateTimePicker.Text) //Si esta ocupada la fecha y hora
                    {   
                         MyErrorProvider.SetError(HoraDateTimePicker, "Esta hora no está disponible para la fecha");
                         HoraDateTimePicker.Focus();
                         paso = false;
                        break;                        
                    }
                }
            }
            
            if (string.IsNullOrWhiteSpace(EstadoComboBox.Text))
            {
                MyErrorProvider.SetError(EstadoComboBox, "Debe asignar un estado a la cita");
                EstadoComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void LlenarCampos(Citas cita)
        {
            CitaIdNumericUpDown.Value = cita.CitaId;
            PacienteComboBox.SelectedValue = cita.PacienteId; //probar que funcione
            FechaDateTimePicker.Value = cita.Fecha;
            HoraDateTimePicker.Value = Convert.ToDateTime(cita.Hora);
            EstadoComboBox.Text = cita.Estado;
            ObservacionTextBox.Text = cita.Observacion;

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            UsuarioLabel.Text = repositorio.Buscar(cita.UsuarioId).Nombre;

        }

        private Citas LlenarClase()
        {
            Citas cita = new Citas();

            cita.CitaId = Convert.ToInt32(CitaIdNumericUpDown.Value);
            cita.PacienteId = Convert.ToInt32(PacienteComboBox.SelectedValue);
            cita.Fecha = FechaDateTimePicker.Value;
            cita.Hora =HoraDateTimePicker.Text;
            cita.Estado = EstadoComboBox.Text;
            cita.Observacion = ObservacionTextBox.Text;
            cita.UsuarioId= Login.UsuarioActivo.UsuarioId;

            return cita;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();
            Citas cita = repositorio.Buscar((int)CitaIdNumericUpDown.Value);
            return (cita != null);
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Citas cita;
            bool paso = false;

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();


            if (!Validar())
                return;

            cita = LlenarClase();

            if (CitaIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(cita);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = repositorio.Modificar(cita);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(CitaIdNumericUpDown.Text, out id);

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();


            if (MessageBox.Show("Estas seguro de eliminar esta Cita?", "Eliminar Cita", MessageBoxButtons.YesNo) == DialogResult.Yes) //Probando...
            {
                if (repositorio.Buscar(id) != null)
                {
                    if (repositorio.Eliminar(id))
                    {
                        Limpiar();
                        MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MyErrorProvider.SetError(CitaIdNumericUpDown, "No se puede eliminar un registro que no existe");
                    CitaIdNumericUpDown.Focus();
                }
            }
        }

        private void BuscarCitasButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(CitaIdNumericUpDown.Text, out id);

            Citas cita = new Citas();

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();

            Limpiar();

            cita = repositorio.Buscar(id);

            if (cita != null)
            {
                LlenarCampos(cita);
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }

        private void AgregarPacienteButton_Click(object sender, EventArgs e)
        {
            rPaciente rPaciente = new rPaciente();
            rPaciente.ShowDialog();
        }
    }
}
