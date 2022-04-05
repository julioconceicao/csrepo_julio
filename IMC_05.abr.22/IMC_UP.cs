using System;

namespace ProjVSC0504
{
    class Program
    {
        static void Main(string[] args)
        {

            float altura, peso, imc;
             
            Console.WriteLine("Roi, vem sempre aqui? Qual seu nome chuchu?");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + "!" + "Vamos calcular seu IMC! Se importa em me dizer: qual o seu peso? ");
            peso = float.Parse (Console.ReadLine());

            Console.WriteLine("Ok, e qual a sua altura em metros?");
            altura = float.Parse (Console.ReadLine());

           
            imc = peso / (altura * altura);
            if(imc < 18.5)
            {
                Console.WriteLine("Seu imc é: " + imc + ". " + "Abaixo do peso recomendado. ");
            }
            else if(imc <25)
            {
                Console.WriteLine("Seu imc é: " + imc + ". " + "Peso normal. ");
            }       
            else if(imc < 30)
            {
                Console.WriteLine("Seu imc é: " + imc + "." + "Sobrepeso. Projetinho fellas. ");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("Seu imc é: " + imc + ". " + "Obesidade. O importante é se amar <3");
            }

        }
    }
}
