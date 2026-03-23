namespace CapaPresentacion
{
    partial class FrmListadoProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtncodigo = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.dlistado = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 66);
            this.panel1.TabIndex = 8;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(451, 26);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(57, 21);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(375, 26);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 21);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(176, 28);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(178, 20);
            this.txtbuscar.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtncodigo);
            this.groupBox1.Controls.Add(this.rbtnnombre);
            this.groupBox1.Location = new System.Drawing.Point(18, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(153, 37);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio de busqueda";
            // 
            // rbtncodigo
            // 
            this.rbtncodigo.AutoSize = true;
            this.rbtncodigo.Location = new System.Drawing.Point(86, 17);
            this.rbtncodigo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtncodigo.Name = "rbtncodigo";
            this.rbtncodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtncodigo.TabIndex = 2;
            this.rbtncodigo.TabStop = true;
            this.rbtncodigo.Text = "Codigo";
            this.rbtncodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(4, 17);
            this.rbtnnombre.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnnombre.TabIndex = 1;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            this.rbtnnombre.CheckedChanged += new System.EventHandler(this.rbtnnombre_CheckedChanged);
            // 
            // dlistado
            // 
            this.dlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlistado.Location = new System.Drawing.Point(14, 126);
            this.dlistado.Margin = new System.Windows.Forms.Padding(2);
            this.dlistado.Name = "dlistado";
            this.dlistado.RowHeadersWidth = 51;
            this.dlistado.RowTemplate.Height = 24;
            this.dlistado.Size = new System.Drawing.Size(683, 160);
            this.dlistado.TabIndex = 9;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(491, 307);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(57, 21);
            this.btnnuevo.TabIndex = 12;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(564, 307);
            this.btneditar.Margin = new System.Windows.Forms.Padding(2);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(57, 21);
            this.btneditar.TabIndex = 13;
            this.btneditar.Text = "&Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(640, 307);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(57, 21);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "&Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // FrmListadoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dlistado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmListadoProducto";
            this.Text = "FrmListadoProducto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dlistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtncodigo;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.DataGridView dlistado;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
    }
}