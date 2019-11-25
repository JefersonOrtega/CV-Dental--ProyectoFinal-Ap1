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
    public partial class rTiposProcedimientos : Form
    {
        public rTiposProcedimientos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            ProcedimientoIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
        }





        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "No se puede dejar este campo en blanco");
                NombreTextBox.Focus();
                paso = false;
            }
            if (PrecioNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "No se puede dejar este campo en blanco");
                PrecioNumericUpDown.Focus();
                paso = false;
            }

            return paso;

        }

        private void LlenarCampos(TiposProcedimientos tipoProcedimiento)
        {
            ProcedimientoIdNumericUpDown.Value = tipoProcedimiento.TipoProcedimientoId;
            NombreTextBox.Text = tipoProcedimiento.NombreProcedimiento;
            DescripcionTextBox.Text = tipoProcedimiento.Descripcion;
            PrecioNumericUpDown.Value = tipoProcedimiento.Precio;

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            UsuarioLabel.Text = repositorio.Buscar(tipoProcedimiento.UsuarioId).Nombre;
        }

        private TiposProcedimientos LlenarClase()
        {
            TiposProcedimientos tipoProcedimiento = new TiposProcedimientos();

            tipoProcedimiento.TipoProcedimientoId = Convert.ToInt32(ProcedimientoIdNumericUpDown.Value);
            tipoProcedimiento.NombreProcedimiento = NombreTextBox.Text;
            tipoProcedimiento.Descripcion = DescripcionTextBox.Text;
            tipoProcedimiento.Precio = PrecioNumericUpDown.Value;
            tipoProcedimiento.UsuarioId = Login.UsuarioActivo.UsuarioId;

            return tipoProcedimiento;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<TiposProcedimientos> repositorio = new RepositorioBase<TiposProcedimientos>();
            TiposProcedimientos tipoProcedimiento = repositorio.Buscar((int)ProcedimientoIdNumericUpDown.Value);
            return (tipoProcedimiento != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            TiposProcedimientos tipoProcedimiento;
            bool paso = false;

            RepositorioBase<TiposProcedimientos> repositorio = new RepositorioBase<TiposProcedimientos>();


            if (!Validar())
                return;

            tipoProcedimiento = LlenarClase();

            if (ProcedimientoIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(tipoProcedimiento);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = repositorio.Modificar(tipoProcedimiento);
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
            int.TryParse(ProcedimientoIdNumericUpDown.Text, out id);

            RepositorioBase<TiposProcedimientos> repositorio = new RepositorioBase<TiposProcedimientos>();


            if (MessageBox.Show("Estas seguro de eliminar esta consulata?", "Eliminar consulta", MessageBoxButtons.YesNo) == DialogResult.Yes) //Probando...
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
                    MyErrorProvider.SetError(ProcedimientoIdNumericUpDown, "No se puede eliminar un registro que no existe");
                    ProcedimientoIdNumericUpDown.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int id;
            int.TryParse(ProcedimientoIdNumericUpDown.Text, out id);

            TiposProcedimientos tipoProcedimiento = new TiposProcedimientos();

            RepositorioBase<TiposProcedimientos> repositorio = new RepositorioBase<TiposProcedimientos>();

            Limpiar();

            tipoProcedimiento = repositorio.Buscar(id);

            if (tipoProcedimiento != null)
            {
                LlenarCampos(tipoProcedimiento);
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }

        private void rTiposProcedimientos_Load(object sender, EventArgs e)
        {
            UsuarioLabel.Text = Login.UsuarioActivo.Nombre;
        }
    }
}
