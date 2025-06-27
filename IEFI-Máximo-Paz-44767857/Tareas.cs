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
    public partial class Tareas : Form
    {
        ConexionBD conexion;
        public Tareas(ConexionBD conexion)
        {
            InitializeComponent();
            this.conexion = conexion;

            pnlTareas.BackColor = Color.FromArgb(74, 54, 41);

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

        private void Tareas_Load(object sender, EventArgs e)
        {
            cmbTarea.Items.Add("Auditoria");
            cmbTarea.Items.Add("Visita");
            cmbTarea.Items.Add("Inspeccion");
            cmbTarea.Items.Add("Gestion");

            cmbLugar.Items.Add("Empresa");
            cmbLugar.Items.Add("Oficina");
            cmbLugar.Items.Add("Servicio");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbTarea.SelectedItem == null || cmbLugar.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una tarea y un lugar.");
                return;
            }

            string usuario = txtUsuario.Text;
            string tarea = cmbTarea.SelectedItem.ToString();
            string lugar = cmbLugar.SelectedItem.ToString();
            DateTime fecha = dtpFecha.Value;

            try
            {
                conexion.AgregarTarea(usuario, tarea, lugar, fecha);
                MessageBox.Show("Tarea registrada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar tarea: " + ex.Message);
            }
        }

        private void dgvMostrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = conexion.ObtenerTodasLasTareas();
        }
    }
}
