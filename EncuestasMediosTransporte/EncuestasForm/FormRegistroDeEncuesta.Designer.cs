namespace EncuestasForm
{
    partial class FormRegistroDeEncuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbUsaBicicleta = new System.Windows.Forms.CheckBox();
            this.gbFormRegistroTransporte = new System.Windows.Forms.GroupBox();
            this.cbUsaTransportePublico = new System.Windows.Forms.CheckBox();
            this.cbUsaAuto = new System.Windows.Forms.CheckBox();
            this.btnFormRegistroAceptar = new System.Windows.Forms.Button();
            this.btnFormRegistroCancelar = new System.Windows.Forms.Button();
            this.gbDistancia = new System.Windows.Forms.GroupBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.lbPreguntaDistancia = new System.Windows.Forms.Label();
            this.gbContacto = new System.Windows.Forms.GroupBox();
            this.rbContactoNo = new System.Windows.Forms.RadioButton();
            this.rbContactoSi = new System.Windows.Forms.RadioButton();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbContacto = new System.Windows.Forms.Label();
            this.gbFormRegistroTransporte.SuspendLayout();
            this.gbDistancia.SuspendLayout();
            this.gbContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUsaBicicleta
            // 
            this.cbUsaBicicleta.AutoSize = true;
            this.cbUsaBicicleta.Location = new System.Drawing.Point(187, 37);
            this.cbUsaBicicleta.Name = "cbUsaBicicleta";
            this.cbUsaBicicleta.Size = new System.Drawing.Size(99, 17);
            this.cbUsaBicicleta.TabIndex = 0;
            this.cbUsaBicicleta.Text = "¿Usa bicicleta?";
            this.cbUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // gbFormRegistroTransporte
            // 
            this.gbFormRegistroTransporte.Controls.Add(this.cbUsaTransportePublico);
            this.gbFormRegistroTransporte.Controls.Add(this.cbUsaAuto);
            this.gbFormRegistroTransporte.Controls.Add(this.cbUsaBicicleta);
            this.gbFormRegistroTransporte.Location = new System.Drawing.Point(12, 12);
            this.gbFormRegistroTransporte.Name = "gbFormRegistroTransporte";
            this.gbFormRegistroTransporte.Size = new System.Drawing.Size(390, 127);
            this.gbFormRegistroTransporte.TabIndex = 1;
            this.gbFormRegistroTransporte.TabStop = false;
            this.gbFormRegistroTransporte.Text = "Transporte";
            // 
            // cbUsaTransportePublico
            // 
            this.cbUsaTransportePublico.AutoSize = true;
            this.cbUsaTransportePublico.Location = new System.Drawing.Point(187, 83);
            this.cbUsaTransportePublico.Name = "cbUsaTransportePublico";
            this.cbUsaTransportePublico.Size = new System.Drawing.Size(144, 17);
            this.cbUsaTransportePublico.TabIndex = 2;
            this.cbUsaTransportePublico.Text = "¿Usa transporte publico?";
            this.cbUsaTransportePublico.UseVisualStyleBackColor = true;
            // 
            // cbUsaAuto
            // 
            this.cbUsaAuto.AutoSize = true;
            this.cbUsaAuto.Location = new System.Drawing.Point(187, 60);
            this.cbUsaAuto.Name = "cbUsaAuto";
            this.cbUsaAuto.Size = new System.Drawing.Size(81, 17);
            this.cbUsaAuto.TabIndex = 1;
            this.cbUsaAuto.Text = "¿Usa auto?";
            this.cbUsaAuto.UseVisualStyleBackColor = true;
            // 
            // btnFormRegistroAceptar
            // 
            this.btnFormRegistroAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFormRegistroAceptar.Location = new System.Drawing.Point(22, 432);
            this.btnFormRegistroAceptar.Name = "btnFormRegistroAceptar";
            this.btnFormRegistroAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnFormRegistroAceptar.TabIndex = 2;
            this.btnFormRegistroAceptar.Text = "Enviar";
            this.btnFormRegistroAceptar.UseVisualStyleBackColor = true;
            // 
            // btnFormRegistroCancelar
            // 
            this.btnFormRegistroCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFormRegistroCancelar.Location = new System.Drawing.Point(327, 432);
            this.btnFormRegistroCancelar.Name = "btnFormRegistroCancelar";
            this.btnFormRegistroCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnFormRegistroCancelar.TabIndex = 3;
            this.btnFormRegistroCancelar.Text = "Cancelar";
            this.btnFormRegistroCancelar.UseVisualStyleBackColor = true;
            // 
            // gbDistancia
            // 
            this.gbDistancia.Controls.Add(this.tbDistancia);
            this.gbDistancia.Controls.Add(this.lbPreguntaDistancia);
            this.gbDistancia.Location = new System.Drawing.Point(12, 146);
            this.gbDistancia.Name = "gbDistancia";
            this.gbDistancia.Size = new System.Drawing.Size(396, 69);
            this.gbDistancia.TabIndex = 4;
            this.gbDistancia.TabStop = false;
            this.gbDistancia.Text = "Distancia";
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(187, 37);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(100, 20);
            this.tbDistancia.TabIndex = 1;
            // 
            // lbPreguntaDistancia
            // 
            this.lbPreguntaDistancia.AutoSize = true;
            this.lbPreguntaDistancia.Location = new System.Drawing.Point(7, 20);
            this.lbPreguntaDistancia.Name = "lbPreguntaDistancia";
            this.lbPreguntaDistancia.Size = new System.Drawing.Size(383, 13);
            this.lbPreguntaDistancia.TabIndex = 0;
            this.lbPreguntaDistancia.Text = "¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)";
            // 
            // gbContacto
            // 
            this.gbContacto.Controls.Add(this.rbContactoNo);
            this.gbContacto.Controls.Add(this.rbContactoSi);
            this.gbContacto.Controls.Add(this.lbMail);
            this.gbContacto.Controls.Add(this.tbMail);
            this.gbContacto.Controls.Add(this.lbContacto);
            this.gbContacto.Location = new System.Drawing.Point(13, 222);
            this.gbContacto.Name = "gbContacto";
            this.gbContacto.Size = new System.Drawing.Size(395, 140);
            this.gbContacto.TabIndex = 5;
            this.gbContacto.TabStop = false;
            this.gbContacto.Text = "Contacto";
            // 
            // rbContactoNo
            // 
            this.rbContactoNo.AutoSize = true;
            this.rbContactoNo.Location = new System.Drawing.Point(186, 64);
            this.rbContactoNo.Name = "rbContactoNo";
            this.rbContactoNo.Size = new System.Drawing.Size(39, 17);
            this.rbContactoNo.TabIndex = 6;
            this.rbContactoNo.TabStop = true;
            this.rbContactoNo.Text = "No";
            this.rbContactoNo.UseVisualStyleBackColor = true;
            this.rbContactoNo.CheckedChanged += new System.EventHandler(this.rbContactoNo_CheckedChanged);
            // 
            // rbContactoSi
            // 
            this.rbContactoSi.AutoSize = true;
            this.rbContactoSi.Location = new System.Drawing.Point(186, 41);
            this.rbContactoSi.Name = "rbContactoSi";
            this.rbContactoSi.Size = new System.Drawing.Size(34, 17);
            this.rbContactoSi.TabIndex = 5;
            this.rbContactoSi.TabStop = true;
            this.rbContactoSi.Text = "Si";
            this.rbContactoSi.UseVisualStyleBackColor = true;
            this.rbContactoSi.CheckedChanged += new System.EventHandler(this.rbContactoSi_CheckedChanged);
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(186, 86);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(36, 13);
            this.lbMail.TabIndex = 4;
            this.lbMail.Text = "E-Mail";
            // 
            // tbMail
            // 
            this.tbMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.tbMail.Enabled = false;
            this.tbMail.Location = new System.Drawing.Point(186, 102);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 20);
            this.tbMail.TabIndex = 3;
            // 
            // lbContacto
            // 
            this.lbContacto.AutoSize = true;
            this.lbContacto.Location = new System.Drawing.Point(9, 20);
            this.lbContacto.Name = "lbContacto";
            this.lbContacto.Size = new System.Drawing.Size(124, 13);
            this.lbContacto.TabIndex = 0;
            this.lbContacto.Text = "¿Puede ser contactado?";
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 476);
            this.Controls.Add(this.gbContacto);
            this.Controls.Add(this.gbDistancia);
            this.Controls.Add(this.btnFormRegistroCancelar);
            this.Controls.Add(this.btnFormRegistroAceptar);
            this.Controls.Add(this.gbFormRegistroTransporte);
            this.Name = "FormRegistroDeEncuesta";
            this.Text = "FormRegistroDeEncuesta";
            this.gbFormRegistroTransporte.ResumeLayout(false);
            this.gbFormRegistroTransporte.PerformLayout();
            this.gbDistancia.ResumeLayout(false);
            this.gbDistancia.PerformLayout();
            this.gbContacto.ResumeLayout(false);
            this.gbContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbFormRegistroTransporte;
        private System.Windows.Forms.Button btnFormRegistroAceptar;
        private System.Windows.Forms.Button btnFormRegistroCancelar;
        public System.Windows.Forms.CheckBox cbUsaBicicleta;
        public System.Windows.Forms.CheckBox cbUsaTransportePublico;
        public System.Windows.Forms.CheckBox cbUsaAuto;
        private System.Windows.Forms.GroupBox gbDistancia;
        private System.Windows.Forms.Label lbPreguntaDistancia;
        public System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.GroupBox gbContacto;
        private System.Windows.Forms.Label lbContacto;
        private System.Windows.Forms.Label lbMail;
        public System.Windows.Forms.TextBox tbMail;
        public System.Windows.Forms.RadioButton rbContactoNo;
        public System.Windows.Forms.RadioButton rbContactoSi;
    }
}