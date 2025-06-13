using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Máximo_Paz_44767857
{
    public partial class Modificar : Form
    {
        ConexionBD conexion;
        public Modificar(ConexionBD conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string NomModificar = txtNombreModificar.Text;
            string nombre2 = txtNombre2.Text;
            string contraseña2 = txtContraseña2.Text;
            string tarea1 = txtTarea1.Text;
            string categoria1 = cmbCategoria1.Text;

            conexion.Modificar(NomModificar,nombre2, contraseña2, tarea1, categoria1);

            txtNombreModificar.Text = "";
            txtNombre2.Text = "";
            txtContraseña2.Text = "";
            cmbCategoria1.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string NomModificar = txtNombreModificar.Text;

            conexion.Eliminar(NomModificar);

            txtNombreModificar.Text = ""; 
        }
    }
}
