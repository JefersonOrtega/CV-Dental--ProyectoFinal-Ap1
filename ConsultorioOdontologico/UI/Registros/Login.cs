using ConsultorioOdontologico.BLL;
using ConsultorioOdontologico.Entidades;
using ConsultorioOdontologico.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioOdontologico.UI
{
    
    public partial class Login : Form
    {
        public static Usuarios UsuarioActivo { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void CrearUsuarioLabel_Click(object sender, EventArgs e)
        {
            rUsuarios rUsuarios = new rUsuarios();
            rUsuarios.Show();
        }

        private void MostrarContrasenaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarContrasenaCheckBox.Checked == true)
            {
                ContraseñaTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ContraseñaTextBox.UseSystemPasswordChar = true;
            }
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;

            if (string.IsNullOrWhiteSpace(UsuarioTextBox.Text))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "No se puede dejar el campo contraseña en blanco");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                MyErrorProvider.SetError(ContraseñaTextBox, "No se puede dejar el campo contraseña en blanco");
                ContraseñaTextBox.Focus();
                paso = false;
            }


            return paso;
        }

        private void Ingresar()
        {
            if (!Validar())
                return;

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var Lista = repositorio.GetList(p => true);

            foreach (var item in Lista)
            {
                if (UsuarioTextBox.Text == item.NombreUsuario)
                {
                    if (ContraseñaTextBox.Text == item.Contraseña)
                    {
                        UsuarioActivo = repositorio.Buscar(item.UsuarioId);
                        MainForm menu = new MainForm();
                        menu.Show();
                        this.Close();
                        MyErrorProvider.Clear();
                    }
                    else
                    {
                        MyErrorProvider.SetError(ContraseñaTextBox, "Debe digitar una contraseña valida");
                        ContraseñaTextBox.Focus();
                        break;
                    }

                }
                else
                {
                    MyErrorProvider.SetError(UsuarioTextBox, "Debe digitar un usuario valido");
                    UsuarioTextBox.Focus();
                }
            }
        }
        private void IngresarButton_Click(object sender, EventArgs e)
        {
            Ingresar();
            

        }

        private void IngresarButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Ingresar();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            var ListaUsuarios = repositorio.GetList(p => true);
            if (ListaUsuarios.Count==0)
            {
                Usuarios usuario = new Usuarios();
                usuario.UsuarioId = 0;
                usuario.Nombre = "Administrador";
                usuario.Tipo = "Administrador";
                usuario.NombreUsuario = "Admin";
                usuario.Contraseña = "123";

                repositorio.Guardar(usuario);
            }
        }
    }
}
