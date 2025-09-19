using ExemploExplorando.models;
using ExemploExplorando.Models;

Console.WriteLine("Exemplo de Tuplas");
(int Id, string Nome, string Sobrenome, decimal Altura) tuopla = (1, "Ariel", "Brandon", 1.64m);

// ValueTuple<int, string, string, decimal> segundaTupla = (1, "Ariel", "Brandon", 1.64m);
// var terceiraTupla = Tuple.Create(1, "Ariel", "Brandon", 1.64m);

Console.WriteLine($"Id : {tuopla.Id}");
Console.WriteLine($"Nome : {tuopla.Nome}");
Console.WriteLine($"Sobrenome : {tuopla.Sobrenome}");
Console.WriteLine($"Altura : {tuopla.Altura}");
Console.WriteLine("------------------------------------------------------------------");

Console.WriteLine("Exemplo de um método que retorna uma Tupla");
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");
if (sucesso)
{
    // Console.WriteLine($"Quantidade de linhas do arquivo: {quantidade}");
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("Exemplo de Deconstruct com tuplas");

Pessoa pessoa = new Pessoa("Ariel", "Brandon");
(string nome, string sobrenome) = pessoa;

Console.WriteLine($"Nome: {nome} Sobrenome: {sobrenome}");
Console.WriteLine("------------------------------------------------------------------");
Console.WriteLine("Exemplo de if simplificado com operador ternário");
int numero = 10;
bool par = numero % 2 == 0;

Console.WriteLine($"O numero {numero} é" + (par ? "Par" : "Impar"));

if (numero % 2 == 0)
{
    Console.WriteLine($"Número par: {numero}");
}
else
{
    Console.WriteLine($"Número ímpar: {numero}");
}
