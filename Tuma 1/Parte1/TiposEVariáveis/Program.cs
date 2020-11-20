using System;
using System.Runtime.CompilerServices;
using TiposEVariáveis.TiposReferencia;

namespace TiposEVariáveis
{
    enum diasDaSemana
    {
        domingo = 0,
        segunda,
        terça,
        quarta,
        quinta,
        sexta,
        sábado
    }

    struct Aluno
    {
        public string Nome;
        public int Idade;
        public float Nota;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de valor:
            //  Tipos simples:
            //      Signed integral: sbyte, short, int, long
            sbyte valorMaximoDeUmSByte = sbyte.MaxValue;
            sbyte valorMinimoDeUmSByte = sbyte.MinValue;
            Console.WriteLine("Valor máximo de um sbyte: {0}", valorMaximoDeUmSByte);
            Console.WriteLine("Valor mínimo de um sbyte: {0}", valorMinimoDeUmSByte);

            short valorMaximoDeUmShort = short.MaxValue;
            short valorMinimoDeUmShort = short.MinValue;
            Console.WriteLine("Valor máximo de um short: {0}", valorMaximoDeUmShort);
            Console.WriteLine("Valor mínimo de um short: {0}", valorMinimoDeUmShort);

            int valorMaximoDeUmInteiro = int.MaxValue;
            int valorMinimoDeUmInteiro = int.MinValue;
            Console.WriteLine("Valor máximo de um inteiro: {0}", valorMaximoDeUmInteiro);
            Console.WriteLine("Valor mínimo de um inteiro: {0}", valorMinimoDeUmInteiro);

            long valorMaximoDeUmLong = long.MaxValue;
            long valorMinimoDeumLong = long.MinValue;
            Console.WriteLine("Valor máximo de um long: {0}", valorMaximoDeUmLong);
            Console.WriteLine("Valor mínimo de um long: {0}", valorMinimoDeumLong);

            //      Unsigned integral: byte, ushort, uint, ulong
            byte valorMaximoByte = byte.MaxValue;
            byte valorMinimoByte = byte.MinValue;
            Console.WriteLine("Valor máximo de um byte: {0}", valorMaximoByte);
            Console.WriteLine("Valor mínimo de um byte: {0}", valorMinimoByte);

            ushort valorMaximoUShort = ushort.MaxValue;
            ushort valorMinimoUShort = ushort.MinValue;
            Console.WriteLine("Valor máximo de um ushort: {0}", valorMaximoUShort);
            Console.WriteLine("Valor mínimo de um ushort: {0}", valorMinimoUShort);

            uint valorMaximoUInt = uint.MaxValue;
            uint valorMinimoUInt = uint.MinValue;
            Console.WriteLine("Valor máximo de um uint: {0}", valorMaximoUInt);
            Console.WriteLine("Valor mínimo de um uint: {0}", valorMinimoUInt);

            ulong valorMaximoULong = ulong.MaxValue;
            ulong valorMinimoULong = ulong.MinValue;
            Console.WriteLine("Valor máximo de um ulong: {0}", valorMaximoULong);
            Console.WriteLine("Valor mínimo de um ulong: {0}", valorMinimoULong);

            //Inteiros Literais
            var inteiroLiteral = 1;
            var hexaDecimalLiteral = 0xF;
            var binarioLiteral = 0b_1110_0001_0000_1111;
            Console.WriteLine("inteiro literal: {0}", inteiroLiteral);
            Console.WriteLine("hexadecimal literal: {0}", hexaDecimalLiteral);
            Console.WriteLine("binário literal: {0}", binarioLiteral);

            //      Unicode characters: char, que representa uma unidade de código UTF-16
            char caracterRepresentandoALetraAMinuscula = 'a';
            Console.WriteLine("a: {0}", caracterRepresentandoALetraAMinuscula);

            //      IEEE binary floating-point: float, double
            float valorMaximoFloat = float.MaxValue;
            float valorMinimoFloat = float.MinValue;
            Console.WriteLine("Valor máximo de um float: {0}", valorMaximoFloat);
            Console.WriteLine("Valor mínimo de um float: {0}", valorMinimoFloat);

            double valorMaximoDouble = double.MaxValue;
            double valorMinimoDouble = double.MinValue;
            Console.WriteLine("Valor máximo de um double: {0}", valorMaximoDouble);
            Console.WriteLine("Valor mínimo de um double: {0}", valorMinimoDouble);

            //      High-precision decimal floating-point: decimal
            decimal valorMaximoDecimal = decimal.MaxValue;
            decimal valorMinimoDecimal = decimal.MinValue;
            Console.WriteLine("Valor máximo de um decimal: {0}", valorMaximoDecimal);
            Console.WriteLine("Valor mínimo de um decimal: {0}", valorMinimoDecimal);

            //      Boolean: bool, que representa valores Boolianos — valores que são true ou false
            bool representaValorBoolianoVerdadeiro = true;
            bool representaValorBoolianoFalso = false;
            Console.WriteLine("Valor booliano: {0}", representaValorBoolianoVerdadeiro);
            Console.WriteLine("Valor booliano: {0}", representaValorBoolianoFalso);

