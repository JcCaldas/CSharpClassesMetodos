Console.WriteLine("## Tratamento de erros ##\n");

Console.WriteLine("Divisão de números inteiros");
Console.WriteLine("x / y");

Console.WriteLine("\nInforme o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nInforme o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());


/*Sem o bloco try-catch-finally, se houver algum erro (exemplo de divisão por 0)
 o programa para a execução. Com o bloco try-catch, o erro é tratado e 
retorna o que for definido, sem para a execução do programa.

 Ao executar esse bloco, o programa tenta a execução no try, se não consegui
entra no catch, para tratar a excessão, e após executa o bloco finally.
Caso o bloco try seja bem sucedido, o programa pula imediatamento para o bloco
finally, sem executar o bloco catch.*/


try
{
    int resultado = x / y;
    Console.WriteLine($"\n{x} / {y} = {resultado}");
}
/*Para acessar as propriedades da excessão, deve-se criar uma variavel do tipo
 "Exception" que acessará a mensagem de erro e os detalhes do erro.*/
catch (Exception ex)
{
    Console.WriteLine("\nNão existe divisão por zero. Tente outro número...");
    Console.WriteLine($"\nErro: {ex.Message}");//Mensagem do erro
    Console.WriteLine($"\nDetalhes: {ex?.StackTrace?.ToString()}");//Detalhes do erro.
    /*Com esse operador condicional nulo (?), se "ex" for avaliado como nulto, o resultado de
     toda a expressão será null. Se "ex" não for null, ele irá avaliar o "StackTrace", se ele for
    null, o restante também será. Ou seja, o primeiro null que for encontrada, definirá se a expressão
    será null ou não.*/
}
finally
{
    Console.WriteLine("\nProcessamento concluido...");
}

Console.ReadKey();