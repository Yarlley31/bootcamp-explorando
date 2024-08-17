using bootcamp_explorando.Models;

//jeito mais limpo de codar 
Pessoa p1 = new Pessoa(nome: "Yarlley", sobrenome: "Fernandes");
Pessoa p2 = new Pessoa(nome: "Marcos", sobrenome: "Matos");
Pessoa p3 = new Pessoa(nome: "Danielle", sobrenome: "Oliveira");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Busuu";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();



// p1.Nome = "Yarlley";
// p1.Sobrenome = "Fernandes";
// p1.Idade = 7;
// p1.Apresentar();
