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
    public partial class FmrRegistrarCategoria : Form
    {

        public bool Insert = false;
        public bool Edit = false;

        public FmrRegistrarCategoria()
        {
            InitializeComponent();
            this.Top = 0;
            this.Left = 0;
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            FmrListadoCategoria form = new FmrListadoCategoria();
            form.Show();
            this.Hide();
        }

        private void FmrRegistrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void FmrRegistrarCategoria_Load_1(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //VALIDACION MEJORADA//
                if (string.IsNullOrWhiteSpace(this.txtdescripcion.Text))
                {
                    MessageBox.Show("Ingrese los datos de la categoria", "Sistema de Ventas",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string respuesta = "";
                
                {
                    if (this.Insert == true)
                    {
                        //GUARDAR//
                        CNCategoria.Guardar(this.txtdescripcion.Text.Trim().ToUpper());

                        if (respuesta == "OK")
                        MessageBox.Show("Categoria registrada correctamente", "Sistema de Ventas.",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNCategoria.Editar(Convert.ToInt32(this.txtidcategoria.Text),
                                            this.txtdescripcion.Text.Trim().ToUpper());

                        MessageBox.Show("Categoria editada correctamente", "Sistema de Ventas.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FmrListadoCategoria form = new FmrListadoCategoria();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}