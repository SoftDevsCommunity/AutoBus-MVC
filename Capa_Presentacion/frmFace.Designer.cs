namespace Capa_Presentacion
{
    partial class frmFace
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipsefrmFace = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControlPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tablaChoferCompleto = new System.Windows.Forms.DataGridView();
            this.btnAsignarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAsignarAutobus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarAutobus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarChofer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChoferCompleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Capa_Presentacion.Properties.Resources.X;
            this.pictureBox3.Location = new System.Drawing.Point(762, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(185)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Terminal de autobuses.";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(85, 162);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 13);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choferes y rutas activas.";
            // 
            // bunifuElipsefrmFace
            // 
            this.bunifuElipsefrmFace.ElipseRadius = 7;
            this.bunifuElipsefrmFace.TargetControl = this;
            // 
            // bunifuDragControlPanel
            // 
            this.bunifuDragControlPanel.Fixed = true;
            this.bunifuDragControlPanel.Horizontal = true;
            this.bunifuDragControlPanel.TargetControl = this.panel1;
            this.bunifuDragControlPanel.Vertical = true;
            // 
            // tablaChoferCompleto
            // 
            this.tablaChoferCompleto.AllowUserToAddRows = false;
            this.tablaChoferCompleto.AllowUserToDeleteRows = false;
            this.tablaChoferCompleto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaChoferCompleto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaChoferCompleto.BackgroundColor = System.Drawing.Color.White;
            this.tablaChoferCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaChoferCompleto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaChoferCompleto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaChoferCompleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaChoferCompleto.ColumnHeadersVisible = false;
            this.tablaChoferCompleto.Location = new System.Drawing.Point(47, 187);
            this.tablaChoferCompleto.Name = "tablaChoferCompleto";
            this.tablaChoferCompleto.ReadOnly = true;
            this.tablaChoferCompleto.RowHeadersVisible = false;
            this.tablaChoferCompleto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaChoferCompleto.Size = new System.Drawing.Size(417, 232);
            this.tablaChoferCompleto.TabIndex = 11;
            // 
            // btnAsignarRuta
            // 
            this.btnAsignarRuta.Activecolor = System.Drawing.Color.Red;
            this.btnAsignarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAsignarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignarRuta.BorderRadius = 0;
            this.btnAsignarRuta.ButtonText = "Asignar Ruta";
            this.btnAsignarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsignarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsignarRuta.Iconimage = global::Capa_Presentacion.Properties.Resources.add;
            this.btnAsignarRuta.Iconimage_right = null;
            this.btnAsignarRuta.Iconimage_right_Selected = null;
            this.btnAsignarRuta.Iconimage_Selected = null;
            this.btnAsignarRuta.IconMarginLeft = 0;
            this.btnAsignarRuta.IconMarginRight = 0;
            this.btnAsignarRuta.IconRightVisible = true;
            this.btnAsignarRuta.IconRightZoom = 0D;
            this.btnAsignarRuta.IconVisible = true;
            this.btnAsignarRuta.IconZoom = 90D;
            this.btnAsignarRuta.IsTab = false;
            this.btnAsignarRuta.Location = new System.Drawing.Point(609, 365);
            this.btnAsignarRuta.Name = "btnAsignarRuta";
            this.btnAsignarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAsignarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAsignarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsignarRuta.selected = false;
            this.btnAsignarRuta.Size = new System.Drawing.Size(151, 35);
            this.btnAsignarRuta.TabIndex = 10;
            this.btnAsignarRuta.Text = "Asignar Ruta";
            this.btnAsignarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarRuta.Textcolor = System.Drawing.Color.White;
            this.btnAsignarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRuta.Click += new System.EventHandler(this.btnAsignarRuta_Click);
            // 
            // btnAsignarAutobus
            // 
            this.btnAsignarAutobus.Activecolor = System.Drawing.Color.Red;
            this.btnAsignarAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAsignarAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignarAutobus.BorderRadius = 0;
            this.btnAsignarAutobus.ButtonText = "Asignar Autobus";
            this.btnAsignarAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarAutobus.DisabledColor = System.Drawing.Color.Gray;
            this.btnAsignarAutobus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAsignarAutobus.Iconimage = global::Capa_Presentacion.Properties.Resources.add;
            this.btnAsignarAutobus.Iconimage_right = null;
            this.btnAsignarAutobus.Iconimage_right_Selected = null;
            this.btnAsignarAutobus.Iconimage_Selected = null;
            this.btnAsignarAutobus.IconMarginLeft = 0;
            this.btnAsignarAutobus.IconMarginRight = 0;
            this.btnAsignarAutobus.IconRightVisible = true;
            this.btnAsignarAutobus.IconRightZoom = 0D;
            this.btnAsignarAutobus.IconVisible = true;
            this.btnAsignarAutobus.IconZoom = 90D;
            this.btnAsignarAutobus.IsTab = false;
            this.btnAsignarAutobus.Location = new System.Drawing.Point(609, 314);
            this.btnAsignarAutobus.Name = "btnAsignarAutobus";
            this.btnAsignarAutobus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAsignarAutobus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAsignarAutobus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAsignarAutobus.selected = false;
            this.btnAsignarAutobus.Size = new System.Drawing.Size(151, 35);
            this.btnAsignarAutobus.TabIndex = 9;
            this.btnAsignarAutobus.Text = "Asignar Autobus";
            this.btnAsignarAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarAutobus.Textcolor = System.Drawing.Color.White;
            this.btnAsignarAutobus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarAutobus.Click += new System.EventHandler(this.btnAsignarAutobus_Click);
            // 
            // btnAgregarRuta
            // 
            this.btnAgregarRuta.Activecolor = System.Drawing.Color.Red;
            this.btnAgregarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAgregarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarRuta.BorderRadius = 0;
            this.btnAgregarRuta.ButtonText = "Agregar Ruta";
            this.btnAgregarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarRuta.Iconimage = global::Capa_Presentacion.Properties.Resources.ruta;
            this.btnAgregarRuta.Iconimage_right = null;
            this.btnAgregarRuta.Iconimage_right_Selected = null;
            this.btnAgregarRuta.Iconimage_Selected = null;
            this.btnAgregarRuta.IconMarginLeft = 0;
            this.btnAgregarRuta.IconMarginRight = 0;
            this.btnAgregarRuta.IconRightVisible = true;
            this.btnAgregarRuta.IconRightZoom = 0D;
            this.btnAgregarRuta.IconVisible = true;
            this.btnAgregarRuta.IconZoom = 90D;
            this.btnAgregarRuta.IsTab = false;
            this.btnAgregarRuta.Location = new System.Drawing.Point(609, 262);
            this.btnAgregarRuta.Name = "btnAgregarRuta";
            this.btnAgregarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAgregarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarRuta.selected = false;
            this.btnAgregarRuta.Size = new System.Drawing.Size(151, 35);
            this.btnAgregarRuta.TabIndex = 8;
            this.btnAgregarRuta.Text = "Agregar Ruta";
            this.btnAgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarRuta.Textcolor = System.Drawing.Color.White;
            this.btnAgregarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRuta.Click += new System.EventHandler(this.btnAgregarRuta_Click);
            // 
            // btnAgregarAutobus
            // 
            this.btnAgregarAutobus.Activecolor = System.Drawing.Color.Red;
            this.btnAgregarAutobus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAgregarAutobus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAutobus.BorderRadius = 0;
            this.btnAgregarAutobus.ButtonText = "Agregar Autobus";
            this.btnAgregarAutobus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAutobus.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarAutobus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarAutobus.Iconimage = global::Capa_Presentacion.Properties.Resources.add1;
            this.btnAgregarAutobus.Iconimage_right = null;
            this.btnAgregarAutobus.Iconimage_right_Selected = null;
            this.btnAgregarAutobus.Iconimage_Selected = null;
            this.btnAgregarAutobus.IconMarginLeft = 0;
            this.btnAgregarAutobus.IconMarginRight = 0;
            this.btnAgregarAutobus.IconRightVisible = true;
            this.btnAgregarAutobus.IconRightZoom = 0D;
            this.btnAgregarAutobus.IconVisible = true;
            this.btnAgregarAutobus.IconZoom = 90D;
            this.btnAgregarAutobus.IsTab = false;
            this.btnAgregarAutobus.Location = new System.Drawing.Point(609, 209);
            this.btnAgregarAutobus.Name = "btnAgregarAutobus";
            this.btnAgregarAutobus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAgregarAutobus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarAutobus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarAutobus.selected = false;
            this.btnAgregarAutobus.Size = new System.Drawing.Size(151, 35);
            this.btnAgregarAutobus.TabIndex = 7;
            this.btnAgregarAutobus.Text = "Agregar Autobus";
            this.btnAgregarAutobus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAutobus.Textcolor = System.Drawing.Color.White;
            this.btnAgregarAutobus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutobus.Click += new System.EventHandler(this.btnAgregarAutobus_Click);
            // 
            // btnAgregarChofer
            // 
            this.btnAgregarChofer.Activecolor = System.Drawing.Color.Red;
            this.btnAgregarChofer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAgregarChofer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarChofer.BorderRadius = 0;
            this.btnAgregarChofer.ButtonText = "Agregar Chofer";
            this.btnAgregarChofer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarChofer.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarChofer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarChofer.Iconimage = global::Capa_Presentacion.Properties.Resources.añadir;
            this.btnAgregarChofer.Iconimage_right = null;
            this.btnAgregarChofer.Iconimage_right_Selected = null;
            this.btnAgregarChofer.Iconimage_Selected = null;
            this.btnAgregarChofer.IconMarginLeft = 0;
            this.btnAgregarChofer.IconMarginRight = 0;
            this.btnAgregarChofer.IconRightVisible = true;
            this.btnAgregarChofer.IconRightZoom = 0D;
            this.btnAgregarChofer.IconVisible = true;
            this.btnAgregarChofer.IconZoom = 90D;
            this.btnAgregarChofer.IsTab = false;
            this.btnAgregarChofer.Location = new System.Drawing.Point(609, 156);
            this.btnAgregarChofer.Name = "btnAgregarChofer";
            this.btnAgregarChofer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAgregarChofer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarChofer.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarChofer.selected = false;
            this.btnAgregarChofer.Size = new System.Drawing.Size(151, 35);
            this.btnAgregarChofer.TabIndex = 6;
            this.btnAgregarChofer.Text = "Agregar Chofer";
            this.btnAgregarChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarChofer.Textcolor = System.Drawing.Color.White;
            this.btnAgregarChofer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarChofer.Click += new System.EventHandler(this.btnAgregarChofer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa_Presentacion.Properties.Resources.textbox;
            this.pictureBox2.Location = new System.Drawing.Point(76, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.lupa;
            this.pictureBox1.Location = new System.Drawing.Point(47, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Activecolor = System.Drawing.Color.Red;
            this.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrescar.BorderRadius = 0;
            this.btnRefrescar.ButtonText = "Refrescar";
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.DisabledColor = System.Drawing.Color.Gray;
            this.btnRefrescar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Iconimage = global::Capa_Presentacion.Properties.Resources.ruta;
            this.btnRefrescar.Iconimage_right = null;
            this.btnRefrescar.Iconimage_right_Selected = null;
            this.btnRefrescar.Iconimage_Selected = null;
            this.btnRefrescar.IconMarginLeft = 0;
            this.btnRefrescar.IconMarginRight = 0;
            this.btnRefrescar.IconRightVisible = true;
            this.btnRefrescar.IconRightZoom = 0D;
            this.btnRefrescar.IconVisible = true;
            this.btnRefrescar.IconZoom = 90D;
            this.btnRefrescar.IsTab = false;
            this.btnRefrescar.Location = new System.Drawing.Point(482, 262);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRefrescar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRefrescar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRefrescar.selected = false;
            this.btnRefrescar.Size = new System.Drawing.Size(114, 35);
            this.btnRefrescar.TabIndex = 12;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefrescar.Textcolor = System.Drawing.Color.White;
            this.btnRefrescar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // frmFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.tablaChoferCompleto);
            this.Controls.Add(this.btnAsignarRuta);
            this.Controls.Add(this.btnAsignarAutobus);
            this.Controls.Add(this.btnAgregarRuta);
            this.Controls.Add(this.btnAgregarAutobus);
            this.Controls.Add(this.btnAgregarChofer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFace";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaChoferCompleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipsefrmFace;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControlPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarChofer;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsignarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btnAsignarAutobus;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarAutobus;
        private System.Windows.Forms.DataGridView tablaChoferCompleto;
        private Bunifu.Framework.UI.BunifuFlatButton btnRefrescar;
    }
}

