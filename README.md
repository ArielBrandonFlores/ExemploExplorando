# 📦 Projeto de Serialização e Desserialização em C#

Este projeto foi desenvolvido como parte do meu aprendizado em **C#**, com foco na **serialização e desserialização de objetos utilizando JSON**, por meio da biblioteca **Newtonsoft.Json**. O objetivo principal foi entender como converter objetos C# para JSON e vice-versa, permitindo persistência e troca de dados de maneira eficiente.

## 🛠️ Tecnologias Utilizadas

- **C#** – Linguagem de programação utilizada no projeto.
- **.NET** – Plataforma de desenvolvimento.
- **[Newtonsoft.Json](https://www.newtonsoft.com/json)** – Biblioteca para manipulação de dados em formato JSON.

## ✅ Funcionalidades Implementadas

### 🔹 1. Definição da Classe `Venda`
A classe `Venda` representa uma venda de produto e possui as seguintes propriedades:

- `Id` (int): Identificador único da venda.
- `Produto` (string): Nome do produto vendido.
- `Preco` (decimal): Preço do produto.
- `DataVenda` (DateTime): Data da venda.


### 🔹 2. Serialização
- Criação de uma lista de objetos `Venda`.
- Conversão dessa lista para uma string JSON formatada utilizando `JsonConvert.SerializeObject`.
- Armazenamento do JSON gerado em um arquivo: `Arquivo/listaVendas.json`.


### 🔹 3. Desserialização
- Leitura do arquivo `listaVendas.json`.
- Conversão do conteúdo JSON de volta para uma lista de objetos `Venda` com `JsonConvert.DeserializeObject`.
- Impressão das informações das vendas desserializadas no console para validação.


## 💻 Exemplo de Código

### Classe `Venda`
```csharp
namespace ExemploExplorando.models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
````

### Uso no Programa Principal

```csharp
Console.WriteLine("Exercício de serialização e desserialização em C# com JSON usando Newtonsoft.Json\n");

DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new List<Venda>
{
    new Venda(1, "Notebook", 3500.00m, dataAtual),
    new Venda(2, "Smartphone", 2500.00m, dataAtual),
    new Venda(3, "Tablet", 1500.00m, dataAtual),
    new Venda(4, "Monitor", 1200.00m, dataAtual),
    new Venda(5, "Teclado", 200.00m, dataAtual),
    new Venda(6, "Mouse", 100.00m, dataAtual)
};

// Exibe a lista original
foreach (var venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, Preço: {venda.Preco}, Data: {venda.DataVenda}");
}

// Serializa e salva em arquivo
string serializadoLista = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivo/listaVendas.json", serializadoLista);
Console.WriteLine("\nSerialização concluída!");

// Lê e desserializa o arquivo
string jsonString = File.ReadAllText("Arquivo/listaVendas.json");
List<Venda> desserializadoLista = JsonConvert.DeserializeObject<List<Venda>>(jsonString);

// Exibe os dados desserializados
foreach (var vendaDesserializada in desserializadoLista)
{
    Console.WriteLine($"Id: {vendaDesserializada.Id}, Produto: {vendaDesserializada.Produto}, Preço: {vendaDesserializada.Preco}, Data: {vendaDesserializada.DataVenda}");
}

Console.WriteLine($"\n{desserializadoLista.Count} vendas desserializadas com sucesso!");
```