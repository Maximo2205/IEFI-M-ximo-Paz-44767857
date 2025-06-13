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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoBusqueda = txtBuscar.Text.Trim();

                if (string.IsNullOrEmpty(textoBusqueda))
                {
                    MessageBox.Show("Ingrese el nombre del Usuario que desea filtrar");
                    return;
                }

                DataTable resultados = new ConexionBD().Buscar(textoBusqueda);
                dgvMostrar1.DataSource = resultados;

                if (resultados.Rows.Count == 0)
                    MessageBox.Show("No se encontraron coincidencias");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
