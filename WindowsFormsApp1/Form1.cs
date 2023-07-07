using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodball
{
    public partial class Telainical : Form
    {
        public Telainical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarClientes formulario = new AdicionarClientes();
            formulario.Show();
            

        }

        private void Telainical_Shown(object sender, EventArgs e)
        {
            
            //TeladeLoad formulario = new TeladeLoad();
            //formulario.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Telainical_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarPratos formulario = new AdicionarPratos();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BuscarClientes formulario = new BuscarClientes();
            formulario.Show();
        }
    }
}
