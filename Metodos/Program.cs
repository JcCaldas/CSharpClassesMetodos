Console.WriteLine("## Métodos ##\n");

MinhaClasse objetoClasse = new MinhaClasse();

objetoClasse.Saudacao();



Console.ReadKey();


class MinhaClasse
{
    /*Se o modificador não estiver definido como "public",
     o método fica privado, não podendo ser ultilizado por
    objetos fora da classe.*/

    public void Saudacao()
    {

        Console.WriteLine("Bem-Vindo");
        ExibirDataAtual();
    }

    /*Quando um método só tem uma linha de código, pode-se
     ultilizar "=>" ou invés de chaves ({ }), para ficar
    mais compacta.*/
    public void ExibirDataAtual() =>
        Console.WriteLine(DateTime.Now.ToShortDateString());
}