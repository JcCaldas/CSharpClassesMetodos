Console.WriteLine("## Argumentos Nomeados ##\n");

Email email = new();

//modo padrão
email.Enviar("teste@email.com", "Urgente", "Reunião de Orçamento");

//Argumentos Nomeados
//não importa a ordem, desde que tenha o nome do parâmetro seguido de dois pontos (:).
email.Enviar(assunto: "Reunião de Orçamento", destino: "teste@email.com", titulo: "Urgente");

Console.ReadKey();

public class Email
{
    public void Enviar (string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo}\nAssunto: {assunto}");
    }
}