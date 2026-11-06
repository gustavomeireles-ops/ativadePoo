using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atividadePoo
{
    public class Livro
    {
        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public int numeroPaginas { get; set; }

        public Livro()
        {
            Titulo = "João e pé de feijão";
            Autor = "Carlos Drummond de Andrade";
            numeroPaginas = 250;
        }
        
        public Livro(string? titulo)
        {
            Titulo = "João e pé de feijão";
        }

        public Livro(string? titulo, string? autor)
        {
            Titulo = "João e pé de feijão";
            Autor = "Carlos Drummond de Andrade";
        }
        public Livro(string? titulo, string? autor, int numeroPaginas)
        {
            Titulo = "João e pé de feijão";
            Autor = "Carlos Drummond de Andrade";
            this.numeroPaginas = 250;
        }

        public void exibirInfo()
        {
            Console.WriteLine($"O título do livro é {Titulo}, seu autor é {Autor} e ele possui {numeroPaginas} páginas.");
        }
    }
}