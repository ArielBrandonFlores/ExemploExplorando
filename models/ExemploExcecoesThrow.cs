using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class ExemploExcecoesThrow
    {
        // Neste exemplo temos uma cadeia de métodos (metodo1, metodo2, metodo3, metodo4).Para exercitar o uso do throw,
        // o método metodo4 lança uma exceção, que é propagada de volta através dos outros métodos até ser capturada e tratada no metodo1.
        // O bloco finally no metodo1 garante que uma mensagem seja exibida independentemente de uma exceção ter ocorrido ou não.
        public void metodo1()
        {
            try
            {
                // Chama o método metodo2, que pode lançar uma exceção.
                metodo2();
            }
            catch (Exception ex)
            {
                // Captura e trata a exceção lançada pelo metodo4.
                Console.WriteLine($"Exceção tratada: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Chegou no bloco finally");
            }
        }

        public void metodo2()
        {
            // Chama o método metodo3, que também pode lançar uma exceção.
            metodo3();
        }

        public void metodo3()
        {
            // Chama o método metodo4, onde a exceção é realmente lançada.
            metodo4();
        }

        public void metodo4()
        {
            // Lança uma nova exceção com uma mensagem específica.
            throw new Exception("Ocorreu um erro na aplicação");
        }
    }
}