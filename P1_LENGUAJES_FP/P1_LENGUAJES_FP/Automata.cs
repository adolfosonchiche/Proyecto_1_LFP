using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using System.Windows.Forms;

namespace P1_LENGUAJES_FP
{
    class Automata
    {
        private EstadoAceptacion aceptacion;
        private EstadoNoAceptacion noAceptacion;
        protected static int estado = 0;
        protected Boolean moverToken = false;
        protected static Boolean errorToken = false;
        protected string tokens = "";
        protected PintaTokens pintaT;
        protected String tok = "";
        private string[] signosOperadores = new string[] {"+", "-", "++", "--", "<", ">",
           "<=", ">=", "==", "!=", "!", "||", "&&", "(", ")", "=", ";"};

        public void iniciarVaiables(PintaTokens pintar)
        {
            aceptacion = new EstadoAceptacion();
            noAceptacion = new EstadoNoAceptacion();
            this.pintaT = pintar;
        }

        public void obtenerEstado(KeyPressEventArgs e, RichTextBox rtbError)
        {
            Char token = e.KeyChar;

            for(int cont = 0; cont < signosOperadores.Length; cont++)
            {
                if(signosOperadores[cont].Equals(token.ToString()) || token.ToString().Equals(" ")
                    || token.ToString().Equals("\r"))
                {
                    moverToken = false;
                    break;
                }
                else
                {
                    moverToken = true;
                }
            }

            /*sentencia para que se acepten token de tipo espacio y seguir moviendonos en estados*/
            if((estado == 6 || estado == 7 || estado == 8 || estado == 10) && !token.Equals('\r'))
            {
                moverToken = true;
            }
            if (estado == 9 || estado == 5 && !token.Equals('*'))
            {
                moverToken = true;
            }

            if (moverToken == true)
            {
               //verificar si el usuario borra un caracter (token)
                if (token.Equals(''))
                {                  
                    String a = tokens.Remove(tokens.Length - 1, 1);
                    tokens = a;
                    String b = tokens.Remove(0, a.Length - 1);
                    
                    token = Convert.ToChar(b);
                    errorToken = false;
                }
                else
                {
                    tokens += token.ToString();
                }

                switch (estado)
                {
                    case 0:
                        estado = noAceptacion.estadoA(token);
                        break;

                    case 1:
                       estado = aceptacion.estadoB(token);
                        break;

                    case 2:
                        estado = noAceptacion.estadoC(token);
                        break;

                    case 3:
                        estado = aceptacion.estadoD(token);
                        break;

                    case 4:
                        estado = noAceptacion.estadoE(token);
                        break;

                    case 5:
                        estado = noAceptacion.estadoF(token);
                        break;

                    case 6:
                        estado = noAceptacion.estadoG(token);
                        break;

                    case 7:
                        estado = noAceptacion.estadoH(token);
                        break;

                    case 8:
                        estado = noAceptacion.estadoI(token);
                        break;

                    case 9:
                        estado = noAceptacion.estadoJ(token);
                        break;

                    case 10:
                        estado = aceptacion.estadoK(token);
                        break;

                    case 11:
                        estado = noAceptacion.estadoL(token);
                        break;

                    default:

                        break;
                }
            }
            else if(moverToken == false)
            {
                for(int ctd = 0; ctd < pintaT.getTextoReservado().Length; ctd++)
                {
                    if (pintaT.getTextoReservado()[ctd].Equals(tokens))
                    {
                        errorToken = false;
                        break;
                    }
                }

                if (errorToken == true)
                {
                    rtbError.AppendText("Error: no se reconoce token: " + tokens + "\n");
                }

                tokens = "";
                estado = 0;
            }            

        }
      
    }
}
