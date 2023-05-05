
using CarrosEnum;

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Cor;

    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;

            else if (value > 2022)
                ano = 2022;

            else
                ano = value;
        }
    }

    public int Potencia;
    public static double ValorIpva;
  

    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia, int cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = cor;
    }

    /*Substituindo o método ObterValorIPVA() por um construtor estático para inicializar o campo estático
    ValorIpva, ele inicializa o campo automaticamente.*/
    static Carro()
    {
        ValorIpva = 4;
    }

    public Carro()
    {
        
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}!");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        velocidade = potencia * 1.75;
        potencia += 7;
        return potencia;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0000, int cor = 0)
    {

        Console.WriteLine("Apresentação das informações do Veículo:");
        Console.WriteLine($"\nModelo: {modelo};");
        Console.WriteLine($"Montadora: {montadora};");
        Console.WriteLine($"Marca: {marca};");
        Console.WriteLine($"Potência: {potencia}cv;");
        Console.WriteLine($"Ano: {(ano == 0000 ? "Não informado" : ano)}.");
        Console.WriteLine($"Cor: {(cor == 0 ? "Não informada" : (Cores)cor)}.");

    }

    //public static void ObterValorIPVA()
    //{
    //    ValorIpva = 4;
    //}

}