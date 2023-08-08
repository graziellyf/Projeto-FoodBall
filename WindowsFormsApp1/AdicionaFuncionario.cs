using Foodball;
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
    public partial class AdicionaFuncionario : Form
    {
        public AdicionaFuncionario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public clFuncionario funcionario;

        private void AdicionaFuncionario_Load(object sender, EventArgs e)
        {
            if( funcionario != null)
            {
                txtID.Text = funcionario.idFuncionario.ToString(); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
