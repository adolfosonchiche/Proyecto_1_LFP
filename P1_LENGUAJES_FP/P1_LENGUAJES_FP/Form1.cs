using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_LENGUAJES_FP
{
    public partial class Form1 : Form
    {
        private Archivo archivo;
        private Automata automata;
        private PintaTokens pinta;
        private String mensaje = "";
        private static int line = 0;
        private static int column = 0;
        /*List<String> numeroEnteros = new List<String>(new String[] { });
        List<String> numeroDecimal = new List<String>(new String[] { });
        List<String> comentario = new List<String>(new String[] { });
        List<String> cadenaTexto = new List<String>(new String[] { });
        List<String> caracteres = new List<String>(new String[] { });*/

        public Form1()
        {
            InitializeComponent();
            archivo = new Archivo();
            pinta = new PintaTokens();
            automata = new Automata();
            automata.iniciarVaiables(pinta);
        }

        public void obtenerTextoRichText()
        {
            mensaje = txtIngresoCodigo.Text;
        }

        private void itemAbrir_Click(object sender, EventArgs e)
        {
            archivo.abrirDocumetno(txtIngresoCodigo);
        }

        private void itemGuardarComo_Click(object sender, EventArgs e)
        {
            obtenerTextoRichText();
            archivo.nuevoGuardar();
            archivo.guardarDocumeto(mensaje);
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            string message = "Esta seguro que quiere salir.!";
            string caption = "Salir";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            // mensaje en el text box
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {
            obtenerTextoRichText();
            archivo.guardarDocumeto(mensaje);
        }

        private void menuCrearNuevo_Click(object sender, EventArgs e)
        {
            obtenerTextoRichText();
            if (archivo.getPat().Equals("") && mensaje.Equals(""))
            {
                archivo.guardarDocumeto(mensaje);
                txtSalidaError.Clear();
                txtIngresoCodigo.Clear();
            }
            else
            {
                archivo.mensajeGuardar("Nuevo documento", mensaje, txtIngresoCodigo);
            }
        }

        private void menuCerrar_Click(object sender, EventArgs e)
        {
            obtenerTextoRichText();
            if (archivo.getPat().Equals("") && mensaje.Equals(""))
            {
                txtIngresoCodigo.Clear();
                txtSalidaError.Clear();
                mensaje = "";
                archivo.setPat("");
            }
            else
            {
                archivo.mensajeGuardar("Cerrar documento", mensaje, txtIngresoCodigo);
            }
        }

        private void txtIngresoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            obtenerPosicion();

            automata.obtenerEstado(e, txtSalidaError, txtIngresoCodigo);
           
            pinta.pintarTextoReservada(txtIngresoCodigo);
            pinta.pintarSignosOperadores(txtIngresoCodigo);
            pinta.pintarTokensCompleto(txtIngresoCodigo, pinta.getCadenaTexto(), 3);
            pinta.pintarTokensCompleto(txtIngresoCodigo, pinta.getNumeroEntero(), 0);
            pinta.pintarTokensCompleto(txtIngresoCodigo, pinta.getNumeroDecimal(), 1);
            pinta.pintarTokensCompleto(txtIngresoCodigo, pinta.getComentario(), 4);

        }

        private void txtIngresoCodigo_Click(object sender, EventArgs e)
        {
            obtenerPosicion();
        }

        public void obtenerPosicion()
        {
            // retorna la linea .
            int index = txtIngresoCodigo.SelectionStart;
            line = txtIngresoCodigo.GetLineFromCharIndex(index);
            int fila = line + 1;
            labelFila.Text = "fila: " + fila.ToString();
            // retorna la columna.
            int firstChar = txtIngresoCodigo.GetFirstCharIndexFromLine(line);
            column = index - firstChar + 1;
            labelColumna.Text = "columna: " + column.ToString();
        }
    }
}
