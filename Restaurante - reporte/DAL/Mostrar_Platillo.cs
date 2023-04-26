using Restaurante___reporte.DLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

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

        //METODOS COMBO BOX - COMPLEJO
        public void ObtenerProcedimiento(string id_platillo, TextBox text)
        {
            string sentencia = "Select * from RECETA";
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = conexion.EstablecerConexion();
            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[0].ToString() == id_platillo)
                {
                    text.Text = text.Text + dr[0].ToString() + "  " + dr[0].ToString() +"\r\n";
                }

            }
            cmd.Connection.Close();
        }

        //Recuperar informacion PLATILLO
        public string[] Retornar_info_1(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = conexion.EstablecerConexion();
            cmd.Connection.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string[] informacion = new string[10];

            while (dr.Read())
            {
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    informacion[i] = dr[i].ToString();
                }
            }
            cmd.Connection.Close();
            return informacion;
        }//para el metodo modificar


        //public byte[] BuscarCliId(string sentencia)
        //{
        //    //DataTable tb = new DataTable();
        //    //SqlDataAdapter da = new SqlDataAdapter("usp_BuscarCliId '" + xid + "'", cn);
        //    //da.Fill(tb);
        //    //return tb;

        //    SqlCommand cmd = new SqlCommand(sentencia);
        //    //cmd.Connection = conexion.EstablecerConexion();
        //    //cmd.Connection.Open();

        //    //SqlDataReader dr = cmd.ExecuteReader();
        //    //byte[] foto = null;

        //    //while (dr.Read())
        //    //{
        //    //    foto = (byte[])dr[0];
        //    //}
        //    //cmd.Connection.Close();
        //    //return foto;
        //}

        public DataTable BuscarCliId(string xid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.EstablecerConexion();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter($"Select plato_foto From PLATILLO WHERE plato_id = {xid}", cmd.Connection);
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
            string nombre_categoria = "";
            while (dr.Read())
            {
                nombre_categoria = dr[0].ToString();
            }
            cmd.Connection.Close();
            return nombre_categoria;
        }
    }
}
