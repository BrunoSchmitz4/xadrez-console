using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Program
    {
        // Rei - K (King)
        // Rainha - Q (Quenn)
        // Cavalo - H (Horse)
        // Torre - T (Tower)
        // Bispo - B (Bishop)
        // Peão - P (Pawn)
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