using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace P1_LENGUAJES_FP
{
    class Automata
    {
        private String[] operadores = new String[] { "+", "-", "*", "/",
                       "<", ">", "!", "|", "&", "(", ")"};
        private String[] simbolo = new String[] { "=", ";" };
        private int estado = 0;
        private string tokensInicial;
        private string tokens = "";
        PintaTokens pintaT = new PintaTokens();

        public void obtenerEstado(KeyPressEventArgs e, RichTextBox rtbError)
        {
            Char tokenIngresado = e.KeyChar;

            for(int cont = 0; cont < pintaT.getOperadorSigno().Length; cont++)

            switch (estado)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                default:

                    break;
            }

        }

      
    }
}
