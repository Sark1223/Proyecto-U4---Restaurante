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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mas_menos_Paint(object sender, PaintEventArgs e)
        {
            
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
    }
}
