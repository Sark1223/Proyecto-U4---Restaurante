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
            this.label8 = new System.Windows.Forms.Label();
            this.lblIgredienteId = new System.Windows.Forms.Label();
            this.lblIngredienteNombre = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.lblCantidadAlmacen = new System.Windows.Forms.Label();
            this.comboMedida = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIngredienteId = new System.Windows.Forms.TextBox();
            this.txtIngredienteNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIngredienteCant = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarIngrediente = new ns1.BunifuFlatButton();
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
            this.lblIgredienteId.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIgredienteId.Location = new System.Drawing.Point(39, 97);
            this.lblIgredienteId.Name = "lblIgredienteId";
            this.lblIgredienteId.Size = new System.Drawing.Size(142, 25);
            this.lblIgredienteId.TabIndex = 8;
            this.lblIgredienteId.Text = "Identificador:";
            // 
            // lblIngredienteNombre
            // 
            this.lblIngredienteNombre.AutoSize = true;
            this.lblIngredienteNombre.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredienteNombre.Location = new System.Drawing.Point(328, 97);
            this.lblIngredienteNombre.Name = "lblIngredienteNombre";
            this.lblIngredienteNombre.Size = new System.Drawing.Size(94, 25);
            this.lblIngredienteNombre.TabIndex = 9;
            this.lblIngredienteNombre.Text = "Nombre:";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidadMedida.Location = new System.Drawing.Point(39, 206);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(192, 25);
            this.lblUnidadMedida.TabIndex = 10;
            this.lblUnidadMedida.Text = "Unidad de Medida:";
            // 
            // lblCantidadAlmacen
            // 
            this.lblCantidadAlmacen.AutoSize = true;
            this.lblCantidadAlmacen.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAlmacen.Location = new System.Drawing.Point(328, 206);
            this.lblCantidadAlmacen.Name = "lblCantidadAlmacen";
            this.lblCantidadAlmacen.Size = new System.Drawing.Size(223, 25);
            this.lblCantidadAlmacen.TabIndex = 11;
            this.lblCantidadAlmacen.Text = "Cantidad en Almacen:";
            // 
            // comboMedida
            // 
            this.comboMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.comboMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboMedida.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F);
            this.comboMedida.FormattingEnabled = true;
            this.comboMedida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboMedida.Location = new System.Drawing.Point(46, 246);
            this.comboMedida.Margin = new System.Windows.Forms.Padding(1);
            this.comboMedida.Name = "comboMedida";
            this.comboMedida.Size = new System.Drawing.Size(185, 24);
            this.comboMedida.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(44, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 14;
            // 
            // txtIngredienteId
            // 
            this.txtIngredienteId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.txtIngredienteId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteId.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteId.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteId.Location = new System.Drawing.Point(44, 135);
            this.txtIngredienteId.Name = "txtIngredienteId";
            this.txtIngredienteId.Size = new System.Drawing.Size(200, 20);
            this.txtIngredienteId.TabIndex = 16;
            this.txtIngredienteId.Click += new System.EventHandler(this.txtIngredienteId_Click);
            this.txtIngredienteId.CursorChanged += new System.EventHandler(this.txtIngredienteId_CursorChanged);
            this.txtIngredienteId.TextChanged += new System.EventHandler(this.txtIngredienteId_TextChanged);
            // 
            // txtIngredienteNombre
            // 
            this.txtIngredienteNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.txtIngredienteNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteNombre.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteNombre.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteNombre.Location = new System.Drawing.Point(333, 135);
            this.txtIngredienteNombre.Name = "txtIngredienteNombre";
            this.txtIngredienteNombre.Size = new System.Drawing.Size(200, 20);
            this.txtIngredienteNombre.TabIndex = 18;
            this.txtIngredienteNombre.Click += new System.EventHandler(this.txtIngredienteNombre_Click);
            this.txtIngredienteNombre.TextChanged += new System.EventHandler(this.txtIngredienteNombre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(333, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 17;
            // 
            // txtIngredienteCant
            // 
            this.txtIngredienteCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.txtIngredienteCant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngredienteCant.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredienteCant.ForeColor = System.Drawing.Color.Black;
            this.txtIngredienteCant.Location = new System.Drawing.Point(333, 246);
            this.txtIngredienteCant.Name = "txtIngredienteCant";
            this.txtIngredienteCant.Size = new System.Drawing.Size(200, 20);
            this.txtIngredienteCant.TabIndex = 20;
            this.txtIngredienteCant.Click += new System.EventHandler(this.txtIngredienteCant_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(333, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 19;
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.btnAgregarIngrediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
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
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(112, 337);
            this.btnAgregarIngrediente.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.btnAgregarIngrediente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarIngrediente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarIngrediente.selected = false;
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(146, 61);
            this.btnAgregarIngrediente.TabIndex = 22;
            this.btnAgregarIngrediente.Text = "Agregar";
            this.btnAgregarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarIngrediente.Textcolor = System.Drawing.Color.Black;
            this.btnAgregarIngrediente.TextFont = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarIngrediente);
            this.Controls.Add(this.txtIngredienteCant);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtIngredienteNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIngredienteId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboMedida);
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
        private System.Windows.Forms.ComboBox comboMedida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIngredienteId;
        private System.Windows.Forms.TextBox txtIngredienteNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIngredienteCant;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuFlatButton btnAgregarIngrediente;
    }
}