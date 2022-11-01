using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningPoker
{
    class Carta
    {
        

        public enum VALOR
        {
            O=0, I, II, III, V, VIII, XIII, XXI,
            XXXIV, LV , DUVIDA , CAFE
        }

        //Propriedades
        public VALOR MeuValorO { get; set; }
        public VALOR MeuValorI { get; set; }
        public VALOR MeuValorII { get; set; }
        public VALOR MeuValorIII { get; set; }
        public VALOR MeuValorV { get; set; }
        public VALOR MeuValorVIII { get; set; }
        public VALOR MeuValorXIII { get; set; }
        public VALOR MeuValorXXI { get; set; }
        public VALOR MeuValorXXXIV { get; set; }
        public VALOR MeuValorLV { get; set; }
        public VALOR MeuValorCAFE { get; set; }
        public VALOR MeuValorDUVIDA { get; set; }





    }
}
