Console.WriteLine("## Propriedades ##\n");

Produto p1 = new();
p1.Nome = "caderno";
p1.Preco = 4.99;
//p1.Desconto = 0.05; //Somente leitura
//p1.PrecoFinal = p1.Preco - (p1.Preco * p1.Desconto); //Somente leitura
p1.EstoqueMinimo = 10;

p1.Exibir();


Console.ReadKey();

public class Produto
{
    //Atalho para criação de propriedade: prop + tab + tab
    /*Para a manipulação da propriedade, deve-se ultizar um
     campo de apoio, privado, do mesmo tipo. As boas práticas são para
    ultilizar o mesmo nome, porém com Camel Case.*/

    private string? nome;
    public string? Nome 
    {
        get { return nome.ToUpper(); } 
        set { nome = value; } 
    }
    
    private double preco;
    public double Preco 
    { 
        get { return preco; } 
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        } 
    }
    
    /*propriedade somente leitura, sendo impossível para
     o usuário definir um valor para ela*/
    private double desconto = 0.05;
    public double Desconto 
    { 
        get {return desconto; }
    }

     public double PrecoFinal 
    {
        get { return Preco - (Preco * Desconto); } 
    }

    private int estoqueMinimo;
    public int EstoqueMinimo 
    { 
        set { estoqueMinimo = value; } 
    }

    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome}\nPreço: {Preco.ToString("c")}\nDesconto: {Desconto}\nPreço Final: {PrecoFinal.ToString("c")}\nEstoque mínimo: {estoqueMinimo} unidades");
    }
}