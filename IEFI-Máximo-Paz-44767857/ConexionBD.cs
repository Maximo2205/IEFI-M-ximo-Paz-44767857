using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEFI_Máximo_Paz_44767857
{
    public class ConexionBD
    {
        public DataSet DS { get; set; }

        public OleDbDataAdapter DAA { get; set; }
        public OleDbDataAdapter DAU { get; set; }

        public string Error = "";

        public DateTime horaInicioSesion;
        public string usuarioActual;

        public ConexionBD()
        {
            try
            {
                DS = new DataSet();

                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=Acceso.mdb";
                cnn.Open();

                OleDbCommand cmp = new OleDbCommand();
                cmp.CommandType = CommandType.TableDirect;
                cmp.CommandText = "Usuarios";
                cmp.Connection = cnn;
                DAU = new OleDbDataAdapter();
                DAU.SelectCommand = cmp;
                DAU.Fill(DS, "Usuarios");

                OleDbCommand cma = new OleDbCommand();
                cma.CommandType = CommandType.TableDirect;
                cma.CommandText = "Auditoria";
                cma.Connection = cnn;
                DAA = new OleDbDataAdapter();
                DAA.SelectCommand = cma;
                DAA.Fill(DS, "Auditoria");

                DataColumn[] clavePrimaria = new DataColumn[1];
                clavePrimaria[0] = DS.Tables["Usuarios"].Columns["NombreUsuario"];
                DS.Tables["Usuarios"].PrimaryKey = clavePrimaria;

                OleDbCommandBuilder cb = new OleDbCommandBuilder(DAU);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }

        }

        public bool ValidarUsuario(string nombreUsuario, string contraseña)
        {
            try
            {
                foreach (DataRow fila in DS.Tables["Usuarios"].Rows)
                {
                    if (fila["NombreUsuario"].ToString() == nombreUsuario && fila["Contraseña"].ToString() == contraseña)
                    {
                        return true; // Usuario válido
                    }
                }
                return false; // No se encontró coincidencia
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar usuario: " + ex.Message);
                return false;
            }
        }

        public void RegistrarAuditoria(string usuario, DateTime fecha, int tiempoUso)
        {
            try
            {
                DataRow dr = DS.Tables["Auditoria"].NewRow();
                dr["Usuario"] = usuario;
                dr["Fecha"] = fecha;
                dr["TiempoUso"] = tiempoUso;
                DS.Tables["Auditoria"].Rows.Add(dr);

                OleDbCommandBuilder cb = new OleDbCommandBuilder(DAA);
                DAA.Update(DS, "Auditoria");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar auditoría: " + ex.Message);
            }
        }

        public void Agregar(string nombre1, string contraseña1, string tarea, string categoria)
        {
            try
            {
                if (DS == null || DS.Tables["Usuarios"] == null)
                {
                    MessageBox.Show("La tabla 'Usuarios' no está cargada.");
                    return;
                }

                DataRow dr = DS.Tables["Usuarios"].NewRow();
                dr["NombreUsuario"] = nombre1;
                dr["Contraseña"] = contraseña1;
                dr["Tarea"] = tarea;
                dr["Categoria"] = categoria;
                DS.Tables["Usuarios"].Rows.Add(dr);

                OleDbCommandBuilder cb = new OleDbCommandBuilder(DAU);
                DAU.Update(DS, "Usuarios");

                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        public void Modificar(string NomModificar, string nombre2, string contraseña2, string tarea1, string categoria1)
        {
            try
            {
                DataRow fila = DS.Tables["Usuarios"].Rows.Find(NomModificar);
                if (fila != null)
                {
                    fila.BeginEdit();
                    fila["NombreUsuario"] = nombre2;
                    fila["Contraseña"] = contraseña2;
                    fila["Tarea"] = tarea1;
                    fila["Categoria"] = categoria1;
                    fila.EndEdit();

                    DAU.Update(DS, "Usuarios");
                }

                MessageBox.Show("Contacto modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
                throw;
            }
        }

        public void Eliminar(string NomModificar)
        {
            foreach (DataRow dr in DS.Tables["Usuarios"].Rows)
            {
                if (dr["NombreUsuario"].ToString() == NomModificar)
                {
                    dr.Delete();
                    break;
                }
            }

            OleDbCommandBuilder cb = new OleDbCommandBuilder(DAU);
            DAU.Update(DS, "Usuarios");
        }

        public DataTable Buscar(string textoBusqueda)
        {
            DataTable resultados = DS.Tables["Auditoria"].Clone();

            foreach (DataRow row in DS.Tables["Auditoria"].Rows)
            {
                if (row["Usuario"].ToString().Contains(textoBusqueda) ||
                    row["Fecha"].ToString().ToLower().Contains(textoBusqueda.ToLower()) ||
                    row["TiempoUso"].ToString().Contains(textoBusqueda))
                {
                    resultados.ImportRow(row);
                }
            }

            return resultados;
        }

        public DataTable ObtenerAuditorias()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Auditoria", DAA.SelectCommand.Connection);
                OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener auditorías: " + ex.Message);
                return null;
            }
        }

        public DataTable ObtenerTarea()
        {
            DataTable Tareas = new DataTable();
            Tareas.Columns.Add("Tarea");

            foreach (DataRow fila in DS.Tables["Usuarios"].Rows)
            {
                if (fila["NombreUsuario"].ToString() == usuarioActual)
                {
                    DataRow nuevaFila = Tareas.NewRow();
                    nuevaFila["Tarea"] = fila["Tarea"].ToString();
                    Tareas.Rows.Add(nuevaFila);
                    break;
                }
            }

            return Tareas;
        }

        public string ObtenerCategoriaUsuarioActual()
        {
            foreach (DataRow fila in DS.Tables["Usuarios"].Rows)
            {
                if (fila["NombreUsuario"].ToString() == usuarioActual)
                {
                    return fila["Categoria"].ToString();
                }
            }

            return "";
        }


    }
}
