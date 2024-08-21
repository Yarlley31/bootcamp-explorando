using bootcamp_explorando.Models;
using System.Data;
using System.Globalization;

string dataString = "2024-08-20 20:48";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd hh:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data);

Console.WriteLine(data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso: {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida");
}




// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-br");


// // esse "c" e "p" são pra representar cédula e porcentagem e outras coisas
// decimal valorMonetario = 1576.87M;

// Console.WriteLine(valorMonetario.ToString("c2"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("p"));

// // legal pra quando pedir para o usuario add um numero de telefone. 
// int numero = 123456;
// Console.WriteLine(numero.ToString("00-00-00"));



// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);



//jeito mais limpo de codar 
// Pessoa p1 = new Pessoa(nome: "Yarlley", sobrenome: "Fernandes");
// Pessoa p2 = new Pessoa(nome: "Marcos", sobrenome: "Matos");
// Pessoa p3 = new Pessoa(nome: "Danielle", sobrenome: "Oliveira");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Busuu";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ListarAlunos();



// p1.Nome = "Yarlley";
// p1.Sobrenome = "Fernandes";
// p1.Idade = 7;
// p1.Apresentar();
