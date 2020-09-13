using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto_Uno
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string mensaje = "";
        private Archivo archivo;

        public MainWindow()
        {
            InitializeComponent();
            archivo = new Archivo();
        }

        public void obtenerTextoRichText()
        {
            TextRange range = new TextRange(txtIngresoCodigo.Document.ContentStart,
                txtIngresoCodigo.Document.ContentEnd);
            mensaje = range.Text;
        }

        private void menuGuardar_Click(object sender, RoutedEventArgs e)
        {
            obtenerTextoRichText();
            archivo.guardarDocumeto(mensaje);
        }

        private void itemSalir_Click(object sender, RoutedEventArgs e)
        {
            string message = "Esta seguro que quiere salir.!";
            string caption = "Salir";
            MessageBoxButton buttons = MessageBoxButton.OKCancel;
            // mensaje en el text box
            MessageBoxResult result = MessageBox.Show(message, caption, buttons);

            if (result == MessageBoxResult.OK)
            {
                this.Close();
            }            
        }

        private void menuCerrar_Click(object sender, RoutedEventArgs e)
        {
            obtenerTextoRichText();
            if (archivo.getPat().Equals("") && mensaje.Equals(""))
            {
                txtIngresoCodigo.Document.Blocks.Clear();
                mensaje = "";
                archivo.setPat("");
            }
            else
            {
                archivo.mensajeGuardar("Cerrar documento", mensaje, txtIngresoCodigo);
            }
        }

        private void menuNuevo_Click(object sender, RoutedEventArgs e)
        {
            obtenerTextoRichText();
            if (archivo.getPat().Equals("") && mensaje.Equals(""))
            {
                archivo.guardarDocumeto(mensaje);
                txtIngresoCodigo.Document.Blocks.Clear();
            }
            else
            {
                archivo.mensajeGuardar("Nuevo documento", mensaje, txtIngresoCodigo);
            }
        }

        private void itemAbrir_Click(object sender, RoutedEventArgs e)
        {
            archivo.abrirDocumetno(txtIngresoCodigo);
        }

        private void itemGuardarComo_Click(object sender, RoutedEventArgs e)
        {
            obtenerTextoRichText();
            archivo.nuevoGuardar();
            archivo.guardarDocumeto(mensaje);
        }
    }
}
