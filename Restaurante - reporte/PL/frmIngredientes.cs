using Restaurante___reporte.BLL;
using Restaurante___reporte.DAL;
using Restaurante___reporte.DLL;
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

        //Creacion de objetos
        IngredienteBLL ingredienteBLL = new IngredienteBLL();
        Editar_Ingrediente editar_Ingrediente = new Editar_Ingrediente();
        Conexion conexion = new Conexion();

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
            return false;
            //}
        }



        //Validacion de solo numeros en ID Ingredientes
        private void txtIngredienteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten valores numericos", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Validacion de solo numeros en Cantidad de Ingredientes
        private void txtIngredienteCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten valores numericos", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //validacion de solo letras en Nombre de Ingrediente
        private void txtIngredienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se admiten letras", "ALERTA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Recupera informacion de ingrediente
        public void RecuperarInforcion()
        {
            ingredienteBLL.ingrediente_id = int.Parse(txtIngredienteId.Text);
            ingredienteBLL.ingrediente_nombre = txtIngredienteNombre.Text;
            ingredienteBLL.ingrediente_unidad_medida = comboMed.Text;
            ingredienteBLL.ingrediente_cantidad_almacen = int.Parse(txtIngredienteCant.Text);
        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            RecuperarInforcion();
            editar_Ingrediente.AgregarIngrediente(ingredienteBLL);
            //Refrescar tabla
            dgvTablaDB.DataSource = editar_Ingrediente.TablaCategoria().Tables[0];
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

        //Cerrar pestaña
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            txtIngredienteId.Clear(); txtIngredienteCant.Clear(); txtIngredienteNombre.Clear();
            txtIngredienteId.Focus();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cmdLimpiar(object sender, EventArgs e)
        {

        }
    }
}
