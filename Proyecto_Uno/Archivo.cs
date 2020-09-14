using System;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.TextFormatting;

namespace Proyecto_Uno
{
    class Archivo
    {
        /* declaracion de variables*/
        private String mensaje = "";
        private String pat = "";
        String nuevoPat = "";

        /* Metodo para guardar un archivo nuevo o crear un archivo
         *tambien para guardar archivos ya creados*/
        public void guardarDocumeto(string mensaje)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "gt files (*.gt)|*.gt";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (pat.Equals(""))
            {
                try
                {

                    if (saveFile.ShowDialog() == true)
                    {
                        if (File.Exists(saveFile.FileName))
                        {
                            pat = saveFile.FileName;
                            StreamWriter texto = File.CreateText(pat);
                            texto.Write(mensaje + "\n");
                            texto.Close();

                        }
                        else
                        {
                            pat = saveFile.FileName;
                            StreamWriter texto = File.CreateText(pat);
                            texto.Write(mensaje);
                            texto.Close();
                        }
                        MessageBox.Show("Archivo creado.", "Guardar archivo");
                    }
                    else
                    {
                        MessageBox.Show("no se creo nada.", "Guardaar Archivo");
                        pat = nuevoPat;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error en guardar el archivo.", "Guardar archivo");
                    pat = nuevoPat;
                }

            }
            else
            {
                try
                {
                    StreamWriter texto = File.CreateText(pat);
                    texto.Write(mensaje);
                    texto.Close();
                    MessageBox.Show("Archivo guradado Exitosamente.", "Guardar archivo");
                }
                catch (Exception)
                {
                    MessageBox.Show("Error: no se puedo guardar el archivo", "Guardar Arcchivo");
                }
            }
        }

        /* Metodo para abrir un archivo*/
        public void abrirDocumetno(RichTextBox txt_ingreso)
        {
            String resultado = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text documents (.gt)|*.gt";

            try
            {
                if (openFile.ShowDialog() == true)
                {
                    pat = openFile.FileName;
                    resultado = File.ReadAllText(pat);
                }
                txt_ingreso.Document.Blocks.Clear();
                txt_ingreso.AppendText(resultado);
                MessageBox.Show("Archivo leido correctamente.", "Abrir archivo");

            }
            catch (Exception)
            {
                MessageBox.Show("Error en leer el archivo.", "Abrir archivo");
            }
        }

        /* Metodo para preguntar al usuario y guardar su seleccion
         * si desea guradar el archivo antes de cerrarlo */
        public void mensajeGuardar(String texto, String mensaje,
            RichTextBox txtIngresoCodigo)
        {
            this.mensaje = mensaje;
            string message = "Deseas guardar el documento.!";
            string caption = texto;
            MessageBoxButton buttons = MessageBoxButton.YesNoCancel;
            // mensaje en el text box
            MessageBoxResult result = MessageBox.Show(message, caption, buttons);

            if (result == MessageBoxResult.Yes)
            {
                guardarDocumeto(mensaje);
                txtIngresoCodigo.Document.Blocks.Clear();
                mensaje = "";
                pat = "";
            }
            else if (result == MessageBoxResult.No)
            {
                txtIngresoCodigo.Document.Blocks.Clear();
                mensaje = "";
                pat = "";
            }

            if(texto.Equals("Nuevo documento") && result != MessageBoxResult.Cancel)
            {
                guardarDocumeto("");
            }
        }

        /* Metodo que retorna el pat de un archivo*/
        public String getPat()
        {
            return pat;
        }

        /* Metodo para establecer un nuevo valor al pat de un archivo*/
        public void setPat(String pat)
        {
            this.pat = pat;
        }

        /* Metodo que guarda el pat anterior para que el usuario busque otro pat*/
        public void nuevoGuardar()
        {
            nuevoPat = pat;
            pat = "";
        }
    }
}
