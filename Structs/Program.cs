Console.WriteLine("## Structs ##\n");

//Struct aloca na memória Stack
Cliente cliente = new();
cliente.Nome = "Maria";
cliente.Idade = 19;

Console.WriteLine($"Cliente: {cliente.Nome} - Idade: {cliente.Idade}");

Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente (string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
