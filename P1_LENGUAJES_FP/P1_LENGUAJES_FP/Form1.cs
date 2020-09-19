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
        public Form1()
        {
            InitializeComponent();
            archivo = new Archivo();
            automata = new Automata();
            pinta = new PintaTokens();
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
                mensaje = "";
                archivo.setPat("");
            }
            else
            {
                archivo.mensajeGuardar("Cerrar documento", mensaje, txtIngresoCodigo);
            }
        }

        private void txtIngresoCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            pinta.pintarTextoReservada(txtIngresoCodigo);
            pinta.pintarSignosOperadores(txtIngresoCodigo);
        }

        private void txtIngresoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            automata.obtenerEstado(e, txtSalidaError);
        }
    }
}
