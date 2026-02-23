using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // 1. MÉTODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        // Este método recibe cualquier formulario y lo mete en el panel central
        private void AbrirFormularioEnPanel(object formHijo)
        {
            // Si el panel ya tiene un formulario, lo eliminamos para poner el nuevo
            if (this.panelCentral.Controls.Count > 0)
                this.panelCentral.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false; // Decimos que no es una ventana independiente
            fh.FormBorderStyle = FormBorderStyle.None; // Le quitamos los bordes
            fh.Dock = DockStyle.Fill; // Que se estire para llenar todo el panel

            this.panelCentral.Controls.Add(fh); // Lo agregamos al panel
            this.panelCentral.Tag = fh;
            fh.Show(); // ¡Listo! El formulario aparece dentro
        }

        // 2. EVENTOS DE TUS BOTONES DEL MENÚ
        // Supongamos que tienes un botón llamado btnProveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            // Llamamos al método y le pasamos el formulario que quieres ver
            AbrirFormularioEnPanel(new FrmListadoProveedor());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmBitacora());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Opcional: Puedes cargar una pantalla de bienvenida al iniciar
            // AbrirFormularioEnPanel(new FrmBienvenida());
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRegistrarProveedor());
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            // Reemplaza 'panelCentral' por el nombre que le pusiste a tu panel del medio
            AbrirFormularioEnPanel(new FrmListadoProveedor());
        }

        private void btnBitácora_Click(object sender, EventArgs e)
        {
            // Usamos la misma estructura de conexión que ya tienes
            string cadenaConexion = "Data Source = USUARIO-TVQNB7K; Initial Catalog = dbfarmacia; Integrated Security = True";

            try
            {
                // 1. Validamos si el usuario guardado en la clase Sesion es "admin"
                // No necesitamos hacer un SELECT a la base de datos aquí porque ya sabemos 
                // quién es el usuario desde el login.
                if (Sesion.NombreUsuario.ToLower() == "admin")
                {
                    // 2. Si es admin, abrimos el formulario que muestra la tabla de auditoría
                    FrmBitacora frm = new FrmBitacora();

                    // Si usas el diseño de paneles, usa tu método para mostrarlo dentro:
                    // AbrirFormularioEnPanel(frm); 

                    // Si no, ábrelo como una ventana emergente:
                    frm.ShowDialog();
                }
                else
                {
                    // 3. Si es cualquier otro usuario, lanzamos el mensaje de restricción
                    MessageBox.Show("No cuentas con los permisos para acceder a la bitácora de registro de acciones.",
                                    "Acceso Denegado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Estructura de manejo de errores idéntica a la que pasaste
                MessageBox.Show("Error al intentar acceder a la bitácora: " + ex.Message);
            }
        }

        private void btnVerAuditoria_Click(object sender, EventArgs e)
{
    // 1. Verificamos si el usuario activo es el administrador
    // Usamos ToLower() por si en la base de datos dice "Admin", "ADMIN" o "admin"
    if (Sesion.NombreUsuario.ToLower() == "admin")
    {
        // 2. ACCESO CONCEDIDO: Mostramos el formulario
        frmAuditoriaSesiones formAuditoria = new frmAuditoriaSesiones();
        
        // Si estás usando el diseño web con paneles que hablamos antes, usa:
        // AbrirFormularioEnPanel(formAuditoria);
        
        // Si lo estás abriendo como ventana normal (flotante), usa:
        formAuditoria.ShowDialog(); 
    }
    else
    {
        // 3. ACCESO DENEGADO
        MessageBox.Show("ACCESO DENEGADO\n\nEl usuario '" + Sesion.NombreUsuario + "' no tiene permisos para ver los tiempos de sesion.\nSolo el 'admin' puede ingresar aquí.", 
                        "Alerta de Seguridad", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
    }
}
    }
}
namespace CapaPresentacion // Asegúrate de que el namespace coincida con tus formularios
{
    public static class VariablesGlobales
    {
        // Esta variable guardará el nombre del usuario que hizo login
        public static string NombreUsuario;
    }
}