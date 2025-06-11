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
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre1 = txtNombre.Text;
            string contraseña1 = txtContraseña1.Text;
            string tarea = txtTarea.Text;
            string categoria = cmbCategoria.Text;

            conexion.Agregar(nombre1, contraseña1, tarea, categoria);


        }
    }
}
