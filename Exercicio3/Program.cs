Console.WriteLine("## Exercício Classes e Métodos 3 ##");

Carro chevrolet = new Carro("Sedan", "Chevrolet", 110);
Carro ford = new Carro("SUV", "Ford", 120);

Console.WriteLine($"\nModelo: {chevrolet.Modelo}");
Console.WriteLine($"Montadora: {chevrolet.Montadora}");
Console.WriteLine($"Potência: {chevrolet.Potencia}cv");
Console.WriteLine($"A velocidade máxima é de {chevrolet.VelocidadeMaxima(chevrolet.Potencia)}Km/h");
Console.WriteLine($"Com o aumento de potência TEMPORÁRIO (por VALOR +3cv) ela irá para {chevrolet.AumentarPotencia(chevrolet.Potencia)}cv");
Console.WriteLine($"Potência atual: {chevrolet.Potencia}cv");
Console.WriteLine($"Com o aumento de potência DEFINITIVO (por REFERÊNCIA +5cv) ela irá para {chevrolet.AumentarPotencia(ref chevrolet.Potencia)}cv");
Console.WriteLine($"Potência atual: {chevrolet.Potencia}cv");


Console.WriteLine($"\nModelo: {ford.Modelo}");
Console.WriteLine($"Montadora: {ford.Montadora}");
Console.WriteLine($"Potência: {ford.Potencia}cv");
Console.WriteLine($"A velocidade máxima é de {ford.VelocidadeMaxima(ford.Potencia)}Km/h");
Console.WriteLine($"Com o aumento de potência TEMPORÁRIO (por VALOR) ela irá para {ford.AumentarPotencia(ford.Potencia)}cv");
Console.WriteLine($"Potência atual: {ford.Potencia}cv");
Console.WriteLine($"Com o aumento de potência DEFINITIVO (por REFERÊNCIA) ela irá para {ford.AumentarPotencia(ref ford.Potencia)}cv");
Console.WriteLine($"Potência atual: {ford.Potencia}cv");

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

    public int AumentarPotencia (int potencia)
    {
        potencia += 3;
        return potencia;
    }
    
    public int AumentarPotencia (ref int potencia)
    {
        potencia += 5;
        return potencia;
    }


}