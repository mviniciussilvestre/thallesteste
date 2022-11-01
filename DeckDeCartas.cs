using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPoker
{
    class DeckDeCartas : Carta
    {
        const int NUM_DE_CARTAS = 12; //Numero de Cartas
        private Carta[] deck; //Matriz com todas as Cartas

        public DeckDeCartas()
        {
            deck = new Carta[NUM_DE_CARTAS];
        }

        public Carta[] getDeck {  get { return deck; } }  //Pega carta
        
        //Criar deck
        public void ConfiguraDeck()
        {
            int i = 0;
            foreach(VALOR v in Enum.GetValues(typeof(VALOR)))
            {
                deck[i] = new Carta { MeuValorO = v };
                i++;
            }
        }
    }
}
