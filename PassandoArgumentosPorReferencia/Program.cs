Console.WriteLine("## Passando argumentos por referência (REF) ##\n");

int x = 20;
Console.WriteLine($"Valor do argumento X antes de passar por valor: {x}");

Calculo calc = new();
calc.Dobrar(ref x); //Deve-se colocar "ref" no chamador

Console.WriteLine($"\nValor do argumento X depois de passar por valor: {x}");




Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y) //Deve-se colocar "ref" no parâmetro do método
    {
        y *= 2;
        Console.WriteLine($"\nValor do parâmetro Y no método Dobrar é: {y}");
    }
}