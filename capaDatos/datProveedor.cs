﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;

namespace capaDatos
{
    public class datProveedor
    {
        #region sigleton
        private static readonly datProveedor _instancia = new datProveedor();
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion sigleton

        #region metodos

        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand($"LeerProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Pro = new entProveedor();
                    Pro.IDProveedor = Convert.ToInt32(dr["IDProveedor"]);
                    Pro.RUCProveedor = dr["RUCProveedor"].ToString();
                    Pro.Categoria = dr["Categoria"].ToString();
                    Pro.NombreProveedor = dr["NombreProveedor"].ToString();
                    Pro.FormaPago = dr["FormaPago"].ToString();
                    Pro.TelefonoProveedor = dr["TelefonoProveedor"].ToString();
                    Pro.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    lista.Add(Pro);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        public Boolean InsertarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("CrearProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUCProveedor", Pro.RUCProveedor);
                cmd.Parameters.AddWithValue("@Categoria", Pro.Categoria);
                cmd.Parameters.AddWithValue("@NombreProveedor", Pro.NombreProveedor);
                cmd.Parameters.AddWithValue("@FormaPago", Pro.FormaPago);
                cmd.Parameters.AddWithValue("@TelefonoProveedor", Pro.TelefonoProveedor);
                cmd.Parameters.AddWithValue("@FechaRegistro", Pro.FechaRegistro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean EditarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ActualizarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDProveedor", Pro.IDProveedor);
                cmd.Parameters.AddWithValue("@RUCProveedor", Pro.RUCProveedor);
                cmd.Parameters.AddWithValue("@Categoria", Pro.Categoria);
                cmd.Parameters.AddWithValue("@NombreProveedor", Pro.NombreProveedor);
                cmd.Parameters.AddWithValue("@FormaPago", Pro.FormaPago);
                cmd.Parameters.AddWithValue("@TelefonoProveedor", Pro.TelefonoProveedor);
                cmd.Parameters.AddWithValue("@FechaRegistro", Pro.FechaRegistro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        public Boolean DeshabilitarProveedor(entProveedor Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("BorrarProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDProveedor", Pro.IDProveedor);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }


        #endregion metodos

    }
}