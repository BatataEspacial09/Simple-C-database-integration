using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_WF_TrabalhoFinal
{
    internal class Aluno
    {
        private string nome;
        private string matricula;
        private string cpf;

        public Aluno (string nome, string matricula, string cpf)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.cpf = cpf;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
