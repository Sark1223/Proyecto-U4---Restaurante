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

        //Variables auxiliares
        string ID_Actual, nombre;
        bool primeraApertura = true;


        private void frmEditarPlatillo_Load(object sender, EventArgs e)
        {
            if (lblTitle.Text == "AGREGAR PLATILLO")
            {
                editar_plato.LlenarCBCategoria(cbCategoria);
                cmdAgregarIngrediente.Enabled = false;
                cmdAgregarPaso.Enabled = false;
                pnAgregar.Visible = true;
                pnModificar.Visible = false;
            }
            else
            {
                pnModificar.Visible = true;
                pnAgregar.Visible = false;

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
                if(pbFotoPlatillo.Image == Properties.Resources.estilo_grafico__1_)
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

        //INGRESAR IMAGEN
        private void cmdExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if(selectorImagen.ShowDialog() == DialogResult.OK)
            {
                pbFotoPlatillo.SizeMode = PictureBoxSizeMode.StretchImage;
                pbFotoPlatillo.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                pbFotoPlatillo.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Jpeg);

                platilloBLL.plato_foto = memoria.ToArray();
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


        //METODOS INGREDIENTES--------------------------------------------------

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
            ingre_platoBLL.ingrediente_id = conexion.GuardarInfoCB_Tabla("SELECT ingrediente_id FROM INGREDIENTE WHERE ingrediente_nombre='" + cbIngredientes.Text + "'"); ;
            ingre_platoBLL.cantidad_ingre_plato = float.Parse(txtCantidad.Text);
        }

        private void agregarIngrediente_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosIngrediente())
            {
                RecuperarInformacionIngrediente();
                if (editar_plato.AgregarIngrediente(ingre_platoBLL))
                {
                    MessageBox.Show("Se INGRESARON los ingredientes CORRECTAMENTE", "Ingrediente Agregado");
                    
                }
                else
                {
                    MessageBox.Show("NO se pudo ingresar la informacion del platillo", "Error al ingresar platillo");
                }
            }
        }

        //accion de botones
        private void agregarIngrediente_MouseHover(object sender, EventArgs e)
        {
             this.cmdAgregarIngrediente.Size = new Size(29, 31);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex > 0)
            {
                platilloBLL.categoria_id = conexion.GuardarInfoCB_Tabla("SELECT * FROM CATEGORIA WHERE categoria_nombre='" + cbCategoria.Text + "'");

            }
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Close();
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


        private void agregarIngrediente_MouseLeave(object sender, EventArgs e)
        {
            this.cmdAgregarIngrediente.Size = new Size(26, 27);
        }




    }
}
