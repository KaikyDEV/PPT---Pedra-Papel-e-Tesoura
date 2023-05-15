using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedrapapeltesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
                                                                                                
            int mao, mao2;
            string repetir;
            repetir = "s";
            string joga1, joga2;

            Console.WriteLine("Olá. Seja bem vindo!!");
            Console.Write("\n Digite o seu nome: ");
            joga1 = Console.ReadLine();

            Console.Write("\n Digite o nome do segundo jogador: ");
            joga2 = Console.ReadLine();


            while(repetir.ToLower() == "s")
            {
                Console.WriteLine("Primeiro jogador, Escolha entre: \n 1 - Pedra \n 2 - Papel \n 3 - Tesoura");
                mao = int.Parse(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("\nSegundo jogador, Escolha entre: \n 1 - Pedra \n 2 - Papel \n 3 - Tesoura");
                mao2 = int.Parse(Console.ReadLine());

                Console.Clear();

                if (mao == 1 && mao2 == 2) Console.WriteLine("Jogador dois ganhou");
                else if (mao == 1 && mao2 == 3) Console.WriteLine("Jogador um ganhou");
                else if (mao == 2 && mao2 == 1) Console.WriteLine("Jogador um ganhou");
                else if (mao == 3 && mao2 == 2) Console.WriteLine("Jogador um ganhou");
                else if (mao == 2 && mao2 == 3) Console.WriteLine("Jogador dois ganhou");
                else if (mao == 3 && mao2 == 1) Console.WriteLine("Jogador dois ganhou");
                else if (mao == 2 && mao2 == 1) Console.WriteLine("Jogador dois ganhou");
                else if (mao == 3 && mao2 == 3) Console.WriteLine("Empate");
                else if (mao == 2 && mao2 == 2) Console.WriteLine("Empate");
                else if (mao == 1 && mao2 == 1) Console.WriteLine("Empate");

                    else { Console.WriteLine("Opção inválida"); }

                Console.WriteLine("Vocês querem repetir o processo?");
                repetir = Console.ReadLine();   

            }while(repetir.ToLower() == "s")    

            Console.ReadKey();
        }
    }
}
