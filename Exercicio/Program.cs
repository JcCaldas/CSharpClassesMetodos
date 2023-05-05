Console.WriteLine("## Exercício Classes e Métodos 1 ##");

Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro ford = new Carro("SUV", "Ford", "Ecosport", 2018, 120);

Console.WriteLine($"Modelo: {chevrolet.Modelo}");
Console.WriteLine($"Montadora: {chevrolet.Montadora}");
Console.WriteLine($"Marca: {chevrolet.Marca}");
Console.WriteLine($"Ano: {chevrolet.Ano}");
Console.WriteLine($"Potência: {chevrolet.Potencia}cv");
chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine($"\nModelo: {ford.Modelo}");
Console.WriteLine($"Montadora: {ford.Montadora}");
Console.WriteLine($"Marca: {ford.Marca}");
Console.WriteLine($"Ano: {ford.Ano}");
Console.WriteLine($"Potência: {ford.Potencia}cv");
ford.Acelerar(ford.Marca);



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

}