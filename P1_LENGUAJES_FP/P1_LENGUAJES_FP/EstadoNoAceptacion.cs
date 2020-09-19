using System;
using System.Collections.Generic;
using System.Text;

namespace P1_LENGUAJES_FP
{
    class EstadoNoAceptacion : Automata
    {

        public void estadoA(Char token)
        {
            String tok = token.ToString();
            if (tok.Equals("0") || tok.Equals("1") || tok.Equals("2") || tok.Equals("3") 
                || tok.Equals("4") || tok.Equals("5") || tok.Equals("6") || tok.Equals("7")
                || tok.Equals("8") || tok.Equals("9"))
            {
                estado = 1;
            }
        }



        public void estadoC()
        {

        }



        public void estadoE()
        {

        }

        public void estadoF()
        {

        }

        public void estadoG()
        {

        }

        public void estadoH()
        {

        }

        public void estadoI()
        {

        }

        public void estadoJ()
        {

        }



        public void estadoL()
        {

        }

    }
}
