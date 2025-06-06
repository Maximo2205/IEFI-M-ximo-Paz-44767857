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
    public partial class Audi : Form
    {
        public Audi()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            dgvMostrar1.DataSource = conexion.ObtenerAuditorias();
        }
    }
}
