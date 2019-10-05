using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contador
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador,n1;

            Console.Write("Digite o numero");
            n1 = int.Parse(Console.ReadLine());
            contador = 1;

            while (contador <= 100)
               
           
            Console.WriteLine("Contador:" + contador);
            contador = contador  + 1;

            n1 = contador + n1;
            
            Console.ReadKey();


        }
    }
}
