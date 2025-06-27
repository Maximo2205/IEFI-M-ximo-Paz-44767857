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

            pnlModificar.BackColor = Color.FromArgb(74, 54, 41);

            btnModificar.BackColor = Color.Tan;
            btnModificar.ForeColor = Color.Black;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnEliminar.BackColor = Color.Tan;
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string NomModificar = txtNombreModificar.Text;
            string nombre2 = txtNombre2.Text;
            string contraseña2 = txtContraseña2.Text;
            string categoria1 = cmbCategoria1.Text;

            conexion.Modificar(NomModificar,nombre2, contraseña2, categoria1);

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
