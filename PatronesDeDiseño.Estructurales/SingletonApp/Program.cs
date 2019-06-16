using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton obj1 = new Singleton();
            Singleton obj1 = Singleton.GetInstancia();
            Singleton obj2 = Singleton.GetInstancia();

            //validar si obj1 y obj2 son la misma instancia
            if(obj1 == obj2)
            {
                Console.WriteLine("Misma instancia Singleton");
            }
            //validar si obj1 y obj2 son del mismo tipo
            if (obj1.GetType() == obj2.GetType())
            {
                Console.WriteLine("Mismo tipo Singleton");
            }

            //asignar un valor string a obj1
            obj1.Valor = "Valor ingresado a [obj1] de la instancia [Singleton]";
            //imprimir el valor string almacenado en obj1
            Console.WriteLine("valor de [obj1] = " + obj1.Valor);
            //asignar un valor string a obj2
            obj2.Valor = "Valor ingresado a [obj2] de la instancia [Singleton]";
            //imprimir el valor string almacenado en obj1
            Console.WriteLine("valor de [obj1] = " + obj1.Valor);

            Console.WriteLine("------------------------------");

            Otro o1 = new Otro();
            Otro o2 = new Otro();

            //validar si o1 y o2 son la misma instancia
            if (o1 == o2)
            {
                Console.WriteLine("Misma instancia Otro");
            }
            //validar si o1 y o2 son del mismo tipo
            if (o1.GetType() == o2.GetType())
            {
                Console.WriteLine("Mismo tipo Otro");
            }

            //asignar un valor string a o1
            o1.Valor = "Valor ingresado a [o1]";
            //imprimir el valor string almacenado en o1
            Console.WriteLine("valor de [o1] = " + o1.Valor);
            //asignar un valor string a o2
            o2.Valor = "Valor ingresado a [o2]";
            //imprimir el valor string almacenado en o1
            Console.WriteLine("valor de [o1] = " + o1.Valor);

            //asignar un valor string a ObjetoSingletonEnOtro del objeto o1
            o1.ObjetoSingletonEnOtro.Valor = "Valor ingresado a [ObjetoSingletonEnOtro] de la instancia [Singleton]";
            //imprimir el valor string almacenado en obj1
            Console.WriteLine("valor de [obj1] = " + obj1.Valor);

            Console.ReadLine();
        }
    }
}
