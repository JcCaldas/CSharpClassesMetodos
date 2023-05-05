Console.WriteLine("## Exercício Classes e Métodos 2 ##");

Carro chevrolet = new Carro("Sedan","Chevrolet");
Carro ford = new Carro("SUV", "Ford");

Console.WriteLine($"\nModelo: {chevrolet.Modelo}");
Console.WriteLine($"Montadora: {chevrolet.Montadora}");
Console.WriteLine($"A velocidade máxima é de {chevrolet.VelocidadeMaxima(110)}Km/h");


Console.WriteLine($"\nModelo: {ford.Modelo}");
Console.WriteLine($"Montadora: {ford.Montadora}");
Console.WriteLine($"A velocidade máxima é de {ford.VelocidadeMaxima(120)}Km/h");



Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Montadora;

    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public double VelocidadeMaxima (int potencia)
    {
        return potencia * 1.75;
    }
    

}