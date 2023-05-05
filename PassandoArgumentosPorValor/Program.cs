Console.WriteLine("## Passando argumentos por valor ##\n");

int x = 20;
Console.WriteLine($"Valor do argumento X antes de passar por valor: {x}");

Calculo calc = new();
calc.Dobrar(x);

Console.WriteLine($"\nValor do argumento X depois de passar por valor: {x}");




Console.ReadKey();

public class Calculo
{
    public void Dobrar (int y)
    {
        y *= 2;
        Console.WriteLine($"\nValor do parâmetro Y no método Dobrar é: {y}");
    }
}