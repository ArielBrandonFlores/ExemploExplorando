# Exemplo de Uso de Tuplas, Operador Ternário e Desconstrução em C#

Este repositório demonstra, de forma prática e objetiva, conceitos modernos da linguagem C#, como tuplas, operador ternário e desconstrução. O projeto foi desenvolvido com foco em clareza e boas práticas, sendo ideal para quem deseja entender e aplicar esses recursos no dia a dia profissional.

## Principais Conceitos Demonstrados

### 1. Tuplas

- **O que são?**  
    Tuplas permitem agrupar múltiplos valores de tipos diferentes em uma única variável, facilitando o retorno de múltiplos dados sem criar estruturas adicionais.

- **Exemplo:**
    ```csharp
    (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Ariel", "Brandon", 1.64m);
    Console.WriteLine($"Id : {tupla.Id}");
    Console.WriteLine($"Nome : {tupla.Nome}");
    Console.WriteLine($"Sobrenome : {tupla.Sobrenome}");
    Console.WriteLine($"Altura : {tupla.Altura}");
    ```

### 2. Operador Ternário

- **O que é?**  
    O operador ternário simplifica estruturas condicionais, tornando o código mais enxuto e legível.

- **Exemplo:**
    ```csharp
    int numero = 10;
    bool par = numero % 2 == 0;
    Console.WriteLine($"O número {numero} é " + (par ? "Par" : "Ímpar"));
    ```

### 3. Desconstrução de Tuplas

- **O que é?**  
    Permite extrair valores de uma tupla diretamente em variáveis separadas, tornando o código mais limpo e intuitivo.

- **Exemplo:**
    ```csharp
    Pessoa pessoa = new Pessoa("Ariel", "Brandon");
    (string nome, string sobrenome) = pessoa;
    Console.WriteLine($"Nome: {nome} Sobrenome: {sobrenome}");
    ```

## Código Completo de Demonstração

```csharp
using ExemploExplorando.models;
using ExemploExplorando.Models;

Console.WriteLine("Exemplo de Tuplas");
(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Ariel", "Brandon", 1.64m);
Console.WriteLine($"Id : {tupla.Id}");
Console.WriteLine($"Nome : {tupla.Nome}");
Console.WriteLine($"Sobrenome : {tupla.Sobrenome}");
Console.WriteLine($"Altura : {tupla.Altura}");
Console.WriteLine("------------------------------------------------------------------");

Console.WriteLine("Exemplo de um método que retorna uma Tupla");
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");
if (sucesso)
{
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
Console.WriteLine($"O número {numero} é " + (par ? "Par" : "Ímpar"));
```