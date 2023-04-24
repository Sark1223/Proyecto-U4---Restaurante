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
        }

        private void frmIngredientes_Load(object sender, EventArgs e)
        {

        }
        //VALIDACION DE VALORES INGRESADOS POR EL USUARIO
        public bool ValoresVaciosIngredientes()
        {
            //string valoresVacios = "";
            //int no_vacios = 0;
            ////VERIFICACION DE VALORES VACIOS
            //{
            //    if (txtIngredienteId.Text == "")
            //    {
            //        valoresVacios += "id_platillo, ";
            //        no_vacios++;
            //    }
            //    if (txtNombre.Text == "")
            //    {
            //        valoresVacios += "Nombre, ";
            //        no_vacios++;
            //    }
            //    if (cbCategoria.Text == "-- Categoria --")
            //    {
            //        valoresVacios += "Categoria, ";
            //        no_vacios++;
            //    }
            //    if (cbDificultad.Text == "-- Dificultad --")
            //    {
            //        valoresVacios += "Dificultad, ";
            //        no_vacios++;
            //    }
            //    if (txtPrecio.Text == "")
            //    {
            //        valoresVacios += "Precio, ";
            //        no_vacios++;
            //    }
            //    if (txtDescripcion.Text == "")
            //    {
            //        valoresVacios += "Descripcion,";
            //        no_vacios++;
            //    }
            //    if (pbFotoPlatillo.Image == Properties.Resources.estilo_grafico__1_)
            //    {
            //        valoresVacios += "Imagen";
            //        no_vacios++;
            //    }

            //}
            //if (no_vacios > 0)
            //{
            //    MessageBox.Show("No puede dejar información en blanco \r\n\r\n" +
            //                    "No. de valores vacios: " + no_vacios + "\r\n" +
            //                    "Valores vacios: " + valoresVacios, "ERROR AL INGRESAR VALORES");
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        private void txtIngredienteId_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtIngredienteId_CursorChanged(object sender, EventArgs e)
        {
           
        }
        private void txtIngredienteId_Click(object sender, EventArgs e)
        {
        }
        private void txtIngredienteNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtIngredienteNombre_Click(object sender, EventArgs e)
        {
        }
        private void txtIngredienteCant_Click(object sender, EventArgs e)
        {
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
