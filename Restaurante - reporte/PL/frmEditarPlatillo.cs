using Restaurante___reporte.BLL;
using Restaurante___reporte.DAL;
using Restaurante___reporte.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Restaurante___reporte.PL
{
    public partial class frmEditarPlatillo : Form
    {
        public frmEditarPlatillo()
        {
            InitializeComponent();
        }

        ///Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Mover(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Objetos de clases
        PlatilloBLL platilloBLL = new PlatilloBLL();
        Platillo_IngredienteBLL ingre_platoBLL = new Platillo_IngredienteBLL();
        Platillo_ProcedimientoBLL pro_platoBLL = new Platillo_ProcedimientoBLL();
        Editar_Platillo editar_plato = new Editar_Platillo();
        Conexion conexion = new Conexion();
        Mostrar_Platillo mostrar = new Mostrar_Platillo();
        //Variables auxiliares
        string ID_Actual, nombre;
        bool primeraApertura = true;
        bool imagen = false;


        private void frmEditarPlatillo_Load(object sender, EventArgs e)
        {
            editar_plato.LlenarCBIngrediete(cbIngredientes);

            if (lblTitle.Text == "AGREGAR PLATILLO")
            {
                editar_plato.LlenarCBCategoria(cbCategoria);
                
                cmdAgregarIngrediente.Enabled = false;
                cmdAgregarPaso.Enabled = false;

                //Habilitar paneles de añadir
                //pnAñadirIngre.Visible = true;
                pnAñadirPaso.Visible = true;
                pnAgregar.Visible = true;

                //Inabilitar paneles modificar
                pnModificar.Visible = false;
                pnModifiIngre.Visible = false;
                pnModifiPaso.Visible = false;
                imagen = false;
            }
            else
            {
                cmdAgregarIngrediente.Enabled = true;
                cmdAgregarPaso.Enabled = true;
                //Inabilitar paneles de añadir
                //pnAñadirIngre.Visible = false;
                //pnAñadirPaso.Visible = false;
                pnAgregar.Visible = false;

                //Mostrar paneles modificar
                pnModificar.Visible = true;
                pnModifiIngre.Visible = true;
                pnModifiPaso.Visible = true;

                imagen = true;

                if (txtId_platillo.Text != "")
                {
                    ID_Actual = txtId_platillo.Text;
                }

                if(txtNombre.Text != "")
                {
                    nombre = txtNombre.Text;
                }
            }
            primeraApertura = false;
        }


        //METODOS PLATILLO---------------------------------------------------------------
        public void RecuperarInforcionPlatillo()
        {
            platilloBLL.plato_id = int.Parse(txtId_platillo.Text);
            platilloBLL.plato_nombre = txtNombre.Text;
            platilloBLL.plato_dificultad = cbDificultad.Text;
            platilloBLL.plato_preciof = float.Parse(txtPrecio.Text);
            platilloBLL.plato_descripcion = txtDescripcion.Text;
            //platilloBLL.categoria_id = cbCategoria.Text;

            GuardarImagen();
        }

        //VALIDACION DE VALORES INGRESADOS POR EL USUARIO
        public bool ValoresVaciosPlatillo()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtId_platillo.Text == "")
                {
                    valoresVacios += "id_platillo, ";
                    no_vacios++;
                }
                if (txtNombre.Text == "")
                {
                    valoresVacios += "Nombre, ";
                    no_vacios++;
                }
                if (cbCategoria.Text == "-- Categoria --")
                {
                    valoresVacios += "Categoria, ";
                    no_vacios++;
                }
                if (cbDificultad.Text == "-- Dificultad --")
                {
                    valoresVacios += "Dificultad, ";
                    no_vacios++;
                }
                if (txtPrecio.Text == "")
                {
                    valoresVacios += "Precio, ";
                    no_vacios++;
                }
                if (txtDescripcion.Text == "")
                {
                    valoresVacios += "Descripcion,";
                    no_vacios++;
                }
                if(imagen == false)
                {
                    valoresVacios += "Imagen";
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

        //VALIDACIONES DE ID PLATILLO
        private void txtId_platillo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                platilloBLL.plato_id = int.Parse(txtId_platillo.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                txtId_platillo.SelectAll();
            }
        }

        private void txtId_platillo_Validated(object sender, EventArgs e)
        {
            error.SetError(txtId_platillo, "");
        }

        private void txtId_platillo_Validating(object sender, CancelEventArgs e)
        {
            if(primeraApertura == false)
            {
                if (lblTitle.Text == "GREGAR PLATILLO")
                {
                    if (!conexion.BuscarEnTabla_AGREGAR("SELECT * FROM PLATILLO", txtId_platillo.Text, 0, txtId_platillo, error) && txtId_platillo.Text != "")
                    {
                        // Cancel the event and select the text to be corrected by the user.
                        e.Cancel = true;
                        txtId_platillo.Select(0, txtId_platillo.Text.Length);
                    }
                    else
                    {
                        platilloBLL.plato_id = int.Parse(txtId_platillo.Text);
                    }
                }
                else
                {
                    //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN
                    if (!conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM PLATILLO", txtId_platillo.Text, 0, ID_Actual, txtId_platillo, error) && txtId_platillo.Text != "")
                    {
                        e.Cancel = true;
                        txtId_platillo.Select(0, txtId_platillo.Text.Length);
                    }
                    else
                    {
                        platilloBLL.plato_id = int.Parse(txtId_platillo.Text);
                    }

                }

            }
        }

        //VALIDACIONES DE NOMBRE PLATILLO

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            error.SetError(txtNombre, "");
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (primeraApertura == false)
            {
                if (lblTitle.Text == "GREGAR PLATILLO")
                {
                    if (!conexion.BuscarEnTabla_AGREGAR("SELECT * FROM PLATILLO", txtNombre.Text, 1, txtNombre, error) && txtNombre.Text != "")
                    {
                        // Cancel the event and select the text to be corrected by the user.
                        e.Cancel = true;
                        txtNombre.Select(0, txtNombre.Text.Length);
                    }
                    else
                    {
                        platilloBLL.plato_nombre = txtNombre.Text;
                    }
                }
                else
                {
                    //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN
                    if (!conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM PLATILLO", txtNombre.Text, 1, nombre, txtNombre, error) && txtNombre.Text != "")
                    {
                        e.Cancel = true;
                        txtNombre.Select(0, txtNombre.Text.Length);
                    }
                    else
                    {
                        platilloBLL.plato_nombre = txtNombre.Text;
                    }

                }

            }
        }

        public void GuardarImagen()
        {
            MemoryStream memoria = new MemoryStream();
            pbFotoPlatillo.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

            platilloBLL.plato_foto = memoria.GetBuffer();
        }

        //INGRESAR IMAGEN
        private void cmdExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if(selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pbFotoPlatillo.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoPlatillo.Image = Image.FromStream(selectorImagen.OpenFile());
               

                imagen = true;
            }
        }

        //AGREGAR PLATILLO 
        private void pbListo_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosPlatillo())
            {
                RecuperarInforcionPlatillo();
                if (editar_plato.AgregarPlatillo(platilloBLL))
                {
                    MessageBox.Show("Se INGRESARON los datos del platillo CORRECTAMENTE","Platillo Agregado");
                    pbListo.Enabled = false;
                    cmdAgregarIngrediente.Enabled = true;
                    cmdAgregarPaso.Enabled = true;
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del platillo","Error al ingresar platillo");
                }
            }
            
        }

        
        private void pbModificar_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosPlatillo())
            {
                RecuperarInforcionPlatillo();

                if (editar_plato.ModificarPlatillo(platilloBLL, ID_Actual))
                {
                    MessageBox.Show($"El platillo {txtNombre.Text} ha sido modificado", "Platillo MODIFICADO");

                }
                else
                {
                    MessageBox.Show("No se pudo MODIFICAR el platillo.", "ERROR DE MODIFICACIÓN");
                }
            }
        }

        private void pbEliminarPlato_Click(object sender, EventArgs e)
        {
            if (editar_plato.EliminarPlatillo(txtId_platillo.Text))
            {
                MessageBox.Show("El Platillo " + txtNombre.Text + " fue ELIMINADO", "REGISTRO ELIMINADO");

                primeraApertura = true;
                Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex > 0)
            {
                platilloBLL.categoria_id = int.Parse(conexion.GuardarInfoCB_Tabla("SELECT * FROM CATEGORIA WHERE categoria_nombre='" + cbCategoria.Text + "'"));

            }
        }

        //accion de botones
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
      
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                platilloBLL.plato_preciof = float.Parse(txtPrecio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
                txtPrecio.SelectAll();
            }
        }

        
        
        //METODOS INGREDIENTES ---------------------------------------------------------
        List<APIngrediente> TablaIngre = new List<APIngrediente>();
        APIngrediente ingre;

        //VALIDACION DE VALORES INGRESADOS POR EL USUARIO
        public bool ValoresVaciosIngrediente()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (cbIngredientes.Text == "-- Ingrediente --")
                {
                    valoresVacios += "Ingrediente, ";
                    no_vacios++;
                }
                if (txtCantidad.Text == "")
                {
                    valoresVacios += "Cantidad ";
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

        public void RecuperarInformacionIngrediente()
        {
            ingre_platoBLL.platillo_id = int.Parse(txtId_platillo.Text);
            ingre_platoBLL.ingrediente_id = int.Parse(conexion.GuardarInfoCB_Tabla("SELECT ingrediente_id FROM INGREDIENTE WHERE ingrediente_nombre='" + cbIngredientes.Text + "'"));
            ingre_platoBLL.cantidad_ingre_plato = float.Parse(txtCantidad.Text);
        }
        
        int pos=0;
        private void agregarIngrediente_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosIngrediente())
            {
                RecuperarInformacionIngrediente();
                if (editar_plato.AgregarIngrediente(ingre_platoBLL))
                {
                    MessageBox.Show("Se INGRESARON los ingredientes CORRECTAMENTE", "Ingrediente Agregado");

                    ingre = new APIngrediente
                    {
                        nombre_ingrediente =cbIngredientes.Text,
                        unidad =conexion.GuardarInfoCB_Tabla("SELECT ingrediente_unidad_medida FROM INGREDIENTE WHERE ingrediente_nombre='" + cbIngredientes.Text + "'"),
                        cantidad =ingre_platoBLL.cantidad_ingre_plato.ToString()
                    };

                    TablaIngre.Add(ingre);

                    //Agrega valores a las filas de la tabla
                    int n= dgvIngredientes.Rows.Add();
                    dgvIngredientes.Rows[n].Cells[0].Value =TablaIngre[pos].nombre_ingrediente;
                    dgvIngredientes.Rows[n].Cells[1].Value =TablaIngre[pos].cantidad;
                    dgvIngredientes.Rows[n].Cells[2].Value =TablaIngre[pos].unidad;

                    pos++;
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del platillo", "Error al ingresar platillo");
                }
            }
        }
       
        private void cbIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbIngredientes.SelectedIndex > 0)
            {
                ingre_platoBLL.ingrediente_id = int.Parse(conexion.GuardarInfoCB_Tabla("SELECT ingrediente_id FROM INGREDIENTE WHERE ingrediente_nombre ='" + cbIngredientes.Text + "'"));

                lblUnidad_Medida.Text = conexion.GuardarInfoCB_Tabla("SELECT ingrediente_unidad_medida FROM INGREDIENTE WHERE ingrediente_nombre ='" + cbIngredientes.Text + "'");
            }
        }
       
        string idIngre = "";
        int ind = 0;
        private void dgvIngredientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            string ingrediene = dgvIngredientes.Rows[indice].Cells[0].Value.ToString();
            idIngre = mostrar.Buscar_Retornar($"Select ingrediente_id From INGREDIENTE WHERE ingrediente_nombre ='{ingrediene}'");
            ind = e.RowIndex;
            //Buscar ingrediente en combo box
            bool bandera = false;
            int i = 0;
            while (bandera == false)
            {
                cbIngredientes.SelectedIndex = i;
                if (cbIngredientes.SelectedItem.ToString() == ingrediene)
                {
                    bandera = true;
                }
                i++;
            }

            txtCantidad.Text = dgvIngredientes.Rows[indice].Cells[1].Value.ToString();
        }
        
        private void pbModificarIngrediente_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosIngrediente())
            {
                RecuperarInformacionIngrediente();

                if (editar_plato.ModificarIngrediente(ingre_platoBLL, idIngre))
                {
                    MessageBox.Show($"El ingrediente {cbIngredientes.Text} ha sido modificado", "Ingrediente MODIFICADO");

                    //Agrega valores a las filas de la tabla
                    dgvIngredientes.Rows[ind].Cells[0].Value = cbIngredientes.Text;
                    dgvIngredientes.Rows[ind].Cells[1].Value = txtCantidad.Text;
                    dgvIngredientes.Rows[ind].Cells[2].Value = lblUnidad_Medida.Text;
                }
                else
                {
                    MessageBox.Show("No se pudo MODIFICAR el ingredinte.", "ERROR DE MODIFICACIÓN");
                }
            }
        }

        private void pbEliminarIngrediente_Click(object sender, EventArgs e)
        {
            if (editar_plato.EliminarIngrediente(idIngre))
            {
                MessageBox.Show("El Ingrediente " + cbIngredientes.Text + " fue ELIMINADO", "REGISTRO ELIMINADO");
                //dgvIngredientes.Rows[ind].Visible = false;
                dgvIngredientes.Rows.RemoveAt(ind);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }


        //METODOS RECETA ---------------------------------------------------------------
        public bool ValoresVaciosPasos()
        {
            string valoresVacios = "";
            int no_vacios = 0;
            //VERIFICACION DE VALORES VACIOS
            {
                if (txtInstruccion.Text == "")
                {
                    valoresVacios += "Instruccion";
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

        public void RecuperarInfoPASO()
        {
            pro_platoBLL.plato_id = int.Parse(txtId_platillo.Text);
            pro_platoBLL.no_paso = int.Parse(txtPaso_no.Text);
            pro_platoBLL.descripcion = txtInstruccion.Text; 
        }

        int paso = 1;
        private void cmdAgregarPaso_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosPasos())
            {
                RecuperarInfoPASO();
                if (editar_plato.AgregarPaso(pro_platoBLL))
                {
                    MessageBox.Show("La instruccion se agrego CORRECTAMENTE", "Instruccion Agregada");

                    
                    //Agrega valores a las filas de la tabla
                    int n = dgvProcedimiento.Rows.Add();
                    dgvProcedimiento.Rows[n].Cells[0].Value = paso;
                    dgvProcedimiento.Rows[n].Cells[1].Value = pro_platoBLL.descripcion;

                    paso++;
                    txtPaso_no.Text = paso.ToString();

                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del paso", "Error al ingresar Instruccion");
                }
            }
        }

        private void pbModificarPaso_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosPasos())
            {
                RecuperarInfoPASO();
                if (editar_plato.ModificarPaso(pro_platoBLL,idPaso))
                {
                    MessageBox.Show("La instruccion se momdifico CORRECTAMENTE", "Instruccion MODIFICADA");

                    dgvProcedimiento.Rows[ind].Cells[0].Value = txtPaso_no.Text;
                    dgvProcedimiento.Rows[ind].Cells[1].Value = pro_platoBLL.descripcion;

                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del platillo", "Error al Modificar instruccion");
                }
            }
        }

        private void pbEliminarPaso_Click(object sender, EventArgs e)
        {
            if (editar_plato.EliminarPaso(idPaso))
            {
                MessageBox.Show("El Paso " + idPaso + " fue ELIMINADO", "REGISTRO ELIMINADO");
                dgvProcedimiento.Rows.RemoveAt(ind);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "ERROR", MessageBoxButtons.OK);
            }
        }

        string idPaso = "";
        private void dgvProcedimiento_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            idPaso = dgvProcedimiento.Rows[indice].Cells[0].Value.ToString();
            ind = e.RowIndex;

            txtPaso_no.Text = idPaso;
            txtInstruccion.Text = dgvProcedimiento.Rows[indice].Cells[1].Value.ToString();
        }


        //accion de botones
        private void agregarIngrediente_MouseHover(object sender, EventArgs e)
        {
             this.cmdAgregarIngrediente.Size = new Size(29, 31);
        }

        private void agregarIngrediente_MouseLeave(object sender, EventArgs e)
        {
            this.cmdAgregarIngrediente.Size = new Size(26, 27);
        }

        

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
