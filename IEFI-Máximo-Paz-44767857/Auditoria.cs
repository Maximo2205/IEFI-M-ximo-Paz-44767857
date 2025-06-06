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
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            DateTime horaFin = DateTime.Now;
            TimeSpan duracion = horaFin - conexion.horaInicioSesion;
            int tiempoUsoEnMinutos = (int)duracion.TotalMinutes;

            conexion.RegistrarAuditoria(conexion.usuarioActual, horaFin, tiempoUsoEnMinutos);
            Application.Exit();
        }
    }
}
