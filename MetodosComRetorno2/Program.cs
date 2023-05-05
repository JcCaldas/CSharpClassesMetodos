Console.WriteLine("## Assinatura de método - Sobrecarga ##\n");

Email email = new Email();

/*Ao ultilizar o nome do método que tem a sobrecargar,
 o VS mostra as 4 sobrecargas.*/
email.Enviar("empresa.com.br");
email.Enviar("empresa.com.br", "assunto");
email.Enviar("empresa.com.br", 2000);
email.Enviar(200, "empresa.com.br");

Console.ReadKey();

public class Email
{
    //Mesmo nome de método, mas com diferenças nos parâmetros
    //1 parâmetro
    public void Enviar (string endereco)
    {
        Console.WriteLine($"\n{endereco}");
        Console.WriteLine("Assunto padrão");
    }
    //2 parâmetros
    public void Enviar (string endereco, string assunto)
    {
        Console.WriteLine($"\n{endereco}");
        Console.WriteLine($"{assunto}");
    }
    //2 parâmetos, com 1 sendo diferente do método anterior
    public void Enviar (string endereco, decimal valor)
    {
        Console.WriteLine($"\n{endereco}");
        Console.WriteLine("Prposta comercial");
        Console.WriteLine($"{valor}");
    }
    //2 parâmetros, iguais ao anterior, com ordem invertida
    public void Enviar (decimal valor, string endereco)
    {
        Console.WriteLine($"\n{endereco}");
        Console.WriteLine("Pagamento Fornecedor");
        Console.WriteLine($"{valor}");
    }
}