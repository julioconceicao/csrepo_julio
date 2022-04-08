
using AULA8A.src;
using System;

namespace AULA8A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gatitos");
            Gato garfield = new Gato("Garfield", "laranja", 8);
            Gato thomas = new Gato("Thomas", "Cinza", 5);
            Gato frajola = new Gato("");

            Console.WriteLine($"Gato 1 é o {garfield.nomeGato} de cor {} e tem o tamanho {}");
        }
    }
}