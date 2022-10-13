using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>()
        {
            3, 5 ,7, 8, 0, -2, -43, 5, 12, 120, 220
        };

        List<Persona> personas = new List<Persona>()
        {
            new Persona() {Nombre="Jose", Edad=99, Salario=435},
            new Persona() {Nombre="Luis", Edad=12, Salario=200},
            new Persona() {Nombre="Pedrio", Edad=9, Salario=100},
            new Persona() {Nombre="Tamal", Edad=21, Salario=67547},
            new Persona() {Nombre="Lu", Edad=45, Salario=372},
            new Persona() {Nombre="Ser", Edad=27, Salario=8564}
        };


        var result = numeros.Where(x => x > 0).ToList();
        var indicesPares = numeros.Where((x, indice) => indice % 2 == 0).ToList();
            
        // Invierte el orden de la lista, se puede tambien tomar ciertos rangos de elementos a aplicar, 1 parametro, indice de donde empezara, 2do parametro, apartir del 1er parametro cuanto tomara para revertir
        numeros.Reverse(3, 4);
            
        // trae 1er elemento de la lista, que cumpla con el delegado, sino ninguno cumple lanza una exception
        var primerElemento = numeros.First( x => x > 100 );
        // trae 1er elemento de la lista, si esta vacia lanza una exception
        var primerElementoMayorQue100 = numeros.First();


        // trae 1er elemento de la lista, si esta vacia retorna el valor por defecto que maneja su tpo de dato
        var primerElementoPorDefento = numeros.FirstOrDefault();
        // trae 1er elemento de la lista, si nose cumple la condicion retorna el valor por defecto que maneja su tpo de dato
        var primerElementoPorDefectoMayorque100 = numeros.FirstOrDefault(x => x > 100);

        // ordnena de forma ascendente por nombre y luego por Salario
        var listPersonasOrdenadasPorNombreySalario = personas.OrderByDescending(x => x.Nombre).ThenBy(x => x.Salario).ToList();

        // Primer elemento que edad < 18 y solo traeme los campos edad y nombre en un objeto anonimo
        var peimerSoloNombreEdadDePersonaMenor = personas.Where(x => x.Edad < 18).Select(x =>
            new 
            {
                Edad = x.Edad,
                Nombre = x.Edad
            }).FirstOrDefault();
            
        // toma elementos > 0, se salta 2 posiciones y desde ahi solo toma los primeros 3 elementos
        var filtroTomade2Elementos = numeros.Where(x => x > 0).Skip(2).Take(3).ToList();

        // Toma elementos mientras la condicion sea cierta, una vez que no se cumple deja te tomar
        var listado = numeros.TakeWhile(x => x < 30);

        // todo lo contrario a TakeWhile, mientras se cumpla la condicon no los toma en cuenta, una vez que se rompe la considicion, toma los restates
        var listado2 = numeros.SkipWhile(x => x < 30);


        Console.Read();


    }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
    }
}
