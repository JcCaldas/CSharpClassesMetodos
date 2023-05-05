Console.WriteLine("## Campos Estáticos ##\n");

/*Assim como os métodos estáticos, os campos estáticos
 pertecem a classe e não a instância. As instâncias não
conseguem acessa-los, somente a classe. Ao definir um valor
para eles, todas as instâncias da classe tem acesso ao valor.*/

A a1 = new();
a1.x = 10;

A a2 = new();
a2.x = 20;

A.y = 30;

Console.WriteLine($"a1.x = {a1.x}, a2.x = {a2.x}, A.y = {A.y}.");

Console.ReadKey();

public class A
{
    public int x;
    public static int y;
    //Restante do código
}