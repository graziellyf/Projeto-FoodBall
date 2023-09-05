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
    public partial class BuscaPratos : Form
    {
        public BuscaPratos()
        {
            InitializeComponent();
        }

        clAdicionaPratos pratos = new clAdicionaPratos();

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    pratos.nome = txtPesquisa.Text;
                    dgvPratos.DataSource = pratos.PesquisaPorNome();
                }

                // dgvPratos.Columns[0].Visible = false;


                // dgvPratos.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvPratos.SelectedRows;
            pratos.id_AdicionarPratos = int.Parse(linha[0].Cells[0].Value.ToString());
            pratos.nome = linha[0].Cells[1].Value.ToString();
            pratos.preco = linha[0].Cells[2].Value.ToString();
            pratos.tipo = linha[0].Cells[3].Value.ToString();

            AdicionarPratos formulario = new AdicionarPratos();
            formulario.Prato = pratos;
            formulario.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPratos.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvPratos.SelectedRows;
                pratos.id_AdicionarPratos = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o pratos" + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    pratos.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
        }

        private void BuscaPratos_Load(object sender, EventArgs e)
        {

        }
    }
}
