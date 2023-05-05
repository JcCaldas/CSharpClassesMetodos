

public class Pessoa
{
    public static int IdadeMinima;

    //Propriedades
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    public Pessoa()
    { }

    /*Se não for fornecido um construtor estático para
     inicializar os campos estáticos, eles vão inicializar
    com o valor padrão.*/
    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}