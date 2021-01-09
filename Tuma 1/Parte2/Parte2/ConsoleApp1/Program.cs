using ConsoleApp1.enums;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Parte2 do curso.");
            //Estruturas de seleção/decisão
            //Console.WriteLine("Entre com sua idade:");
            //var idade = Console.ReadLine();
            //ProcessaIdade(idade);

            //Console.WriteLine("Entre com seu signo:");
            //var signo = Console.ReadLine();
            //ProcessaSigno(signo);

            //Estruturas de repetição.
            Console.WriteLine("Programa que lê signos.");
            bool continuar;
            do
            {
            //while (continuar)
            //{
                //string[] vetorSigno = new string[2];
                List<string> listSignos = new List<string>();
                Console.WriteLine("Entre com seu SOL:");
                var sol = Console.ReadLine();
                listSignos.Add(sol);
                //vetorSigno[0] = sol;
                Console.WriteLine("Entre com sua LUA:");
                var lua = Console.ReadLine();
                listSignos.Add(lua);
                //vetorSigno[1] = lua;
                //for (int i = 0; i < vetorSigno.Length; i++)
                //{
                //    try
                //    {
                //        ProcessaSigno(vetorSigno[i]);
                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine(ex.Message);
                //    }
                //}
                foreach (var signo in listSignos)
                {
                    try
                    {
                        ProcessaSigno(signo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine("Deseja digitar seu signo novamente? S/N");
                var usuarioDesejaContinuar = Console.ReadLine();
                if (usuarioDesejaContinuar.ToUpper() == "N")
                {
                    continuar = false;
                }
                else
                {
                    continuar = true;
                }
                //}
            } while (continuar);
            Console.WriteLine("Fim do programa");
        }



        private static void ProcessaSigno(string signo)
        {
            //if (signo.ToUpper() == "PEIXES")
            //{
            //    Console.WriteLine("Signo TOP!");
            //}
            //else if (signo.ToUpper() == "ARIES")
            //{
            //    Console.WriteLine("Signo zoado!!! XP");
            //}
            //else
            //{
            //    Console.WriteLine("Signo meia bomba.");
            //}

            var signoFoiConvertido = Enum.TryParse(signo, true, out Signo signoConvertido);
            if (!signoFoiConvertido)
                throw new ArgumentException("Signo inválido!");

            switch (signoConvertido)
            {
                case Signo.Áries:
                    Console.WriteLine("Nascer com o Sol em Áries, significa ter personalidade forte, ser impulsivo e por ser o primeiro do zodíaco, tem a força de iniciar projetos e se lançar sem medo na vida.");
                    break;
                case Signo.Touro:
                    Console.WriteLine("Sol em Touro significa ser muito paciente, ter bom gosto e são sensuais. Normalmente trabalham duro e valorizam segurança, prazer e conforto.");
                    break;
                case Signo.Gêmeos:
                    Console.WriteLine("Quem nasce com o Sol em Gêmeos é uma pessoa comunicativa, inteligente, curiosa e tem o desejo de ser livre. Fazem amizade com facilidade e sabem falar sobre tudo.");
                    break;
                case Signo.Câncer:
                    Console.WriteLine("Sol em Câncer significa ser sensível, carinhoso, amoroso e intuitivo. São bem ligados à família e ao lar, precisam sentir-se seguros para se abrirem.");
                    break;
                case Signo.Leão:
                    Console.WriteLine("Quem nasce com o Sol em Leão é corajoso, leal, criativo, tem autoestima e gosta de ser o centro das atenções. São em geral muito otimistas e generosos.");
                    break;
                case Signo.Virgem:
                    Console.WriteLine("O Sol em Virgem significa ser uma pessoa metódica, que gosta de organização e objetividade. São pessoas que levam ordem aonde tem caos e nenhum detalhe passa despercebido.");
                    break;
                case Signo.Libra:
                    Console.WriteLine("Ter o Sol em Libra significa ser cortês, delicado, equilibrado e buscam ter relacionamentos harmoniosos e pacíficos.");
                    break;
                case Signo.Escorpião:
                    Console.WriteLine("Os nativos que nascem com o Sol em Escorpião são pessoas intensas, misteriosas, magnéticas e com muito poder de transformação.");
                    break;
                case Signo.Sagitário:
                    Console.WriteLine("Sol em Sagitário significa ser otimista, aventureiro, livre, viajante e jovial. Gostam de conhecer coisas novas e filosofar sobre a vida.");
                    break;
                case Signo.Capricórnio:
                    Console.WriteLine("Nascer com o Sol em Capricórnio significa ter persistência, força física, responsabilidade e ser trabalhador. Gostam de ter metas e buscam ascensão social.");
                    break;
                case Signo.Aquário:
                    Console.WriteLine("Quem nasce com o Sol em Aquário é uma pessoa humanitária, criativa, independente e que busca liberdade.");
                    break;
                case Signo.Peixes:
                    Console.WriteLine("Ter o Sol em Peixes significa ter sensibilidade, percepção, intuição e solidariedade. São muito sonhadores e têm forte conexão com a espiritualidade.");
                    break;
                default:
                    Console.WriteLine("Signo: {0} não é válido", signoConvertido);
                    break;
            }

        }

        private static void ProcessaIdade(string idade)
        {
            var foiConvertido = int.TryParse(idade, out int conversaoIdade);

            if (!foiConvertido)
            {
                throw new ArgumentException("O valor da idade deve ser numérico.");
            }
            else
            {
                var anoDeNascimento = DateTime.Now.Year - conversaoIdade;
                Console.WriteLine("Seu ano de nascimento é: {0}", anoDeNascimento);
            }
        }
    }
}
