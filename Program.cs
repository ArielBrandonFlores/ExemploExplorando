using ExemploExplorando.models;

// Instanciando objetos da classe Pessoa. Existem 3 formas de instanciar objetos:
// 1. Usando propriedades autoimplementadas.
// 2. Usando o construtor padrão (sem parâmetros).
// 3. Usando o construtor com parâmetros (que inicializa as propriedades com valores específicos).

// Criando um objeto da classe Pessoa com o nome "Ariel" e sobrenome "Giron".
Pessoa pessoa1 = new Pessoa("Ariel", "Giron");

// Criando um objeto da classe Pessoa usando nome e sobrenome como parâmetros nomeados.
Pessoa pessoa2 = new Pessoa(nome: "Maria", sobrenome: "Oliveira");

// Criando um objeto da classe Pessoa usando o construtor padrão (sem parâmetros).
Pessoa pessoa4 = new Pessoa();
// Atribuindo valores às propriedades Nome e Sobrenome do objeto pessoa4.
pessoa4.Nome = "Jamielly";
pessoa4.Sobrenome = "Dos Reis";
// Instanciando um objeto da classe Curso.
Curso curso = new Curso();
// Atribuindo um nome ao curso.
curso.Nome = "C#";
// Inicializando a lista de alunos do curso, que irá armazenar objetos do tipo Pessoa.
curso.Alunos = new List<Pessoa>();
curso.AdicionarAluno(pessoa1);
curso.AdicionarAluno(pessoa2);
curso.AdicionarAluno(pessoa4);
// Listando todos os alunos matriculados no curso.
curso.ListarAlunos();
// Removendo o aluno do curso.
curso.RemoverAluno(pessoa2);
// Listando novamente os alunos para verificar se "João Silva" foi removido com sucesso.
curso.ListarAlunos();
