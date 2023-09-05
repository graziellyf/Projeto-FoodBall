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
    public partial class BuscarFornecedor : Form
    {
        public BuscarFornecedor()
        {
            InitializeComponent();
        }

        clFornecedor fornecedor = new clFornecedor();

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telainical formulario = new Telainical();
            formulario.Show();
            this.Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    fornecedor.nome = txtPesquisa.Text;
                    dgvFornecedor.DataSource = fornecedor.PesquisaPorNome();
                }

                dgvFornecedor.Columns[0].Visible = false;


                dgvFornecedor.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;
            fornecedor.idfornecedor = int.Parse(linha[0].Cells[0].Value.ToString());
            fornecedor.nome = linha[0].Cells[1].Value.ToString();
            fornecedor.cnpj = linha[0].Cells[2].Value.ToString();
            fornecedor.telefone = linha[0].Cells[9].Value.ToString();

            frmFornecedor formulario = new frmFornecedor();
            formulario.fornecedor = fornecedor;
            formulario.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedor.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFornecedor.SelectedRows;
                fornecedor.idfornecedor = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o Fornecedor " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    fornecedor.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um Fornecedor para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BuscarFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
