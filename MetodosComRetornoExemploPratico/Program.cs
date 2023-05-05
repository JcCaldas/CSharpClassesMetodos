Console.WriteLine("## Métodos com Retorno - Exemplo Prático ##\n");


Cadastro cadastro = new(); //cria objeto do tipo Cadastro

var cliente = cadastro.Registrar(); //cria uma variavel, que se torna um objeto do tipo Cliente devido as informações do método, que recebe o objeto que retornará do método informado

cadastro.ExibirDados(cliente); //Exibe os dados da variável

cliente = cadastro.Registrar(cliente); //altera a renda, conforme método

cadastro.ExibirDados("Renda alterada", cliente);

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    /*O construtor vazio permite a criação de um objeto
     utilizando a sintaxe padrão, não sendo necessário
    informar os parâmetros na hora de criar o objeto.*/
    public Cliente()
    {
        
    }
}

public class Cadastro
{
    public Cliente Registrar ()
    {
        Cliente cliente = new("Maria", 23, 3000);
        return cliente;
    }

    public Cliente Registrar (Cliente cliente)
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados (Cliente cliente)
    {
        Console.WriteLine($"Nome: {cliente.Nome}");
        Console.WriteLine($"Idade: {cliente.Idade}");
        Console.WriteLine($"Renda: {cliente.Renda.ToString("c")}");
    }

    public void ExibirDados (string texto, Cliente cliente)
    {
        Console.Write($"\n{texto}\t");
        Console.Write($"{cliente.Nome} - {cliente.Renda.ToString("c")}");
    }
}