namespace Restaurante___reporte
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Panel_encabezado = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.linea_menu = new System.Windows.Forms.Panel();
            this.cmdIngredientes = new System.Windows.Forms.Panel();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.cmdPlatillo = new System.Windows.Forms.Panel();
            this.lblPlatillo = new System.Windows.Forms.Label();
            this.cmdCategorias = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.forma_redondeada = new ns1.BunifuElipse(this.components);
            this.menu = new ns1.BunifuElipse(this.components);
            this.mas_menos = new System.Windows.Forms.Panel();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contenedor_menu = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbIngredientes = new System.Windows.Forms.PictureBox();
            this.pbPlatillo = new System.Windows.Forms.PictureBox();
            this.pbcategoria = new System.Windows.Forms.PictureBox();
            this.pbMasMenos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_encabezado.SuspendLayout();
            this.Panel_Menu.SuspendLayout();
            this.cmdIngredientes.SuspendLayout();
            this.cmdPlatillo.SuspendLayout();
            this.cmdCategorias.SuspendLayout();
            this.mas_menos.SuspendLayout();
            this.Panel_Contenedor.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Contenedor_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMasMenos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(217)))), ((int)(((byte)(182)))));
            this.panel1.Location = new System.Drawing.Point(308, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 10);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(68, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(255, 38);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "MENU RESTAURANTE";
            // 
            // Panel_encabezado
            // 
            this.Panel_encabezado.Controls.Add(this.panel2);
            this.Panel_encabezado.Controls.Add(this.lblTitle);
            this.Panel_encabezado.Controls.Add(this.pictureBox1);
            this.Panel_encabezado.Controls.Add(this.panel1);
            this.Panel_encabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_encabezado.Location = new System.Drawing.Point(0, 0);
            this.Panel_encabezado.Name = "Panel_encabezado";
            this.Panel_encabezado.Size = new System.Drawing.Size(901, 65);
            this.Panel_encabezado.TabIndex = 4;
            this.Panel_encabezado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 2);
            this.panel2.TabIndex = 4;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Menu.Controls.Add(this.linea_menu);
            this.Panel_Menu.Controls.Add(this.cmdIngredientes);
            this.Panel_Menu.Controls.Add(this.cmdPlatillo);
            this.Panel_Menu.Controls.Add(this.cmdCategorias);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(79, 449);
            this.Panel_Menu.TabIndex = 4;
            // 
            // linea_menu
            // 
            this.linea_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.linea_menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.linea_menu.Location = new System.Drawing.Point(77, 0);
            this.linea_menu.Name = "linea_menu";
            this.linea_menu.Size = new System.Drawing.Size(2, 449);
            this.linea_menu.TabIndex = 11;
            // 
            // cmdIngredientes
            // 
            this.cmdIngredientes.Controls.Add(this.lblIngrediente);
            this.cmdIngredientes.Controls.Add(this.pbIngredientes);
            this.cmdIngredientes.Location = new System.Drawing.Point(1, 190);
            this.cmdIngredientes.Name = "cmdIngredientes";
            this.cmdIngredientes.Size = new System.Drawing.Size(72, 65);
            this.cmdIngredientes.TabIndex = 8;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.Location = new System.Drawing.Point(-1, 29);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(75, 16);
            this.lblIngrediente.TabIndex = 8;
            this.lblIngrediente.Text = "Ingredientes";
            // 
            // cmdPlatillo
            // 
            this.cmdPlatillo.Controls.Add(this.lblPlatillo);
            this.cmdPlatillo.Controls.Add(this.pbPlatillo);
            this.cmdPlatillo.Location = new System.Drawing.Point(0, 108);
            this.cmdPlatillo.Name = "cmdPlatillo";
            this.cmdPlatillo.Size = new System.Drawing.Size(72, 65);
            this.cmdPlatillo.TabIndex = 6;
            // 
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlatillo.Location = new System.Drawing.Point(12, 29);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(44, 16);
            this.lblPlatillo.TabIndex = 5;
            this.lblPlatillo.Text = "Platillo";
            // 
            // cmdCategorias
            // 
            this.cmdCategorias.Controls.Add(this.lblCategoria);
            this.cmdCategorias.Controls.Add(this.pbcategoria);
            this.cmdCategorias.Location = new System.Drawing.Point(1, 271);
            this.cmdCategorias.Name = "cmdCategorias";
            this.cmdCategorias.Size = new System.Drawing.Size(72, 65);
            this.cmdCategorias.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(8, 30);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // forma_redondeada
            // 
            this.forma_redondeada.ElipseRadius = 10;
            this.forma_redondeada.TargetControl = this;
            // 
            // menu
            // 
            this.menu.ElipseRadius = 15;
            this.menu.TargetControl = this.mas_menos;
            // 
            // mas_menos
            // 
            this.mas_menos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(151)))));
            this.mas_menos.Controls.Add(this.pbMasMenos);
            this.mas_menos.Location = new System.Drawing.Point(72, 202);
            this.mas_menos.Name = "mas_menos";
            this.mas_menos.Size = new System.Drawing.Size(33, 44);
            this.mas_menos.TabIndex = 10;
            this.mas_menos.Paint += new System.Windows.Forms.PaintEventHandler(this.mas_menos_Paint);
            this.mas_menos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mas_menos_MouseClick);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Controls.Add(this.label1);
            this.Panel_Contenedor.Controls.Add(this.pictureBox6);
            this.Panel_Contenedor.Controls.Add(this.label8);
            this.Panel_Contenedor.Controls.Add(this.panel6);
            this.Panel_Contenedor.Controls.Add(this.panel5);
            this.Panel_Contenedor.Controls.Add(this.panel3);
            this.Panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Contenedor.Location = new System.Drawing.Point(105, 65);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(796, 449);
            this.Panel_Contenedor.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Estado del restaurante";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.pictureBox5);
            this.panel6.Location = new System.Drawing.Point(530, 69);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(134, 140);
            this.panel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "110";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "No. de categorias";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(318, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(134, 140);
            this.panel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "110";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "No. de ingredientes";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(106, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 140);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "110";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "No. de platillos";
            // 
            // Contenedor_menu
            // 
            this.Contenedor_menu.Controls.Add(this.Panel_Menu);
            this.Contenedor_menu.Controls.Add(this.mas_menos);
            this.Contenedor_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Contenedor_menu.Location = new System.Drawing.Point(0, 65);
            this.Contenedor_menu.Name = "Contenedor_menu";
            this.Contenedor_menu.Size = new System.Drawing.Size(105, 449);
            this.Contenedor_menu.TabIndex = 12;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Restaurante___reporte.Properties.Resources.sale_de;
            this.pictureBox6.Location = new System.Drawing.Point(255, 228);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(240, 229);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Restaurante___reporte.Properties.Resources.libro_abierto;
            this.pictureBox5.Location = new System.Drawing.Point(17, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 83);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Restaurante___reporte.Properties.Resources.hamburguesa;
            this.pictureBox4.Location = new System.Drawing.Point(17, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Restaurante___reporte.Properties.Resources.restaurante__2_;
            this.pictureBox2.Location = new System.Drawing.Point(17, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pbIngredientes
            // 
            this.pbIngredientes.Image = global::Restaurante___reporte.Properties.Resources.ingredientes;
            this.pbIngredientes.Location = new System.Drawing.Point(1, 1);
            this.pbIngredientes.Name = "pbIngredientes";
            this.pbIngredientes.Size = new System.Drawing.Size(71, 64);
            this.pbIngredientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngredientes.TabIndex = 5;
            this.pbIngredientes.TabStop = false;
            // 
            // pbPlatillo
            // 
            this.pbPlatillo.Image = global::Restaurante___reporte.Properties.Resources.restaurante;
            this.pbPlatillo.Location = new System.Drawing.Point(1, 0);
            this.pbPlatillo.Name = "pbPlatillo";
            this.pbPlatillo.Size = new System.Drawing.Size(71, 64);
            this.pbPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlatillo.TabIndex = 0;
            this.pbPlatillo.TabStop = false;
            // 
            // pbcategoria
            // 
            this.pbcategoria.Image = global::Restaurante___reporte.Properties.Resources.categorias;
            this.pbcategoria.Location = new System.Drawing.Point(1, 1);
            this.pbcategoria.Name = "pbcategoria";
            this.pbcategoria.Size = new System.Drawing.Size(71, 64);
            this.pbcategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbcategoria.TabIndex = 5;
            this.pbcategoria.TabStop = false;
            // 
            // pbMasMenos
            // 
            this.pbMasMenos.Image = global::Restaurante___reporte.Properties.Resources.eliminar_aplicaciones__1_;
            this.pbMasMenos.Location = new System.Drawing.Point(8, 10);
            this.pbMasMenos.Name = "pbMasMenos";
            this.pbMasMenos.Size = new System.Drawing.Size(22, 24);
            this.pbMasMenos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMasMenos.TabIndex = 9;
            this.pbMasMenos.TabStop = false;
            this.pbMasMenos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mas_menos_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Restaurante___reporte.Properties.Resources.limon;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(901, 514);
            this.Controls.Add(this.Panel_Contenedor);
            this.Controls.Add(this.Contenedor_menu);
            this.Controls.Add(this.Panel_encabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel_encabezado.ResumeLayout(false);
            this.Panel_encabezado.PerformLayout();
            this.Panel_Menu.ResumeLayout(false);
            this.cmdIngredientes.ResumeLayout(false);
            this.cmdIngredientes.PerformLayout();
            this.cmdPlatillo.ResumeLayout(false);
            this.cmdPlatillo.PerformLayout();
            this.cmdCategorias.ResumeLayout(false);
            this.cmdCategorias.PerformLayout();
            this.mas_menos.ResumeLayout(false);
            this.Panel_Contenedor.ResumeLayout(false);
            this.Panel_Contenedor.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Contenedor_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMasMenos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_encabezado;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.PictureBox pbPlatillo;
        private System.Windows.Forms.PictureBox pbIngredientes;
        private System.Windows.Forms.PictureBox pbcategoria;
        private System.Windows.Forms.Panel cmdIngredientes;
        private System.Windows.Forms.Panel cmdPlatillo;
        private System.Windows.Forms.Label lblPlatillo;
        private System.Windows.Forms.Panel cmdCategorias;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.PictureBox pbMasMenos;
        private System.Windows.Forms.Label lblCategoria;
        private ns1.BunifuElipse forma_redondeada;
        private ns1.BunifuElipse menu;
        private System.Windows.Forms.Panel mas_menos;
        private System.Windows.Forms.Panel linea_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Panel Contenedor_menu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
    }
}

