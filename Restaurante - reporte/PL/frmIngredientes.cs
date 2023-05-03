using Restaurante___reporte.BLL;
using Restaurante___reporte.DAL;
using Restaurante___reporte.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection cone = new SqlConnection(@"server=DESKTOP-BNMO14B; 
        Initial Catalog=RESTAURANTE; integrated security=true");

        //Creacion de objetos
        IngredienteBLL ingredienteBLL = new IngredienteBLL();
        Editar_Ingrediente editar_Ingrediente = new Editar_Ingrediente();
        Conexion conexion = new Conexion();

        //VALIDACION DE VALORES INGRESADOS POR EL USUARIO
        public bool ValoresVaciosIngredientes()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtIngredienteId.Text == "")
                {
                    valoresVacios += "id_ingrediente, ";
                    no_vacios++;
                }
                if (txtIngredienteNombre.Text == "")
                {
                    valoresVacios += "Nombre, ";
                    no_vacios++;
                }
                if (comboMed.Text == "-- Medida --")
                {
                    valoresVacios += "Unidad de medida, ";
                    
                }
                if (txtIngredienteCant.Text == "")
                {
                    valoresVacios += "cantidad, ";

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
            dgvIngredientes.DataSource = editar_Ingrediente.TablaIngredientes().Tables[0];
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

        private void dgvIngredientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*CREATE TABLE INGREDIENTE (
    ingrediente_id               VARCHAR(4) NOT NULL,
    ingrediente_nombre           VARCHAR(30) UNIQUE,
    ingrediente_unidad_medida           VARCHAR(20) NOT NULL,
    ingrediente_cantidad_almacen VARCHAR(4) NOT NULL
);
*/
            int indice = e.RowIndex;
            id_actual = dgvIngredientes.Rows[indice].Cells[0].Value.ToString();
            txtIngredienteId.Text = id_actual.ToString();
            txtIngredienteNombre.Text = dgvIngredientes.Rows[indice].Cells[1].Value.ToString();

            //Dificultad
            bool bandera = false;
            int i = 0;
            while (bandera == false)
            {
                comboMed.SelectedIndex = i;
                if (comboMed.SelectedItem.ToString() == dgvIngredientes.Rows[indice].Cells[2].Value.ToString())
                {
                    bandera = true;
                }
                i++;
            };

            txtIngredienteCant.Text = dgvIngredientes.Rows[indice].Cells[3].Value.ToString();
        }

        string id_actual;
        private void btnEditarIngrediente_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosIngredientes())
            {
                RecuperarInforcion();

                if (editar_Ingrediente.ModificarIngrediente(ingredienteBLL, id_actual))
                {
                    MessageBox.Show($"El ingrediente {txtIngredienteNombre.Text} ha sido modificado", "ingrediente MODIFICADO");

                }
                else
                {
                    MessageBox.Show("No se pudo MODIFICAR el ingrediente.", "ERROR DE MODIFICACIÓN");
                }
            }
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            string baja = "DELETE FROM INGREDIENTE WHERE ingrediente_id = @ingrediente_id";

            SqlCommand cmdIns = new SqlCommand(baja, cone);
            cmdIns.Parameters.Add("ingrediente_id", txtIngredienteId.Text);
            cone.Open();
            cmdIns.ExecuteNonQuery();

            cmdIns.Dispose();
            cmdIns = null;
            txtIngredienteId.Clear();
            cone.Close();

            MessageBox.Show("Ingrediente eliminado");
        }

        private void cmdBuscarIngrediente(object sender, EventArgs e)
        {
            cone.Open();

            string busca = "select * from INGREDIENTE where ingrediente_id=" + txtIngredienteId.Text + "";
            SqlDataAdapter adaptador = new SqlDataAdapter(busca, cone);
            DataTable data = new DataTable();
            //lenar la tabla con lo que se almacena en adaptador
            adaptador.Fill(data);
            //mostrar en datagridview
            dgvIngredientes.DataSource = data;
            SqlCommand com = new SqlCommand(busca, cone);
            SqlDataReader lector;
            lector = com.ExecuteReader();
            if (lector.Read())
            {
                txtIngredienteId.Text = lector["ingrediente_id"].ToString();
                txtIngredienteNombre.Text = lector["ingrediente_nombre"].ToString();
                txtIngredienteCant.Text = lector["ingrediente_cantidad_almacen"].ToString();
                comboMed.DisplayMember = lector["ingrediente_unidad_medida"].ToString();
            }
            cone.Close();
        }
    }
}
