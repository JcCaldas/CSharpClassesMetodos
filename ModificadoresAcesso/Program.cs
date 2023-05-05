using ModificadoresAcesso;

Console.WriteLine("## Modificadores de acesso ##\n");

/*Os acessos a classe, a struct e ao enum estão
 * disponiveis pois os tipos estão no mesmo
 Assembly (mesmo projeto)*/

MinhaClasse minhaClasse = new MinhaClasse();
minhaClasse.MeuCampo;
minhaClasse.MinhaPropriedade;
minhaClasse.Meumetodo();

MinhaStruct minhaStruct = new MinhaStruct();
minhaStruct.MeuCampo;
minhaStruct.MinhaPropriedade;
minhaStruct.Meumetodo();

/*Os membros não são acessados
 pois estão com o modificador de acesso padrão
"private" e são acessados somente dentro da
classe e da struct*/

/*O tipo Enum é acessado pois o modificador de
 acesso é internal.*/
Console.WriteLine(MinhaEnum.opcao1);



Console.ReadKey();

