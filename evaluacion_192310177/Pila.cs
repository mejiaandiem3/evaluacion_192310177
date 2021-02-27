using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_192310177
{
    class Pila
    {
      
       //se declara el numero de elementos para declarar un arreglo que se llama pilas
       const int numeroElementos = 10;
       private int[] pila = new int[numeroElementos];

        //declaracion de variables
        int maximoPila = numeroElementos - 1;
        int Tope;

        bool ValidacionLleno()
        {
            //aqui valido que la pila no este llena para poder seguir insertando elementos
            if(Tope == maximoPila)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void insertarPila(int dato)
        {


            if (ValidacionLleno())
            {
                //tope va sumando una posicion cada que se inserta un dato a la pila
                Tope++;
                pila[Tope] = dato;
            }

            else
            {
                //se muestra un mensaje de que la pila esta llena
                Console.WriteLine("La pila esta llena");
            }


        }

      

        public void mostrarElemento ()
        {
            Console.WriteLine("El elemento {0} en la pila es: {1}", Tope, pila[Tope]);
            Tope--;
        }








    }
}
