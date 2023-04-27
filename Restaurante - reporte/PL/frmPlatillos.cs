using CrystalDecisions.Windows.Forms;
using Restaurante___reporte.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            dgvPlatillos_muestra.DataSource = mostrar.MuestraPlatillos_Tabla().Tables[0];
        }
        string id;
        private void dgvPlatillos_muestra_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*string*/ id = "";
            //OBTENER INFORMACION DEL PLATILLO -----------------------------------------------------------
            {
                int indice = e.RowIndex;
                //Indicar el nombre del platillo en la pantalla
                string nombre_plato = dgvPlatillos_muestra.Rows[indice].Cells[0].Value.ToString();

                //Recuperar el "id" del platillo por medio del nombre del plato
                id = mostrar.RetornarID("SELECT plato_id FROM PLATILLO WHERE plato_nombre = '" + nombre_plato + "'");

                //Obtener toda la informacion por medio de plato_id 
                DataTable tb = mostrar.InformacionID($"Select * From PLATILLO WHERE plato_id = {id}");
                //Mostrar ID y Nombre del plato
                lblNombrePlatillo.Text = tb.Rows[0]["plato_id"].ToString() + " " + tb.Rows[0]["plato_nombre"].ToString();
                //Desccripcion
                txtDescripcion.Text = tb.Rows[0]["plato_descripcion"].ToString();
                //Dificultad
                lblDificultad.Text = "Dificultad: " + tb.Rows[0]["plato_dificultad"].ToString();
                //Precio
                lblPrecio.Text = "Precio: $" + tb.Rows[0]["plato_preciof"].ToString();

                //Obtener el nombre de la categoria por medio del id que se almaceno en la tabla
                string Comando = "SELECT categoria_nombre FROM CATEGORIA WHERE categoria_id =" + tb.Rows[0]["categoria_id"].ToString();
                lblCategoria.Text = "Categoria: " + mostrar.Buscar_Retornar(Comando);

                //Obtener el arreglo de Bytes 
                byte[] img = (byte[])tb.Rows[0]["plato_foto"];

                //Convertir el arreglo a imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                pbImagenPlato.Image = Image.FromStream(ms);
            }

            //OBTENER INGREDIENTES DEL PLATILLO DEL PLATILLO -----------------------------------------------------------
            {
                /*DataTable tb = */mostrar.RetornarProcedimiento($"Select * From RECETA WHERE plato_id = {id}", txtProcedimiento);
                //int cantidad = tb.Rows.Count;

                //for( int i = 0; i < cantidad; i++)
                //{
                //    txtProcedimiento.Text = txtProcedimiento.Text +"\r\n"+ tb.Rows[i]["no_paso"].ToString() +" "+ tb.Rows[i]["descripcion"].ToString();
                //}
               
            }

            //OBTENER RECETA DEL PLATILLO DEL PLATILLO -----------------------------------------------------------
            { }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
