using Restaurante___reporte.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Restaurante___reporte.BLL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante___reporte.DAL
{
    internal class Editar_Platillo
    {
        Conexion conexion = new Conexion();

        public Editar_Platillo()
        {
            conexion = new Conexion();
        }

        //METODOS PLATILLO
        public bool AgregarPlatillo(PlatilloBLL platillo)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into PLATILLO(plato_id," +
                           "plato_nombre," +
                           "plato_descripcion," +
                           "plato_dificultad," +
                           "plato_foto," +
                           "plato_preciof," +
                           "categoria_id)" +
        "values(@id,@nombre,@descripcion,@dififultad,@foto,@precio,@categoria)");
            {
                agregar.Parameters.AddWithValue("id", platillo.plato_id);
                agregar.Parameters.AddWithValue("nombre", platillo.plato_nombre);
                agregar.Parameters.AddWithValue("descripcion", platillo.plato_descripcion);
                agregar.Parameters.AddWithValue("dififultad", platillo.plato_dificultad);
                agregar.Parameters.AddWithValue("foto", platillo.plato_foto);
                agregar.Parameters.AddWithValue("precio", platillo.plato_preciof);
                agregar.Parameters.AddWithValue("categoria", platillo.categoria_id);

                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }

        public void ModificarPlatillo(PlatilloBLL platillo, int idAnterior)
        {

            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update PLATILLO set plato_id =  @id, " +
                                           "plato_nombre = @nombre," +
                                           "plato_descripcion = @descripcion," +
                                           "plato_dificultad = @dififultad, " +
                                           "plato_foto = @foto, " +
                                           "plato_preciof = @precio, " +
                                           "categoria_id = @categoria " +
                                           "WHERE plato_id =" + idAnterior);

                modificar.Parameters.AddWithValue("id", platillo.plato_id);
                modificar.Parameters.AddWithValue("nombre", platillo.plato_nombre);
                modificar.Parameters.AddWithValue("descripcion", platillo.plato_descripcion);
                modificar.Parameters.AddWithValue("dififultad", platillo.plato_dificultad);
                modificar.Parameters.AddWithValue("foto", platillo.plato_foto);
                modificar.Parameters.AddWithValue("precio", platillo.plato_preciof);
                modificar.Parameters.AddWithValue("categoria", platillo.categoria_id);

                conexion.ejecutarComandoSinRetorno(modificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LlenarCBCategoria(ComboBox cbCategoria)
        {
            conexion.RellenarCB(cbCategoria, "SELECT * FROM CATEGORIA", "-- Categoria --", 1);
        }



        //METODOS INGREDIENTES
        public bool AgregarIngrediente(Platillo_IngredienteBLL ingrediente)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into PLATILLO_INGREDIENTE(platillo_id," +
                                         "ingrediente_id," +
                                         "cantidad_ingre_plato)" +
            "values(@id_plato,@id_ingrediente,@cantidad)");
            {
                agregar.Parameters.AddWithValue("id_plato", ingrediente.platillo_id);
                agregar.Parameters.AddWithValue("id_ingrediente", ingrediente.ingrediente_id);
                agregar.Parameters.AddWithValue("cantidad", ingrediente.cantidad_ingre_plato);
                
                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }

        public void ModificarPlatillo(Platillo_IngredienteBLL ingrediente, int idAnterior)
        {

            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update PLATILLO set platillo_id =  @id_plato, " +
                                           "ingrediente_id = @id_ingrediente," +
                                           "cantidad_ingre_plato = @cantidad " +
                                           "WHERE plato_id =" + idAnterior);

                modificar.Parameters.AddWithValue("id_plato", ingrediente.platillo_id);
                modificar.Parameters.AddWithValue("id_ingrediente", ingrediente.ingrediente_id);
                modificar.Parameters.AddWithValue("cantidad", ingrediente.cantidad_ingre_plato);

                conexion.ejecutarComandoSinRetorno(modificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LlenarCBIngrediete(ComboBox cbIngrediente) 
        {
            conexion.RellenarCB(cbIngrediente, "SELECT * FROM INGREDIENTE", "-- Ingrediente --", 1);
        }

        public DataSet MuestraIngredientesPlato()
        {
            SqlCommand sentencia = new SqlCommand("SELECT plato_nombre,plato_descripcion FROM PLATILLO");
            return conexion.EjecutarSentenciaConRetorno(sentencia);
        }
    }
}
