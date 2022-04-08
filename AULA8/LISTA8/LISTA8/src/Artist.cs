using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA8.src
{
    internal class Artist
    {
        public string nameArtist { get; set; }
        public string heightArtist { get; set; }
        public string skinColor { get; set; }

        public string ageArtist { get; set; }

        public Artist(string _name, string _height, string _skin, string _age)
        {
            nameArtist = _name;
            heightArtist = _height;
            skinColor = _skin;
            ageArtist = _age;
        }
        public void tocar(string tocandoGuitarra)
        {
            Console.WriteLine("uéu uéu uéu- bululululu_ wiooooonnn *sons de guitarra *");
        }
        public void queimando(string queimandoGuitarra)
        {
            Console.WriteLine("*porque fizestes isso Jimi? ;-; ");
        }
    }
}
