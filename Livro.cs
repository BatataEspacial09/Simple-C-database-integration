using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_WF_TrabalhoFinal
{
    internal class Livro
    {
        private string nome;
        private string autor;
        private string ano;

        public Livro (string nome, string autor, string ano)
        {
            this.nome = nome;
            this.autor = autor;
            this.ano = ano;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Ano { get => ano; set => ano = value; }
    }
}
