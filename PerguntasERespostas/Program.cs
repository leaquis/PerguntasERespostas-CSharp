using System;

namespace PerguntasERespostas
{
    class Program
    {
       static void Main(string[] Args)
        {
            int pontuacao = 0;
            int resposta1;
            int resposta2;
            string resposta3;
            string resposta4;

            Console.WriteLine("Quanto é 5 + 5?\nEscreva sua resposta abaixo:");
            resposta1 = Convert.ToInt32(Console.ReadLine());
            if (resposta1 == 10) 
            {
                pontuacao++;
                Console.WriteLine("Parabens, você acertou!!");
            } else
            {
                Console.WriteLine("Você Errou!!");
            }

            Console.WriteLine("Quanto é 10 + 5?\nEscreva sua resposta abaixo:");
            resposta2 = Convert.ToInt32(Console.ReadLine());
            if (resposta2 == 15)
            {
                pontuacao++;
                Console.WriteLine("Parabens, você acertou!!");
            }
            else
            {
                Console.WriteLine("Você Errou!!");
            }

            Console.WriteLine("Quem é o fundador da Microsoft?\nEscreva sua resposta abaixo:");
            resposta3 = Console.ReadLine();
            if (resposta3 == "Bill Gates")
            {
                pontuacao++;
                Console.WriteLine("Parabens, você acertou!!");
            }
            else
            {
                Console.WriteLine("Você Errou!!");
            }

            Console.WriteLine("Qual é o esporte mais famoso do Brasil?\nEscreva sua resposta abaixo:");
            resposta4 = Console.ReadLine();
            if (resposta4 == "Futebol")
            {
                pontuacao++;
                Console.WriteLine("Parabens, você acertou!!");
            }
            else
            {
                Console.WriteLine("Você Errou!!");
            }

            Console.WriteLine("A sua pontuação final foi: " + pontuacao);
        } 
    }
}
