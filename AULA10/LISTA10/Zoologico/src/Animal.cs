using System;
namespace Zoologico.src
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Classificacao { get; set; }

        public Animal() {}

        public Animal(string nome, string cor, string classificacao)
        {
            Nome = nome;
            Cor = cor;
            Classificacao = classificacao;
        }

        public virtual void Comunicar(string comunicacao) //virtual permite que o metodo possa utilizar ou implementar algo a um metodo existente
        {
            Console.WriteLine($"{Nome} está falando: {comunicacao}");
        }
    }
}