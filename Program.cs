using System;
using System.Collections.Generic;

namespace multiplos_de_3
{
    class Program
    {
        static void Main(string[] args)

        {
            List<int> listamultiplos = new List<int>();

            Console.WriteLine("Ingrese la cantidad de multiplos de 3 que desea ver");
            int numero = Int32.Parse(Console.ReadLine());

            for(int i = 0; listamultiplos.Count < numero; i++)
            {
                if (i%3==0 & i%5!=0)
                {
                    listamultiplos.Add(i);
                }

            }

             foreach(var z in listamultiplos) 
             { 
                Console.WriteLine(z); 
             }        
        }
    }
}
