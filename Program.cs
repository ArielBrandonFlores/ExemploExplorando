using ExemploExplorando.models; // Importa o namespace que contém as classe ExemploExcecoesThrow

Console.WriteLine("Tratamento de exceções - Bloco try catch finally"); 

try
{
    // Tenta ler todas as linhas de um arquivo de texto especificado. Armazendo as linhas em um array de strings.
    string[] linhas = File.ReadAllLines("Arquivo/arquivoLeitura.txt");

    // Itera sobre cada linha lida do arquivo.
    foreach (var linha in linhas)
    {
        // Exibe cada linha no console.
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    // Captura e trata a exceção se o arquivo não for encontrado.
    Console.WriteLine($"Ocorreu um erro: Arquivo não encontrado. Detalhes: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    // Captura e trata a exceção se o diretório do arquivo não for encontrado.
    Console.WriteLine($"Ocorreu um erro: Diretório não encontrado. Detalhes: {ex.Message}");
}
catch (Exception ex)
{
    // Captura e trata qualquer outra exceção genérica que possa ocorrer.
    Console.WriteLine($"Ocorreu um erro: Erro genérico. Detalhes: {ex.Message}");
}
finally
{
    // Este bloco é executado sempre, independentemente de uma exceção ter ocorrido ou não.
    Console.WriteLine("Terminou a leitura do arquivo"); 
    Console.WriteLine("-------------------------------");
}

// Mensagem indicando que o próximo teste de exceções será realizado.
Console.WriteLine("Testando tratamento de exceções com throw em vários métodos até tratar a exceção");

// Cria uma nova instância da classe ExemploExcecoesThrow e chama o método1.
new ExemploExcecoesThrow().metodo1();

Console.WriteLine("-------------------------------");
