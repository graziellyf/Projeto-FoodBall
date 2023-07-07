using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Foodball
{
    public partial class TeladeLoad : Form
    {
        public TeladeLoad()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
                
        }

        private void TeladeLoad_Shown(object sender, EventArgs e)
        {
            this.Refresh();

            for (int i = 1; i < 101; i++)
            {
                pgbProgresso.Value = i;
                Thread.Sleep(30);

            }

            pgbProgresso.Value = 99;
            Thread.Sleep(500);

            this.Close();
        }

        private void TeladeLoad_FormClosed(object sender, FormClosedEventArgs e)
        {
            Telainical formulario = new Telainical();
            formulario.Show();
        }

        private void TeladeLoad_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
