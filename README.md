# Projeto de Gerenciamento de Cursos

Este projeto é uma aplicação simples em C# que permite gerenciar cursos e alunos. Ele inclui classes para representar cursos e alunos, permitindo adicionar, listar e remover alunos de um curso.

## Estrutura do Projeto

O projeto contém as seguintes classes principais:

- **Curso**: Representa um curso, incluindo o nome do curso e uma lista de alunos matriculados.
- **Pessoa**: Representa um aluno, com propriedades para armazenar informações relevantes.

## Tecnologias Utilizadas

- C#
- .NET (Framework)

## Como Usar

### Classe `Curso`

A classe `Curso` possui os seguintes métodos:

- **AdicionarAluno(Pessoa aluno)**: Adiciona um aluno à lista de alunos do curso.
- **ListarAlunos()**: Exibe todos os alunos matriculados no curso e a quantidade total de alunos.
- **RemoverAluno(Pessoa aluno)**: Remove um aluno da lista de alunos do curso.

### Classe `Pessoa`

A classe `Pessoa` deve conter as seguintes propriedades:

- **NomeCompleto**: O nome completo do aluno.

### Exemplo de Uso

Aqui está um exemplo básico de como usar as classes:

```csharp
// Criação de um novo curso
Curso curso = new Curso { Nome = "Desenvolvimento de Software", Alunos = new List<Pessoa>() };

// Criação de novos alunos
Pessoa aluno1 = new Pessoa { NomeCompleto = "João Silva" };
Pessoa aluno2 = new Pessoa { NomeCompleto = "Maria Oliveira" };

// Adicionando alunos ao curso
curso.AdicionarAluno(aluno1);
curso.AdicionarAluno(aluno2);

// Listando alunos
curso.ListarAlunos();

// Removendo um aluno
curso.RemoverAluno(aluno1);
```
## Contribuição

Sinta-se à vontade para contribuir com o projeto! Você pode fazer isso da seguinte maneira:

1. Fork o repositório.
2. Crie uma nova branch (`git checkout -b feature/nome-da-sua-feature`).
3. Faça suas alterações e commit (`git commit -m 'Adicionando nova feature'`).
4. Faça push para a branch (`git push origin feature/nome-da-sua-feature`).
5. Abra um Pull Request.

## Contato

Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato:

- **Email**: brandon.giron.flores@gmail.com
