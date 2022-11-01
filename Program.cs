using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPoker
{
    class Program
    {
        static void Main(string[] args)
        {

            TelaCartas.LinhasCartas(0, 0);
            
            Carta carta = new Carta();
            carta.MeuValorO = Carta.VALOR.O;
            carta.MeuValorI = Carta.VALOR.I;
            carta.MeuValorII = Carta.VALOR.II;
            carta.MeuValorIII = Carta.VALOR.III;
            carta.MeuValorV = Carta.VALOR.V;
            carta.MeuValorVIII = Carta.VALOR.VIII;
            carta.MeuValorXIII = Carta.VALOR.XIII;
            carta.MeuValorXXI = Carta.VALOR.XXI;
            carta.MeuValorXXXIV = Carta.VALOR.XXXIV;
            carta.MeuValorLV = Carta.VALOR.LV;
            carta.MeuValorCAFE = Carta.VALOR.CAFE;
            carta.MeuValorDUVIDA = Carta.VALOR.DUVIDA;

            TelaCartas.DesenhoCartaValor(carta, 0, 0);

            Console.WriteLine("\n \n \n \n \n \n \n                   Escolha sua Carta!!!");

            Console.ReadKey();
        }
    }
}
