using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PruebaAppConfig
{
    class Program
    {

        static void Main(String[] args)
        {

            var circinferencia = new Circunferencia();
            var cuadrado = new Rectagulo();
            var cir2 = new Circunferencia();

            // antes
            var ci3 = cir2 as Circunferencia;
            if (cir2 != null)
            {
                cir2.Altura = 4;
            }
            
            // ahora
            // Si c2 es una isntancia de Circinferencia entonces guardala en la variable cirtemporaal
            //if(c2 is Circunferencia cirtemporal)
            //{
            //    cirtemporal.Radio = 4;
            //}


            // con swich

            //switch (cuadrado)
            //{ 
            //    case Triangulo t:
            //        break;
            //        Console.WriteLine("Es un trianguloa");
            //    case Rectagulo r when r.Anchura == r.Altura:
            //        Console.WriteLine("Es un rectangulo");
            //        break;
            //    case Circunferencia c:
            //        Console.WriteLine("Es una circunferencia");    
            //        break;
            //    default:
            //        break;
            //}
        }

       
    }

    class Base
    {
        public float Anchura { get; set; }
        public float Altura{ get; set; }

    }

    class Rectagulo : Base
    { 
    
    }

    class Triangulo: Base
    {

    }

    class Circunferencia : Base
    {

    }


}
