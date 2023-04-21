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
            this.label8 = new System.Windows.Forms.Label();
            this.lblIgredienteId = new System.Windows.Forms.Label();
            this.lblIngredienteNombre = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblCantidadAlmacen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIngredienteId = new System.Windows.Forms.TextBox();
            this.txtIngredienteNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIngredienteCant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarIngrediente = new ns1.BunifuFlatButton();
            this.comboMed = new ns1.BunifuDropdown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.btnEditarIngrediente = new ns1.BunifuFlatButton();
            this.btnEliminarIngrediente = new ns1.BunifuFlatButton();
            this.btnBuscarIngrediente = new ns1.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(265, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "AGREGAR INGREDIENTE";
            // 
            // lblIgredienteId
            // 
            this.lblIgredienteId.AutoSize = true;
            this.lblIgredienteId.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgredienteId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.lblIgredienteId.Location = new System.Drawing.Point(12, 97);
            this.lblIgredienteId.Name = "lblIgredienteId";
            this.lblIgredienteId.Size = new System.Drawing.Size(102, 21);
            this.lblIgredienteId.TabIndex = 8;
            this.lblIgredienteId.Text = "Identificador:";
            // 
            // lblIngredienteNombre
            // 
            this.lblIngredienteNombre.AutoSize = true;
            this.lblIngredienteNombre.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredienteNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.lblIngredienteNombre.Location = new System.Drawing.Point(275, 97);
            this.lblIngredienteNombre.Name = "lblIngredienteNombre";
            this.lblIngredienteNombre.Size = new System.Drawing.Size(72, 21);
            this.lblIngredienteNombre.TabIndex = 9;
            this.lblIngredienteNombre.Text = "Nombre:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.lblUnidadMedida.Location = new System.Drawing.Point(12, 206);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(156, 21);
            this.lblUnidadMedida.TabIndex = 10;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblCantidadAlmacen
            // 
            this.lblCantidadAlmacen.AutoSize = true;
            this.lblCantidadAlmacen.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAlmacen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.lblCantidadAlmacen.Location = new System.Drawing.Point(275, 206);
            this.lblCantidadAlmacen.Name = "lblCantidadAlmacen";
            this.lblCantidadAlmacen.Size = new System.Drawing.Size(179, 21);
            this.lblCantidadAlmacen.TabIndex = 11;
            this.lblCantidadAlmacen.Text = "Cantidad en Almacen:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel2.Location = new System.Drawing.Point(17, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 14;
            // 
            // txtIngredienteId
            // 
            this.txtIngredienteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.txtIngredienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteId.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteId.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteId.Location = new System.Drawing.Point(17, 135);
            this.txtIngredienteId.Name = "txtIngredienteId";
            this.txtIngredienteId.Size = new System.Drawing.Size(200, 25);
            this.txtIngredienteId.TabIndex = 16;
            this.txtIngredienteId.Click += new System.EventHandler(this.txtIngredienteId_Click);
            this.txtIngredienteId.CursorChanged += new System.EventHandler(this.txtIngredienteId_CursorChanged);
            this.txtIngredienteId.TextChanged += new System.EventHandler(this.txtIngredienteId_TextChanged);
            // 
            // txtIngredienteNombre
            // 
            this.txtIngredienteNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.txtIngredienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteNombre.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteNombre.Location = new System.Drawing.Point(280, 135);
            this.txtIngredienteNombre.Name = "txtIngredienteNombre";
            this.txtIngredienteNombre.Size = new System.Drawing.Size(200, 25);
            this.txtIngredienteNombre.TabIndex = 18;
            this.txtIngredienteNombre.Click += new System.EventHandler(this.txtIngredienteNombre_Click);
            this.txtIngredienteNombre.TextChanged += new System.EventHandler(this.txtIngredienteNombre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel1.Location = new System.Drawing.Point(280, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 17;
            // 
            // txtIngredienteCant
            // 
            this.txtIngredienteCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.txtIngredienteCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteCant.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteCant.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteCant.Location = new System.Drawing.Point(280, 246);
            this.txtIngredienteCant.Name = "txtIngredienteCant";
            this.txtIngredienteCant.Size = new System.Drawing.Size(200, 25);
            this.txtIngredienteCant.TabIndex = 20;
            this.txtIngredienteCant.Click += new System.EventHandler(this.txtIngredienteCant_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel3.Location = new System.Drawing.Point(280, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 19;
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
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(582, 97);
            this.btnAgregarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAgregarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarIngrediente.selected = false;
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(146, 61);
            this.btnAgregarIngrediente.TabIndex = 22;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnAgregarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // comboMed
            // 
            this.comboMed.BackColor = System.Drawing.Color.Transparent;
            this.comboMed.BorderRadius = 1;
            this.comboMed.ForeColor = System.Drawing.Color.Black;
            this.comboMed.Items = new string[] {
        "Kilogramos",
        "Gramos",
        "Litros",
        "Mililitros"};
            this.comboMed.Location = new System.Drawing.Point(17, 241);
            this.comboMed.Name = "comboMed";
            this.comboMed.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.comboMed.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(237)))), ((int)(((byte)(187)))));
            this.comboMed.selectedIndex = -1;
            this.comboMed.Size = new System.Drawing.Size(220, 29);
            this.comboMed.TabIndex = 23;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel4.Location = new System.Drawing.Point(17, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 2);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel5.Location = new System.Drawing.Point(17, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 2);
            this.panel5.TabIndex = 25;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel7.Location = new System.Drawing.Point(17, 240);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 30);
            this.panel7.TabIndex = 37;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.panel6.Location = new System.Drawing.Point(235, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 30);
            this.panel6.TabIndex = 38;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.btnAgregarIngrediente;
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
            this.btnEditarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.cocinando;
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
            this.btnEditarIngrediente.Location = new System.Drawing.Point(582, 161);
            this.btnEditarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditarIngrediente.Name = "btnEditarIngrediente";
            this.btnEditarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEditarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEditarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditarIngrediente.selected = false;
            this.btnEditarIngrediente.Size = new System.Drawing.Size(146, 61);
            this.btnEditarIngrediente.TabIndex = 39;
            this.btnEditarIngrediente.Text = "Editar";
            this.btnEditarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnEditarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnEliminarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.cocinando;
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
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(582, 232);
            this.btnEliminarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEliminarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnEliminarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarIngrediente.selected = false;
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(146, 61);
            this.btnEliminarIngrediente.TabIndex = 40;
            this.btnEliminarIngrediente.Text = "Eliminar";
            this.btnEliminarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnEliminarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnBuscarIngrediente.Iconimage = global::Restaurante___reporte.Properties.Resources.cocinando;
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
            this.btnBuscarIngrediente.Location = new System.Drawing.Point(22, 345);
            this.btnBuscarIngrediente.Margin = new System.Windows.Forms.Padding(6);
            this.btnBuscarIngrediente.Name = "btnBuscarIngrediente";
            this.btnBuscarIngrediente.Normalcolor = System.Drawing.Color.Transparent;
            this.btnBuscarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnBuscarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarIngrediente.selected = false;
            this.btnBuscarIngrediente.Size = new System.Drawing.Size(146, 61);
            this.btnBuscarIngrediente.TabIndex = 41;
            this.btnBuscarIngrediente.Text = "Buscar";
            this.btnBuscarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnBuscarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnBuscarIngrediente);
            this.Controls.Add(this.btnEliminarIngrediente);
            this.Controls.Add(this.btnEditarIngrediente);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.comboMed);
            this.Controls.Add(this.btnAgregarIngrediente);
            this.Controls.Add(this.txtIngredienteCant);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtIngredienteNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIngredienteId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCantidadAlmacen);
            this.Controls.Add(this.lblUnidadMedida);
            this.Controls.Add(this.lblIngredienteNombre);
            this.Controls.Add(this.lblIgredienteId);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngredientes";
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.frmIngredientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIgredienteId;
        private System.Windows.Forms.Label lblIngredienteNombre;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.Label lblCantidadAlmacen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIngredienteId;
        private System.Windows.Forms.TextBox txtIngredienteNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIngredienteCant;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuFlatButton btnAgregarIngrediente;
        private ns1.BunifuDropdown comboMed;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuFlatButton btnEditarIngrediente;
        private ns1.BunifuFlatButton btnEliminarIngrediente;
        private ns1.BunifuFlatButton btnBuscarIngrediente;
    }
}