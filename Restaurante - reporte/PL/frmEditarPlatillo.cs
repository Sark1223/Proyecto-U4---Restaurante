﻿using Restaurante___reporte.BLL;
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

        //Variables auxiliares
        string ID_Actual, id_categoria;
        bool primeraApertura = true;


        private void frmEditarPlatillo_Load(object sender, EventArgs e)
        {
            if (lblTitle.Text == "AGREGAR PLATILLO")
            {
                editar_plato.LlenarCBCategoria(cbCategoria);
                //conexion.RellenarCB_1(cbCiudad, "SELECT * FROM CIUDAD", "-- Selecione Ciudad --");
                //conexion.RellenarCB_2(cbPropietario, "SELECT * FROM PROPIETARIO", "-- Selecione Propietario --");
            }
            primeraApertura = false;
        }


        //METODOS PLATILLO-------------------------------------------
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

        private void pbListo_Click(object sender, EventArgs e)
        {
            if (!ValoresVaciosPlatillo())
            {
                RecuperarInforcionPlatillo();
                editar_plato.AgregarPlatillo(platilloBLL);
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
        private void agregarIngrediente_Click(object sender, EventArgs e)
        {
            
        }

        //accion de botones
        private void agregarIngrediente_MouseHover(object sender, EventArgs e)
        {
             this.agregarIngrediente.Size = new Size(29, 31);
        }

        private void txtId_platillo_TextChanged(object sender, EventArgs e)
        {
            //if (primeraApertura == false)
            //{
            //    try
            //    {
            //        if (lblTitle.Text == "MODIFICAR SUCURSAL")
            //        {
            //            //VERIFICAR QUE LOS DATOS UNICOS NO SE REPITAN 
            //            if (conexion.BuscarEnTabla_MODIFICAR("SELECT * FROM FARMACIA", txtIdFarmacia.Text, 0, ID_Actual, lblFarmacia.Text) < 1 && txtIdFarmacia.Text != "")
            //            {
            //                objSucursal.id_propi_farm = int.Parse(txtIdFarmacia.Text);
            //            }
            //            else
            //            {
            //                txtIdFarmacia.SelectAll();
            //            }

            //        }
            //        else
            //        {
            //            if (conexion.BuscarEnTabla_AGREGAR("SELECT * FROM FARMACIA", txtIdFarmacia.Text, 0, lblFarmacia.Text) && txtIdFarmacia.Text != "")
            //            {
            //                objSucursal.id_propi_farm = int.Parse(txtIdFarmacia.Text);
            //            }
            //            else
            //            {
            //                txtIdFarmacia.SelectAll();
            //            }
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        MessageBox.Show("Ingrese SOLO NUMEROS.", "ERROR DE FORMATO");
            //        txtIdFarmacia.SelectAll();
            //    }
            //}
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex > 0)
            {
                platilloBLL.categoria_id = conexion.captar_info_1("SELECT * FROM CIUDAD WHERE nombre_ciudad='" + cbCiudad.Text + "'");

            }
        }

        private void agregarIngrediente_MouseLeave(object sender, EventArgs e)
        {
            this.agregarIngrediente.Size = new Size(26, 27);
        }

       
    }
}
