using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_explorando.Models
{
    public class Curso
    {
        // Propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        // métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine("Alunos matriculados no curso");
            foreach(Pessoa aluno in Alunos)
            {
                Console.WriteLine($"Aluno(a): {aluno.NomeCompleto}");
            }
        }
    }
}