using CrystalDecisions.Windows.Forms;
using Restaurante___reporte.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        frmEditarPlatillo ep = new frmEditarPlatillo();
        Editar_Platillo platillo = new Editar_Platillo();
        Mostrar_Platillo mostrar = new Mostrar_Platillo();


        private void frmPlatillos_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarPatillo_Click(object sender, EventArgs e)
        {
            ep.txtPaso_no.Enabled = false;
            ep.txtPaso_no.ReadOnly = true;
            ep.ShowDialog();

            dgvPlatillos_muestra.DataSource = mostrar.MuestraPlatillos_Tabla().Tables[0];
        }
        string id;
        private void dgvPlatillos_muestra_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ep.lblTitle.Text = "AGREGAR PLATILLO";
            /*string*/
            id = "";
            //OBTENER INFORMACION DEL PLATILLO -----------------------------------------------------------
            {
                txtDescripcion.Clear();
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

            //OBTENER RECETA DEL PLATILLO DEL PLATILLO -----------------------------------------------------------
            {
                txtProcedimiento.Clear();
                mostrar.RetornarProcedimiento($"Select * From RECETA WHERE plato_id = {id}", txtProcedimiento);
            }

            //OBTENER INGREDIENTES DEL PLATILLO DEL PLATILLO -----------------------------------------------------------
            {
                txtIngredientes_Platillo.Clear();
                DataTable dt = mostrar.InformacionID($"Select * From PLATILLO_INGREDIENTE WHERE platillo_id = {id}");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string ingre = $"Select ingrediente_nombre From INGREDIENTE WHERE ingrediente_id = {dt.Rows[i]["ingrediente_id"]}";
                    string ingrediente = mostrar.Buscar_Retornar(ingre);
                    string unidad = $"Select ingrediente_unidad_medida From INGREDIENTE WHERE ingrediente_id = {dt.Rows[i]["ingrediente_id"]}";
                    string U_medida = mostrar.Buscar_Retornar(unidad);
                    txtIngredientes_Platillo.Text = txtIngredientes_Platillo.Text + dt.Rows[i]["cantidad_ingre_plato"].ToString() + "" + U_medida + "   " + ingrediente + "\r\n";
                }
            }
        }

        private void dgvPlatillos_muestra_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ep.lblTitle.Text = "MODIFICAR PLATILLO";
            ep.txtPaso_no.Enabled = true;
            ep.txtPaso_no.ReadOnly = false;
            //OBTENER INFORMACION DEL PLATILLO -----------------------------------------------------------
            {
                int indice = e.RowIndex;
                //Indicar el nombre del platillo en la pantalla
                string nombre_plato = dgvPlatillos_muestra.Rows[indice].Cells[0].Value.ToString();

                //Recuperar el "id" del platillo por medio del nombre del plato
                id = mostrar.RetornarID("SELECT plato_id FROM PLATILLO WHERE plato_nombre = '" + nombre_plato + "'");

                //Obtener toda la informacion por medio de plato_id 
                DataTable tb = mostrar.InformacionID($"Select * From PLATILLO WHERE plato_id = {id}");
                //Mostrar ID
                ep.txtId_platillo.Text = tb.Rows[0]["plato_id"].ToString();
                //Nombre del plato
                ep.txtNombre.Text = tb.Rows[0]["plato_nombre"].ToString();
                //Desccripcion
                ep.txtDescripcion.Text = tb.Rows[0]["plato_descripcion"].ToString();
                
                //Dificultad
                bool bandera = false;
                int i = 0;
                while (bandera == false)
                {
                    ep.cbDificultad.SelectedIndex = i;
                    if (ep.cbDificultad.SelectedItem.ToString() == tb.Rows[0]["plato_dificultad"].ToString())
                    {
                        bandera = true;
                    }
                    i++;
                }
                ep.txtPrecio.Text = tb.Rows[0]["plato_preciof"].ToString();

                //Categoria
                string categoria = mostrar.ObtenerCategoria(ep.cbCategoria, tb.Rows[0]["categoria_id"].ToString());
                bandera = false;
                i = 0;
                while (bandera == false)
                {
                    ep.cbCategoria.SelectedIndex = i;
                    if (ep.cbCategoria.SelectedItem.ToString() == categoria)
                    {
                        bandera = true;
                    }
                    i++;
                }

                //Obtener el arreglo de Bytes 
                byte[] img = (byte[])tb.Rows[0]["plato_foto"];

                //Convertir el arreglo a imagen
                System.IO.MemoryStream ms = new System.IO.MemoryStream(img);
                ep.pbFotoPlatillo.Image = Image.FromStream(ms);

                
            }

            //OBTENER INGREDIENTES DEL PLATILLO  -----------------------------------------------------------
            {
                ep.dgvIngredientes.Rows.Clear();
                DataTable dt = mostrar.InformacionID($"Select * From PLATILLO_INGREDIENTE WHERE platillo_id = {id}");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string ingre = $"Select ingrediente_nombre From INGREDIENTE WHERE ingrediente_id = {dt.Rows[i]["ingrediente_id"]}";
                    string ingrediente = mostrar.Buscar_Retornar(ingre);
                    string unidad = $"Select ingrediente_unidad_medida From INGREDIENTE WHERE ingrediente_id = {dt.Rows[i]["ingrediente_id"]}";
                    string U_medida = mostrar.Buscar_Retornar(unidad);

                    //Agrega valores a las filas de la tabla
                    int n = ep.dgvIngredientes.Rows.Add();
                    ep.dgvIngredientes.Rows[n].Cells[1].Value = dt.Rows[i]["cantidad_ingre_plato"].ToString();
                    ep.dgvIngredientes.Rows[n].Cells[2].Value = U_medida;
                    ep.dgvIngredientes.Rows[n].Cells[0].Value = ingrediente ;
                }
            }

            //OBTENER RECETA DEL PLATILLO DEL PLATILLO -----------------------------------------------------------
            {
                ep.dgvProcedimiento.Rows.Clear();
                DataTable t = mostrar.InformacionID($"Select * From RECETA WHERE plato_id = {id}");

                for (int i = 0; i < t.Rows.Count; i++)
                {
                    //Agrega valores a las filas de la tabla
                    int n = ep.dgvProcedimiento.Rows.Add();
                    ep.dgvProcedimiento.Rows[n].Cells[0].Value = t.Rows[i]["no_paso"].ToString();
                    ep.dgvProcedimiento.Rows[n].Cells[1].Value = t.Rows[i]["descripcion"].ToString();
                }
            }

            ep.ShowDialog();
            dgvPlatillos_muestra.DataSource = mostrar.MuestraPlatillos_Tabla().Tables[0];
        }

        private void cmdImprimirReceta_Click(object sender, EventArgs e)
        {
            frmRecetaPlatillo receta = new frmRecetaPlatillo();
            CrystalReport1 reporte = new CrystalReport1();

            DataSet dst = mostrar.Reporte("Select * From RECETA WHERE plato_id=" + id);
            //DataSet dst = mostrar.Reporte("Select * From RECETA WHERE plato_id=" + id);

            reporte.SetDataSource(dst.Tables[0]);
            receta.crystalReportViewer1.ReportSource = reporte;
            receta.ShowDialog();
        }
    }
}
