Console.WriteLine("## Construtores ##\n");

/*Se usar o parâmetro de apenas um construtor, os outros
 ficaram com os parâmetros padrão.*/
//Aluno aluno = new Aluno("João");
//Aluno aluno = new Aluno(33, "masculino", "s");

//chamada com o construtor com todos os parâmetros
Aluno aluno = new Aluno("João", 33, "masculino", "s");


Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


Console.ReadKey();

public class Aluno
{
    //Se o construtor tiver somente uma linha de código, pode-se utiliza a sintaxe abaixo para compactar
    public Aluno(string nome) => Nome = nome;


    /*ctor - Cria um construtor automaticamente, sem parâmetros
    Caso queria que um construtor chame o outro, para informar algum parâmetro,
    ultiliza-se os dois pontos (:), após o construtor que quer
    chamar o outro, e a palavra "this (parametro a ser chamado do construtor anterior)"*/
    public Aluno(string nome, int idade, string sexo, string aprovado) : this (nome)
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
