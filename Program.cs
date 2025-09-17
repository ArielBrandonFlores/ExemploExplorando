
Console.WriteLine("Utilizando filas na pratica ");
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
Console.WriteLine("Adicionando o elemento 10 na fila");
fila.Enqueue(10);
Console.WriteLine("Elementos da fila após remoção e adição:");

foreach (var item in fila)
{
    Console.WriteLine(item);
}
Console.WriteLine($"O próximo elemento a ser removido é: {fila.Peek()}");
Console.WriteLine("-------------------------------");

Console.WriteLine("Utilizando pilhas na pratica ");
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
Console.WriteLine("Adicionando o elemento 10 na pilha");
pilha.Push(10);
Console.WriteLine("Elementos da pilha após remoção e adição:");
foreach (var item in pilha)
{
    Console.WriteLine(item);
}
Console.WriteLine($"O próximo elemento a ser removido é: {pilha.Peek()}");
Console.WriteLine("-------------------------------");
Console.WriteLine("Utilizando dicionários na pratica ");
Dictionary<string, string> dicionario = new Dictionary<string, string>();
dicionario.Add(key: "br", value: "Brasil");
dicionario.Add("us", "Estados Unidos");
dicionario.Add("fr", "França");
dicionario.Add("ar", "Argentina");
Console.WriteLine("Elementos do dicionário:");
foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("Removendo o elemento com chave 'ar'");
dicionario.Remove("ar");
Console.WriteLine("Adicionando o elemento com chave 'uk' e valor 'Reino Unido'");
dicionario.Add("uk", "Reino Unido");
Console.WriteLine("Elementos do dicionário após remoção e adição:");

foreach (var item in dicionario)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
Console.WriteLine($"O valor associado à chave 'us' é: {dicionario["us"]}");
Console.WriteLine("-------------------------------");

