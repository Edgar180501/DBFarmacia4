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
    public partial class FmrListadoCategoria : Form
    {
        public FmrListadoCategoria()
        {
            InitializeComponent();
        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Top = 0;

            this.Mostrar();
        }


        private void Mostrar()
        {
            this.dlistado.DataSource = CNCategoria.Listar();
        }

        private void Buscar()
        {
            this.dlistado.DataSource = CNCategoria.BuscarNombre(txtbuscar.Text);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FmrRegistrarCategoria form = new FmrRegistrarCategoria();
            form.Show();
            form.Insert = true;
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FmrRegistrarCategoria form = new FmrRegistrarCategoria();
            form.Show();
            form.Insert = false;
            form.Edit = true;

            form.txtidcategoria.Text = this.dlistado.CurrentRow.Cells["id_categoria"].Value.ToString();
            form.txtdescripcion.Text = this.dlistado.CurrentRow.Cells["descripcion"].Value.ToString();

            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente desea eliminar el(los) registro(s)?",
                    "Sistema de Ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idcategoria = dlistado.CurrentRow.Cells["id_categoria"].Value.ToString();
                        CNCategoria.Eliminar(Convert.ToInt32(idcategoria));

                        MessageBox.Show("Registro eliminado",
                            "Sistema de Ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Mostrar();
                    }

                }

                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            FmrRegistrarCategoria form = new FmrRegistrarCategoria();
            form.Show();
            form.Insert = true;
            this.Hide();
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {

        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
