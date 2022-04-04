using System;

namespace IMC
{
    internal class IMClesson
    {
        static void Main(string[] args)
        {
            float altura, peso, imc;

            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá" + nome + ". Agora me diga sua altura por favor: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Perfeito. Agora me diga seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + imc);
        
        }
    }
}
