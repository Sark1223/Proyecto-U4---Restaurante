using Restaurante___reporte.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Restaurante___reporte.DAL
{
    internal class Mostrar_Platillo
    {

        Conexion conexion = new Conexion();

        public Mostrar_Platillo()
        {
            conexion = new Conexion();
        }

        public DataSet MuestraPlatillos_Tabla()
        {
            SqlCommand sentencia = new SqlCommand("SELECT plato_nombre,plato_descripcion FROM PLATILLO");
            return conexion.EjecutarSentenciaConRetorno(sentencia);
        }

       
        //Recuperar ID
        public string RetornarID(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = conexion.EstablecerConexion();
            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string id = "";

            while (dr.Read())
            {
                id = dr[0].ToString();
            }
            cmd.Connection.Close();
            return id;
        }//para el metodo modificar

        public DataTable InformacionID(string sentencia)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = conexion.EstablecerConexion()
            };
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sentencia, cmd.Connection);
            da.Fill(tb);
            return tb;
        }

        //Obtener categoria
        public string Buscar_Retornar(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = conexion.EstablecerConexion();
            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string dato = "";
            while (dr.Read())
            {
                dato = dr[0].ToString();
            }
            cmd.Connection.Close();
            return dato;
        }


        //Recuperar PROCEDIMIENTO -----------------------------------------------------------
        public void RetornarProcedimiento(string sentencia, System.Windows.Forms.TextBox text)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = conexion.EstablecerConexion();
            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                text.Text = text.Text + "\r\n" + dr[0].ToString() +" " + dr[2].ToString();
            }
            cmd.Connection.Close();
        }//lo que se guarda en la tabla

        //Recuperar RECETA -----------------------------------------------------------


        //Recuperar PLATILLO -----------------------------------------------------------
        public string ObtenerCategoria(ComboBox cbCategoria, string id) 
        {
            conexion.RellenarCB(cbCategoria, "SELECT * FROM CATEGORIA", "-- Categoria --", 1);
            
            return Buscar_Retornar("SELECT categoria_nombre FROM CATEGORIA WHERE categoria_id=" + id);
            
        }
    
    
    
    }
}
