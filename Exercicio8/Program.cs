Console.WriteLine("## Exercício 8 ##\n");

Cliente cliente1 = new("Maria", "maria@email.com", idade: 15);

Cliente.ExibirInfo(cliente1.Nome, cliente1.Email);
Cliente.ExibirInfo(cliente1.Nome, cliente1.Email, cliente1.Idade);

Cliente cliente2 = new();
cliente2.Nome = "Joana";
cliente2.Email = "joana@email.com";
cliente2.Idade = 12;

Cliente.ExibirInfo(cliente2.Nome, cliente2.Email);
Cliente.ExibirInfo(cliente2.Nome, cliente2.Email, cliente2.Idade);

Cliente cliente3 = new();
cliente3.Nome = "José";
cliente3.Email = "josé@email.com";
cliente3.Idade = 36;

Cliente.ExibirInfo(cliente3.Nome, cliente3.Email);
Cliente.ExibirInfo(cliente3.Nome, cliente3.Email, cliente3.Idade);

Console.ReadKey();


public struct Cliente
{
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        idadecliente = idade; 
        Idade = idade; //Sem essa informação, ele não valida a idade quando ela é informada no parâmetro. Porque?
    }

    public string Nome;
    public string Email;


    private int idadecliente;
    public int Idade
    {
        get { return idadecliente; }
        set
        {
            if (value < 18)
            {
                idadecliente = 18;
                Console.WriteLine("\nCliente menor de 18 anos.");

            }
            else
            {
                idadecliente = value;
                Console.WriteLine("\nCliente maior de 18 anos.");

            }
        }
    }

    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"\nNome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Idade: {idade}");
    }
}