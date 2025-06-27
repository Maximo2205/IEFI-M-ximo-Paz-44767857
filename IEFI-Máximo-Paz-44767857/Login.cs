using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IEFI_Máximo_Paz_44767857
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
            btnInicio.BackColor = Color.Tan;
            btnInicio.ForeColor = Color.Black;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Font = new Font("Segoe UI", 9, FontStyle.Bold);

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            bool valido = conexion.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (valido)
            {
                conexion.horaInicioSesion = DateTime.Now;
                conexion.usuarioActual = txtUsuario.Text;

                Auditoria menu = new Auditoria(conexion);
                menu.Show();
                this.Hide();

                MessageBox.Show("Inicio de sesión exitoso");
                // Acá podés abrir el formulario principal
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
