using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Foodball
{
    class conectaBD
    {
        // Campo responsável pela definição da string de conexão
        public string _strConexao;

        // Campo responsável pela definição da string do sql
        public string _sql;

        // Campo responsável pelo comando de SQL a ser executado
        private SqlCommand _comandoSQL;

        // Propriedade que expõe o campo para definição do comando de SQL a ser executado
        private SqlCommand ComandoSQL
        {
            get { return _comandoSQL; }
            set { _comandoSQL = value; }
        }

        // Campo que define o objeto de conexão
        private SqlConnection _conn;

        // Campo que define o objeto de transação
        private SqlTransaction _transacao;

        // Construtor que define uma string de conexão fixa e cria os objetos de conexão e comando
        public conectaBD()

        {
            StreamReader str = new StreamReader("conexao.ini");
            _strConexao = str.ReadLine() + "Initial Catalog=Foodball;Persist Security Info=True;User ID=sa;Password=senac";
            _conn = new SqlConnection(_strConexao);
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _conn;
        }

        // Construtor que recebe por parametro a string de conexão a ser utilizada e cria
        // os objetos de comando e conexão
        public conectaBD(string stringConexao)
        {
            _strConexao = stringConexao;
            _conn = new SqlConnection(_strConexao);
            _comandoSQL = new SqlCommand();
            _comandoSQL.Connection = _conn;
        }

        public void setParameter(String var, byte[] foto)
        {
            _comandoSQL.Parameters.AddWithValue(var, foto);
        }

        // Método para abrir a conexão com o banco de dados
        // true -> Com transação | false -> Sem transação
        public bool AbreConexao(bool transacao)
        {
            try
            {
                _conn.Open();
                if (transacao)
                {
                    _transacao = _conn.BeginTransaction();
                    _comandoSQL.Transaction = _transacao;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Métodos para fechar a conexão com o banco de dados
        //Retorna um booleano para indicar o resultado da operação
        public bool FechaConexao()
        {
            try
            {
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Finaliza uma transação
        // true -> Executa o commit | false -. Executa o rollback
        public void FinalizaTransacao(bool commit)
        {
            if (commit)
                _transacao.Commit();
            else
                _transacao.Rollback();
            FechaConexao();
        }

        // Destrutor que fecha a conexão com o banco de dados
        ~conectaBD()
        {
            FechaConexao();

        }

        // Método responsável pela execução dos comandos de Insert, Update e Delete
        //Retorna um número inteiro que indica a quantidade de linhas afetadas
        public int ExecutaComando(bool transacao = false)
        {
            int retorno;
            AbreConexao(transacao);
            try
            {
                _comandoSQL.CommandText = _sql;
                retorno = _comandoSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return -1;
            }
            finally
            {
                if (!transacao)
                    FechaConexao();
            }
            return retorno;
        }

        //Método responsável pela execução dos comandos de Insert com retorno do último código cadastrado
        //Retorna um número inteiro que indica a quantidade de linhas afetadas
        public int ExecutaComando(bool transacao, out int ultimoCodigo)
        {
            int retorno;
            ultimoCodigo = 0;
            AbreConexao(transacao);
            try
            {
                //Executa o comando de insert e já retorna o @@IDENTITY
                _comandoSQL.CommandText = _sql;
                ultimoCodigo = Convert.ToInt32(_comandoSQL.ExecuteScalar());
                retorno = 1;
            }
            catch
            {
                retorno = -1;
            }
            finally
            {
                if (!transacao)
                    FechaConexao();
            }
            return retorno;
        }

        //Método responsável pela execução dos comandos de Select
        //Retorna um DataTable com o resultado da operação
        public DataTable ExecutaSelect()
        {
            AbreConexao(false);
            DataTable dt = new DataTable();
            try
            {
                _comandoSQL.CommandText = _sql;
                dt.Load(_comandoSQL.ExecuteReader());
            }
            catch
            {
                dt = null;
            }
            finally
            {
                FechaConexao();
            }
            return dt;
        }

        // Método que executa comandos de Select para retornos escalares, ou seja,
        // retorna a primeira linha e primeira coluna do resultado do comando de Select.
        // Para nosso exemplo, sempre convertemos esse valor para Double
        //Retorna a primeira linha e primeira coluna do resultado comando de Select</returns>
        public double ExecutaScalar()
        {
            AbreConexao(false);
            double retorno;
            try
            {
                _comandoSQL.CommandText = _sql;
                retorno = Convert.ToDouble(_comandoSQL.ExecuteScalar());
            }
            catch
            {
                retorno = -1;
            }
            finally
            {
                FechaConexao();
            }
            return retorno;
        }

        internal int ExecutaComando(bool p, out uint Id)
        {
            throw new NotImplementedException();
        }

    }
}
