using CarrosEnum;

Console.WriteLine("## Exercicio 10 ##\n");

Carro chevrolet = new();
chevrolet.Modelo = "Sedan";
chevrolet.Montadora = "Chevrolet";
chevrolet.Marca = "Onix";
chevrolet.Ano = 2016;
chevrolet.Potencia = 110;

Console.WriteLine("\nEscolha a cor do seu carro:");
Console.WriteLine("Não informar - 0");
Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
chevrolet.Cor = Convert.ToInt32(Console.ReadLine());

chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca, chevrolet.Potencia, chevrolet.Ano, chevrolet.Cor);
chevrolet.ExibirInfo(chevrolet.Modelo, chevrolet.Montadora, chevrolet.Marca, chevrolet.Potencia, chevrolet.Ano);
Console.WriteLine(Carro.ValorIpva);

Console.ReadKey();