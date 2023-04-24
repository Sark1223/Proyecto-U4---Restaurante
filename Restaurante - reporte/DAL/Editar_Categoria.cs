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
    internal class Editar_Categoria
    {
        Conexion conexion = new Conexion();

        public Editar_Categoria()
        {
            conexion = new Conexion();
        }

        //METODOS CIUDAD
        public bool AgregarCategoria(CategoriaBLL categoria)
        {
            SqlCommand agregar = new SqlCommand(
        "insert into CATEGORIA(categoria_id," +
                           "categoria_nombre," +
                           "categoria_descripcion," +
                           "categoria_encargado)" +
        "values(@id,@nombre,@descripcion,@encargado)");
            {
                agregar.Parameters.AddWithValue("id", categoria.categoria_id);
                agregar.Parameters.AddWithValue("nombre", categoria.categoria_nombre);
                agregar.Parameters.AddWithValue("descripcion", categoria.categoria_descripcion);
                agregar.Parameters.AddWithValue("encargado", categoria.categoria_encargado);

                conexion.ejecutarComandoSinRetorno(agregar);
            }
            return true;

        }

        public void ModificarCategoria(CategoriaBLL categoria, int idAnterior)
        {
            /*/*CREATE TABLE CATEGORIA (
    categoria_id          VARCHAR(3) NOT NULL,
    categoria_nombre      VARCHAr(30) NOT NULL UNIQUE,
    categoria_descripcion VARCHAR(200) NOT NULL,
    categoria_encargado   VARCHAR(50) NOT NULL
);
        public int categoria_id;
        public string categoria_nombre;
        public string categoria_descripcion;
        public string categoria_encargado;*/
            try
            {
                SqlCommand modificar = new SqlCommand(
                         "update CATEGORIA set categoria_id =  @id, " +
                                           "categoria_nombre = @nombre," +
                                           "categoria_descripcion = @descripcion," +
                                           "categoria_encargado = @encargado " +
                                           "WHERE categoria_id =" + idAnterior);

                modificar.Parameters.AddWithValue("id", categoria.categoria_id);
                modificar.Parameters.AddWithValue("nombre", categoria.categoria_nombre);
                modificar.Parameters.AddWithValue("descripcion", categoria.categoria_descripcion);
                modificar.Parameters.AddWithValue("encargado", categoria.categoria_encargado);

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
            SqlCommand sentencia = new SqlCommand("SELECT * FROM CATEGORIA");
            return conexion.EjecutarSentenciaConRetorno(sentencia);
        }

    }
}
