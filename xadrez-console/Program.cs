﻿using System;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrex pos = new PosicaoXadrex('a', 1);

            Console.WriteLine(pos);
        }
    }
}