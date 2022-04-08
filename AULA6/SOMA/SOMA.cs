using System;

namespace SOMA060422
{
    class SOMAEX1
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Insira o {i}° valor que deseja somar: ");
                soma += int.Parse(Console.ReadLine());
            }
            //Equivalente à função print do python.
            Console.WriteLine($"Valor da soma: {soma}");
        }
    }
}
