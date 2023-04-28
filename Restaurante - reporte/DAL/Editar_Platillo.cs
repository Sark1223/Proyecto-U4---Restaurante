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

        public bool ModificarPlatillo(PlatilloBLL platillo, string idAnterior)
        {

            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update PLATILLO set plato_id = @id, " +
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
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EliminarPlatillo(string id)
        {
            try
            {
                if (MessageBox.Show("EL platillo sera eliminado permanentemente y con el su receta y los ingredintes del mismo, ¿Desea CONTINUAR?", "ATENCION", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return false;
                }
                else
                {
                    //Eliminar Receta
                    SqlCommand eliminarpasos = new SqlCommand($"DELETE FROM RECETA WHERE plato_id = {id}");
                    conexion.ejecutarComandoSinRetorno(eliminarpasos);

                    //Eliminar Ingredientes
                    SqlCommand eliminaringredientes = new SqlCommand($"DELETE FROM PLATILLO_INGREDIENTE WHERE platillo_id = {id}");
                    conexion.ejecutarComandoSinRetorno(eliminaringredientes);

                    //Eliminar platillo
                    SqlCommand eliminarplato = new SqlCommand($"DELETE FROM PLATILLO WHERE plato_id = {id}");
                    conexion.ejecutarComandoSinRetorno(eliminarplato);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public void LlenarCBCategoria(ComboBox cbCategoria)
        {
            conexion.RellenarCB(cbCategoria, "SELECT * FROM CATEGORIA", "-- Categoria --", 1);
        }


        //METODOS INGREDIENTES -------------------------------------------------------------------
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

        public bool ModificarIngrediente(Platillo_IngredienteBLL ingrediente, string id)
        {

            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update PLATILLO_INGREDIENTE set platillo_id =  @id_plato, " +
                                           "ingrediente_id = @id_ingrediente," +
                                           "cantidad_ingre_plato = @cantidad " +
                                           "WHERE ingrediente_id = " + id);

                modificar.Parameters.AddWithValue("id_plato", ingrediente.platillo_id);
                modificar.Parameters.AddWithValue("id_ingrediente", ingrediente.ingrediente_id);
                modificar.Parameters.AddWithValue("cantidad", ingrediente.cantidad_ingre_plato);

                conexion.ejecutarComandoSinRetorno(modificar);
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EliminarIngrediente(string id)
        {
            try
            {
                SqlCommand eliminar = new SqlCommand($"DELETE FROM PLATILLO_INGREDIENTE WHERE ingrediente_id = {id}");
                conexion.ejecutarComandoSinRetorno(eliminar);
                return true;
            }
            catch
            {
                return false;
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

        public bool Eliminar(string codigoSQL)
        {
            try
            {
                if (MessageBox.Show("El registro sera eliminado permanente, ¿Desea CONTINUAR?", "ATENCION", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return false;
                }
                else
                {
                    SqlCommand sentencia = new SqlCommand(codigoSQL);
                    conexion.ejecutarComandoSinRetorno(sentencia);
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }


        //METODOS PROCEDIMIENTO--------------------------------------------------------------
        public bool AgregarPaso(Platillo_ProcedimientoBLL paso)
        {
            SqlCommand agregar = new SqlCommand(
            "insert into RECETA(no_paso," +
                               "plato_id," +
                               "descripcion)" +
            "values(@id_paso,@id_plato,@descripcion)");
            {
                agregar.Parameters.AddWithValue("id_paso", paso.no_paso);
                agregar.Parameters.AddWithValue("id_plato", paso.plato_id);
                agregar.Parameters.AddWithValue("descripcion", paso.descripcion);

                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }

        public bool ModificarPaso(Platillo_ProcedimientoBLL paso, string id)
        {
            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update RECETA set no_paso =  @id_paso, " +
                                           "plato_id = @id_plato," +
                                           "descripcion = @descripcion " +
                                           "WHERE no_paso =" + id);

                modificar.Parameters.AddWithValue("id_paso", paso.no_paso);
                modificar.Parameters.AddWithValue("id_plato", paso.plato_id);
                modificar.Parameters.AddWithValue("descripcion", paso.descripcion);

                conexion.ejecutarComandoSinRetorno(modificar);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool EliminarPaso(string id)
        {
            try
            {
                SqlCommand eliminar = new SqlCommand($"DELETE FROM RECETA WHERE no_paso = {id}");
                conexion.ejecutarComandoSinRetorno(eliminar);
                return true;
            }
            catch
            {
                return false;
            }

            
        }

    }
}
