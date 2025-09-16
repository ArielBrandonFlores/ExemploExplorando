# Projeto de Tratamento de Exceções em C#

Este projeto tem como objetivo demonstrar o tratamento de exceções em C# utilizando as estruturas `try`, `catch` e `finally`. O código foi desenvolvido como parte de um exercício prático para explorar o funcionamento das exceções e como propagá-las através de métodos.

## Estrutura do Projeto

O projeto é composto por duas classes principais:

1. **Program**: Contém o método principal (`Main`) que executa a leitura de um arquivo e implementa o tratamento de exceções.
2. **ExemploExcecoesThrow**: Demonstra o uso de exceções com `throw`, propagando-as através de uma cadeia de métodos.

## Funcionalidades

### Tratamento de Exceções

- **Leitura de Arquivo**: O código tenta ler um arquivo de texto e exibe seu conteúdo no console. Se o arquivo ou diretório não for encontrado, uma exceção específica é capturada e uma mensagem de erro é exibida.
- **Propagação de Exceções**: A classe `ExemploExcecoesThrow` demonstra como uma exceção pode ser lançada em um método (`metodo4`) e propagada de volta através de outros métodos (`metodo3` e `metodo2`) até ser tratada no método `metodo1`.
- **Uso do Bloco `finally`**: Garante que uma mensagem de conclusão seja exibida, independentemente de uma exceção ter sido lançada ou não.

## Código

### Exemplo de Uso

Aqui está um exemplo de como o código funciona:

```csharp
using ExemploExplorando.models; // Importa o namespace que contém as classes necessárias.
using System.Data; // Importa o namespace para manipulação de dados.

Console.WriteLine("Tratamento de exceções - Bloco try catch finally");
try
{
    string[] linhas = File.ReadAllLines("Arquivo/arquivoLeitura.txt");
    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro: Arquivo não encontrado. Detalhes: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro: Diretório não encontrado. Detalhes: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: Erro genérico. Detalhes: {ex.Message}");
}
finally
{
    Console.WriteLine("Terminou a leitura do arquivo");
    Console.WriteLine("-------------------------------");
}

// Testando tratamento de exceções com throw
new ExemploExcecoesThrow().metodo1();
```

### Estrutura das Classes

#### Classe `ExemploExcecoesThrow`

```csharp
public class ExemploExcecoesThrow
{
    public void metodo1()
    {
        try
        {
            metodo2();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exceção tratada: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Chegou no bloco finally");
        }
    }

    public void metodo2()
    {
        metodo3();
    }

    public void metodo3()
    {
        metodo4();
    }

    public void metodo4()
    {
        throw new Exception("Ocorreu um erro na aplicação");
    }
}
```

## Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/seurepositorio.git
   ```

2. Navegue até o diretório do projeto:
   ```bash
   cd seurepositorio
   ```

3. Abra o projeto no seu IDE preferido (por exemplo, Visual Studio).

4. Certifique-se de que o arquivo `arquivoLeitura.txt` esteja na pasta `Arquivo`.

5. Compile e execute o projeto.
