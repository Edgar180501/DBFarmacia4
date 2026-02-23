using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaPresentacion // Asegúrate que sea tu namespace real
{
    public partial class frmAuditoriaSesiones : Form
    {
        public frmAuditoriaSesiones()
        {
            InitializeComponent();
        }

        private void frmAuditoriaSesiones_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source = USUARIO-TVQNB7K; Initial Catalog = dbfarmacia; Integrated Security = True";

            using (SqlConnection con = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM auditoria_sesiones ORDER BY fecha_inicio DESC";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                try
                {
                    con.Open(); // Asegúrate de abrir la conexión explícitamente
                    adaptador.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvAuditoria.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("La consulta no devolvió datos. La tabla está vacía.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión o consulta: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}