Console.WriteLine("## Passando argumentos por referência (OUT) ##\n");

Console.Write("Informe o raio do círculo (cm): ");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

//SEM OUT
double perimetro2 = circulo.CalculaPerimetro(raio);
double area2 = circulo.CalculaArea(raio);

Console.WriteLine($"Perímetro da Circunferência: {perimetro2} cm");
Console.WriteLine($"Área da Circunferência: {area2} cm");


//COM OUT
double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);

Console.WriteLine($"Perímetro da Circunferência: {circunferencia} cm");// retorna somente o perímetro, conforme return do método
Console.WriteLine($"Área da Circunferência: {area} cm");// retorna a área, pois o out faz retornar mais de um argumento por método

Console.ReadKey();


public class Circulo
{
    //SEM OUT
    public double CalculaArea (double raio)
    {
        double area = Math.PI * Math.Pow (raio, 2);
        return area;
    }

    public double CalculaPerimetro (double raio)
    {
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
   
    //COM OUT
    public double CalculaAreaPerimetro (double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}