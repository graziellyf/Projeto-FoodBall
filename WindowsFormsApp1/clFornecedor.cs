using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodball
{
    public class clFornecedor 
    {
        public int idfornecedor;
        public string nome;
        public string cnpj;
        public string cep;
        public string endereco;
        public string complemento;
        public string bairro;
        public string uf;
        public string cidade;
        public string telefone;

        conectaBD BD = new conectaBD();

        // métodos
        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO FORNECEDOR ( NOME,CNPJ, CEP, ENDERECO, " +
                                                       "COMPLEMENTO,BAIRRO,UF,CIDADE,TELEFONE ) " +
                                              " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' )",
                                                nome, cnpj, cep, endereco, complemento, bairro, uf,
                                                cidade, telefone) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Fornecedor cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Fornecedor", "Erro", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

            return id;


        }

        public void Excluir()
        {
            try
            {
                int exOK = 0;

                BD._sql = "DELETE FROM FORNECEDOR WHERE ID_FORNECEDOR = " + idfornecedor;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Fornecedor deletado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar Fornecedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = "UPDATE FORNECEDOR SET NOME = '" + nome + "', CEP = '" + cep + "', ENDERECO = '" + endereco + "', BAIRRO = '" + bairro + "', CIDADE = '" + cidade + "', UF = '" + uf + "', COMPLEMENTO = '" + complemento + "', " +
                      "TELEFONE = '" + telefone + "', CNPJ = '" + cnpj + "' where id_fornecedor = " + idfornecedor;

                exOK = BD.ExecutaComando(false);



                if (exOK > 0)
                {
                    MessageBox.Show("Fornecedor Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Fornecedor, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM FORNECEDOR " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void PesquisaPorCPFCNPJ()
        {

        }

        public void PesquisaPorRGIE()
        {

        }
    }
}

