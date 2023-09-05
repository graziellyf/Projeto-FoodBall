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
    public partial class BuscarFuncionarios : Form
    {
        public BuscarFuncionarios()
        {
            InitializeComponent();
        }

        clFuncionario funcionario = new clFuncionario();

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvFuncionarios.SelectedRows;
                funcionario.idFuncionario = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o funcinario " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    funcionario.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um funcionario para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvFuncionarios.SelectedRows;
            funcionario.idFuncionario = int.Parse(linha[0].Cells[0].Value.ToString());
            funcionario.nome = linha[0].Cells[1].Value.ToString();
            funcionario.cpf = linha[0].Cells[2].Value.ToString();
            funcionario.telefone = linha[0].Cells[3].Value.ToString();
            funcionario.cargo = linha[0].Cells[4].Value.ToString();
            //funcionario.email = linha[0].Cells[4].Value.ToString();

            funcionario.telefone = linha[0].Cells[9].Value.ToString();

            AdicionaFuncionario formulario = new AdicionaFuncionario();
            formulario.funcionario = funcionario;
            formulario.ShowDialog();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    funcionario.nome = txtPesquisa.Text;
                    dgvFuncionarios.DataSource = funcionario.PesquisaPorNome();
                }

                dgvFuncionarios.Columns[0].Visible = false;


                dgvFuncionarios.Columns[1].Width = 200;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void BuscarFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
