using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante___reporte.PL
{
    public partial class frmEditarPlatillo : Form
    {
        public frmEditarPlatillo()
        {
            InitializeComponent();
        }

        private void cmdExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if(selectorImagen.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdListo_MouseHover(object sender, EventArgs e)
        {
            this.pbListo.Image = Properties.Resources.marca_de_verificacion__2_;
            lblListo.ForeColor = Color.FromArgb(85, 181, 151);
        }

        private void cmdListo_MouseLeave(object sender, EventArgs e)
        {
            this.pbListo.Image = Properties.Resources.marca_de_verificacion__1_;
            lblListo.ForeColor = Color.Black;
        }

        private void frmEditarPlatillo_Load(object sender, EventArgs e)
        {

        }

        private void agregarIngrediente_MouseHover(object sender, EventArgs e)
        {
             this.agregarIngrediente.Size = new Size(29, 31);
        }

        private void agregarIngrediente_MouseLeave(object sender, EventArgs e)
        {
            this.agregarIngrediente.Size = new Size(26, 27);
        }
    }
}
