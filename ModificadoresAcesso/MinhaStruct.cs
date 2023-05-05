using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcesso;


//Modificador de acesso padrão de criação é internal
internal struct MinhaStruct
{
    /*Quando não é definido um modificador de acesso,
     todos os membros criados recebem o modificador de
    acesso "private", ficando visiveis apenas nessa classe*/
    int MeuCampo;

    string? MinhaPropriedade { get; set; }

    void MeuMetodo()
    {
        Console.WriteLine("Meu Método");
    }
}
