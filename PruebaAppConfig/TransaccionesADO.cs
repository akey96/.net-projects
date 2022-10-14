using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class TransaccionesADO
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
        //        var IdPais = (int)Paises.Mexico;
        //        using (SqlConnection sql = new SqlConnection(connectionString))
        //        {
        //            sql.Open();

        //            using (SqlCommand cmd = new SqlCommand("sp_Persona_Agregar ", sql))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add(new SqlParameter("@IdPais", IdPais));
        //                cmd.Parameters.Add(new SqlParameter("@Edad", 45));
        //                cmd.Parameters.Add(new SqlParameter("@Nombre", "Sin Transaccion"));
        //                cmd.ExecuteNonQuery();
        //            }
        //            var transaction = sql.BeginTransaction();

        //            using (SqlCommand cmd = new SqlCommand("sp_Persona_Agregar", sql, transaction))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.Add(new SqlParameter("@IdPais", IdPais));
        //                cmd.Parameters.Add(new SqlParameter("@Edad", 19));
        //                cmd.Parameters.Add(new SqlParameter("@Nombre", "Primero"));
        //                cmd.ExecuteNonQuery();
        //            }

        //            //throw new ApplicationException("ooop! Error!");

        //            using (SqlCommand cmd = new SqlCommand("sp_Persona_Agregar", sql, transaction))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.Add(new SqlParameter("@IdPais", IdPais));
        //                cmd.Parameters.Add(new SqlParameter("@Edad", 27));
        //                cmd.Parameters.Add(new SqlParameter("@Nombre", "Segundo"));
        //                cmd.ExecuteNonQuery();
        //            }

        //            //transaction.Rollback();
        //            transaction.Commit();
        //        }

        //    }
        //    catch (ApplicationException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }


        //    Console.Read();

        //}

        //private static DataTable ObtenerPersonas(int idPais)
        //{
        //    var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;

        //    using (SqlConnection sql = new SqlConnection(connectionString))
        //    {
        //        //using ( SqlCommand cmd = new SqlCommand(query, sql) )
        //        using (SqlCommand cmd = new SqlCommand("sp_Buscar_Persona_Por_Pais ", sql))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@IdPais", idPais));
        //            DataTable dt = new DataTable();
        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            sql.Open();
        //            da.Fill(dt);
        //            sql.Close();
        //            return dt;
        //        }
        //    }
        //}


        private enum Paises
        {
            Bolivia = 1,
            Peru = 2,
            Ecuador = 3,
            Mexico = 4,
            Francia = 5
        }
    
    }

    
}
