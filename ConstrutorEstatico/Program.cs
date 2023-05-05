Console.WriteLine("## Construtor Estático ##\n");

//Invoca o construtor parametrizado e o estático
Pessoa p1 = new("Maria",19);
Console.WriteLine($"{p1.Nome} - {p1.Idade}");
Console.WriteLine($"Idade Mínima: {Pessoa.IdadeMinima}");

/*Invoca somente o construtor parametrizado, pois o 
 construtor estático somente é invocado uma vez durante
a vida útil do programa*/
Pessoa p2 = new("Manoel", 30);
Console.WriteLine($"{p2.Nome} - {p2.Idade}");
Console.WriteLine($"Idade Mínima: {Pessoa.IdadeMinima}");

Console.ReadKey();

/*A classe está em um outro arquivo "Pessoa.cs"
Para fazer isso, basta selecionar a classe, e pedir
ao VS para colocar em um arquivo com o mesmo nome da classe*/