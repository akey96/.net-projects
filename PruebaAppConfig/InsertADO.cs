using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class InsertADO
    {
        //static void Main(string[] args)
        //{


        //    var connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;

        //    var idPais = (int)Paises.Bolivia;


        //    using (SqlConnection sql = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("sp_Persona_Agregar ", sql))
        //        {
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@IdPais", idPais));
        //            cmd.Parameters.Add(new SqlParameter("@Edad", 46));
        //            cmd.Parameters.Add(new SqlParameter("@Nombre", "Patricio"));

        //            sql.Open();
        //            cmd.ExecuteNonQuery();
        //            sql.Close();
        //        }


        //    }

        //    Console.Read();
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
