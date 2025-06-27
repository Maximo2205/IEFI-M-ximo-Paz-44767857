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
    public partial class Registrar : Form
    {
        ConexionBD conexion;

        public Registrar(ConexionBD conexion)
        {
            InitializeComponent();
            this.conexion = conexion;

            pnlRegistrar.BackColor = Color.FromArgb(74, 54, 41);

            btnModificar.BackColor = Color.Tan;
            btnModificar.ForeColor = Color.Black;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnAgregar.BackColor = Color.Tan;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnMostrar.BackColor = Color.Tan;
            btnMostrar.ForeColor = Color.Black;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.FlatAppearance.BorderSize = 0;
            btnMostrar.Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtNombre.Text;
            string contraseña1 = txtContraseña1.Text;
            string categoria = cmbCategoria.Text;

            conexion.Agregar(nombre1, contraseña1, categoria);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar frmM = new Modificar(conexion);
            frmM.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = conexion.ObtenerTodosLosUsuarios();
        }
    }
}
