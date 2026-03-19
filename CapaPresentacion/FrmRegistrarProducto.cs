using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarProducto : Form
    {
        public bool Insert = false;
        public bool Edit = false;

        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = (rbtnactivo.Checked) ? "ACTIVO" : "INACTIVO";

            try
            {
                if (string.IsNullOrWhiteSpace(this.txtcodigo.Text) || string.IsNullOrWhiteSpace(this.txtnombre.Text))
                {
                    MessageBox.Show("Debe completar los campos obligatorios", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detiene la ejecución para que no se cierre el form
                }

                string rpta = "";

                // Si ambas son false, vamos a asumir que es una Inserción para que puedas probar
                if (this.Insert == false && this.Edit == false)
                {
                    this.Insert = true;
                }

                if (this.Insert)
                {
                    rpta = CNProducto.Guardar(
                        this.txtcodigo.Text,
                        this.txtnombre.Text,
                        this.txtdescripcion.Text,
                        this.dtpfingreso.Value,
                        this.dtpfvencimiento.Value,
                        Convert.ToDouble(this.txtpcompra.Text),
                        Convert.ToDouble(this.txtpventa.Text),
                        Convert.ToInt32(this.txtstock.Text),
                        estado,
                        Convert.ToInt32(this.txtidcategoria.Text)
                    );
                }
                else if (this.Edit)
                {
                    rpta = CNProducto.Editar(
                        Convert.ToInt32(this.txtidproducto.Text),
                        this.txtcodigo.Text,
                        this.txtnombre.Text,
                        this.txtdescripcion.Text,
                        this.dtpfingreso.Value,
                        this.dtpfvencimiento.Value,
                        Convert.ToDouble(this.txtpcompra.Text),
                        Convert.ToDouble(this.txtpventa.Text),
                        Convert.ToInt32(this.txtstock.Text),
                        estado,
                        Convert.ToInt32(this.txtidcategoria.Text)
                    );
                }

                // VERIFICAMOS LA RESPUESTA DE LA BASE DE DATOS
                if (rpta.Equals("OK"))
                {
                    MessageBox.Show("Operación realizada con éxito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Insert = false;
                    this.Edit = false;
                    this.Close(); // Solo se cierra si la respuesta fue OK
                }
                else
                {
                    // Si hubo un error en el procedimiento almacenado o SQL, aquí te dirá qué pasó
                    MessageBox.Show("Error al guardar: " + rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtidcategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}