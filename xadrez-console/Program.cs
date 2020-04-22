using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.colocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.colocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tabuleiro);
                */
                PosicaoXadrez p = new PosicaoXadrez('c', 7);
                Console.WriteLine(p);
                Console.WriteLine(p.toPosicao());
            }
            catch (TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }


            Console.ReadKey();
        }
    }
}
