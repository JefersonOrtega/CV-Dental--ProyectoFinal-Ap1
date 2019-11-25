using ConsultorioOdontologico.BLL;
using ConsultorioOdontologico.DAL;
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
    public partial class rPaciente : Form
    {
        public rPaciente()
        {
            InitializeComponent();
        }

        private void rPaciente_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = Login.UsuarioActivo.Nombre;
        }

        private void Limpiar()
        {
            PacienteIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            GeneroComboBox.Text = string.Empty;
            FechaNacimientoDateTimePicker.Value = DateTime.Now;
            SeguroMedicoTextBox.Text = string.Empty;
            FechaRegistoDateTimePicker.Value = DateTime.Now;
            AlergiasTextBox.Text = string.Empty;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyErrorProvider.SetError(NombresTextBox, "Este campo no puede dejarse en blanco");
                NombresTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ApellidosTextBox.Text))
            {
                MyErrorProvider.SetError(ApellidosTextBox, "Este campo no puede dejarse en blanco");
                ApellidosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text.Replace("-","")))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Este campo no puede dejarse en blanco");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            
            return paso;
        }


        private void LlenarCampos(Pacientes paciente)
        {
            PacienteIdNumericUpDown.Value = paciente.PacienteId;
            NombresTextBox.Text = paciente.Nombres;
            ApellidosTextBox.Text = paciente.Apellidos;
            DireccionTextBox.Text = paciente.Direccion;
            TelefonoMaskedTextBox.Text = paciente.Telefono;
            CelularMaskedTextBox.Text = paciente.Celular;
            EmailTextBox.Text = paciente.Email;
            GeneroComboBox.SelectedIndex = Convert.ToInt32(paciente.Genero);
            FechaNacimientoDateTimePicker.Value = paciente.FechaNacimiento;
            FechaRegistoDateTimePicker.Value = paciente.FechaRegistro;
            SeguroMedicoTextBox.Text = paciente.SeguroMedico;
            AlergiasTextBox.Text = paciente.Alergias;

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            UsuarioLabel.Text = repositorio.Buscar(paciente.UsuarioId).Nombre;
        }

        private Pacientes LlenarClase()
        {
            Pacientes paciente = new Pacientes();

            paciente.PacienteId = Convert.ToInt32(PacienteIdNumericUpDown.Value);
            paciente.Nombres = NombresTextBox.Text;
            paciente.Apellidos = ApellidosTextBox.Text;
            paciente.Direccion = DireccionTextBox.Text;
            paciente.Telefono = TelefonoMaskedTextBox.Text;
            paciente.Celular = CelularMaskedTextBox.Text;
            paciente.Email = EmailTextBox.Text;
            paciente.Genero = Convert.ToBoolean(GeneroComboBox.SelectedIndex);
            paciente.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            paciente.FechaRegistro = FechaRegistoDateTimePicker.Value;
            paciente.SeguroMedico = SeguroMedicoTextBox.Text;
            paciente.Alergias = AlergiasTextBox.Text;
            paciente.UsuarioId = Login.UsuarioActivo.UsuarioId;

            return paciente;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            Pacientes paciente = repositorio.Buscar((int)PacienteIdNumericUpDown.Value);
            return (paciente != null);
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Pacientes paciente;
            bool paso = false;

            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();


            if (!Validar())
                return;

            paciente= LlenarClase();

            if (PacienteIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(paciente);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = repositorio.Modificar(paciente);
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
            int.TryParse(PacienteIdNumericUpDown.Text, out id);

            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();
            

            if (MessageBox.Show("Estas seguro de eliminar este paciente?", "Eliminar paciente", MessageBoxButtons.YesNo) == DialogResult.Yes) //Probando...
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
                    MyErrorProvider.SetError(PacienteIdNumericUpDown, "No se puede eliminar un paciente que no existe");
                    PacienteIdNumericUpDown.Focus();
                }
            }
           
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(PacienteIdNumericUpDown.Text, out id);

            Pacientes paciente = new Pacientes();

            RepositorioBase<Pacientes> repositorio = new RepositorioBase<Pacientes>();

            Limpiar();

            paciente = repositorio.Buscar(id);

            if (paciente != null)
            {
                LlenarCampos(paciente);
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }
    }
}
