﻿namespace P1_LENGUAJES_FP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIngresoCodigo = new System.Windows.Forms.RichTextBox();
            this.btnGuardarError = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCrearNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSalidaError = new System.Windows.Forms.RichTextBox();
            this.labeOutput = new System.Windows.Forms.Label();
            this.labelFila = new System.Windows.Forms.Label();
            this.labelColumna = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngresoCodigo
            // 
            this.txtIngresoCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIngresoCodigo.Location = new System.Drawing.Point(26, 40);
            this.txtIngresoCodigo.Name = "txtIngresoCodigo";
            this.txtIngresoCodigo.Size = new System.Drawing.Size(890, 376);
            this.txtIngresoCodigo.TabIndex = 0;
            this.txtIngresoCodigo.Text = "";
            this.txtIngresoCodigo.Click += new System.EventHandler(this.txtIngresoCodigo_Click);
            this.txtIngresoCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresoCodigo_KeyPress);
            // 
            // btnGuardarError
            // 
            this.btnGuardarError.Location = new System.Drawing.Point(26, 613);
            this.btnGuardarError.Name = "btnGuardarError";
            this.btnGuardarError.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarError.TabIndex = 1;
            this.btnGuardarError.Text = "Guardar Errores";
            this.btnGuardarError.UseVisualStyleBackColor = true;
            this.btnGuardarError.Click += new System.EventHandler(this.btnGuardarError_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuGuardar,
            this.menuCrearNuevo,
            this.menuCerrar,
            this.menuAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbrir,
            this.itemGuardarComo,
            this.itemSalir});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // itemAbrir
            // 
            this.itemAbrir.Image = ((System.Drawing.Image)(resources.GetObject("itemAbrir.Image")));
            this.itemAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemAbrir.Name = "itemAbrir";
            this.itemAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itemAbrir.Size = new System.Drawing.Size(190, 22);
            this.itemAbrir.Text = "Abrir";
            this.itemAbrir.Click += new System.EventHandler(this.itemAbrir_Click);
            // 
            // itemGuardarComo
            // 
            this.itemGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("itemGuardarComo.Image")));
            this.itemGuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.itemGuardarComo.Name = "itemGuardarComo";
            this.itemGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itemGuardarComo.Size = new System.Drawing.Size(190, 22);
            this.itemGuardarComo.Text = "Guardar como";
            this.itemGuardarComo.Click += new System.EventHandler(this.itemGuardarComo_Click);
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(190, 22);
            this.itemSalir.Text = "Salir";
            this.itemSalir.Click += new System.EventHandler(this.itemSalir_Click);
            // 
            // menuGuardar
            // 
            this.menuGuardar.Name = "menuGuardar";
            this.menuGuardar.Size = new System.Drawing.Size(61, 20);
            this.menuGuardar.Text = "Guardar";
            this.menuGuardar.Click += new System.EventHandler(this.menuGuardar_Click);
            // 
            // menuCrearNuevo
            // 
            this.menuCrearNuevo.Name = "menuCrearNuevo";
            this.menuCrearNuevo.Size = new System.Drawing.Size(85, 20);
            this.menuCrearNuevo.Text = "Crear Nuevo";
            this.menuCrearNuevo.Click += new System.EventHandler(this.menuCrearNuevo_Click);
            // 
            // menuCerrar
            // 
            this.menuCerrar.Name = "menuCerrar";
            this.menuCerrar.Size = new System.Drawing.Size(51, 20);
            this.menuCerrar.Text = "Cerrar";
            this.menuCerrar.Click += new System.EventHandler(this.menuCerrar_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            // 
            // txtSalidaError
            // 
            this.txtSalidaError.Location = new System.Drawing.Point(26, 470);
            this.txtSalidaError.Name = "txtSalidaError";
            this.txtSalidaError.ReadOnly = true;
            this.txtSalidaError.Size = new System.Drawing.Size(890, 137);
            this.txtSalidaError.TabIndex = 3;
            this.txtSalidaError.Text = "";
            // 
            // labeOutput
            // 
            this.labeOutput.AutoSize = true;
            this.labeOutput.Location = new System.Drawing.Point(26, 452);
            this.labeOutput.Name = "labeOutput";
            this.labeOutput.Size = new System.Drawing.Size(41, 15);
            this.labeOutput.TabIndex = 4;
            this.labeOutput.Text = "Salida:";
            // 
            // labelFila
            // 
            this.labelFila.AutoSize = true;
            this.labelFila.Location = new System.Drawing.Point(739, 419);
            this.labelFila.Name = "labelFila";
            this.labelFila.Size = new System.Drawing.Size(40, 15);
            this.labelFila.TabIndex = 5;
            this.labelFila.Text = "Fila:  1";
            // 
            // labelColumna
            // 
            this.labelColumna.AutoSize = true;
            this.labelColumna.Location = new System.Drawing.Point(537, 419);
            this.labelColumna.Name = "labelColumna";
            this.labelColumna.Size = new System.Drawing.Size(71, 15);
            this.labelColumna.TabIndex = 6;
            this.labelColumna.Text = "Columna:  1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 648);
            this.Controls.Add(this.labelColumna);
            this.Controls.Add(this.labelFila);
            this.Controls.Add(this.labeOutput);
            this.Controls.Add(this.txtSalidaError);
            this.Controls.Add(this.btnGuardarError);
            this.Controls.Add(this.txtIngresoCodigo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LENGUAJE FORMAL Y DE PROGRAMACION 2020";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtIngresoCodigo;
        private System.Windows.Forms.Button btnGuardarError;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAbrir;
        private System.Windows.Forms.ToolStripMenuItem itemGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.ToolStripMenuItem menuGuardar;
        private System.Windows.Forms.ToolStripMenuItem menuCrearNuevo;
        private System.Windows.Forms.ToolStripMenuItem menuCerrar;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.RichTextBox txtSalidaError;
        private System.Windows.Forms.Label labeOutput;
        private System.Windows.Forms.Label labelFila;
        private System.Windows.Forms.Label labelColumna;
    }
}

