using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPoker
{
    class TelaCartas
    {
        //Linhas exibição cartas
        public static void LinhasCartas (int xcoor, int ycoor)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            int x = xcoor * 12;
            int y = ycoor;  

            Console.SetCursorPosition(x, y);
            Console.Write(" __________\n"); //Superior Borda Carta

            for (int i = 0; i < 7; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 6)
                    Console.WriteLine("|          |"); //Esquerda e Direta Carta
                else
                    Console.WriteLine("|__________|"); //Inferior Carta

            }
        }
        public static void DesenhoCartaValor(Carta carta, int xcoor, int ycoor)
        {
            //char CartaSimbolo = ' ';
            int x = xcoor * 12;
            int y = ycoor;

            //Imprimir valor e simbolo na carta
            //CartaSimbolo = Encoding.GetEncoding(437).GetChars(new byte[] { 1 })[0];
            //Console.ForegroundColor = ConsoleColor.White;

            //Console.SetCursorPosition(x + 5, y + 5);
            //Console.Write(CartaSimbolo);
            Console.SetCursorPosition(x + 5, y + 4);
            Console.Write(carta.MeuValorO);

            Console.SetCursorPosition(x + 20, y + 4);
            Console.Write(carta.MeuValorI);

            Console.SetCursorPosition(x + 35, y + 4);
            Console.Write(carta.MeuValorII);

            Console.SetCursorPosition(x + 50, y + 4);
            Console.Write(carta.MeuValorIII);



            Console.SetCursorPosition(x + 6, y + 12);
            Console.Write(carta.MeuValorV);

            Console.SetCursorPosition(x + 19, y + 12);
            Console.Write(carta.MeuValorVIII);

            Console.SetCursorPosition(x + 34, y + 12);
            Console.Write(carta.MeuValorXIII);

            Console.SetCursorPosition(x + 50, y + 12);
            Console.Write(carta.MeuValorXXI);



            Console.SetCursorPosition(x + 5, y + 20);
            Console.Write(carta.MeuValorXXXIV);

            Console.SetCursorPosition(x + 20, y + 20);
            Console.Write(carta.MeuValorLV);

            Console.SetCursorPosition(x + 34, y + 20);
            Console.Write(carta.MeuValorCAFE);

            Console.SetCursorPosition(x + 48, y + 20);
            Console.Write(carta.MeuValorDUVIDA);
        }
    }
}
