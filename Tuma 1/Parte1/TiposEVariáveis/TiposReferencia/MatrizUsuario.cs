using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariáveis.TiposReferencia
{
    //Você pode armazenar diversas variáveis do mesmo tipo em uma estrutura de dados de matriz. 
    //Você pode declarar uma matriz especificando o tipo de seus elementos. Se você quiser que a matriz armazene elementos de qualquer tipo, 
    //você pode especificar object como seu tipo. No sistema de tipos unificado do C#, todos os tipos, predefinidos e definidos pelo usuário, 
    //tipos de referência e tipos de valor, herdam direta ou indiretamente de Object.
    public class MatrizUsuario
    {
        static void Main()
        {
            int[] array1 = new int[5];//Matriz unidimensional
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            int[,] multiDimensionalArray1 = new int[2, 3];//Matriz de duas dimensões
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            //Uma matriz denteada é uma matriz cujos elementos são matrizes. 
            //Os elementos de uma matriz denteada podem ter diferentes dimensões e tamanhos. Às vezes, 
            //uma matriz denteada é chamada de uma "matriz de matrizes."
            int[][] jaggedArray = new int[6][];
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            //Exemplo de matriz com classe
            Usuario[] usuarios = new Usuario[5];//Matriz unidimensional de 5 usuários;
            usuarios[0] = new Usuario();
            usuarios[0].InterfaceInterna = new TesteInterfaceInterna();
            usuarios[0].InterfaceInterna.Roi();

            Usuario[] usuariosDeclarandoESetando = new Usuario[]
            {
                new Usuario(),
                new Usuario()
            };

            Usuario[] usuarioSintaxAlternativa =
            {
                new Usuario(),
                new Usuario()
            };

            Usuario[,] usuariosMultidimensional = new Usuario[1, 1];//Matriz Multidimensional
            usuariosMultidimensional[0,0] = new Usuario();
            usuariosMultidimensional[0,0].InterfaceInterna = new TesteInterfaceInterna();
            usuariosMultidimensional[0,0].InterfaceInterna.Roi();

            Usuario[,] usuariosMultidimensionalDeclarandoESetando = new Usuario[,]
            {
                { new Usuario() },
                { new Usuario() }
            };

            //Uma matriz denteada é uma matriz cujos elementos são matrizes. 
            //Os elementos de uma matriz denteada podem ter diferentes dimensões e tamanhos. Às vezes, 
            //uma matriz denteada é chamada de uma "matriz de matrizes."
            Usuario[][] usuariosMatrizDenteada = new Usuario[1][];
            usuariosMatrizDenteada[0] = usuarios;
        }
    }
}
