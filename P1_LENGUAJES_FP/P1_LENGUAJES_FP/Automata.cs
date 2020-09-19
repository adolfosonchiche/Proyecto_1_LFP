using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace P1_LENGUAJES_FP
{
    class Automata
    {
        private EstadoAceptacion aceptacion;
        private EstadoNoAceptacion noAceptacion;
        protected static int estado = 0;
        protected Boolean estadoToken = false;
        protected string tokens = "";
        protected PintaTokens pintaT;

        public void iniciarVaiables(PintaTokens pintar)
        {
            aceptacion = new EstadoAceptacion();
            noAceptacion = new EstadoNoAceptacion();
            this.pintaT = pintar;
        }

        public void obtenerEstado(KeyPressEventArgs e, RichTextBox rtbError)
        {
            Char token = e.KeyChar;

            for(int cont = 0; cont < pintaT.getOperadorSigno().Length; cont++)
            {
                if(pintaT.getOperadorSigno()[cont].Equals(token) || token.ToString().Equals(" ")
                    || token.ToString().Equals("\r"))
                {
                    estadoToken = false;
                    break;
                }
                else
                {
                    estadoToken = true;
                }
            }

            if(estadoToken == true)
            {
                tokens += token.ToString();
                switch (estado)
                {
                    case 0:
                        noAceptacion.estadoA(token);
                        break;
                    case 1:
                        aceptacion.estadoB(token);
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
            else if(estadoToken == false)
            {
                
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
                        rtbError.AppendText("Error: no se reconoce token: " + tokens + "\n");
                        break;
                }
                tokens = "";
                estado = 0;
            }
            

        }

        

      
    }
}
