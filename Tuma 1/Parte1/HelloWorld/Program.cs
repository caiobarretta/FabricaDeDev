using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explica comentário de uma linha
            /*
             * De 
             * várias 
             * linhas
             */
            Console.WriteLine("Hello, World!");
            //ou concatenando
            Console.WriteLine("Hello, " + "World!");
            // ou passando como parametro
            Console.WriteLine("Hello, {0}", "World!");
            //ou
            Console.WriteLine("{0}, {1}", "Hello", "World!");
        }
    }
}
