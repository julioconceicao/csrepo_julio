using System;

namespace TABUADA
{
    class TABUADA
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuadinha <3");
            Console.WriteLine("Quer saber a tabuada de qual número? ");
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int resultado = (numero * x);
                Console.WriteLine($"{numero} * {x}  = {resultado}");
            }      
        }    
    }
}
