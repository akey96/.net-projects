using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class DataTablesADO
    {
        //static void Main(string[] args)
        //{

        //    var miDataTable = new DataTable();

        //    // Agregamos dos columnas
        //    miDataTable.Columns.Add("Nombre", typeof(string));
        //    miDataTable.Columns.Add("Edad", typeof(int));

        //    // Agrega una fila
        //    miDataTable.Rows.Add(new Object[] {"Felipe", 999});

        //    // Leer una fila
        //    var nombre = miDataTable.Rows[0]["Nombre"];

        //    // Bortra la data del datatable
        //    miDataTable.Clear();

        //    var dtPersonas = ObtenerPersonas(1);

        //    // Iterar un DataTable
        //    foreach (DataRow drow in dtPersonas.Rows)
        //    {
        //        Console.WriteLine(drow["Nombre"]);
        //    }

        //    // Filtrando las filas del DataTable
        //    var filas = dtPersonas.Select("Id=1");

        //    // Sumando elelmentos en una columnas
        //    var resultado = dtPersonas.Compute("Sum(edad)", "");

        //    Console.Read();

        //}

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
