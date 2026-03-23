namespace CapaPresentacion
{
    partial class FrmRegistrarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpfvencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpfingreso = new System.Windows.Forms.DateTimePicker();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.rbtnactivo = new System.Windows.Forms.RadioButton();
            this.txtpventa = new System.Windows.Forms.TextBox();
            this.txtpcompra = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboidcategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 125);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Fecha de vencimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Fecha de ingreso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 230);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Precio de venta";
            // 
            // dtpfvencimiento
            // 
            this.dtpfvencimiento.Location = new System.Drawing.Point(519, 150);
            this.dtpfvencimiento.Name = "dtpfvencimiento";
            this.dtpfvencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpfvencimiento.TabIndex = 62;
            // 
            // dtpfingreso
            // 
            this.dtpfingreso.Location = new System.Drawing.Point(519, 88);
            this.dtpfingreso.Name = "dtpfingreso";
            this.dtpfingreso.Size = new System.Drawing.Size(200, 20);
            this.dtpfingreso.TabIndex = 61;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(341, 140);
            this.txtstock.Margin = new System.Windows.Forms.Padding(2);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(144, 20);
            this.txtstock.TabIndex = 59;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(141, 87);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(88, 20);
            this.txtidproducto.TabIndex = 58;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(604, 276);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(58, 19);
            this.btncancelar.TabIndex = 57;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(519, 276);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(56, 19);
            this.btnguardar.TabIndex = 56;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.Location = new System.Drawing.Point(599, 226);
            this.rbtninactivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtninactivo.TabIndex = 55;
            this.rbtninactivo.TabStop = true;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Location = new System.Drawing.Point(518, 226);
            this.rbtnactivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnactivo.TabIndex = 54;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // txtpventa
            // 
            this.txtpventa.Location = new System.Drawing.Point(341, 258);
            this.txtpventa.Margin = new System.Windows.Forms.Padding(2);
            this.txtpventa.Name = "txtpventa";
            this.txtpventa.Size = new System.Drawing.Size(144, 20);
            this.txtpventa.TabIndex = 53;
            // 
            // txtpcompra
            // 
            this.txtpcompra.Location = new System.Drawing.Point(341, 196);
            this.txtpcompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtpcompra.Name = "txtpcompra";
            this.txtpcompra.Size = new System.Drawing.Size(144, 20);
            this.txtpcompra.TabIndex = 52;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(85, 236);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(144, 20);
            this.txtdescripcion.TabIndex = 51;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(85, 179);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(144, 20);
            this.txtcodigo.TabIndex = 50;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(85, 118);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(144, 20);
            this.txtnombre.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Precio de compra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(516, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Seleccione Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Lote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Registrar Nuevo Producto";
            // 
            // cboidcategoria
            // 
            this.cboidcategoria.FormattingEnabled = true;
            this.cboidcategoria.Location = new System.Drawing.Point(341, 51);
            this.cboidcategoria.Name = "cboidcategoria";
            this.cboidcategoria.Size = new System.Drawing.Size(121, 21);
            this.cboidcategoria.TabIndex = 67;
            this.cboidcategoria.Text = "Id Categoria";
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 329);
            this.Controls.Add(this.cboidcategoria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpfvencimiento);
            this.Controls.Add(this.dtpfingreso);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtninactivo);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.txtpventa);
            this.Controls.Add(this.txtpcompra);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "FrmRegistrarProducto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpfvencimiento;
        private System.Windows.Forms.DateTimePicker dtpfingreso;
        public System.Windows.Forms.TextBox txtstock;
        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbtninactivo;
        public System.Windows.Forms.RadioButton rbtnactivo;
        public System.Windows.Forms.TextBox txtpventa;
        public System.Windows.Forms.TextBox txtpcompra;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboidcategoria;
    }
}