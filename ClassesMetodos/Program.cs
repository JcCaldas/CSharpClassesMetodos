Console.WriteLine("## Classes e Métodos ##\n");


/*Para a criação de objeto de uma determinada classe,
 primeiro coloca o nome da classe, depois o nome do 
 objeto recebendo "new NomeDaClasse()"*/

Pessoa p1 = new Pessoa();

/*O ponto (.) após o nome do objeto acessa os métodos e comportamentos,
 declarados na classe, do objeto*/

p1.Nome = "Maria";
p1.Idade = 25;
p1.Sexo = "feminino";

Console.WriteLine($"Pessoa 1: {p1.Nome}, {p1.Idade}, {p1.Sexo}");

/*Pode-se criar um objeto ultilizando a palavra reservada "var" */
var p2 = new Pessoa();

p2.Nome = "Manuel";
p2.Idade = 23;
p2.Sexo = "masculino";

Console.WriteLine($"Pessoa 2: {p2.Nome}, {p2.Idade}, {p2.Sexo}");

/*A partir do C# 10, existe outra forma de declarar um objeto.

 NomeDaClasse nomeDoObjeto = new()

Somente pode ser declarado assim, se o nome da classe for explicitamente
informado.*/

Pessoa p3 = new();

p3.Nome = "João";
p3.Idade = 30;
p3.Sexo = "masculino";

Console.WriteLine($"Pessoa 3: {p3.Nome}, {p3.Idade}, {p3.Sexo}");

Console.ReadKey();

/*Com as instruções de alto nível no .NET6, as declarações
 de classes podem ser feitas no mesmo arquivo. Ao final do código.

 A nomeclatura usada para declarar campos é a PascalCase. assim o correto
seria usar os nomes com iniciais maiúscula.*/

class Pessoa
{
    public string? Nome;
    public int Idade;
    public string? Sexo;
}