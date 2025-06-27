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
    public partial class Auditoria : Form
    {
        private ConexionBD conexion;
        public Auditoria(ConexionBD conexion)
        {
            InitializeComponent();
            this.conexion = conexion;
            this.FormClosing += Auditoria_FormClosing;

            pnlPaginaPrincipal.BackColor = Color.FromArgb(74, 54, 41);

            btnOperador.BackColor = Color.Tan;
            btnOperador.ForeColor = Color.Black;
            btnOperador.FlatStyle = FlatStyle.Flat;
            btnOperador.FlatAppearance.BorderSize = 0;
            btnOperador.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnMostrarTareas.BackColor = Color.Tan;
            btnMostrarTareas.ForeColor = Color.Black;
            btnMostrarTareas.FlatStyle = FlatStyle.Flat;
            btnMostrarTareas.FlatAppearance.BorderSize = 0;
            btnMostrarTareas.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnAdministrador.BackColor = Color.Tan;
            btnAdministrador.ForeColor = Color.Black;
            btnAdministrador.FlatStyle = FlatStyle.Flat;
            btnAdministrador.FlatAppearance.BorderSize = 0;
            btnAdministrador.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnAuditoria.BackColor = Color.Tan;
            btnAuditoria.ForeColor = Color.Black;
            btnAuditoria.FlatStyle = FlatStyle.Flat;
            btnAuditoria.FlatAppearance.BorderSize = 0;
            btnAuditoria.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnRegistar.BackColor = Color.Tan;
            btnRegistar.ForeColor = Color.Black;
            btnRegistar.FlatStyle = FlatStyle.Flat;
            btnRegistar.FlatAppearance.BorderSize = 0;
            btnRegistar.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnRegistrarTarea.BackColor = Color.Tan;
            btnRegistrarTarea.ForeColor = Color.Black;
            btnRegistrarTarea.FlatStyle = FlatStyle.Flat;
            btnRegistrarTarea.FlatAppearance.BorderSize = 0;
            btnRegistrarTarea.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            btnCerrar.BackColor = Color.Tan;
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Font = new Font("Segoe UI", 9, FontStyle.Bold);


        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            dgvMostrar.Enabled = false;
            btnMostrarTareas.Enabled = false;
            btnAuditoria.Enabled = false;
            btnRegistar.Enabled = false;

            tslConexion.Text = conexion.EstadoConexion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DateTime horaFin = DateTime.Now;
            TimeSpan duracion = horaFin - conexion.horaInicioSesion;
            int tiempoUsoEnMinutos = (int)duracion.TotalMinutes;

            conexion.RegistrarAuditoria(conexion.usuarioActual, horaFin, tiempoUsoEnMinutos);
            Application.Exit();
        }

        private void Auditoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Solo registrar auditoría si no se ha hecho ya
            if (conexion.horaInicioSesion != DateTime.MinValue)
            {
                DateTime horaFin = DateTime.Now;
                TimeSpan duracion = horaFin - conexion.horaInicioSesion;
                int tiempoUsoEnMinutos = (int)duracion.TotalMinutes;

                conexion.RegistrarAuditoria(conexion.usuarioActual, horaFin, tiempoUsoEnMinutos);

                // Evitamos que se registre otra vez si también se usó el botón cerrar
                conexion.horaInicioSesion = DateTime.MinValue;
            }
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            Audi frm = new Audi();
            frm.ShowDialog();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar(conexion);
            registrar.ShowDialog();
        }

        private void btnOperador_Click(object sender, EventArgs e)
        {
            string categoria = conexion.ObtenerCategoriaUsuarioActual();

            if (categoria == "Operador")
            {
                dgvMostrar.Enabled = true;
                btnMostrarTareas.Enabled = true;

                MessageBox.Show("Funciones de operador habilitadas.");
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a funciones de operador.");
            }
        }

        private void btnMostrarTareas_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = conexion.ObtenerTareasDelUsuario();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            string categoria = conexion.ObtenerCategoriaUsuarioActual();

            if (categoria == "Administrador")
            {
                dgvMostrar.Enabled = true;
                btnMostrarTareas.Enabled = true;
                btnAuditoria.Enabled = true;
                btnRegistar.Enabled = true;
                btnRegistrarTarea.Enabled = true;

                MessageBox.Show("Funciones de administrador habilitadas.");
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a funciones de administrador.");
            }
        }

        private void btnRegistrarTarea_Click(object sender, EventArgs e)
        {
           Tareas tarea = new Tareas(conexion);
           tarea.ShowDialog();
        }
    }
}
