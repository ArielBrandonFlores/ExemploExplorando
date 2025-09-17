# Exemplo de Uso de Filas, Pilhas e Dicionários em C#

Este repositório contém exemplos práticos de como utilizar filas, pilhas e dicionários em C#. O código demonstra a criação, manipulação e operações básicas dessas estruturas de dados, que são fundamentais em programação.

## Estruturas de Dados Utilizadas

### 1. Filas (Queue)

- **Descrição**: As filas são estruturas de dados do tipo FIFO (First In, First Out). O primeiro elemento adicionado é o primeiro a ser removido.
- **Uso**: Utilizadas em situações como gerenciamento de tarefas, filas de atendimento, e processamento de eventos.

### 2. Pilhas (Stack)

- **Descrição**: As pilhas são estruturas de dados do tipo LIFO (Last In, First Out). O último elemento adicionado é o primeiro a ser removido.
- **Uso**: Comuns em operações de desfazer ações, controle de chamadas de funções, e algoritmos de backtracking.

### 3. Dicionários (Dictionary)

- **Descrição**: Os dicionários armazenam pares chave-valor, onde cada chave é única e usada para acessar o valor correspondente.
- **Uso**: Úteis para armazenar dados associados, como uma tabela de consulta, configuração de parâmetros, ou mapeamento de dados.

## Código

### Exemplo de Uso

O código a seguir ilustra como cada uma dessas estruturas pode ser utilizada:

```csharp
// Exemplo de uso de filas
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
Console.WriteLine("Elementos da fila:");
foreach (var item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o primeiro elemento da fila: {fila.Dequeue()}");
fila.Enqueue(10);
Console.WriteLine("Elementos da fila após remoção e adição:");
foreach (var item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"O próximo elemento a ser removido é: {fila.Peek()}");

// Exemplo de uso de pilhas
Stack<int> pilha = new Stack<int>();
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
Console.WriteLine("Elementos da pilha:");
foreach (var item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Removendo o topo da pilha: {pilha.Pop()}");
pilha.Push(10);
Console.WriteLine("Elementos da pilha após remoção e adição:");
foreach (var item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"O próximo elemento a ser removido é: {pilha.Peek()}");

// Exemplo de uso de dicionários
Dictionary<string, string> dicionario = new Dictionary<string, string>();
dicionario.Add("br", "Brasil");
dicionario.Add("us", "Estados Unidos");
dicionario.Add("fr", "França");
dicionario.Add("ar", "Argentina");
Console.WriteLine("Elementos do dicionário:");
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
dicionario.Remove("ar");
dicionario.Add("uk", "Reino Unido");
Console.WriteLine("Elementos do dicionário após remoção e adição:");
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine($"O valor associado à chave 'us' é: {dicionario["us"]}");

