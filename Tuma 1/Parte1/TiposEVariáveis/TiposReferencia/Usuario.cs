using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposEVariáveis.TiposReferencia
{
    enum PerfilUsuario
    {
        Administrador = 1,
        Funcionario,
        Gerente
    }
    struct StructInterna : InterfaceInterna
    {
        public void Roi() => Console.WriteLine("Roi");
    }
    interface InterfaceInterna
    {
        void Roi();
    }
    class TesteInterfaceInterna : InterfaceInterna
    {
        public void Roi() => Console.WriteLine("Roi");
    }
    class ClasseInternaUsuario
    {
        public void Roi() => Console.WriteLine("Roi");
    }
    //public class Usuario
    //internal class Usuario
    class Usuario
    {
        //Os membros da classe, incluindo classes aninhadas, podem ser públicos, internos protegidos, 
        //protegidos, internos, privados ou protegidos privados. Os membros são private por padrão.
        //Uma classe pode conter declarações dos seguintes membros:
        //Construtores
        public Usuario()
        {

        }
        //Constantes
        public const int CodigoPerfil = 1;

        //Fields
        private string tipoUsuario;
        public int codigoTipoUsuario;//Não recomendado (É recomendado encapsular em uma propriedade)

        //Finalizadores
        ~Usuario() // Utilizado geralmente no consumo de recursos externos não gerenciados pelo CLR
        {

        }

        //Métodos
        //Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o método e 
        //especificando os argumentos de método necessários. No C#, todas as instruções executadas são realizadas no contexto de um método. 
        //O Main método é o ponto de entrada para cada aplicativo C# e é chamado pelo Common Language Runtime (CLR) quando o programa é iniciado.
        //Os métodos são declarados em uma classe, structou interface especificando o nível de acesso, como public ou private , modificadores opcionais, 
        //como abstract ou sealed , o valor de retorno, 
        //o nome do método e qualquer parâmetro de método. Juntas, essas partes são a assinatura do método.
        public void RetornaCodigoUsuario() { }
        public void RetornaCodigoUsuario(int codigoPerfil) { }

        protected void SalvaUsuario() { }//Somenete classes derivadas podem chamar o método

        public virtual void SalvaUsuario(int codigoUsuario) { }//Classes derivadas podem sobreescrever a implementação

        //Propriedades
        public int MyProperty { get; set; }

        //Indexadores
        //Os indexadores permitem que instâncias de uma classe ou struct sejam indexados como matrizes. 
        //O valor indexado pode ser definido ou recuperado sem especificar explicitamente um membro de instância ou tipo. 
        //Os indexadores parecem com propriedades, a diferença é que seus acessadores usam parâmetros.

        //Declara um array para armazenar os dados do elemento
        private int[] ArrayDeInteiros = new int[100];

        //Define o indexador para allow a utilizacao de [] na notação
        public int this[int index]
        {
            get { return ArrayDeInteiros[index]; }
            set { ArrayDeInteiros[index] = value; }
        }

        //Exemplo em um método

        public void AdicionaInteiro(int index)
        {
            var usuarios = new Usuario();
            usuarios[0] = 1;
            Console.WriteLine("usuarios[0]:" + usuarios[0]);
        }


        //Operadores
        //O C# fornece vários operadores. Muitos deles têm suporte dos tipos internos e permitem que você execute operações básicas com valores desses tipos. 
        //Esses operadores incluem os seguintes grupos:
        //Operadores aritméticos que executam operações aritméticas com operandos numéricos
        //Operadores de comparação que comparam operandos numéricos
        //Operadores lógicos boolianos que executam operações lógicas com bool operandos
        //Operadores de tecla e bit de alternância que executam operações de bit ou de Shift com operandos dos tipos integrais
        //Operadores de igualdade que verificam se os operandos são iguais ou não

        //exemplos de expressões estão no lado direito das atribuições:
        public void ExemploDeExpressoesEAtribuicoes()
        {
            int a, b, c;
            a = 7;
            b = a;
            c = b++;
            b = a + b * c;
            c = a >= 100 ? b : c / 10;
            a = (int)Math.Sqrt(b * b + c * c);

            string s = "String literal";
            char l = s[s.Length - 1];

            var numbers = new List<int>(new[] { 1, 2, 3 });
            b = numbers.FindLast(n => n > 1);

            //Expressões de cadeia de caracteres interpoladas que 
            //fornecem uma sintaxe conveniente para criar cadeias formatadas:
            var r = 2.3;
            var message = $"The area of a circle with radius {r} is {Math.PI * r * r:F3}.";
            Console.WriteLine(message);

            //Expressões lambda que permitem criar funções anônimas:
            int[] numbers2 = { 2, 3, 4, 5 };
            var maximumSquare = numbers2.Max(x => x * x);
            Console.WriteLine(maximumSquare);

            //Expressões de consulta que permitem que você use recursos de consulta diretamente em C#:
            var scores = new[] { 90, 97, 78, 68, 85 };
            IEnumerable<int> highScoresQuery =
                from score in scores
                where score > 80
                orderby score descending
                select score;
            Console.WriteLine(string.Join(" ", highScoresQuery));

            //Precedência do operador
            //Em uma expressão com vários operadores, os operadores com maior precedência são avaliados antes dos operadores com menor precedência. 
            //No exemplo a seguir, a multiplicação é executada primeiro porque tem uma precedência mais alta do que a adição:
            var a1 = 2 + 2 * 2;
            Console.WriteLine(a1); //  output: 6

            //Use parênteses para alterar a ordem de avaliação imposta pela precedência do operador:
            var a3 = (2 + 2) * 2;
            Console.WriteLine(a); //  output: 8

        }

        //Eventos
        //Visão geral sobre eventos
        //Os eventos têm as seguintes propriedades:
        //O editor determina quando um evento é acionado. Os assinantes determinam a ação que é executada em resposta ao evento.
        //Um evento pode ter vários assinantes. Um assinante pode manipular vários eventos de vários publicadores.
        //Eventos que não têm assinantes nunca são acionados.
        //Normalmente, os eventos são usados para sinalizar ações do usuário, como cliques de botão ou seleções de menu em interfaces gráficas do usuário.
        //Quando um evento tem vários assinantes, os manipuladores de eventos são invocados sincronicamente quando um evento é acionado. Para invocar eventos de forma assíncrona, consulte Chamando métodos síncronos assincronamente.
        //Na biblioteca de classes .NET, os eventos são baseados no EventHandler delegado e na EventArgs classe base.
        //Criar aplicação Desktop para exemplificar melhor

        //Delegados
        //Um delegado é um tipo que representa referências aos métodos com lista de parâmetros e tipo de retorno específicos. 
        //Ao instanciar um delegado, você pode associar sua instância a qualquer método com assinatura e tipo de retorno compatíveis. 
        //Você pode invocar (ou chamar) o método através da instância de delegado.
        //Delegados são usados para passar métodos como argumentos a outros métodos. 
        //Os manipuladores de eventos nada mais são do que métodos chamados por meio de delegados. Ao criar um método personalizado, 
        //uma classe como um controle do Windows poderá chamá-lo quando um determinado evento ocorrer. O seguinte exemplo mostra uma declaração de delegado:
        public delegate void MeuDelegado();

        public void OlaMundo() => Console.WriteLine("Ola mundo");
        public void TesteDelegado()
        {
            var delegado = new MeuDelegado(OlaMundo);
            delegado();
        }

        //Classes
        //O Facade é um padrão de projeto estrutural que fornece uma interface simplificada (mas limitada) para um sistema complexo de classes, 
        //biblioteca, ou framework. Embora o Facade diminua a complexidade geral do aplicativo, também ajuda a mover dependências indesejadas para um só local.
        //Explicar implementação padão Facade
        //Identificação: O Facade pode ser reconhecido em uma classe que possui uma interface simples, 
        //mas delega a maior parte do trabalho para outras classes. Geralmente, as fachadas gerenciam 
        //o ciclo de vida completo dos objetos que usam.
        //Exemplos de uso: O padrão Facade é comumente usado em aplicações escritas em C#. 
        //É especialmente útil ao trabalhar com bibliotecas e APIs complexas.
        private ClasseInternaUsuario ClasseInternaUsuario { get; set; }
        public void TesteClasseInterna()
        {
            Usuario usuario = new Usuario();
            usuario.ClasseInternaUsuario = new ClasseInternaUsuario();
            usuario.ClasseInternaUsuario.Roi();
        }

        //Interfaces
        //Uma interface contém definições para um grupo de funcionalidades relacionadas que uma classe não abstrata ou uma struct deve implementar. 
        //Uma interface pode definir static métodos, que devem ter uma implementação. A partir do C# 8,0, uma interface pode definir uma implementação 
        //padrão para membros. Uma interface não pode declarar dados de instância, como campos, 
        //propriedades implementadas automaticamente ou eventos de propriedade.
        //Usando interfaces, você pode, por exemplo, incluir o comportamento de várias fontes em uma classe. 
        //Essa funcionalidade é importante em C# porque a linguagem não dá suporte a várias heranças de classes. 
        //Além disso, use uma interface se você deseja simular a herança para structs, pois eles não podem herdar de outro struct ou classe.
        public InterfaceInterna InterfaceInterna { get; set; }
        public void TesteInterfaceInterna()
        {
            Usuario usuario = new Usuario();
            usuario.InterfaceInterna = new TesteInterfaceInterna();
            usuario.InterfaceInterna.Roi();
        }
        //Resumo de interfaces
        //Normalmente, uma interface é como uma classe base abstrata com apenas membros abstratos. Qualquer classe ou struct que implementa a interface 
        //deve implementar todos os seus membros. Opcionalmente, uma interface pode definir implementações padrão para alguns ou todos os seus membros. 
        //Uma interface não pode ser instanciada diretamente. Seus membros são implementados por qualquer classe ou struct que implemente a interface.
        //Uma classe ou struct pode implementar várias interfaces. Uma classe pode herdar uma classe base e também implementar uma ou mais interfaces.


        //Tipos de estrutura
        //Um tipo de estrutura (ou tipo de struct) é um tipo de valor que pode encapsular dados e funcionalidade relacionada. 
        public StructInterna StructInterna { get; set; }
        public void TesteStructInterna()
        {
            var usuario = new Usuario();
            usuario.StructInterna = new StructInterna();
            usuario.StructInterna.Roi();
        }

        //Tipos de enumeração
        //Um tipo de enumeração (ou tipode enumeração) é um tipo de valor definido por um conjunto de constantes nomeadas do tipo numérico integral subjacente.
        public PerfilUsuario PerfilDoUsuario { get; set; }

    }
}
