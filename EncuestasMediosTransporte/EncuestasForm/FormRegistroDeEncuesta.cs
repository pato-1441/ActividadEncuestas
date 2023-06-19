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
    public partial class FormRegistroDeEncuesta : Form
    {
        public FormRegistroDeEncuesta()
        {
            InitializeComponent();
        }

        private void rbContactoSi_CheckedChanged(object sender, EventArgs e)
        {
            tbMail.Enabled = true;
        }

        private void rbContactoNo_CheckedChanged(object sender, EventArgs e)
        {
            tbMail.Enabled = false;
        }
    }
}
