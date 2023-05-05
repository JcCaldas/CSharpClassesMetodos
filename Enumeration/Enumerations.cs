using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration;

enum DiasDaSemana //O nome deve ser definido em Pascal Case
                  //Por padrão o Enum é int. Para definir outro tipo, deve-se declarar antes do nome.
{
    //Se não for definido um valor, por padrão seguem a seguinte ordem:
    Segunda, //valor padrão 0
    Terça, //valor padrão 1
    Quarta, //valor padrão 2
    Quinta, //valor padrão 3
    Sexta, //valor padrão 4
    Sábado, //valor padrão 5
    Domingo //valor padrão 6
}

enum DiasDaSemana2
{
    /*Se for atribuido um valor em qualquer membro,
     os membros após ele receberam o acrescimo de um no valor.*/
    Segunda, //valor padrão 0
    Terça, //valor padrão 1
    Quarta = 5, //5
    Quinta, //6
    Sexta, //7
    Sábado, //8
    Domingo //9
}

enum DiasDaSemana3
{
    /*Cada membro pode ter um valor definido
     manualmente*/
    Segunda = 10, //10
    Terça = 12, //12
    Quarta = 15, //15
    Quinta = 17, //17
    Sexta = 19, //19
    Sábado = 21, //21
    Domingo = 5 //5
}

enum Categorias
{
    Moda,
    Automotivo,
    Artes,
    Bebidas,
    Livros,
    Brinquedos
}

