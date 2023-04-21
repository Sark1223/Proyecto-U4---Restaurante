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
    public partial class frmIngredientes : Form
    {
        public frmIngredientes()
        {
            InitializeComponent();

            //Agregar Categorias a Combobox
            comboMedida.Items.Add("Kilogramos");
            comboMedida.Items.Add("Gramos");
            comboMedida.Items.Add("Litros");
            comboMedida.Items.Add("Mililitros");
        }

        private void frmIngredientes_Load(object sender, EventArgs e)
        {

        }

        private void txtIngredienteId_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtIngredienteId_CursorChanged(object sender, EventArgs e)
        {
           
        }

        private void txtIngredienteId_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Black;
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.White;
        }

        private void txtIngredienteNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngredienteNombre_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel1.BackColor = Color.Black;
            panel3.BackColor = Color.White;
        }

        private void txtIngredienteCant_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel1.BackColor = Color.White;
            panel3.BackColor = Color.Black;
        }
    }
}
