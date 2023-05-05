Console.WriteLine("## Construtores ##\n");

/*Se não definir um construtor, toda classe receberá
 um construtor padrão que será inicializado automaticamente.
Ele recebe o mesmo nome da classe e atribui os valores padrão
aos membros da classe. Exemplo abaixo.*/
Console.WriteLine("Construtor Padrão");
AlunoExemplo alunoExemplo = new AlunoExemplo();

Console.WriteLine(alunoExemplo.Nome == null ? "null" : alunoExemplo.Nome);
Console.WriteLine(alunoExemplo.Idade);
Console.WriteLine(alunoExemplo.Sexo == null ? "null" : alunoExemplo.Sexo);
Console.WriteLine(alunoExemplo.Aprovado == null ? "null" : alunoExemplo.Aprovado);

/*A classe criada com construtor, ignora o construtor
 padrão e ultiliza o construtor que está dentro dela.
Exemplo abaixo:*/
Console.WriteLine("\nConstrutor Definido");
Aluno aluno = new Aluno("João", 33, "masculino", "s");

Console.WriteLine(aluno.Nome == null ? "null" : aluno.Nome);
Console.WriteLine(aluno.Idade);
Console.WriteLine(aluno.Sexo == null ? "null" : aluno.Sexo);
Console.WriteLine(aluno.Aprovado == null ? "null" : aluno.Aprovado);


Console.ReadKey();

//Classe criada sem construtor
public class AlunoExemplo
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

//Classe criada com construtor
public class Aluno
{
    //Construtor
    /*Dessa forma é limitado a forma com o construtor
     é criado*/
    //publico e sem nenhum tipo de retorno
    //Deve ser o mesmo nome da classe
    public Aluno(string nome, int idade, string sexo, string aprovado)
    {
        Nome = nome;
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }


    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}