            //  Tipos de enumeração:
            //      Tipos definidos pelo usuário do formulário enum E {...} . 
            //      Um tipo enum é um tipo distinto com constantes nomeadas. 
            //      Cada tipo enum tem um tipo subjacente, que deve ser um dos oito tipos integrais. 
            //      O conjunto de valores de um tipo enum é o mesmo que o conjunto de valores do tipo subjacente.
            diasDaSemana domingo = diasDaSemana.domingo;
            diasDaSemana sábado = diasDaSemana.sábado;
            Console.WriteLine("domingo: {0}, valor: {1}", domingo, (int)domingo);
            Console.WriteLine("sábado: {0}, valor: {1}", sábado, (int)sábado);

            //  Tipos struct:
            //      Tipos definidos pelo usuário do formulário struct S {...}
            Aluno aluno;
            aluno.Nome = "Nome do aluno";
            aluno.Idade = 18;
            aluno.Nota = 5.5F;
            Console.WriteLine("Nome do aluno: {0}", aluno.Nome);
            Console.WriteLine("Idade do aluno: {0}", aluno.Idade);
            Console.WriteLine("Nota do aluno: {0}", aluno.Nota);


            //  Tipos de valor anuláveis:
            //      Extensões de todos os outros tipos de valor com um valor null
            sbyte? valorAnulavelDeUmSByte = null;
            Console.WriteLine("Valor máximo de um sbyte: {0}", valorAnulavelDeUmSByte);

            short? valorAnulavelDeUmShort = null;
            Console.WriteLine("Valor máximo de um short: {0}", valorAnulavelDeUmShort);

            int? valorAnulavelDeUmInteiro = null;
            Console.WriteLine("Valor máximo de um inteiro: {0}", valorAnulavelDeUmInteiro);

            long? valorAnulavelDeUmLong = null;
            Console.WriteLine("Valor máximo de um long: {0}", valorAnulavelDeUmLong);

            byte? valorAnulavelByte = null;
            Console.WriteLine("Valor máximo de um byte: {0}", valorAnulavelByte);

            ushort? valorAnulavelUShort = null;
            Console.WriteLine("Valor máximo de um ushort: {0}", valorAnulavelUShort);

            uint? valorAnulavelUInt = null;
            Console.WriteLine("Valor máximo de um uint: {0}", valorAnulavelUInt);

            ulong? valorAnulavelULong = null;
            Console.WriteLine("Valor máximo de um ulong: {0}", valorAnulavelULong);

            char? caracterRepresentandoALetraAMinusculaAnulavel = null;
            Console.WriteLine("a: {0}", caracterRepresentandoALetraAMinusculaAnulavel);

            float? valorAnulavelFloat = null;
            Console.WriteLine("Valor máximo de um float: {0}", valorAnulavelFloat);

            double? valorAnulavelDouble = null;
            Console.WriteLine("Valor máximo de um double: {0}", valorAnulavelDouble);

            decimal? valorAnulavelDecimal = null;
            Console.WriteLine("Valor máximo de um decimal: {0}", valorAnulavelDecimal);

            bool? representaValorBoolianoAnulavel = null;
            Console.WriteLine("Valor booliano: {0}", representaValorBoolianoAnulavel);

            diasDaSemana? domingoAnulavel = null;
            //Console.WriteLine("domingo: {0}, valor: {1}", domingoAnulavel, (int)domingoAnulavel);
            Console.WriteLine("domingo: {0}, valor: {1}", domingoAnulavel, (int)domingoAnulavel.GetValueOrDefault(0));
            //Ou
            Console.WriteLine("domingo: {0}, valor: {1}", domingoAnulavel, domingoAnulavel.HasValue ? (int)domingoAnulavel.Value : 0);

            Aluno? alunoAnulavel = null;
            //Console.WriteLine("Nome do aluno: {0}", alunoAnulavel.Value.Nome);
            Console.WriteLine("Nome do aluno: {0}", alunoAnulavel.GetValueOrDefault(aluno).Nome);
            //Console.WriteLine("Idade do aluno: {0}", alunoAnulavel.Value.Idade);
            Console.WriteLine("Idade do aluno: {0}", alunoAnulavel.GetValueOrDefault(aluno).Idade);
            // Console.WriteLine("Nota do aluno: {0}", alunoAnulavel.Value.Nota);
            Console.WriteLine("Nota do aluno: {0}", alunoAnulavel.GetValueOrDefault(aluno).Nota);


            //  Tipos de valor de tupla:
            //      Tipos definidos pelo usuário do formulário (T1, T2, ...)
            (double, double) valorDaTuplaDouble = (-1.0, 1.0);
            Console.WriteLine("Primeiro valor da tupla: {0}, segundo valor da tupla: {1}", valorDaTuplaDouble.Item1, valorDaTuplaDouble.Item2);

            var coordenadaCartesiana = (x: 1.0, y: 2.0);
            Console.WriteLine("Coordenada Cartesiana x: {0} e y:{1}", coordenadaCartesiana.x, coordenadaCartesiana.y);
            //Ou
            var (x1, y1) = (0.0, 0.0);
            Console.WriteLine("Coordenada Cartesiana x: {0} e y:{1}", x1, y1);

            new Usuario().TesteDelegado();
        }
    }
}
