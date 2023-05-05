Console.WriteLine("## Exercício Classes e Métodos 5 ##\n");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("SUV", "Ford", "Ecosport", 2018, 120);

Console.WriteLine("\n-----------\tCHEVROLET\t-----------");
Console.WriteLine("\nParte 1");
Console.WriteLine($"\nModelo: {chevrolet.Modelo}");
Console.WriteLine($"Montadora: {chevrolet.Montadora}");
Console.WriteLine($"Marca: {chevrolet.Marca}");
Console.WriteLine($"Ano: {chevrolet.Ano}");
Console.WriteLine($"Potência: {chevrolet.Potencia}cv");
chevrolet.Acelerar(chevrolet.Marca);
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 2");
double chevroleteVelocidadeMaxima = chevrolet.VelocidadeMaxima(chevrolet.Potencia);
Console.WriteLine($"\nA velocidade máxima é de {chevroleteVelocidadeMaxima}Km/h");
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 3");
int chevroletPotencia = chevrolet.Potencia;
Console.WriteLine($"\nCom o aumento de potência TEMPORÁRIO (por VALOR +3cv) ela irá para {chevrolet.AumentarPotencia(chevroletPotencia)}cv");
Console.WriteLine($"Potência atual: {chevroletPotencia}cv");
Console.WriteLine($"Com o aumento de potência DEFINITIVO (por REFERÊNCIA +5cv) ela irá para {chevrolet.AumentarPotencia(ref chevroletPotencia)}cv");
Console.WriteLine($"Potência atual: {chevroletPotencia}cv");
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 4");
int chevroletAumentoPotenciaVelocidade = chevrolet.AumentarPotenciaVelocidade(chevroletPotencia, out double velocidadeChevrolet);
Console.WriteLine($"\nAumento de Potência TEMPORÁRIO (por VALOR +7): {chevroletAumentoPotenciaVelocidade}cv");
Console.WriteLine($"Velocidade com aumento temporário de potência (OUT): {velocidadeChevrolet}cv");
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 5");
Console.WriteLine("\nChamada sem definição do Ano");
chevrolet.ExibirInfo(potencia: chevrolet.Potencia, montadora: chevrolet.Montadora, marca: chevrolet.Marca, modelo:chevrolet.Modelo);
Console.WriteLine("\nChamada com definição do Ano");
chevrolet.ExibirInfo(potencia: chevrolet.Potencia, montadora: chevrolet.Montadora, marca: chevrolet.Marca, modelo: chevrolet.Modelo, ano: chevrolet.Ano);


Console.WriteLine("\n-----------\tFORD\t-----------");
Console.WriteLine("\nParte 1");
Console.WriteLine($"\nModelo: {ford.Modelo}");
Console.WriteLine($"Montadora: {ford.Montadora}");
Console.WriteLine($"Marca: {ford.Marca}");
Console.WriteLine($"Ano: {ford.Ano}");
Console.WriteLine($"Potência: {ford.Potencia}cv");
ford.Acelerar(ford.Marca);
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 2");
double fordVelocidadeMaxima = ford.VelocidadeMaxima(ford.Potencia);
Console.WriteLine($"\nA velocidade máxima é de {fordVelocidadeMaxima}Km/h");
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 3");
int fordPotencia = ford.Potencia;
Console.WriteLine($"\nAumento de potência TEMPORÁRIO (por VALOR) ela irá para {ford.AumentarPotencia(fordPotencia)}cv");
Console.WriteLine($"Potência atual: {fordPotencia}cv");
Console.WriteLine($"Aumento de potência DEFINITIVO (por REFERÊNCIA) ela irá para {ford.AumentarPotencia(ref fordPotencia)}cv");
Console.WriteLine($"Potência atual: {fordPotencia}cv");
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 4");
int fordAumentoPotenciaVelocidade = ford.AumentarPotenciaVelocidade(fordPotencia, out double velocidadeFord);
Console.WriteLine($"\nAumento de Potência TEMPORÁRIO (por VALOR +7): {fordAumentoPotenciaVelocidade}cv");
Console.WriteLine($"Velocidade com aumento temporário de potência (OUT): {velocidadeFord}cv");
Console.WriteLine("\n-------------------------------");
Console.WriteLine("\nParte 5");
Console.WriteLine("\nChamada sem definição do Ano");
chevrolet.ExibirInfo(potencia: ford.Potencia, montadora: ford.Montadora, marca: ford.Marca, modelo: ford.Modelo);
Console.WriteLine("\nChamada com definição do Ano");
chevrolet.ExibirInfo(potencia: ford.Potencia, montadora: ford.Montadora, marca: ford.Marca, modelo: ford.Modelo, ano: ford.Ano);


Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;

    public Carro(string Modelo, string Montadora, string Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
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

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 0000)
    {
        
        Console.WriteLine("Apresentação das informações do Veículo:");
        Console.WriteLine($"\nModelo: {modelo};");
        Console.WriteLine($"Montadora: {montadora};");
        Console.WriteLine($"Marca: {marca};");
        Console.WriteLine($"Potência: {potencia}cv;");
        Console.WriteLine($"Ano: {(ano == 0000 ? "Não informado" : ano)}.");

    }

}