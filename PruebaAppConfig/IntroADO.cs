using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class IntroADO
    {
//        static void Main(string[] args)
//        {
//            var mensaje = ConfigurationManager.AppSettings["mensaje"];

//            Console.WriteLine(mensaje);

//            //var builder = new SqlConnectionStringBuilder();
//            //builder.DataSource = @"NTVDSD4CTQ\SQLEXPRESS";
//            //builder.InitialCatalog = "prueba";
//            //builder.IntegratedSecurity = true;
//            //builder.UserID = "sa";
//            //builder.Password = "Pepito1234";
//            //var connectionString = builder.ToString();

//            var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
//            //Console.WriteLine(connectionString);

//            var idPais = 1;

////            var query = @"select * 
////                        from Persona
////                        Where IdPais = @IdPais";

//            using ( SqlConnection sql = new SqlConnection(connectionString))
//            {
//                //using ( SqlCommand cmd = new SqlCommand(query, sql) )
//                using (SqlCommand cmd = new SqlCommand("sp_Buscar_Persona_Por_Pais ", sql))
//                {
//                    cmd.CommandType = CommandType.StoredProcedure;
//                    cmd.Parameters.Add(new SqlParameter("@IdPais", idPais));
//                    DataTable dt = new DataTable();
//                    SqlDataAdapter da = new SqlDataAdapter(cmd);
//                    sql.Open();
//                    da.Fill(dt);
//                    sql.Close();
//                }
                
                
//            }

//            Console.Read();
//        }
    }
}
