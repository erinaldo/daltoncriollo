﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class D_Articulo
    {

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spLisArt", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spBuscarArticulo", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }
        
        public DataTable BuscarCodigoArt(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo_pt", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }
        
        public DataTable BuscarCodigoArtMP(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo_mp", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }
        
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spArticuloExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.Int).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        
        public string Insertar(E_Articulo Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spArticulos", SqlCon);
                Comando.CommandType=CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value=1;
                Comando.Parameters.Add("@iart", SqlDbType.Int).Value=Obj.idearticulo;
                Comando.Parameters.Add("@iname", SqlDbType.VarChar).Value=Obj.nombreart;
                Comando.Parameters.Add("@icode", SqlDbType.VarChar).Value=Obj.codigoart;
                Comando.Parameters.Add("@iprecio",SqlDbType.Decimal).Value=Obj.precioart;
                Comando.Parameters.Add("@istock",SqlDbType.Decimal).Value=Obj.stock;
                Comando.Parameters.Add("@iuni",SqlDbType.VarChar).Value=Obj.unidad;
                SqlCon.Open();
                Rpta=Comando.ExecuteNonQuery()==1 ? "OK" : "No se INSERTO Registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        
        public string Actualizar(E_Articulo Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spArticulos", SqlCon);
                Comando.CommandType=CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value=2;
                Comando.Parameters.Add("@iart", SqlDbType.Int).Value=Obj.idearticulo;
                Comando.Parameters.Add("@iname", SqlDbType.VarChar).Value=Obj.nombreart;
                Comando.Parameters.Add("@icode", SqlDbType.VarChar).Value=Obj.codigoart;
                Comando.Parameters.Add("@iprecio",SqlDbType.Decimal).Value=Obj.precioart;
                Comando.Parameters.Add("@istock",SqlDbType.Decimal).Value=Obj.stock;
                Comando.Parameters.Add("@iuni",SqlDbType.VarChar).Value=Obj.unidad;
                SqlCon.Open();
                Rpta=Comando.ExecuteNonQuery()==1 ? "OK" : "No se ACTUALIZO Registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        
        public string  Eliminar(E_Articulo Obj)
        {
                string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spArticulos", SqlCon);
                Comando.CommandType=CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value=3;
                Comando.Parameters.Add("@iart", SqlDbType.Int).Value=Obj.idearticulo;
                Comando.Parameters.Add("@iname", SqlDbType.VarChar).Value=Obj.nombreart;
                Comando.Parameters.Add("@icode", SqlDbType.VarChar).Value=Obj.codigoart;
                Comando.Parameters.Add("@iprecio",SqlDbType.Decimal).Value=Obj.precioart;
                Comando.Parameters.Add("@istock",SqlDbType.Decimal).Value=Obj.stock;
                Comando.Parameters.Add("@iuni",SqlDbType.VarChar).Value=Obj.unidad;
                SqlCon.Open();
                Rpta=Comando.ExecuteNonQuery()==1 ? "OK" : "No se ELIMINO Registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        
        
    }

}
