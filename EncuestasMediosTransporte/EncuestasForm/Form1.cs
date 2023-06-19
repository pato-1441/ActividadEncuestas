using EncuestasLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestasForm
{
    public partial class Form1 : Form
    {
        ProcesoEncuestas proceso = new ProcesoEncuestas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistroEncuesta_Click(object sender, EventArgs e)
        {
            FormRegistroDeEncuesta formRegistro = new FormRegistroDeEncuesta();

            DialogResult dr = formRegistro.ShowDialog();
           
            if (dr == DialogResult.OK)
            {
                Encuesta nuevo = new Encuesta();
                //Console.WriteLine("Modo de transporte habitual");

                nuevo.UsaBicicleta = formRegistro.cbUsaBicicleta.Checked;// Consulta("¿Usa bicleta?: S/N");
                nuevo.UsaAuto = formRegistro.cbUsaAuto.Checked;//Consulta("¿Usa Automóvil?: S/N");
                nuevo.UsaTransportePublico = formRegistro.cbUsaTransportePublico.Checked;//Consulta("¿Usa Transporte público?: S/N");

                //Console.WriteLine("¿Cuál es la distancia aproximada a su destino de trabajo/estudio en km? (ej:1,5)\n");
                if (formRegistro.tbDistancia.Text.ToString() != "")
                {
                    nuevo.DistanciaASuDestino = Convert.ToDouble(formRegistro.tbDistancia.Text.ToString());
                } else
                {
                    nuevo.DistanciaASuDestino = 0.00;
                }
                //MessageBox.Show("{0}", nuevo.DistanciaASuDestino);

                bool puedeSerContactado = formRegistro.rbContactoSi.Checked;//Consulta("¿Puede ser contactado?: S/N");                
                if (puedeSerContactado == true)
                {
                    MessageBox.Show("Pusiste que si");
                    nuevo.Email = formRegistro.tbMail.Text.ToString();//Console.ReadLine();
                    MessageBox.Show(nuevo.Email);
                }

                proceso.RegistrarEncuesta(nuevo, puedeSerContactado);
                MessageBox.Show("Encuesta procesada!");
            }

            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
