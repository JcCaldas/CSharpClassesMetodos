Console.WriteLine("## Tipos Anônimos ##\n");

/*Para criar um tipo anônimo, ultiliza-se a palavra reservada
 "var", o compilador fará o resto.*/
var aluno = new
{
    /*As propriedades são somente leitura, não podendo
     ser atribuido um novo valor após declarado e ter um
    valor atribuido.
    
     O compilador define o tipo da propriedade automaticamente*/

    Nome = "Maria",
    Idade = 43

};

//aluno.Idade = 40;//Como a propriedade é somente leitura, o compilador não permite a mudança de valor

//Mostra o nome que o compilador deu:
Console.WriteLine(aluno.GetType().ToString());

Console.WriteLine($"\nNome: {aluno.Nome} - Idade: {aluno.Idade}");

/*Pode-se criar um anônimo dentro de outro anônimo*/

var aluno2 = new
{
    Id = 1,
    Nome = "Jairo",
    Email = "jairo@email.com",
    Endereco = new
    {
        Id = 1,
        Cidade = "Santos",
        Pais = "Brasil"
    }

};

//Para acessar:
Console.WriteLine($"\nNome: {aluno2.Nome}");
Console.WriteLine($"Cidade: {aluno2.Endereco.Cidade}");

//Pode-se criar, também, um array de tipos anônimos:

var arrayAlunos = new[]
{
    new { Id = 1, Nome = "Maria", Email = "maria@email.com"},
    new { Id = 2, Nome = "Sonia", Email = "sonia@email.com"},
    new { Id = 3, Nome = "Bruno", Email = "bruno@email.com"}
};

//Para acessar deve-se informar o indice
Console.WriteLine($"Nome: {arrayAlunos[0].Nome} - Email: {arrayAlunos[0].Email}");
Console.WriteLine($"Nome: {arrayAlunos[1].Nome} - Email: {arrayAlunos[1].Email}");
Console.WriteLine($"Nome: {arrayAlunos[2].Nome} - Email: {arrayAlunos[2].Email}");
Console.WriteLine();


Console.ReadKey();

