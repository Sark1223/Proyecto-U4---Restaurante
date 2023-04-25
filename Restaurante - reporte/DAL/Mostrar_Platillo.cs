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
    }
}
