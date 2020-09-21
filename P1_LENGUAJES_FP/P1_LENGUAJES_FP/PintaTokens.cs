using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace P1_LENGUAJES_FP
{
    class PintaTokens
    {

        string[] textoReservado = new string[] { "entero", "decimal", "cadena", "booleano",
            "caracter", "SI", "SINO", "SINO_SI", "MIENTRAS", "HACER", "DESDE", "HASTA", "INCREMENTO",
            "verdadero", "falso"};

        string[] signosOperadores = new string[] {"+", "-", "*", "++", "--", "/", "<", ">",
           "<=", ">=", "==", "!=", "!", "||", "&&", "(", ")", "=", ";"};

        private static List<String> numeroEnteros = new List<String>(new String[] { });
        private static List<String> numeroDecimal = new List<String>(new String[] { });
        private static List<String> comentario = new List<String>(new String[] { });
        private static List<String> cadenaTexto = new List<String>(new String[] { });

        public void pintarTextoReservada(RichTextBox txtTexto)
        {

            try /*captura errores*/
            {


                /*inicia la seleccion de un token ingresado*/
                txtTexto.SelectionStart = 0;
                txtTexto.SelectionLength = txtTexto.TextLength;
                txtTexto.SelectionColor = txtTexto.ForeColor;

                /* ciclo para comprobar tokens y pintarlos */
                foreach (string reservadaAuxiliar in textoReservado)
                { 
                    int INDEX = 0;  /* posicion de tokens*/
                    /*ciclo  para buscar la palabra  */
                    while (INDEX <= txtTexto.Text.LastIndexOf(reservadaAuxiliar))
                    {
                        txtTexto.Find(reservadaAuxiliar, INDEX, txtTexto.TextLength, RichTextBoxFinds.WholeWord); //'CUANDO LA ENCUENTRA LA SELECCIONA Y....

                        if (reservadaAuxiliar.Equals("entero"))
                        {
                            txtTexto.SelectionColor = Color.MediumOrchid;
                        }
                        else if (reservadaAuxiliar.Equals("decimal"))
                        {
                            txtTexto.SelectionColor = Color.Aqua;
                        }
                        else if (reservadaAuxiliar.Equals("cadena"))
                        {
                            txtTexto.SelectionColor = Color.DimGray;
                        }
                        else if (reservadaAuxiliar.Equals("booleano") || reservadaAuxiliar.Equals("verdadero")
                            || reservadaAuxiliar.Equals("falso"))
                        {
                            txtTexto.SelectionColor = Color.Orange;
                        }
                        else if (reservadaAuxiliar.Equals("caracter"))
                        {
                            txtTexto.SelectionColor = Color.SaddleBrown;
                        }                       
                        else if (reservadaAuxiliar.Equals("SI") || reservadaAuxiliar.Equals("SINO") ||
                            reservadaAuxiliar.Equals("SINO_SI") || reservadaAuxiliar.Equals("MIENTRAS") ||
                            reservadaAuxiliar.Equals("HACER") || reservadaAuxiliar.Equals("DESDE") ||
                            reservadaAuxiliar.Equals("HASTA") || reservadaAuxiliar.Equals("INCREMENTO"))
                        {
                            txtTexto.SelectionColor = Color.DarkGreen;
                        }
                        else
                        {

                            txtTexto.SelectionColor = Color.Black; 
                        }

                        /* pasa a la siguiente palabra */
                        INDEX = txtTexto.Text.IndexOf(reservadaAuxiliar, INDEX) + 1; 

                    }
                }

                /* volvemos al color normal y la posicion */
                txtTexto.SelectionStart = txtTexto.TextLength;
                txtTexto.SelectionColor = txtTexto.ForeColor;

            }
            catch (Exception e)
            {
                Console.WriteLine("error al pintar texto " + e);
            }

        }

        public void pintarSignosOperadores(RichTextBox txtTextoIngresado)
        {
            try
            {

                foreach (String word in signosOperadores)
                {
                    int startIndex = 0;

                    while (startIndex <= txtTextoIngresado.Text.LastIndexOf(word))
                    {
                        int wordStartIndex =
                        txtTextoIngresado.Find(word, startIndex, txtTextoIngresado.TextLength,
                        RichTextBoxFinds.NoHighlight);
                        // word.Length,

                        if (wordStartIndex != -1)
                        {
                            txtTextoIngresado.SelectionStart = wordStartIndex;
                            txtTextoIngresado.SelectionLength = word.Length;
                         
                            if (word.Equals("+") || word.Equals("-") || word.Equals("*") || word.Equals("/") || 
                                   word.Equals("++") || word.Equals("--") || word.Equals(">") ||
                                   word.Equals("<") || word.Equals(">=") || word.Equals("<=") ||
                                   word.Equals("==") || word.Equals("!=") || word.Equals("!") ||
                                   word.Equals("&&") || word.Equals("||") || word.Equals("(") ||
                                   word.Equals(")")) 
                            {
                                txtTextoIngresado.SelectionColor = Color.DarkBlue;
                            }
                            else if (word.Equals("=") || word.Equals(";") || word.Equals("\""))
                            {
                                txtTextoIngresado.SelectionColor = Color.DeepPink;
                            }

                        }
                        else
                            break;
                        startIndex += wordStartIndex + word.Length;

                    }

                }
                 txtTextoIngresado.SelectionStart = txtTextoIngresado.TextLength;
                //txtTextoIngresado.SelectionColor = txtTextoIngresado.ForeColor;

            }
            catch (Exception e)
            {
                Console.WriteLine("error al pintar signos u operadores " + e);
            }
        }

        public String[] getOperadorSigno()
        {
            return signosOperadores;
        }

        public String[] getTextoReservado()
        {
            return textoReservado;
        }

        public void pintarTokensCompleto(RichTextBox txtTextoIngresado, List<String> tokensCompleto, 
            int tipoToken)
        {
            try
            {

                foreach (String word in tokensCompleto)
                {
                    int startIndex = 0;
                    
                    while (startIndex <= txtTextoIngresado.Text.LastIndexOf(word))
                    {
                        int wordStartIndex =
                        txtTextoIngresado.Find(word, startIndex, txtTextoIngresado.TextLength,
                        RichTextBoxFinds.NoHighlight);

                        // word.Length,

                        if (wordStartIndex != -1)
                        {
                            txtTextoIngresado.SelectionStart = wordStartIndex;
                            txtTextoIngresado.SelectionLength = word.Length;

                            if (tipoToken == 0)
                            {
                                txtTextoIngresado.SelectionColor = Color.MediumOrchid;
                            }
                            else if (tipoToken == 1)
                            {
                                txtTextoIngresado.SelectionColor = Color.Aqua;
                            }
                            else if (tipoToken == 3)
                            {
                                txtTextoIngresado.SelectionColor = Color.DimGray;
                            }
                            else if (tipoToken == 4)
                            {
                                txtTextoIngresado.SelectionColor = Color.Red;
                            }

                        }
                        else
                            break;
                        startIndex += wordStartIndex + word.Length;

                    }

                }
                txtTextoIngresado.SelectionStart = txtTextoIngresado.TextLength;
               // txtTextoIngresado.SelectionColor = txtTextoIngresado.ForeColor;

            }
            catch (Exception e)
            {
                Console.WriteLine("error al pintar signos u operadores " + e);
            }
        }

        public void setNumeroEntero(String num)
        {
            numeroEnteros.Add(num);
        }

        public void setNumeroDecimal(String num)
        {
            numeroDecimal.Add(num);
        }

        public void setCadenaTexto(String text)
        {
            cadenaTexto.Add(text);
        }

        public void setComentario(String com)
        {
            comentario.Add(com);
        }

        public List<String> getNumeroEntero()
        {
            return numeroEnteros;
        }

        public List<String> getNumeroDecimal()
        {
            return numeroDecimal;
        }

        public List<String> getCadenaTexto()
        {
            return cadenaTexto;
        }

        public List<String> getComentario()
        {
            return comentario;
        }

    }
}
