using System;

namespace AULA8A.src

{
    public class Gato
    {
        public string nomeGato { get; set; }
        public string corGato { get; set; }
        public int tamanhoGato { get; set; }

        public Gato()
        {

        }

        public Gato(string _nome, string _cor, int _tamanho)
        {
            nomeGato = _nome;
            corGato = _cor;
            tamanhoGato = _tamanho;
        }

        //Ações

        public void dormir()
        {
            Console.WriteLine("ZzZzzzZz..");
        }

        public void comer(string comida)
        {
            Console.WriteLine($"Estou comendo {comida}");
        }

        public void ronronar(string ronronando)
        {
            Console.WriteLine($"{ronronando}...");
        }

    }
}