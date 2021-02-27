using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace evaluacion_192310177
{
    class Program
    {
        static void Main(string[] args)
        {
            // se declaran las variables
            int valor=1;
            int nCantidad = 0;
            string elemento;

            //se declara la pila
            Stack pila = new Stack();


            Console.WriteLine("**************************** PILA ****************************************");
            Console.WriteLine("--------------------------------------------------------------------------------------");

            //el usuario introduce cuantos elementos quiere que le pida para ingresar
            Console.WriteLine("Cuantos elementos quieres ingresar: ");
            nCantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------------------------");
            

            for (int i = 0; i < nCantidad; i++)
            {
                //ingresa el valor el usuario y con la propiedad push se inserta a la pila y esta dentro de un for para que suceda dicha insercion 
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el elemento {0}: " , valor++);
                elemento = Console.ReadLine();
                pila.Push(elemento);
            }

            //se muestra el contenido de la pila mediante un foreach 
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Mostrar pila");
            Console.WriteLine(" ");

            foreach (string var in pila)
            {
                Console.WriteLine(var);
            }

            //peek retorna el valor que esta al tope de la pila sin eliminarlo
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("El tope de la pila es: ");
            Console.WriteLine(" ");
            Console.WriteLine(pila.Peek());
            Console.WriteLine("--------------------------------------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
    

