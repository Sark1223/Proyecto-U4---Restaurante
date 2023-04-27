namespace Restaurante___reporte.PL
{
    partial class frmIngredientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngredientes));
            this.label8 = new System.Windows.Forms.Label();
            this.lblIgredienteId = new System.Windows.Forms.Label();
            this.lblIngredienteNombre = new System.Windows.Forms.Label();
            this.lblCantidadAlmacen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIngredienteId = new System.Windows.Forms.TextBox();
            this.txtIngredienteNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIngredienteCant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RadioAgregar = new ns1.BunifuElipse(this.components);
            this.btnAgregarIngrediente = new ns1.BunifuFlatButton();
            this.RadioEditar = new ns1.BunifuElipse(this.components);
            this.btnEditarIngrediente = new ns1.BunifuFlatButton();
            this.RadioBuscar = new ns1.BunifuElipse(this.components);
            this.btnBuscarIngrediente = new ns1.BunifuFlatButton();
            this.RadioEliminar = new ns1.BunifuElipse(this.components);
            this.btnEliminarIngrediente = new ns1.BunifuFlatButton();
            this.RadioIngredientes = new ns1.BunifuElipse(this.components);
            this.dgvTablaDB = new System.Windows.Forms.DataGridView();
            this.Panel = new System.Windows.Forms.Panel();
            this.comboMed = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.RadioPanel = new ns1.BunifuElipse(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDB)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "INVENTARIO DE INGREDIENTES";
            // 
            // lblIgredienteId
            // 
            this.lblIgredienteId.AutoSize = true;
            this.lblIgredienteId.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgredienteId.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblIgredienteId.Location = new System.Drawing.Point(14, 23);
            this.lblIgredienteId.Name = "lblIgredienteId";
            this.lblIgredienteId.Size = new System.Drawing.Size(102, 21);
            this.lblIgredienteId.TabIndex = 8;
            this.lblIgredienteId.Text = "Identificador:";
            // 
            // lblIngredienteNombre
            // 
            this.lblIngredienteNombre.AutoSize = true;
            this.lblIngredienteNombre.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredienteNombre.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblIngredienteNombre.Location = new System.Drawing.Point(146, 23);
            this.lblIngredienteNombre.Name = "lblIngredienteNombre";
            this.lblIngredienteNombre.Size = new System.Drawing.Size(72, 21);
            this.lblIngredienteNombre.TabIndex = 9;
            this.lblIngredienteNombre.Text = "Nombre:";
            // 
            // lblCantidadAlmacen
            // 
            this.lblCantidadAlmacen.AutoSize = true;
            this.lblCantidadAlmacen.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAlmacen.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblCantidadAlmacen.Location = new System.Drawing.Point(185, 104);
            this.lblCantidadAlmacen.Name = "lblCantidadAlmacen";
            this.lblCantidadAlmacen.Size = new System.Drawing.Size(179, 21);
            this.lblCantidadAlmacen.TabIndex = 11;
            this.lblCantidadAlmacen.Text = "Cantidad en Almacen:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel2.Location = new System.Drawing.Point(19, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 2);
            this.panel2.TabIndex = 14;
            // 
            // txtIngredienteId
            // 
            this.txtIngredienteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txtIngredienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteId.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteId.Location = new System.Drawing.Point(19, 54);
            this.txtIngredienteId.Name = "txtIngredienteId";
            this.txtIngredienteId.ShortcutsEnabled = false;
            this.txtIngredienteId.Size = new System.Drawing.Size(97, 25);
            this.txtIngredienteId.TabIndex = 16;
            this.txtIngredienteId.Click += new System.EventHandler(this.txtIngredienteId_Click);
            this.txtIngredienteId.CursorChanged += new System.EventHandler(this.txtIngredienteId_CursorChanged);
            this.txtIngredienteId.TextChanged += new System.EventHandler(this.txtIngredienteId_TextChanged);
            this.txtIngredienteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngredienteId_KeyPress);
            // 
            // txtIngredienteNombre
            // 
            this.txtIngredienteNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txtIngredienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteNombre.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteNombre.Location = new System.Drawing.Point(150, 54);
            this.txtIngredienteNombre.Name = "txtIngredienteNombre";
            this.txtIngredienteNombre.ShortcutsEnabled = false;
            this.txtIngredienteNombre.Size = new System.Drawing.Size(200, 25);
            this.txtIngredienteNombre.TabIndex = 18;
            this.txtIngredienteNombre.Text = "holaa";
            this.txtIngredienteNombre.Click += new System.EventHandler(this.txtIngredienteNombre_Click);
            this.txtIngredienteNombre.TextChanged += new System.EventHandler(this.txtIngredienteNombre_TextChanged);
            this.txtIngredienteNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngredienteNombre_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel1.Location = new System.Drawing.Point(150, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 17;
            // 
            // txtIngredienteCant
            // 
            this.txtIngredienteCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.txtIngredienteCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteCant.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteCant.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteCant.Location = new System.Drawing.Point(204, 133);
            this.txtIngredienteCant.Name = "txtIngredienteCant";
            this.txtIngredienteCant.ShortcutsEnabled = false;
            this.txtIngredienteCant.Size = new System.Drawing.Size(160, 25);
            this.txtIngredienteCant.TabIndex = 20;
            this.txtIngredienteCant.Click += new System.EventHandler(this.txtIngredienteCant_Click);
            this.txtIngredienteCant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngredienteCant_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel3.Location = new System.Drawing.Point(204, 158);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 2);
            this.panel3.TabIndex = 19;
            // 
            // RadioAgregar
            // 
            this.RadioAgregar.ElipseRadius = 20;
            this.RadioAgregar.TargetControl = this.btnAgregarIngrediente;
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.btnAgregarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarIngrediente.BorderRadius = 0;
            this.btnAgregarIngrediente.ButtonText = "Agregar";
            this.btnAgregarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarIngrediente.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarIngrediente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.cocinando;
            this.btnAgregarIngrediente.Iconimage_right = null;
            this.btnAgregarIngrediente.Iconimage_right_Selected = null;
            this.btnAgregarIngrediente.Iconimage_Selected = null;
            this.btnAgregarIngrediente.IconMarginLeft = 0;
            this.btnAgregarIngrediente.IconMarginRight = 0;
            this.btnAgregarIngrediente.IconRightVisible = true;
            this.btnAgregarIngrediente.IconRightZoom = 0D;
            this.btnAgregarIngrediente.IconVisible = true;
            this.btnAgregarIngrediente.IconZoom = 90D;
            this.btnAgregarIngrediente.IsTab = false;
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(391, 52);
            this.btnAgregarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAgregarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarIngrediente.selected = false;
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(140, 50);
            this.btnAgregarIngrediente.TabIndex = 22;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnAgregarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // RadioEditar
            // 
            this.RadioEditar.ElipseRadius = 20;
            this.RadioEditar.TargetControl = this.btnEditarIngrediente;
            // 
            // btnEditarIngrediente
            // 
            this.btnEditarIngrediente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.btnEditarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditarIngrediente.BorderRadius = 0;
            this.btnEditarIngrediente.ButtonText = "Editar";
            this.btnEditarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarIngrediente.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditarIngrediente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.editar;
            this.btnEditarIngrediente.Iconimage_right = null;
            this.btnEditarIngrediente.Iconimage_right_Selected = null;
            this.btnEditarIngrediente.Iconimage_Selected = null;
            this.btnEditarIngrediente.IconMarginLeft = 0;
            this.btnEditarIngrediente.IconMarginRight = 0;
            this.btnEditarIngrediente.IconRightVisible = true;
            this.btnEditarIngrediente.IconRightZoom = 0D;
            this.btnEditarIngrediente.IconVisible = true;
            this.btnEditarIngrediente.IconZoom = 90D;
            this.btnEditarIngrediente.IsTab = false;
            this.btnEditarIngrediente.Location = new System.Drawing.Point(391, 109);
            this.btnEditarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditarIngrediente.Name = "btnEditarIngrediente";
            this.btnEditarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEditarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEditarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarIngrediente.selected = false;
            this.btnEditarIngrediente.Size = new System.Drawing.Size(140, 50);
            this.btnEditarIngrediente.TabIndex = 39;
            this.btnEditarIngrediente.Text = "Editar";
            this.btnEditarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnEditarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RadioBuscar
            // 
            this.RadioBuscar.ElipseRadius = 20;
            this.RadioBuscar.TargetControl = this.btnBuscarIngrediente;
            // 
            // btnBuscarIngrediente
            // 
            this.btnBuscarIngrediente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.btnBuscarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarIngrediente.BorderRadius = 0;
            this.btnBuscarIngrediente.ButtonText = "Buscar";
            this.btnBuscarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarIngrediente.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarIngrediente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.buscar_ingrediente;
            this.btnBuscarIngrediente.Iconimage_right = null;
            this.btnBuscarIngrediente.Iconimage_right_Selected = null;
            this.btnBuscarIngrediente.Iconimage_Selected = null;
            this.btnBuscarIngrediente.IconMarginLeft = 0;
            this.btnBuscarIngrediente.IconMarginRight = 0;
            this.btnBuscarIngrediente.IconRightVisible = true;
            this.btnBuscarIngrediente.IconRightZoom = 0D;
            this.btnBuscarIngrediente.IconVisible = true;
            this.btnBuscarIngrediente.IconZoom = 90D;
            this.btnBuscarIngrediente.IsTab = false;
            this.btnBuscarIngrediente.Location = new System.Drawing.Point(20, 189);
            this.btnBuscarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarIngrediente.Name = "btnBuscarIngrediente";
            this.btnBuscarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBuscarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnBuscarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarIngrediente.selected = false;
            this.btnBuscarIngrediente.Size = new System.Drawing.Size(116, 50);
            this.btnBuscarIngrediente.TabIndex = 41;
            this.btnBuscarIngrediente.Text = "Buscar";
            this.btnBuscarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnBuscarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RadioEliminar
            // 
            this.RadioEliminar.ElipseRadius = 20;
            this.RadioEliminar.TargetControl = this.btnEliminarIngrediente;
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.btnEliminarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarIngrediente.BorderRadius = 0;
            this.btnEliminarIngrediente.ButtonText = "Eliminar";
            this.btnEliminarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarIngrediente.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarIngrediente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.eliminar_comida;
            this.btnEliminarIngrediente.Iconimage_right = null;
            this.btnEliminarIngrediente.Iconimage_right_Selected = null;
            this.btnEliminarIngrediente.Iconimage_Selected = null;
            this.btnEliminarIngrediente.IconMarginLeft = 0;
            this.btnEliminarIngrediente.IconMarginRight = 0;
            this.btnEliminarIngrediente.IconRightVisible = true;
            this.btnEliminarIngrediente.IconRightZoom = 0D;
            this.btnEliminarIngrediente.IconVisible = true;
            this.btnEliminarIngrediente.IconZoom = 90D;
            this.btnEliminarIngrediente.IsTab = false;
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(391, 166);
            this.btnEliminarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEliminarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarIngrediente.selected = false;
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(140, 50);
            this.btnEliminarIngrediente.TabIndex = 40;
            this.btnEliminarIngrediente.Text = "Eliminar";
            this.btnEliminarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnEliminarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // RadioIngredientes
            // 
            this.RadioIngredientes.ElipseRadius = 10;
            this.RadioIngredientes.TargetControl = this;
            // 
            // dgvTablaDB
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(193)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTablaDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTablaDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTablaDB.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTablaDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTablaDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaDB.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTablaDB.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTablaDB.EnableHeadersVisualStyles = false;
            this.dgvTablaDB.Location = new System.Drawing.Point(18, 240);
            this.dgvTablaDB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaDB.Name = "dgvTablaDB";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(88)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTablaDB.RowHeadersVisible = false;
            this.dgvTablaDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvTablaDB.RowTemplate.Height = 30;
            this.dgvTablaDB.Size = new System.Drawing.Size(525, 160);
            this.dgvTablaDB.TabIndex = 43;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.Panel.Controls.Add(this.comboMed);
            this.Panel.Controls.Add(this.panel4);
            this.Panel.Controls.Add(this.bunifuThinButton21);
            this.Panel.Controls.Add(this.dgvTablaDB);
            this.Panel.Controls.Add(this.btnBuscarIngrediente);
            this.Panel.Controls.Add(this.btnEliminarIngrediente);
            this.Panel.Controls.Add(this.btnEditarIngrediente);
            this.Panel.Controls.Add(this.btnAgregarIngrediente);
            this.Panel.Controls.Add(this.txtIngredienteCant);
            this.Panel.Controls.Add(this.panel3);
            this.Panel.Controls.Add(this.txtIngredienteNombre);
            this.Panel.Controls.Add(this.panel1);
            this.Panel.Controls.Add(this.txtIngredienteId);
            this.Panel.Controls.Add(this.panel2);
            this.Panel.Controls.Add(this.lblCantidadAlmacen);
            this.Panel.Controls.Add(this.lblIngredienteNombre);
            this.Panel.Controls.Add(this.lblIgredienteId);
            this.Panel.Location = new System.Drawing.Point(6, 36);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(563, 406);
            this.Panel.TabIndex = 44;
            // 
            // comboMed
            // 
            this.comboMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.comboMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.comboMed.ForeColor = System.Drawing.SystemColors.MenuText;
            this.comboMed.FormattingEnabled = true;
            this.comboMed.Items.AddRange(new object[] {
            "Kg",
            "L",
            "gr",
            "ml"});
            this.comboMed.Location = new System.Drawing.Point(20, 132);
            this.comboMed.Name = "comboMed";
            this.comboMed.Size = new System.Drawing.Size(148, 26);
            this.comboMed.TabIndex = 74;
            this.comboMed.Text = "-- Medida --";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.panel4.Location = new System.Drawing.Point(20, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 2);
            this.panel4.TabIndex = 73;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Limpiar todo";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(123)))), ((int)(((byte)(130)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(181)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(392, 10);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(151, 34);
            this.bunifuThinButton21.TabIndex = 72;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.cmdLimpiar);
            // 
            // RadioPanel
            // 
            this.RadioPanel.ElipseRadius = 20;
            this.RadioPanel.TargetControl = this.Panel;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.panel9.Location = new System.Drawing.Point(6, 426);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(563, 16);
            this.panel9.TabIndex = 44;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::Restaurante___reporte.Properties.Resources.Equis;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(526, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 28);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 45;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(577, 449);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngredientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.frmIngredientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDB)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIgredienteId;
        private System.Windows.Forms.Label lblIngredienteNombre;
        private System.Windows.Forms.Label lblCantidadAlmacen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIngredienteId;
        private System.Windows.Forms.TextBox txtIngredienteNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIngredienteCant;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuFlatButton btnAgregarIngrediente;
        private ns1.BunifuElipse RadioAgregar;
        private ns1.BunifuFlatButton btnEditarIngrediente;
        private ns1.BunifuFlatButton btnEliminarIngrediente;
        private ns1.BunifuFlatButton btnBuscarIngrediente;
        private ns1.BunifuElipse RadioEditar;
        private ns1.BunifuElipse RadioBuscar;
        private ns1.BunifuElipse RadioEliminar;
        private ns1.BunifuElipse RadioIngredientes;
        public System.Windows.Forms.DataGridView dgvTablaDB;
        private System.Windows.Forms.Panel Panel;
        private ns1.BunifuElipse RadioPanel;
        private System.Windows.Forms.Panel panel9;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ComboBox comboMed;
        private System.Windows.Forms.Panel panel4;
    }
}