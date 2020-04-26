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

                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirTela(partida);
                        
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        Console.WriteLine();
                        bool[,] posicoesPossiveis = partida.Tab.RetornarPeca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }catch(TabuleiroException erro)
                    {
                        Console.WriteLine(erro.Message);
                        Console.ReadLine();
                    }
                    
                } 
                
            }
            catch (TabuleiroException erro)
            {
                Console.WriteLine(erro.Message);
            }


            Console.ReadKey();
        }
    }
}
