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
            
            for(int count = 0; count < Alunos.Count; count++)
            {
                //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"N° {count+1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}