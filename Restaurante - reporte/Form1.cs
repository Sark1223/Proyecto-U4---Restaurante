using Restaurante___reporte.DAL;
using Restaurante___reporte.PL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante___reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Mostrar_Platillo mos = new Mostrar_Platillo();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNoPla.Text =  mos.Buscar_Retornar("select COUNT(plato_id) FROM PLATILLO");
            lblNoIngre.Text = mos.Buscar_Retornar("select COUNT(ingrediente_id) FROM INGREDIENTE");
            lblNoCate.Text = mos.Buscar_Retornar("select COUNT(categoria_id) FROM CATEGORIA");
        }

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       
        private void mas_menos_MouseClick(object sender, MouseEventArgs e)
        {
            if (Panel_Menu.Width == 79)
            {
                this.pbMasMenos.Image = Properties.Resources.aplicaciones_anadir;
                Panel_Menu.Width = 2;
                mas_menos.Location = new Point(-4, 202);
                Contenedor_menu.Width = 31;
            }
            else
            {
                this.pbMasMenos.Image = Properties.Resources.eliminar_aplicaciones__1_;
                Panel_Menu.Width = 79;
                mas_menos.Location = new Point(72, 202);
                Contenedor_menu.Width = 105;
            }
        }

        //VARIABLES AUXILIARES - OPCIONES DEL MENU
        Panel PanelAnterior, PanelActual, Panel1cmd;
        Reporte reporte = new Reporte();
        bool primerCmd = true;

        //colores de los comandos elegidos
        public void ComandoActivo(Panel panel)
        {
            panel.BackColor = Color.FromArgb(242, 164, 68);
        }

        public void ComandoSleep(Panel panel)
        {
            panel.BackColor = Color.FromArgb(242, 237, 228);
        }

        //mantiene el color diferente el el comando usado actualmente
        public void Ponerfoco()
        {
            if (primerCmd == true)
            {
                ComandoActivo(PanelActual);
                PanelAnterior = PanelActual;
                primerCmd = false;
                Panel_datos_restaurante.Visible = false;
            }
            else
            {
                ComandoSleep(PanelAnterior);
                ComandoActivo(PanelActual);
                PanelAnterior = PanelActual;
            }

        }

        public void AbrirForm(object mas)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
            {
                this.Panel_Contenedor.Controls.RemoveAt(0);
            }

            Form admin = mas as Form;
            admin.TopLevel = false;
            admin.Dock = DockStyle.Fill;
            this.Panel_Contenedor.Controls.Add(admin);
            this.Panel_Contenedor.Tag = admin;

            admin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
            {
                this.Panel_Contenedor.Controls.RemoveAt(0);
            }

            Panel_datos_restaurante.Visible = true;
        }

        //OBJETOS DE FORMAS
        frmPlatillos platillos = new frmPlatillos();
        frmIngredientes ingredientes = new frmIngredientes();
        frmCategoria categoria = new frmCategoria();
        Editar_Categoria editar_categoria = new Editar_Categoria();
        Editar_Ingrediente editar_ingrediente = new Editar_Ingrediente();
        //frmReporte reporte = new frmReporte();
        Mostrar_Platillo mostrar = new Mostrar_Platillo();

        private void cmdIngrediente_Click(object sender, EventArgs e)
        {
            //Refrescar tabla
            ingredientes.dgvIngredientes.DataSource = editar_ingrediente.TablaIngredientes().Tables[0];
            PanelActual = cmdCategorias;
            
            Ponerfoco();
            ingredientes.ShowDialog();
        }

        private void cmdCategoria_Click(object sender, EventArgs e)
        {
            //Refrescar tabla
            categoria.dgvTablaCategoria.DataSource = editar_categoria.TablaCategoria().Tables[0];
            PanelActual = cmdCategorias;
            
            Ponerfoco();
            categoria.ShowDialog();
            
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            PanelActual = cmdReporte;
            
            Ponerfoco();
            reporte.ShowDialog();
            
        }

        private void Cerrar(object sender, EventArgs e)
        {
            Close();
        }

        

        private void cmdPlatillo_Click(object sender, EventArgs e)
        {
            platillos.dgvPlatillos_muestra.DataSource = mostrar.MuestraPlatillos_Tabla().Tables[0];
            AbrirForm(platillos);
            PanelActual = cmdPlatillo;
            Ponerfoco();
        }

        private void pbIngredientes_Click(object sender, EventArgs e)
        {

        }

        private void pbIngredientes_MouseHover(object sender, EventArgs e)
        {
            lblIngrediente.Visible = true;
            pbIngredientes.Visible = false;
        }

        private void pbcategoria_MouseHover(object sender, EventArgs e)
        {
            lblCategoria.Visible = true;
            pbcategoria.Visible = false;
        }

        private void lblReporte_MouseHover(object sender, EventArgs e)
        {
            lblReporte.Visible = true;
            pbReporte.Visible = false;
        }

        private void pbPlatillo_MouseHover(object sender, EventArgs e)
        {
            lblPlatillo.Visible = true;
            pbPlatillo.Visible = false;
        }
        
        private void pbPlatillo_MouseLeave(object sender, EventArgs e)
        {
            lblPlatillo.Visible = false;
            pbPlatillo.Visible = true;
        }


        private void pbIngredientes_MouseLeave(object sender, EventArgs e)
        {
            lblIngrediente.Visible = false;
            pbIngredientes.Visible = true;
        }

        private void pbcategoria_MouseLeave(object sender, EventArgs e)
        {
            lblCategoria.Visible = false;
            pbcategoria.Visible = true;
        }

        private void pbReporte_MouseLeave(object sender, EventArgs e)
        {
            lblReporte.Visible = false;
            pbReporte.Visible = true;
        }
    }
}
