﻿namespace EncuestasForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistroEncuesta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroEncuesta
            // 
            this.btnRegistroEncuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroEncuesta.Location = new System.Drawing.Point(148, 67);
            this.btnRegistroEncuesta.Name = "btnRegistroEncuesta";
            this.btnRegistroEncuesta.Size = new System.Drawing.Size(187, 46);
            this.btnRegistroEncuesta.TabIndex = 0;
            this.btnRegistroEncuesta.Text = "Registro de Encuesta";
            this.btnRegistroEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroEncuesta.Click += new System.EventHandler(this.btnRegistroEncuesta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(148, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(187, 46);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 311);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegistroEncuesta);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroEncuesta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}

