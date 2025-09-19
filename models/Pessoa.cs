using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    // Definindo a classe Pessoa, que representa uma pessoa com nome, sobrenome e idade
    public class Pessoa
    {
        // Construtor padrão, que pode ser utilizado para criar um objeto Pessoa sem inicializar propriedades
        public Pessoa()
        {

        }
        // Construtor que recebe parâmetros para inicializar as propriedades Nome e Sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;          // Atribuindo o valor do parâmetro nome à propriedade Nome
            Sobrenome = sobrenome; // Atribuindo o valor do parâmetro sobrenome à propriedade Sobrenome
        }
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;               // Atribuindo o valor da propriedade Nome ao parâmetro de saída nome
            sobrenome = Sobrenome;     // Atribuindo o valor da propriedade Sobrenome ao parâmetro de saída sobrenome
        }
        // Campo privado para armazenar o nome
        private string _nome;
        // Campo privado para armazenar a idade
        private int _idade;
        // Propriedade Nome com lógica de validação e formatação
        public string Nome
        {
            get => _nome.ToUpper(); // Retorna o nome em letras maiúsculas

            set
            {
                // Validação: o nome não pode ser vazio
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value; // Atribui o valor à variável privada _nome
            }
        }
        // Propriedade Sobrenome com autoimplementação (sem lógica adicional)
        public string Sobrenome { get; set; }
        // Propriedade somente leitura que retorna o nome completo em letras maiúsculas
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        // Propriedade Idade com lógica de validação
        public int Idade
        {
            get => _idade; // Retorna o valor da idade

            set
            {
                // Validação: a idade não pode ser negativa
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value; // Atribui o valor à variável privada _idade
            }
        }
        // Método para apresentar as informações da pessoa
        public void Apresentar()
        {
            // Exibe uma mensagem no console com o nome completo e a idade da pessoa
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }
    }
}
