namespace CapaPresentacion
{
    partial class frmIngresoInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblPrendas = new System.Windows.Forms.Label();
            this.txtPrendasFab = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSam = new System.Windows.Forms.TextBox();
            this.txtPersonas = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtOrdenProduccion = new System.Windows.Forms.TextBox();
            this.txtSubCat = new System.Windows.Forms.TextBox();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.lblSam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantPersonas = new System.Windows.Forms.Label();
            this.lblCantidadPrendas = new System.Windows.Forms.Label();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblModulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Controls.Add(this.lblPrendas);
            this.panel1.Controls.Add(this.txtPrendasFab);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.lblReferencia);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtSam);
            this.panel1.Controls.Add(this.txtPersonas);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtOrdenProduccion);
            this.panel1.Controls.Add(this.txtSubCat);
            this.panel1.Controls.Add(this.txtModulo);
            this.panel1.Controls.Add(this.lblSam);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblCantPersonas);
            this.panel1.Controls.Add(this.lblCantidadPrendas);
            this.panel1.Controls.Add(this.lblSubCategoria);
            this.panel1.Controls.Add(this.lblOP);
            this.panel1.Controls.Add(this.lblModulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 759);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "NOVEDAD";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(691, 588);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(224, 20);
            this.txtComentario.TabIndex = 20;
            // 
            // lblPrendas
            // 
            this.lblPrendas.AutoSize = true;
            this.lblPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrendas.Location = new System.Drawing.Point(173, 475);
            this.lblPrendas.Name = "lblPrendas";
            this.lblPrendas.Size = new System.Drawing.Size(188, 24);
            this.lblPrendas.TabIndex = 19;
            this.lblPrendas.Text = "Prendas fabricadas";
            this.lblPrendas.Visible = false;
            // 
            // txtPrendasFab
            // 
            this.txtPrendasFab.Location = new System.Drawing.Point(372, 480);
            this.txtPrendasFab.Name = "txtPrendasFab";
            this.txtPrendasFab.Size = new System.Drawing.Size(88, 20);
            this.txtPrendasFab.TabIndex = 18;
            this.txtPrendasFab.Visible = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(372, 361);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(270, 20);
            this.txtReferencia.TabIndex = 17;
            this.txtReferencia.TextChanged += new System.EventHandler(this.txtReferencia_TextChanged);
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.Location = new System.Drawing.Point(220, 357);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(141, 24);
            this.lblReferencia.TabIndex = 16;
            this.lblReferencia.Text = "REFERENCIA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(691, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarClick);
            // 
            // txtSam
            // 
            this.txtSam.Location = new System.Drawing.Point(373, 438);
            this.txtSam.Name = "txtSam";
            this.txtSam.Size = new System.Drawing.Size(270, 20);
            this.txtSam.TabIndex = 14;
            this.txtSam.TextChanged += new System.EventHandler(this.txtSam_TextChanged);
            // 
            // txtPersonas
            // 
            this.txtPersonas.Location = new System.Drawing.Point(373, 397);
            this.txtPersonas.Name = "txtPersonas";
            this.txtPersonas.Size = new System.Drawing.Size(270, 20);
            this.txtPersonas.TabIndex = 13;
            this.txtPersonas.TextChanged += new System.EventHandler(this.txtPersonas_TextChanged);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(372, 323);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(270, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtOrdenProduccion
            // 
            this.txtOrdenProduccion.Location = new System.Drawing.Point(373, 285);
            this.txtOrdenProduccion.Name = "txtOrdenProduccion";
            this.txtOrdenProduccion.Size = new System.Drawing.Size(270, 20);
            this.txtOrdenProduccion.TabIndex = 9;
            this.txtOrdenProduccion.TextChanged += new System.EventHandler(this.txtOrdenProduccion_TextChanged);
            // 
            // txtSubCat
            // 
            this.txtSubCat.Location = new System.Drawing.Point(372, 242);
            this.txtSubCat.Name = "txtSubCat";
            this.txtSubCat.Size = new System.Drawing.Size(270, 20);
            this.txtSubCat.TabIndex = 8;
            this.txtSubCat.TextChanged += new System.EventHandler(this.txtSubCat_TextChanged);
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(372, 203);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(270, 20);
            this.txtModulo.TabIndex = 7;
            this.txtModulo.TextChanged += new System.EventHandler(this.txtModulo_TextChanged);
            // 
            // lblSam
            // 
            this.lblSam.AutoSize = true;
            this.lblSam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSam.Location = new System.Drawing.Point(307, 433);
            this.lblSam.Name = "lblSam";
            this.lblSam.Size = new System.Drawing.Size(54, 24);
            this.lblSam.TabIndex = 6;
            this.lblSam.Text = "SAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(77, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(596, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "INGRESO INFORMACION MODULOS";
            // 
            // lblCantPersonas
            // 
            this.lblCantPersonas.AutoSize = true;
            this.lblCantPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPersonas.Location = new System.Drawing.Point(109, 392);
            this.lblCantPersonas.Name = "lblCantPersonas";
            this.lblCantPersonas.Size = new System.Drawing.Size(252, 24);
            this.lblCantPersonas.TabIndex = 4;
            this.lblCantPersonas.Text = "NUMERO DE PERSONAS";
            // 
            // lblCantidadPrendas
            // 
            this.lblCantidadPrendas.AutoSize = true;
            this.lblCantidadPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPrendas.Location = new System.Drawing.Point(150, 323);
            this.lblCantidadPrendas.Name = "lblCantidadPrendas";
            this.lblCantidadPrendas.Size = new System.Drawing.Size(216, 24);
            this.lblCantidadPrendas.TabIndex = 3;
            this.lblCantidadPrendas.Text = "CANTIDAD PRENDAS";
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubCategoria.Location = new System.Drawing.Point(191, 237);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(175, 24);
            this.lblSubCategoria.TabIndex = 2;
            this.lblSubCategoria.Text = "SUB CATEGORIA";
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.Location = new System.Drawing.Point(109, 281);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(258, 24);
            this.lblOP.TabIndex = 1;
            this.lblOP.Text = "ORDEN DE PRODUCCION";
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(268, 198);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(98, 24);
            this.lblModulo.TabIndex = 0;
            this.lblModulo.Text = "MODULO";
            // 
            // frmIngresoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 759);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngresoInfo";
            this.Text = "frmIngresoInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSam;
        private System.Windows.Forms.TextBox txtPersonas;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtOrdenProduccion;
        private System.Windows.Forms.TextBox txtSubCat;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label lblSam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantPersonas;
        private System.Windows.Forms.Label lblCantidadPrendas;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.Label lblPrendas;
        private System.Windows.Forms.TextBox txtPrendasFab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComentario;
    }
}