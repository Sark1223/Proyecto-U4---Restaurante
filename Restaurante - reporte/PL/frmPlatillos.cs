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
        Mostrar_Platillo mostrar = new Mostrar_Platillo();


        private void frmPlatillos_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarPatillo_Click(object sender, EventArgs e)
        {
            frmEditarPlatillo.ShowDialog();
        }

        private void dgvPlatillos_muestra_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*plato_id               VARCHAR(3) NOT NULL,
    plato_nombre           VARCHAR(50) NOT NULL,
    plato_descripcion      VARCHAR(200) NOT NULL,
    plato_dificultad       VARCHAR(8) NOT NULL,
    plato_foto             IMAGE NOT NULL,
    plato_preciof          DECIMAL(6, 2),
    categoria_id VARCHAR(3) NOT NULL*/
            int indice = e.RowIndex;
            string nombre_plato = dgvPlatillos_muestra.Rows[indice].Cells[0].Value.ToString();
            string[] informacion = mostrar.Retornar_info_1("SELECT * FROM PLATILLO WHERE plato_nombre = '" + nombre_plato + "'");

            lblNombrePlatillo.Text = informacion[0].ToString() + " " + informacion[1].ToString();
            txtDescripcion.Text = informacion[2].ToString();
            lblDificultad.Text = "Dificultad: " + informacion[3].ToString();
            //pbImagenPlato.Image = informacion[4];
            lblPrecio.Text = "Precio: $" + informacion[5].ToString();
            //mostrar.ObtenerProcedimiento(,txtDescripcion);
            //
            //
            lblCategoria.Text = "Categoria: " + mostrar.Buscar_Retornar("SELECT categoria_nombre FROM CATEGORIA WHERE categoria_id =" + informacion[6].ToString());
            byte[] imgen = (byte[])informacion[4].;
        }
    }
}
