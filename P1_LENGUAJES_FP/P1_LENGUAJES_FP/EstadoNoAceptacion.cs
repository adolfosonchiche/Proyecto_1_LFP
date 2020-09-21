using System;
using System.Collections.Generic;
using System.Text;

namespace P1_LENGUAJES_FP
{
    class EstadoNoAceptacion : Automata
    {

        public int estadoA(Char token)
        {
            tok = token.ToString();
            if (tok.Equals("0") || tok.Equals("1") || tok.Equals("2") || tok.Equals("3") 
                || tok.Equals("4") || tok.Equals("5") || tok.Equals("6") || tok.Equals("7")
                || tok.Equals("8") || tok.Equals("9"))
            {
                return 1;
            }
            else if (tok.Equals("\""))
            {
                return 7;
            }
            else if (tok.Equals("/"))
            {
                return 4;
            }
            else 
            {
                errorToken = false;
                return 3;
            }
        }



        public int estadoC(Char token)
        {
            tok = token.ToString();
            if (tok.Equals("0") || tok.Equals("1") || tok.Equals("2") || tok.Equals("3")
                || tok.Equals("4") || tok.Equals("5") || tok.Equals("6") || tok.Equals("7")
                || tok.Equals("8") || tok.Equals("9"))
            {
                errorToken = true;
                return 1;
            }
            else if (tok.Equals("."))
            {
                errorToken = true;
                puntoEstadoB++;
                return 2;
            }
            else
            {
                errorToken = true;
                return 2;
            }
        }

        public int estadoE(Char token)
        {
            tok = token.ToString();
            if (tok.Equals("/"))
            {
                errorToken = true;
                return 8;
            }
            else if (tok.Equals("*"))
            {
                errorToken = true;
                return 9;
            }
             else 
            {
                errorToken = true;
                return 4;
            }
        }

        public int estadoF(Char token)
        {
            tok = token.ToString();
            if (tok.Equals("*"))
            {
                cadCom = 1;
                errorToken = true;
                return 11;
            }
            else
            {
                errorToken = true;
                return 5;
            }
        }

        public int estadoG(Char token)
        {
            tok = token.ToString();
            if (tok.Equals("\""))
            {
                cadCom = 0;
                errorToken = false;
                return 3;
            }           
            else
            {
                errorToken = true;
                return 6;
            }
        }

        public int estadoH(Char token)
        {
                errorToken = true;
                return 6;        
        }

        public int estadoI(Char token)
        {
            errorToken = false;
            return 10;
        }

        public int estadoJ(Char token)
        {
            errorToken = true;
            return 5;
        }



        public int estadoL(Char token)
        {
            tok = token.ToString();
            if (tok.Equals("/"))
            {
                cadCom = 1;
                errorToken = false;
                return 3;
            }
            else
            {
                errorToken = true;
                return 11;
            }
        }

    }
}
