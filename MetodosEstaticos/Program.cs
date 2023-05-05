Console.WriteLine("## Métodos estáticos ##\n");


/*Nos métodos padrões as classes precisam de uma instância
 para acessar os métodos. São métodos de instância da Classe*/
Calculadora calc = new();

var soma = calc.Somar(10, 10);
var subtrair = calc.Subtrair(10, 10);
var multiplicar = calc.Multiplicar(10, 10);
var dividir = calc.Dividir(10, 10);

/*Quando é definido um método como estático, não precisa
 de instância para acessar o método. Basta ultilizar o nome
da classe. Os métodos estáticos não pertem ao objeto e sim
a classe.*/

var soma2 = Calculadora.Somar2(10, 10);
var subtrair2 = Calculadora.Somar2(10, 10);
var multiplicar2 = Calculadora.Somar2(10, 10);
var dividir2 = Calculadora.Somar2(10, 10);


Console.ReadKey();

public class Calculadora
{
    public int Somar (int n1, int n2)
    {
        return n1 + n2;
    }
    public int Subtrair (int n1, int n2)
    {
        return n1 - n2;
    }
    public int Multiplicar (int n1, int n2)
    {
        return n1 * n2;
    }
    public int Dividir (int n1, int n2)
    {
        return n1 / n2;
    }
    
    //MÉTODOS ESTÁTICOS
    /*Para definir um método como estático, basta
     coloca a palavra reservada "static" no método.
    antes ou depois do "public"*/
    public static int Somar2 (int n1, int n2)
    {
        return n1 + n2;
    }
    public static int Subtrair2 (int n1, int n2)
    {
        return n1 - n2;
    }
    public static int Multiplicar2 (int n1, int n2)
    {
        return n1 * n2;
    }
    public static int Dividir2 (int n1, int n2)
    {
        return n1 / n2;
    }
}