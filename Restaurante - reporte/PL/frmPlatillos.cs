using Restaurante___reporte.DAL;
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
    public partial class frmPlatillos : Form
    {
        public frmPlatillos()
        {
            InitializeComponent();
        }

        //Objetos de clase
        frmEditarPlatillo frmEditarPlatillo = new frmEditarPlatillo();
        Editar_Platillo platillo = new Editar_Platillo();


        private void frmPlatillos_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarPatillo_Click(object sender, EventArgs e)
        {
            frmEditarPlatillo.ShowDialog();
        }
    }
}
