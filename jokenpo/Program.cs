using System;

namespace jokenpo
{

    class program
    {
        static void Main(string[]args)
        {
            int jogador, cpu;
            int op;

            do
            {
                Console.WriteLine("JOKENPO");
                Console.WriteLine("1 - PEDRA");
                Console.WriteLine("2 - PAPEL");
                Console.WriteLine("3 - TESOURA");
                Console.WriteLine("ESCOLHA UMA OPCAO:");
                jogador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                switch (jogador)
                {
                    case 1:
                        Console.WriteLine("JOGADOR ESCOLHEU PEDRA\n");
                        break;
                    case 2:
                        Console.WriteLine("JOGADOR ESCOLHEU PAPEL\n");
                        break;
                    case 3:
                        Console.WriteLine("JOGADOR ESCOLHEU TESOURA\n");
                        break;
                    default:
                        Console.WriteLine("CÓDIGO INVÁLIDO");
                        break;
                }


                Random aleatório = new Random();
                cpu = aleatório.Next(1, 4); // ESCOLHE UM NUMERO ALEATÓRIO


                switch (cpu)
                {
                    case 1:
                        Console.WriteLine("CPU ESCOLHEU PEDRA\n");
                        break;
                    case 2:
                        Console.WriteLine("CPU ESCOLHEU PAPEL\n");
                        break;
                    case 3:
                        Console.WriteLine("CPU ESCOLHEU TESOURA\n");
                        break;
                    default:
                        Console.WriteLine("CÓDIGO INVÁLIDO");
                        break;
                }


                if (jogador == cpu)
                {
                    Console.WriteLine("EMPATE\n");
                }
                else if ((jogador == 1 && cpu == 3) || (jogador == 2 && cpu == 1) || (jogador == 3 && cpu == 2))
                {
                    Console.WriteLine(" JOGADOR VENCEU\n");
                }
                else
                {
                    Console.WriteLine("CPU VENCEU\n");
                }
                Console.WriteLine(" DIGITE 1 PARA CONTINUAR");
                Console.WriteLine(" DIGITE 2 PARA SAIR");
                op = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            } while (op == 1);


            Console.WriteLine(" JOGO ENCERRADO");

            Console.ReadKey();
        }


    }
}

   
