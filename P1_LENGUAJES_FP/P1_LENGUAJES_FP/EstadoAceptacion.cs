using System;
using System.Collections.Generic;
using System.Text;

namespace P1_LENGUAJES_FP
{
    class EstadoAceptacion  : Automata 
    {

        public void estadoB(Char token)
        {
            String tok = token.ToString();
            if (tok.Equals("0") || tok.Equals("1") || tok.Equals("2") || tok.Equals("3")
                || tok.Equals("4") || tok.Equals("5") || tok.Equals("6") || tok.Equals("7")
                || tok.Equals("8") || tok.Equals("9"))
            {
                estado = 1;
            }
            else
            {
                estado = 12;
            }
            
        }

        public void estadoD()
        {

        }

        public void estadoK()
        {

        }

    }
}
