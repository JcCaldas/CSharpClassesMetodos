Console.WriteLine("## This ##\n");

Teste teste = new Teste();
teste.Num1 = 55;
teste.Num2 = 36;
teste.Exibir();

Console.ReadKey();

public class Cliente
{
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome, int Idade)
    {
        /*this referencia aos parâmetros da classe*/
        this.Nome = Nome;
        this.Idade = Idade;
    }
}

public class Teste
{
    public int Num1;
    public int Num2;

    //Parâmetro é um objeto do tipo "Teste"
    public void PassaParametro (Teste t)
    {
        Console.WriteLine($"this = {this}");
        Console.WriteLine($"Num1: {t.Num1}");
        Console.WriteLine($"Num2: {t.Num2}");
    }

    public void Exibir ()
    {
        /*Passando "this" como um parâmetro, vai se
         referir a classe "Teste"*/
        PassaParametro(this);
    }
}