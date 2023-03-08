using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relogio
{
    public partial class Relogio : Form
    {
        public Relogio()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtpCalendario_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dtpCalendario.Value.ToString("dd/MM/yyyy"));
        }
    }
}
