

//DEU TUDO ERRAO ;-;
/* Está dificil de ler.
 * O console está embaralhando as informações dadas no "Console.WriteLine();".
 * entrega´parcial: 08/04/22
 */

using LISTA8.src;
using System;

namespace LISTA8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Infos:
            Console.WriteLine("Meus 4 artistas preferidos:");
            Artist Jimi = new Artist ("Jimi Hendrix", "Preto", "1.88", "27 (falecido)");
            Artist BBKing = new Artist("BB. King", "Preto", "1.77", "90 (faleceu)");
            Artist Asato = new Artist("Mateus Asato", "Branco", "Unknown", "25");
            Artist Gales = new Artist("Erick Gales", "Preto", "Unknown", "47");

            //Infos que vão sair no console:

            //Jimi
            Console.WriteLine($"Nome: {Jimi.nameArtist}, cor da pele: {Jimi.skinColor}, altura: {Jimi.heightArtist}, idade: {Jimi.ageArtist}");

            //BBKing
            Console.WriteLine($"Nome: {BBKing.nameArtist}, cor da pele: {BBKing.skinColor}, altura: {BBKing.heightArtist}, idade: {BBKing.ageArtist}");

            //Asato              
            Console.WriteLine($"Nome: {Asato.nameArtist}, cor da pele: {Asato.skinColor}, altura: {Asato.heightArtist}, idade: {Asato.ageArtist}");

            //Gales
            Console.WriteLine($"Nome: {Gales.nameArtist}, cor da pele: {Gales.skinColor}, altura: {Gales.heightArtist}, idade: {Gales.ageArtist}");

            


        }
    }
}
