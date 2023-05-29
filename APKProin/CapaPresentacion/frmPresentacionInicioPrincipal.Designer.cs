namespace CapaPresentacion
{
    partial class frmPresentacionInicioPrincipal
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresentacionInicioPrincipal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.lblUnidadesEsperadas = new System.Windows.Forms.Label();
            this.lblEficienciaOcumuladaPlanta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPrendasFabricadasPlanta = new System.Windows.Forms.Label();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelSuperior = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelTransicion = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCalidad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnControlPiso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnMecanico = new System.Windows.Forms.Panel();
            this.panelTransicionLogo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelOpciones;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelOpciones.Controls.Add(this.label3);
            this.panelOpciones.Controls.Add(this.lblUnidadesEsperadas);
            this.panelOpciones.Controls.Add(this.lblEficienciaOcumuladaPlanta);
            this.panelOpciones.Controls.Add(this.label2);
            this.panelOpciones.Controls.Add(this.lblTotalPrendasFabricadasPlanta);
            this.panelOpciones.Controls.Add(this.label13);
            this.panelOpciones.Controls.Add(this.btnRestaurar);
            this.panelOpciones.Controls.Add(this.btnMinimizar);
            this.panelOpciones.Controls.Add(this.btnMaximizar);
            this.panelOpciones.Controls.Add(this.btnCerrar);
            this.panelOpciones.Controls.Add(this.panel5);
            this.panelTransicionLogo.SetDecoration(this.panelOpciones, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.panelOpciones, BunifuAnimatorNS.DecorationType.None);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpciones.Location = new System.Drawing.Point(0, 0);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(1747, 47);
            this.panelOpciones.TabIndex = 1;
            // 
            // lblUnidadesEsperadas
            // 
            this.lblUnidadesEsperadas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidadesEsperadas.AutoSize = true;
            this.panelTransicion.SetDecoration(this.lblUnidadesEsperadas, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.lblUnidadesEsperadas, BunifuAnimatorNS.DecorationType.None);
            this.lblUnidadesEsperadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadesEsperadas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnidadesEsperadas.Location = new System.Drawing.Point(819, 5);
            this.lblUnidadesEsperadas.Name = "lblUnidadesEsperadas";
            this.lblUnidadesEsperadas.Size = new System.Drawing.Size(120, 37);
            this.lblUnidadesEsperadas.TabIndex = 112;
            this.lblUnidadesEsperadas.Text = "espera";
            // 
            // lblEficienciaOcumuladaPlanta
            // 
            this.lblEficienciaOcumuladaPlanta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEficienciaOcumuladaPlanta.AutoSize = true;
            this.panelTransicion.SetDecoration(this.lblEficienciaOcumuladaPlanta, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.lblEficienciaOcumuladaPlanta, BunifuAnimatorNS.DecorationType.None);
            this.lblEficienciaOcumuladaPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEficienciaOcumuladaPlanta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEficienciaOcumuladaPlanta.Location = new System.Drawing.Point(1264, 6);
            this.lblEficienciaOcumuladaPlanta.Name = "lblEficienciaOcumuladaPlanta";
            this.lblEficienciaOcumuladaPlanta.Size = new System.Drawing.Size(237, 37);
            this.lblEficienciaOcumuladaPlanta.TabIndex = 110;
            this.lblEficienciaOcumuladaPlanta.Text = "%Acum planta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.panelTransicion.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(1118, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 109;
            this.label2.Text = "Eficiencia\r\nAcumulada planta";
            // 
            // lblTotalPrendasFabricadasPlanta
            // 
            this.lblTotalPrendasFabricadasPlanta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPrendasFabricadasPlanta.AutoSize = true;
            this.panelTransicion.SetDecoration(this.lblTotalPrendasFabricadasPlanta, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.lblTotalPrendasFabricadasPlanta, BunifuAnimatorNS.DecorationType.None);
            this.lblTotalPrendasFabricadasPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrendasFabricadasPlanta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPrendasFabricadasPlanta.Location = new System.Drawing.Point(479, 5);
            this.lblTotalPrendasFabricadasPlanta.Name = "lblTotalPrendasFabricadasPlanta";
            this.lblTotalPrendasFabricadasPlanta.Size = new System.Drawing.Size(198, 37);
            this.lblTotalPrendasFabricadasPlanta.TabIndex = 107;
            this.lblTotalPrendasFabricadasPlanta.Text = "prendas fab";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTransicionLogo.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.btnRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(1676, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(28, 35);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTransicionLogo.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.btnMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(1642, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTransicionLogo.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.btnMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(1676, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(28, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelTransicionLogo.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.btnCerrar, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1709, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel5
            // 
            this.panelTransicionLogo.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(6, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(961, 508);
            this.panel5.TabIndex = 3;
            // 
            // panelSuperior
            // 
            this.panelSuperior.Fixed = true;
            this.panelSuperior.Horizontal = true;
            this.panelSuperior.TargetControl = this.panelOpciones;
            this.panelSuperior.Vertical = true;
            // 
            // panelTransicion
            // 
            this.panelTransicion.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.panelTransicion.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.panelTransicion.DefaultAnimation = animation2;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.bunifuFlatButton3);
            this.panelMenu.Controls.Add(this.bunifuFlatButton2);
            this.panelMenu.Controls.Add(this.bunifuFlatButton1);
            this.panelMenu.Controls.Add(this.btnCalidad);
            this.panelMenu.Controls.Add(this.btnControlPiso);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelTransicionLogo.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 47);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(222, 906);
            this.panelMenu.TabIndex = 17;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Dashboard Real";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransicion.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 70D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(12, 117);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(201, 45);
            this.bunifuFlatButton3.TabIndex = 20;
            this.bunifuFlatButton3.Text = "Dashboard Real";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click_1);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Ingreso      ";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransicion.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(12, 376);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(202, 45);
            this.bunifuFlatButton2.TabIndex = 19;
            this.bunifuFlatButton2.Text = "Ingreso      ";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Mecanico   ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransicion.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(10, 323);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(202, 45);
            this.bunifuFlatButton1.TabIndex = 18;
            this.bunifuFlatButton1.Text = "Mecanico   ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.btnMecanico_click);
            // 
            // btnCalidad
            // 
            this.btnCalidad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalidad.BorderRadius = 0;
            this.btnCalidad.ButtonText = "Calidad       ";
            this.btnCalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransicion.SetDecoration(this.btnCalidad, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.btnCalidad, BunifuAnimatorNS.DecorationType.None);
            this.btnCalidad.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalidad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalidad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCalidad.Iconimage")));
            this.btnCalidad.Iconimage_right = null;
            this.btnCalidad.Iconimage_right_Selected = null;
            this.btnCalidad.Iconimage_Selected = null;
            this.btnCalidad.IconMarginLeft = 0;
            this.btnCalidad.IconMarginRight = 0;
            this.btnCalidad.IconRightVisible = true;
            this.btnCalidad.IconRightZoom = 0D;
            this.btnCalidad.IconVisible = true;
            this.btnCalidad.IconZoom = 70D;
            this.btnCalidad.IsTab = false;
            this.btnCalidad.Location = new System.Drawing.Point(11, 272);
            this.btnCalidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalidad.Name = "btnCalidad";
            this.btnCalidad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCalidad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCalidad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalidad.selected = false;
            this.btnCalidad.Size = new System.Drawing.Size(202, 45);
            this.btnCalidad.TabIndex = 18;
            this.btnCalidad.Text = "Calidad       ";
            this.btnCalidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalidad.Textcolor = System.Drawing.Color.White;
            this.btnCalidad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalidad.Click += new System.EventHandler(this.btnCalidad_Click);
            // 
            // btnControlPiso
            // 
            this.btnControlPiso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnControlPiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnControlPiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnControlPiso.BorderRadius = 0;
            this.btnControlPiso.ButtonText = "Control Píso";
            this.btnControlPiso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransicion.SetDecoration(this.btnControlPiso, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.btnControlPiso, BunifuAnimatorNS.DecorationType.None);
            this.btnControlPiso.DisabledColor = System.Drawing.Color.Gray;
            this.btnControlPiso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnControlPiso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnControlPiso.Iconimage")));
            this.btnControlPiso.Iconimage_right = null;
            this.btnControlPiso.Iconimage_right_Selected = null;
            this.btnControlPiso.Iconimage_Selected = null;
            this.btnControlPiso.IconMarginLeft = 0;
            this.btnControlPiso.IconMarginRight = 0;
            this.btnControlPiso.IconRightVisible = true;
            this.btnControlPiso.IconRightZoom = 0D;
            this.btnControlPiso.IconVisible = true;
            this.btnControlPiso.IconZoom = 70D;
            this.btnControlPiso.IsTab = false;
            this.btnControlPiso.Location = new System.Drawing.Point(12, 221);
            this.btnControlPiso.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlPiso.Name = "btnControlPiso";
            this.btnControlPiso.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnControlPiso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnControlPiso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnControlPiso.selected = false;
            this.btnControlPiso.Size = new System.Drawing.Size(201, 45);
            this.btnControlPiso.TabIndex = 17;
            this.btnControlPiso.Text = "Control Píso";
            this.btnControlPiso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnControlPiso.Textcolor = System.Drawing.Color.White;
            this.btnControlPiso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPiso.Click += new System.EventHandler(this.btnControlPiso_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Black;
            this.panelTransicionLogo.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(181, 1);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 34);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 16;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.panelTransicion.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "APKProin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "Dashboard ";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelTransicion.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = null;
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 70D;
            this.btnDashboard.IsTab = false;
            this.btnDashboard.Location = new System.Drawing.Point(12, 170);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(201, 45);
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Text = "Dashboard ";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDashboard.Textcolor = System.Drawing.Color.White;
            this.btnDashboard.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.AutoSize = true;
            this.panelPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPrincipal.Controls.Add(this.btnMecanico);
            this.panelPrincipal.Controls.Add(this.panelMenu);
            this.panelPrincipal.Controls.Add(this.panelOpciones);
            this.panelTransicionLogo.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.panelPrincipal, BunifuAnimatorNS.DecorationType.None);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1747, 953);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // btnMecanico
            // 
            this.btnMecanico.AutoSize = true;
            this.btnMecanico.BackColor = System.Drawing.Color.White;
            this.panelTransicionLogo.SetDecoration(this.btnMecanico, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this.btnMecanico, BunifuAnimatorNS.DecorationType.None);
            this.btnMecanico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMecanico.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMecanico.Location = new System.Drawing.Point(222, 47);
            this.btnMecanico.Margin = new System.Windows.Forms.Padding(2);
            this.btnMecanico.Name = "btnMecanico";
            this.btnMecanico.Size = new System.Drawing.Size(1525, 906);
            this.btnMecanico.TabIndex = 18;
            this.btnMecanico.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenus_Paint);
            // 
            // panelTransicionLogo
            // 
            this.panelTransicionLogo.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.panelTransicionLogo.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0.5F;
            animation1.RotateLimit = 0.2F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelTransicionLogo.DefaultAnimation = animation1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.panelTransicion.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(391, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 32);
            this.label13.TabIndex = 108;
            this.label13.Text = "Prendas \r\nfabricadas ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.panelTransicion.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicionLogo.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(740, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 32);
            this.label3.TabIndex = 113;
            this.label3.Text = "Meta\r\nacumulada";
            // 
            // frmPresentacionInicioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1747, 953);
            this.Controls.Add(this.panelPrincipal);
            this.panelTransicionLogo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelTransicion.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPresentacionInicioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmPresentacionInicioPrincipal_Resize);
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl panelSuperior;
        private BunifuAnimatorNS.BunifuTransition panelTransicionLogo;
        private BunifuAnimatorNS.BunifuTransition panelTransicion;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private System.Windows.Forms.Panel panelOpciones;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private Bunifu.Framework.UI.BunifuFlatButton btnControlPiso;
        private System.Windows.Forms.Panel btnMecanico;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalidad;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label lblTotalPrendasFabricadasPlanta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEficienciaOcumuladaPlanta;
        private System.Windows.Forms.Label lblUnidadesEsperadas;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
    }
}