using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariáveis.TiposReferencia
{
    //Uma interface define um contrato. Qualquer um class ou struct que implemente esse contrato deve fornecer uma implementação dos 
    //membros definidos na interface. A partir do C# 8,0, uma interface pode definir uma implementação padrão para membros. 
    //Ele também pode definir static Membros para fornecer uma única implementação para a funcionalidade comum.
    public interface IAcoesDoUsuario
    {
        //Uma interface pode ser membro de um namespace ou de uma classe. Uma declaração de interface pode conter declarações (assinaturas sem qualquer implementação) dos seguintes membros:

        //Métodos
        //Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o método e 
        //especificando os argumentos de método necessários. No C#, todas as instruções executadas são realizadas no contexto de um método. 
        //O Main método é o ponto de entrada para cada aplicativo C# e é chamado pelo Common Language Runtime (CLR) quando o programa é iniciado.
        //Os métodos são declarados em uma classe, structou interface especificando o nível de acesso, como public ou private , modificadores opcionais, 
        //como abstract ou sealed , o valor de retorno, 
        //o nome do método e qualquer parâmetro de método. Juntas, essas partes são a assinatura do método.
        string RetornarNome();
        void GravarNome(string nome);
        int RetornarCodigo();


        //Propriedades
        public int IdAcao { get; set; }

        //Indexadores
        public int[] ArrayIndexes { get; set; }
        public int this[int index]
        {
            get { return ArrayIndexes[index]; }
            set { ArrayIndexes[index] = value; }
        }
        //Eventos

    }
}
