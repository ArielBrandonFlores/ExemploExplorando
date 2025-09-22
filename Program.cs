using ExemploExplorando.models;
using Newtonsoft.Json;

Console.WriteLine("Fazendo exercicios de serialização e desserialização de objetos em C#\n com JSON usando a biblioteca Newtonsoft.Json\n");
Console.WriteLine("Criando uma lista de vendas para serem Serializadas\n");

// Obtém a data e hora atual.
DateTime dataAtual = DateTime.Now;

// Cria uma lista para armazenar as vendas.
List<Venda> listaVendas = new List<Venda>();

// Cria instâncias da classe Venda com dados de exemplo.
Venda venda1 = new Venda(1, "Notebook", 3500.00m, dataAtual);
Venda venda2 = new Venda(2, "Smartphone", 2500.00m, dataAtual);
Venda venda3 = new Venda(3, "Tablet", 1500.00m, dataAtual);
Venda venda4 = new Venda(4, "Monitor", 1200.00m, dataAtual);
Venda venda5 = new Venda(5, "Teclado", 200.00m, dataAtual);
Venda venda6 = new Venda(6, "Mouse", 100.00m, dataAtual);

// Adiciona as vendas à lista.
listaVendas.Add(venda1);
listaVendas.Add(venda2);
listaVendas.Add(venda3);
listaVendas.Add(venda4);
listaVendas.Add(venda5);
listaVendas.Add(venda6);

// Exibe os detalhes de cada venda no console.
foreach (var venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}  Data da Venda: {venda.DataVenda}");
}


Console.WriteLine("\nSerializando o objeto listaVendas para JSON\n");

// Serializa a lista de vendas em uma string JSON formatada.
string serializadoLista = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Salva a string JSON em um arquivo chamado listaVendas.json na pasta "Arquivo".
File.WriteAllText("Arquivo/listaVendas.json", serializadoLista);

// Exibe a string JSON resultante no console.
Console.WriteLine(serializadoLista);


Console.WriteLine("Desserializando o JSON para a lista de vendas\n");

// Lê o conteúdo do arquivo JSON e armazena em uma string.
string jsonString = File.ReadAllText("Arquivo/listaVendas.json");

// Desserializa a string JSON de volta para uma lista de objetos Venda.
List<Venda> desserializadoLista = JsonConvert.DeserializeObject<List<Venda>>(jsonString);

// Exibe os detalhes de cada venda desserializada no console.
foreach (var vendaDesserializada in desserializadoLista)
{
    Console.WriteLine($"Id: {vendaDesserializada.Id}, Produto: {vendaDesserializada.Produto}, Preço: {vendaDesserializada.Preco} Data da Venda: {vendaDesserializada.DataVenda}");
}

// Informa quantas vendas foram desserializadas com sucesso.
Console.WriteLine($"{desserializadoLista.Count} vendas desserializadas com sucesso!");