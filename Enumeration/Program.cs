
using Enumeration; //Como o enum está em um arquivo separado, usa-se o "using"

Console.WriteLine("## Enum ##\n");

Console.WriteLine("Pegando nome e valor");
Console.WriteLine(DiasDaSemana.Domingo); //Exibe o nome
Console.WriteLine(DiasDaSemana.Terça); //Exibe o nome

int dia1 = (int)DiasDaSemana.Domingo; //Para exibir o valor, deve-se fazer um cast par ao tipo do valor definido no enum
int dia2 = (int)DiasDaSemana.Terça; //Para exibir o valor, deve-se fazer um cast par ao tipo do valor definido no enum

Console.WriteLine($"\nDias da semana: {DiasDaSemana.Domingo} vale: {dia1}");
Console.WriteLine($"Dias da semana: {DiasDaSemana.Terça} vale: {dia2}");
Console.WriteLine($"\nDias da semana 2: {DiasDaSemana2.Domingo} vale: {(int)DiasDaSemana2.Domingo}");
Console.WriteLine($"Dias da semana2: {DiasDaSemana2.Terça} vale: {(int)DiasDaSemana2.Terça}");
Console.WriteLine($"\nDias da semana 3: {DiasDaSemana3.Domingo} vale: {(int)DiasDaSemana3.Domingo}");
Console.WriteLine($"Dias da semana3: {DiasDaSemana3.Terça} vale: {(int)DiasDaSemana3.Terça}");

Console.WriteLine("\nPegando nome a partir do valor");
Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Automotivo} - {(int)Categorias.Automotivo}");
Console.WriteLine($"{Categorias.Artes} - {(int)Categorias.Artes}");
Console.WriteLine($"{Categorias.Bebidas} - {(int)Categorias.Bebidas}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Brinquedos} - {(int)Categorias.Brinquedos}");

Console.WriteLine($"\nSelecione a Categoria teclando o seu valor:");
int valor = Convert.ToInt32(Console.ReadLine());

var nomeMembroEnum = (Categorias)valor; //Força o cast para o enum.
Console.WriteLine($"\nVocê selecionou a categoria: {nomeMembroEnum.ToString()}");


Console.ReadKey();

