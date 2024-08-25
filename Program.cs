using bootcamp_explorando.Models;
using System.Data;
using System.Globalization;
using System.Runtime.InteropServices;


int num = 19;
bool ehPar = false;

// if ternário
ehPar = num % 2 == 0;

Console.WriteLine($"O número {num} é " + (ehPar ? "par." : "impar."));


// if (num % 2 == 0)
// {
//     Console.WriteLine($"O número {num} é par");
// } else {
//     Console.WriteLine($"O número {num} é par");
// }









// Pessoa p1 = new Pessoa ("Yarlley", "Fernandes");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");







// LeituraArquivo arquivo = new();

// var (sucesso, linhasDoArquivo, _) = arquivo.LerArquivo("Arquivos/X-Files.txt");

// if(sucesso)
// {
//     //Console.WriteLine("Quantidades de linhas do aquivo " + quantidadeDeLinhas);
//     foreach(string linha in linhasDoArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// } else {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }



// (int ID, string Nome, string Sobrenome, decimal Altura) registro = (1, "Marcos", "Matos", 1.70M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Danielle", "Oliveira", 1.68M);

// var outroExemploTuplaCreate = Tuple.Create(1, "Yarlley", "Fernandes", 1.71M);

// Console.WriteLine($"ID: {registro.ID}");
// Console.WriteLine($"Nome: {registro.Nome}");
// Console.WriteLine($"Sobrenome: {registro.Sobrenome}");
// Console.WriteLine($"Altura: {registro.Altura}");

// Console.WriteLine("------------------------------");

// Console.WriteLine($"ID: {outroExemploTupla.Item1}");
// Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
// Console.WriteLine($"Altura: {outroExemploTupla.Item4}");

// Console.WriteLine("------------------------------");

// Console.WriteLine($"ID: {outroExemploTuplaCreate.Item1}");
// Console.WriteLine($"Nome: {outroExemploTuplaCreate.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemploTuplaCreate.Item3}");
// Console.WriteLine($"Altura: {outroExemploTuplaCreate.Item4}");




// Dictionary<string, string> estados = [];

// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// estados.Add("SP", "São Paulo");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------");

// estados.Remove("SP");
// estados["BA"] = "Bahia, melhor estado do Brasil";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }






// // jeito mais curto de usar o new
// Stack<int> pilha = new();

// // adicionando na pilha
// pilha.Push(3);
// pilha.Push(5);
// pilha.Push(7);
// pilha.Push(9);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// // removendo da pilha
// Console.WriteLine($"Removido o item do topo: {pilha.Pop()}");

// pilha.push

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }


// // FIFO first in first out
// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }



// new ExemploExcexao().Metodo1();


// try {
//     string[] linhas = File.ReadAllLines("Arquivos/X-Files.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha); 
//     }
// } catch(FileNotFoundException exceção)
// {
//     Console.WriteLine($"Ocorreu um erro ao ler o arquivo. Arquivo não encontrado: {exceção.Message}");
// } 
// catch(Exception ex)
// {
//     //achei esse jeito melhor
//     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }






// string dataString = "2024-08-20 20:48";

// bool sucesso = DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd hh:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// Console.WriteLine(data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso: {data}");
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida");
// }




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
