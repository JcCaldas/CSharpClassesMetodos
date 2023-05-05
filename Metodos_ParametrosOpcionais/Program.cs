Console.WriteLine("## Parâmetros Opcionais ##\n");

Console.WriteLine("Informe o destino:");
var destino = Console.ReadLine();

Console.WriteLine("Informe o título:");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto:");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar(destino);
email.Enviar(destino, assunto: assunto);
email.Enviar(destino, titulo);
email.Enviar(assunto: assunto, titulo: titulo, destino: destino);




Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"\nPara {destino} - {titulo}\nAssunto: {assunto}");
    }
}