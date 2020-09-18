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
        private int estadoInicial = 0;
        private string tokensInicial;
        private string tokens = "";

        public void entrarEstadoInicial(KeyEventArgs e, RichTextBox rtb)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("enter");
            }
            else if (e.KeyCode == Keys.Space)
            {
                MessageBox.Show("space");
            }
            else
            {
                tokensInicial = e.KeyCode.ToString();
              int p = rtb.SelectionStart = rtb.SelectionStart;
              String a =  rtb.Find(tokensInicial, p, rtb.TextLength, RichTextBoxFinds.WholeWord).ToString();

                for (int i = 0; i < operadores.Length; i++)
                {
                    if (operadores[i].Equals(tokensInicial))
                    {
                        tokens = tokensInicial;
                        tokensInicial = "";
                        MessageBox.Show("operador " + tokens);
                        break;
                    }
                }

                for(int j = 0; j < simbolo.Length; j++)
                {
                    if (simbolo[j].Equals(tokensInicial))
                    {
                        tokens = tokensInicial;
                        tokensInicial = "";
                        MessageBox.Show("simbolo " + tokens);
                        break;
                    }
                }
            }
        }
        public void estdoUno()
        {

        }

    }
}
