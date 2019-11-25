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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void LlenarCampos(Usuarios usuario)
        {
            UsuarioIdNumericUpDown.Value = usuario.UsuarioId;
            NombreTextBox.Text = usuario.Nombre;
            TipoComboBox.SelectedItem = usuario.Tipo; //
            UsuarioTextBox.Text = usuario.NombreUsuario;
            ContrasenaTextBox.Text = usuario.Contraseña;

        }

        private Usuarios LlenarClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId= Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Tipo = Convert.ToString(TipoComboBox.SelectedItem);
            usuario.NombreUsuario = UsuarioTextBox.Text;
            usuario.Contraseña = ContrasenaTextBox.Text;

            return usuario;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuario != null);
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "No se puede dejar este cmapo en blanco");
                NombreTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TipoComboBox.Text))
            {
                MyErrorProvider.SetError(TipoComboBox, "No se puede dejar este cmapo en blanco");
                TipoComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "No se puede dejar este cmapo en blanco");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ContrasenaTextBox.Text))
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "No se puede dejar este cmapo en blanco");
                ContrasenaTextBox.Focus();
                paso = false;
            }

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var Lista = repositorio.GetList(p => true);
            foreach (var item in Lista)
            {
                if (UsuarioTextBox.Text == item.NombreUsuario)
                {
                    MyErrorProvider.SetError(UsuarioTextBox, "Ya existe un usuario con este nombre");
                    UsuarioTextBox.Focus();
                    paso = false;
                }
            }

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            bool paso = false;

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();


            if (!Validar())
                return;

            usuario = LlenarClase();

            if(UsuarioIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(usuario);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = repositorio.Modificar(usuario);
            }
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            UsuarioIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            TipoComboBox.SelectedItem = -1; //
            UsuarioTextBox.Text = string.Empty;
            ContrasenaTextBox.Text = string.Empty;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);

            RepositorioBase<Citas> repositorio = new RepositorioBase<Citas>();


            if (MessageBox.Show("Estas seguro de eliminar este Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes) //Probando...
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
                    MyErrorProvider.SetError(UsuarioIdNumericUpDown, "No se puede eliminar un registro que no existe");
                    UsuarioIdNumericUpDown.Focus();
                }
            }
        }

        private void BuscarCitasButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);

            Usuarios usuario = new Usuarios();

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Limpiar();

            usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                LlenarCampos(usuario);
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }
    }
}
