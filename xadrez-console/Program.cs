using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Program
    {
        // Rei - K (King) | - R (Rei)
        // Rainha - Q (Quenn) - D (Dama)
        // Cavalo - H (Horse) - C (Cavalo)
        // Torre - T (Tower) - T (Torre)
        // Bispo - B (Bishop) - B (Bispo)
        // Peão - P (Pawn) - P (Peão)
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while(!partida.terminada){
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("\nOrigem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();

                    Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch { }
            //Console.ReadLine();
        }
    }
}