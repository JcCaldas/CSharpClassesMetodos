Console.WriteLine("## Métodos e Parâmetros ##\n");

MinhaClasse nomeObjeto = new MinhaClasse();

//Invocação do método com parâmetros
/*A ordem que os parâmetros foram informados no
 método, é a ordem que devem ser declarados*/
nomeObjeto.Saudacao("Jessé", DateTime.Now.ToShortDateString());

//Podem ser ultilizadas variaveis de tipos compativeis
var nomeCliente = "João";
var dataAtual = DateTime.Now.ToShortDateString();
nomeObjeto.Saudacao(nomeCliente, dataAtual);

Console.ReadKey();

class MinhaClasse
{
    //Método definido com parâmetros
    public void Saudacao (string nome, string data)
    {
        Console.WriteLine($"Hoje é dia {data}.\nOlá {nome}!");
    }
}