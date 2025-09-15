using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    // Definindo a classe Curso, que representa um curso com um nome e uma lista de alunos
    public class Curso
    {
        // Propriedade Nome que armazena o nome do curso
        public string Nome { get; set; }
        // Propriedade Alunos que armazena uma lista de objetos do tipo Pessoa (alunos do curso)
        public List<Pessoa> Alunos { get; set; }
        // Método para adicionar um aluno à lista de alunos do curso
        public void AdicionarAluno(Pessoa aluno)
        {
            // Adiciona o objeto aluno à lista Alunos
            Alunos.Add(aluno);
        }
        // Método para listar todos os alunos matriculados no curso
        public void ListarAlunos()
        {
            // Exibe o nome do curso no console
            Console.WriteLine($"Alunos do curso de {Nome}:");
            // Obtém a quantidade de alunos na lista
            int quantidade = Alunos.Count;
            // Exibe a quantidade de alunos
            Console.WriteLine($"Quantidade de alunos: {quantidade}");
            // Itera sobre a lista de alunos e exibe o nome completo de cada um
            foreach (var aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
        // Método para remover um aluno da lista de alunos do curso
        public void RemoverAluno(Pessoa aluno)
        {
            // Remove o objeto aluno da lista Alunos
            Alunos.Remove(aluno);
            // Exibe uma mensagem confirmando a remoção do aluno
            Console.WriteLine($"Aluno {aluno.NomeCompleto} removido com sucesso!");
        }
    }
}
