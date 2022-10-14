using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class TimeoutADO
    {

        static void Main(String[] args)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;

            try
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    //using ( SqlCommand cmd = new SqlCommand(query, sql) )
                    using (SqlCommand cmd = new SqlCommand("sp_Buscar_Persona_Por_Pais ", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        sql.Open();

                        cmd.CommandTimeout = 3;     // Esperao hasta 3seg para hacer la cosulta    
                        //cmd.CommandType = 0;      // Espera tiempo indefinido para que haga la consulta


                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

       
    }
}
