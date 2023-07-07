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
    public partial class BuscarClientes : Form
    {
        public BuscarClientes()
        {
            InitializeComponent();
        }

        clCliente cliente = new clCliente();


        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telainical formulario = new Telainical();
            formulario.Show();
            this.Close();
        }

        private void adicionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarClientes formulario = new AdicionarClientes();
            formulario.Show();
            this.Close();
        }

        private void adicionarPratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarPratos formulario = new AdicionarPratos();
            formulario.Show();
            this.Close();
        }

        private void BuscarClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    cliente.nome = txtPesquisa.Text;
                    dgvCliente.DataSource = cliente.PesquisaPorNome();
                }

                dgvCliente.Columns[0].Visible = false;
                

                dgvCliente.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;
            cliente.idcliente = int.Parse(linha[0].Cells[0].Value.ToString());
            cliente.nome = linha[0].Cells[1].Value.ToString();
            cliente.cpf = linha[0].Cells[2].Value.ToString();
            //cliente.email = linha[0].Cells[4].Value.ToString();

            cliente.telefone = linha[0].Cells[9].Value.ToString();

            AdicionarClientes formulario = new AdicionarClientes();
            formulario.cliente = cliente;
            formulario.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvCliente.SelectedRows;
                cliente.idcliente = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o cliente " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    cliente.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buscarPratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaPratos pratos = new BuscaPratos();
            pratos.Show();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
