using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class DataSetADO
    {

        static void Main(String[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                //using ( SqlCommand cmd = new SqlCommand(query, sql) )
                using (SqlCommand cmd = new SqlCommand("sp_Cargar_Info_Tablas ", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    sql.Open();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    
                    da.Fill(ds);
                    sql.Close();
                }
            }
            
        }

        private static DataTable ObtenerPersonas(int idPais)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                //using ( SqlCommand cmd = new SqlCommand(query, sql) )
                using (SqlCommand cmd = new SqlCommand("sp_Buscar_Persona_Por_Pais ", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@IdPais", idPais));
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    sql.Open();
                    da.Fill(dt);
                    sql.Close();
                    return dt;
                }
            }
        }


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
