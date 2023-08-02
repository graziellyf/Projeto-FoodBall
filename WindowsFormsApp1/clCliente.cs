using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace Foodball
{
    public class clCliente
    {
        // atributos
        public int idcliente;
        public string nome;
        public string cpf;
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
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CLIENTE ( NOME,CPF,CEP, ENDERECO, " + 
                                                        " COMPLEMENTO, BAIRRO, UF, CIDADE, TELEFONE  )  "+
                                              " values ( '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' )",
                                                nome, cpf, telefone, cep, endereco, complemento, bairro, uf,
                                                cidade, telefone ) + "; SELECT SCOPE_IDENTITY();";

                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK,
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

                BD._sql = "DELETE FROM CLIENTE WHERE ID_CLIENTE = " + idcliente;

                exOK = BD.ExecutaComando(false);

                if (exOK == 1)
                {
                    MessageBox.Show("Cliente deletado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao deletar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                BD._sql = "UPDATE CLIENTE SET NOME = '" + nome + "', CEP = '" + cep + "', ENDERECO = '" + endereco + "', BAIRRO = '" + bairro + "', CIDADE = '" + cidade + "', UF = '" + uf + "', COMPLEMENTO = '" + complemento + "', " +
                      "TELEFONE = '" + telefone + "', CPF = '" + cpf + "' where id_cliente = " + idcliente;

                exOK = BD.ExecutaComando(false);



                if (exOK == 1)
                {
                    MessageBox.Show("Cliente Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Cliente, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BD._sql = "SELECT * FROM CLIENTE " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


    }
}
