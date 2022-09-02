using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIntroducaoPilha
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { get; set; }

        public Livro (string titulo, int iSBN, string autor)
        {
            Titulo = titulo;
            ISBN = iSBN;
            Autor = autor;
            Anterior = null;
        }

        public override string ToString()
        {
            return "\nDADOS DO LIVRO:\nTítulo: " + Titulo + "\nAutor:" + Autor + "\nISBN: " + ISBN;
        }


    }
}
