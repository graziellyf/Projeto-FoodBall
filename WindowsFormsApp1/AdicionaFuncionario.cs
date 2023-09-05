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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clFuncionario funcionario = new clFuncionario();
            funcionario.nome = txtNome.Text;
            funcionario.cpf = txtCpf.Text;
            funcionario.telefone = txtTelefone.Text;
            funcionario.cargo = txtCargo.Text;


            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(funcionario.Salvar());
            }
            else
            {
                funcionario.idFuncionario = int.Parse(txtID.Text);
                funcionario.Atualizar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
