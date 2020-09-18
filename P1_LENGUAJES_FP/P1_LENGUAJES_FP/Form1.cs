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

        }

        private void menuGuardar_Click(object sender, EventArgs e)
        {
            obtenerTextoRichText();
            archivo.guardarDocumeto(mensaje);
        }

        private void menuCrearNuevo_Click(object sender, EventArgs e)
        {

        }

        private void menuCerrar_Click(object sender, EventArgs e)
        {

        }

        private void txtIngresoCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            pinta.pintarTextoReservada(txtIngresoCodigo);
            pinta.pintarSignosOperadores(txtIngresoCodigo);
        }
    }
}
