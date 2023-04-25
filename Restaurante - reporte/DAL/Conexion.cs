using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante___reporte.DLL
{
    internal class Conexion
    {
        private string CadenaConexion = @"server = ANVORGUEZA\SQLEXPRESS; Initial Catalog = RESTAURANTE; Integrated Security = true";
        SqlConnection conexion;

        //METODOS DE CONEXION
        public SqlConnection EstablecerConexion()
        {
            this.conexion = new SqlConnection(this.CadenaConexion);
            return this.conexion;
        }

        public DataSet EjecutarSentenciaConRetorno(SqlCommand comando)
        {
            DataSet DS = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd = comando;
                cmd.Connection = EstablecerConexion();
                adaptador.SelectCommand = cmd;
                conexion.Open();
                adaptador.Fill(DS);
                conexion.Close();

                return DS;
            }
            catch
            {
                return DS;
            }
        }

        //Metodo para AGREGAR, ELIMINAR Y MODIFICAR
        public void ejecutarComandoSinRetorno(SqlCommand Comandosql)
        {
            SqlCommand comando = Comandosql;
            comando.Connection = this.EstablecerConexion();
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        //METODOS COMBO BOX - COMPLEJO
        public void RellenarCB(ComboBox cb, string sentencia, string textoCB, int posicion)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = this.EstablecerConexion();
            cb.Items.Clear();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[posicion].ToString() != textoCB)
                {
                    cb.Items.Add(dr[posicion].ToString());
                }

            }
            conexion.Close();
            cb.Items.Insert(0, textoCB);
            cb.SelectedIndex = 0;
        }

        public int GuardarInfoCB_Tabla(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int ID = 0;
            while (dr.Read())
            {
                ID = int.Parse(dr[0].ToString());
            }
            conexion.Close();
            return ID;
        }//lo que se guarda en la tabla

        public string Retornar_info(string sentencia)
        {
            SqlCommand cmd = new SqlCommand(sentencia);
            cmd.Connection = EstablecerConexion();
            conexion.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            string nombre = "";
            while (dr.Read())
            {
                nombre = dr[0].ToString() + "  " + dr[1].ToString();
            }
            conexion.Close();
            return nombre;
        }//para el metodo modificar

        public string SepararValores(string seleccion)
        {
            //char[] characters = cuote.ToCharArray();
            string[] palabraClave = seleccion.Split();

            return palabraClave[0];
        }


        //Buscar valores en tabla
        public bool BuscarEnTabla_AGREGAR(string sentencia, string valor, int posicion, Control control, ErrorProvider error)
        {
            //public bool ValidEmailAddress(string emailAddress, out string errorMessage)
            //{
            //    // Confirm that the email address string is not empty.
            //    if (emailAddress.Length == 0)
            //    {
            //        errorMessage = "email address is required.";
            //        return false;
            //    }

            //    // Confirm that there is an "@" and a "." in the email address, and in the correct order.
            //    if (emailAddress.IndexOf("@") > -1)
            //    {
            //        if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
            //        {
            //            errorMessage = "";
            //            return true;
            //        }
            //    }

            //    errorMessage = "email address must be valid email address format.\n" +
            //       "For example 'someone@example.com' ";
            //    return false;
            //}
            try
            {
                SqlCommand cmd = new SqlCommand(sentencia);
                cmd.Connection = EstablecerConexion();
                conexion.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[posicion].ToString() == valor)
                    {
                        error.SetError(control, "EL valor " + valor + " de  ya existe");
                        return false;
                    }

                }
                conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public int BuscarEnTabla_MODIFICAR(string sentencia, string valor, int posicion, string valorCarga, string tipoValor)
        {
            int vecesRepetido = 0;
            try
            {
                if (valor == valorCarga)
                {
                    return 0;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sentencia);
                    cmd.Connection = EstablecerConexion();
                    conexion.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (dr[posicion].ToString() == valor)
                        {
                            MessageBox.Show("EL valor " + valor + " de " + tipoValor + " ya existe");
                            vecesRepetido++;
                        }

                    }
                    conexion.Close();
                    return vecesRepetido;
                }

            }
            catch
            {
                return 2;
            }

        }

        ////METODOS GENERALES DE EDICION
        //public bool Eliminar(string codigoSQL)
        //{
        //    try
        //    {

        //        //    MessageBox.Show("El registro sera eliminado permanente, ¿Desea CONTINUAR?", "ATENCION", MessageBoxButtons.OKCancel);
        //        //    if (MessageBox == DialogResult.Cancel)
        //        //    {

        //        //    }
        //        SqlCommand sentencia = new SqlCommand(codigoSQL);
        //        EjecutarSentencia(sentencia);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //        //}
        //        //catch (SqlException ex)
        //        //{

        //    }
        //}

    }
}
