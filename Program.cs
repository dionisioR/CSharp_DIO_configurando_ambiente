using CSharp_DIO_configurando_ambiente.Models;

string apresentacao = "Um exeplo de string!!!";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

// Data
DateTime dataAtual = DateTime.Now;
DateTime dataAdd5Days = dataAtual.AddDays(5);


Console.WriteLine( "Apresentação: " + apresentacao);
Console.WriteLine( "Quantidade: " + quantidade);
Console.WriteLine( "Altura: " + altura);
Console.WriteLine( "Preço: " + preco);
Console.WriteLine( "Condição: " + condicao);
Console.WriteLine( "Data Atual: " + dataAtual);
Console.WriteLine( "Data +5 dias: " + dataAdd5Days);
Console.WriteLine( "Data +5 dias: " + dataAdd5Days.ToString("dd/MM/yyyy"));
Console.WriteLine( "Data +5 dias: " + dataAdd5Days.ToString("dd/MM/yyyy HH:mm"));



// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("C#");

// Pessoa p = new Pessoa();
// p.Nome = "João";
// p.Idade = 30;
// p.Apresentar();
