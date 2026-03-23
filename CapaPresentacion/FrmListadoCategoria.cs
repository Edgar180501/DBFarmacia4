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
            if (dlistado.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            FmrRegistrarCategoria form = new FmrRegistrarCategoria();

            form.Insert = false;
            form.Edit = true;

            form.txtidcategoria.Text = dlistado.CurrentRow.Cells["id_categoria"].Value.ToString();
            form.txtdescripcion.Text = dlistado.CurrentRow.Cells["descripcion"].Value.ToString();

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlistado.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione una fila");
                    return;
                }

                DialogResult opcion = MessageBox.Show(
                    "¿Realmente desea eliminar el registro?",
                    "Sistema de Ventas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int idcategoria = Convert.ToInt32(dlistado.CurrentRow.Cells["id_categoria"].Value);

                    string rpta = CNCategoria.Eliminar(idcategoria);

                    if (rpta == "Ok")
                    {
                        MessageBox.Show("Registro eliminado correctamente");
                        Mostrar();
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
