Console.WriteLine("## Exercício Classes e Métodos 4 ##");

Carro chevrolet = new Carro("Sedan", "Chevrolet", 110);
Carro ford = new Carro("SUV", "Ford", 120);

Console.WriteLine($"\nModelo: {chevrolet.Modelo}");
Console.WriteLine($"Montadora: {chevrolet.Montadora}");
Console.WriteLine($"Potência: {chevrolet.Potencia}cv");
Console.WriteLine("-------------------------------");
double chevroleteVelocidadeMaxima = chevrolet.VelocidadeMaxima(chevrolet.Potencia);
Console.WriteLine($"A velocidade máxima é de {chevroleteVelocidadeMaxima}Km/h");
Console.WriteLine("-------------------------------");
int chevroletPotencia = chevrolet.Potencia;
Console.WriteLine($"Com o aumento de potência TEMPORÁRIO (por VALOR +3cv) ela irá para {chevrolet.AumentarPotencia(chevroletPotencia)}cv");
Console.WriteLine($"Potência atual: {chevroletPotencia}cv");
Console.WriteLine($"Com o aumento de potência DEFINITIVO (por REFERÊNCIA +5cv) ela irá para {chevrolet.AumentarPotencia(ref chevroletPotencia)}cv");
Console.WriteLine($"Potência atual: {chevroletPotencia}cv");
Console.WriteLine("-------------------------------");
int chevroletAumentoPotenciaVelocidade = chevrolet.AumentarPotenciaVelocidade(chevroletPotencia, out double velocidadeChevrolet);
Console.WriteLine($"Aumento de Potência TEMPORÁRIO (por VALOR +7): {chevroletAumentoPotenciaVelocidade}cv");
Console.WriteLine($"Velocidade com aumento temporário de potência (OUT): {velocidadeChevrolet}cv");


Console.WriteLine($"\nModelo: {ford.Modelo}");
Console.WriteLine($"Montadora: {ford.Montadora}");
Console.WriteLine($"Potência: {ford.Potencia}cv");
Console.WriteLine("-------------------------------");
double fordVelocidadeMaxima = ford.VelocidadeMaxima(ford.Potencia);
Console.WriteLine($"A velocidade máxima é de {fordVelocidadeMaxima}Km/h");
Console.WriteLine("-------------------------------");
int fordPotencia = ford.Potencia;
Console.WriteLine($"Aumento de potência TEMPORÁRIO (por VALOR) ela irá para {ford.AumentarPotencia(fordPotencia)}cv");
Console.WriteLine($"Potência atual: {fordPotencia}cv");
Console.WriteLine($"Aumento de potência DEFINITIVO (por REFERÊNCIA) ela irá para {ford.AumentarPotencia(ref fordPotencia)}cv");
Console.WriteLine($"Potência atual: {fordPotencia}cv");
Console.WriteLine("-------------------------------");
int fordAumentoPotenciaVelocidade = ford.AumentarPotenciaVelocidade(fordPotencia, out double velocidadeFord);
Console.WriteLine($"Aumento de Potência TEMPORÁRIO (por VALOR +7): {fordAumentoPotenciaVelocidade}cv");
Console.WriteLine($"Velocidade com aumento temporário de potência (OUT): {velocidadeFord}cv");


Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public int Potencia;

    public Carro(string modelo, string montadora, int potencia)
    {
        Modelo = modelo;
        Montadora = montadora;
        Potencia = potencia;
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

    public int AumentarPotenciaVelocidade (int potencia, out double velocidade)
    {
        velocidade = potencia * 1.75;
        potencia += 7;
        return potencia;
    }

}