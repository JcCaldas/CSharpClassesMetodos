Console.WriteLine("## Campos estáticos - Exercício prático ##\n");

/*Se o campo for estático, ele é compartilhado com todas
 as instâncias do objeto, impossibilitando definir um valor
para cada, pois ele pertence a classe e não ao objeto.
Todas as intâncias acessam o mesmo local de memória do campo
estático.*/

ContaCorrente c1 = new ContaCorrente();
c1.Conta = 101;
c1.Nome = "Maria";
//c1.Juros = 3.99f;

ContaCorrente c2 = new ContaCorrente();
c2.Conta = 102;
c2.Nome = "Marta";
//c2.Juros = 4.99f;

ContaCorrente.Juros = 4.25f;

Console.WriteLine($"Clente: {c1.Nome} - Juros Anual: {c1.JurosAnual()}.");
Console.WriteLine($"Clente: {c2.Nome} - Juros Anual: {c2.JurosAnual()}.");

Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual ()
    {
        return Juros * 12;
    }
}