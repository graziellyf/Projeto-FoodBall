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
    public partial class AdicionarPratos : Form
    {
        public AdicionarPratos()
        {
            InitializeComponent();
        }

        public clAdicionaPratos Prato;

        private void adicionarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telainical formulario = new Telainical();
            formulario.Show();
            this.Close();
        }

        private void adicionarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarClientes formulario = new AdicionarClientes();
            formulario.Show();
            this.Close();
        }

        private void AdicionarPratos_Load(object sender, EventArgs e)
        {
            if (Prato != null)
            {
                txtID.Text = Prato.id_AdicionarPratos.ToString();
                textNome.Text = Prato.nome;
                textPreco.Text = Prato.preco;
                textTipo.Text = Prato.tipo;
                btnConfirma.Text = "Atualizar";
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            clAdicionaPratos Prato = new clAdicionaPratos();
            Prato.nome = textNome.Text;
            Prato.preco = textPreco.Text;
            Prato.tipo = textTipo.Text;

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(Prato.Salvar());
            }
            else
            {
                Prato.id_AdicionarPratos = int.Parse(txtID.Text);
                Prato.Atualizar();
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buscarPratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaPratos prato = new BuscaPratos();
            prato.Show();
            this.Close();
        }

        private void btnConfirma_Click_1(object sender, EventArgs e)
        {
            clAdicionaPratos Prato = new clAdicionaPratos();
            Prato.nome = textNome.Text;
            Prato.preco = textPreco.Text;
            Prato.tipo = textTipo.Text;

            if (txtID.Text == "")
            {
                txtID.Text = Convert.ToString(Prato.Salvar());
            }
            else
            {
                Prato.id_AdicionarPratos = int.Parse(txtID.Text);
                Prato.Atualizar();
            }
        }

        private void btnExclui_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
