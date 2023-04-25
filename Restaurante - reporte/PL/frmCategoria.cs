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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        //Creacion de objetos
        CategoriaBLL categoriaBLL = new CategoriaBLL();
        Editar_Categoria editar_Categoria = new Editar_Categoria();
        Conexion conexion = new Conexion();

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValoresVacios()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtidCategoria.Text == "")
                {
                    valoresVacios += "id_categoria, ";
                    no_vacios++;
                }
                if (txtNom_categoria.Text == "")
                {
                    valoresVacios += "Nombre, ";
                    no_vacios++;
                }
                if (txtNomEncargado.Text == "")
                {
                    valoresVacios += "Encargado, ";
                    no_vacios++;
                }
                if (txtDescCategoria.Text == "")
                {
                    valoresVacios += "Descripcón";
                    no_vacios++;
                }

            }
            if (no_vacios > 0)
            {
                MessageBox.Show("No puede dejar información en blanco \r\n\r\n" +
                                "No. de valores vacios: " + no_vacios + "\r\n" +
                                "Valores vacios: " + valoresVacios, "ERROR AL INGRESAR VALORES");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RecuperarInforcion()
        {
            categoriaBLL.categoria_id = int.Parse(txtidCategoria.Text);
            categoriaBLL.categoria_nombre = txtNom_categoria.Text;
            categoriaBLL.categoria_encargado = txtNomEncargado.Text;
            categoriaBLL.categoria_descripcion = txtDescCategoria.Text;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            RecuperarInforcion();
            editar_Categoria.AgregarCategoria(categoriaBLL);
            //Refrescar tabla
            dgvTablaCategoria.DataSource = editar_Categoria.TablaCategoria().Tables[0];

        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtidCategoria_Validated(object sender, EventArgs e)
        {
            error.SetError(txtidCategoria, "");
        }

        private void txtidCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (!conexion.BuscarEnTabla_AGREGAR("SELECT * FROM CATEGORIA", txtidCategoria.Text, 0, txtidCategoria, error) && txtidCategoria.Text != "")
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtidCategoria.Select(0, txtidCategoria.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                //this.error.SetError(txtId_platillo, errorMsg);
            }
        }
    }
}
