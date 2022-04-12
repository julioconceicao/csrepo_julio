using System;
using CalcArea.src;

namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Medida dos lados do quadrado: ");
            double ladoQuadrado = double.Parse(Console.ReadLine());
            Quadrado quadrado = new Quadrado("quadrado", ladoQuadrado, ladoQuadrado);
            Console.WriteLine($"A base do {quadrado.Nome} é {quadrado.Base} e a altura é {quadrado.Altura}\nA area é {quadrado.CalcularArea()}");

            Console.WriteLine("Base do retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura do retângulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine());
            Retangulo retangulo = new Retangulo("retangulo", baseRetangulo, alturaRetangulo);
            Console.WriteLine($"A base do {retangulo.Nome} é {retangulo.Base} e a altura é {retangulo.Altura}\nA area é {retangulo.CalcularArea()}");

            Console.WriteLine("Base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            Triangulo triangulo = new Triangulo("triangulo", baseTriangulo, alturaTriangulo);
            Console.WriteLine($"A base do {triangulo.Nome} é {triangulo.Base} e a altura é {triangulo.Altura}\nA area é {triangulo.CalcularArea()}");
        }
    }
}