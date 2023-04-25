using Restaurante___reporte.BLL;
using Restaurante___reporte.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante___reporte.DAL
{
    internal class Editar_Ingrediente
    {
        Conexion conexion = new Conexion();

        public Editar_Ingrediente()
        {
            conexion = new Conexion();
        }

        //Metodo para agregar ingrediente
        public bool AgregarIngrediente(IngredienteBLL ingrediente)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into INGREDIENTE(ingrediente_id," +
                           "ingrediente_nombre," +
                           "ingrediente_unidad_medida," +
                           "ingrediente_cantidad_almacen)" +
        "values(@id,@nombre,@unidadMedida,@cantidadAlmacen)");
            {
                agregar.Parameters.AddWithValue("id", ingrediente.ingrediente_id);
                agregar.Parameters.AddWithValue("nombre", ingrediente.ingrediente_nombre);
                agregar.Parameters.AddWithValue("unidadMedida", ingrediente.ingrediente_unidad_medida);
                agregar.Parameters.AddWithValue("cantidadAlmacen", ingrediente.ingrediente_cantidad_almacen);

                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;
        }

        //Metodo para modificar ingrediente
        public void ModificarIngrediente(IngredienteBLL ingrediente, int idAnterior)
        {
            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update INGREDIENTE set ingrediente_id =  @id, " +
                                           "ingrediente_nombre = @nombre," +
                                           "ingrediente_unidad_medida = @unidadMedida," +
                                           "ingrediente_cantidad_almacen = @cantidadAlmacen " +
                                           "WHERE ingrediente_id =" + idAnterior);

                modificar.Parameters.AddWithValue("id", ingrediente.ingrediente_id);
                modificar.Parameters.AddWithValue("nombre", ingrediente.ingrediente_nombre);
                modificar.Parameters.AddWithValue("unidadMedida", ingrediente.ingrediente_unidad_medida);
                modificar.Parameters.AddWithValue("cantidadAlmacen", ingrediente.ingrediente_cantidad_almacen);

                conexion.ejecutarComandoSinRetorno(modificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Cargar tabla
        public DataSet TablaCategoria()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM INGREDIENTE");
            return conexion.EjecutarSentenciaConRetorno(sentencia);
        }
    }
}
