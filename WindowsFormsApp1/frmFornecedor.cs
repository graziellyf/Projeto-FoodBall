using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodball
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

      
        public clFornecedor fornecedor = new clFornecedor();

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            if (fornecedor != null)
            {
                txtID.Text = fornecedor.idfornecedor.ToString();
                txtNome.Text = fornecedor.nome;
                txtCnpj.Text = fornecedor.cnpj;
                txtCEP.Text = fornecedor.cep;
                txtComplemento.Text = fornecedor.complemento;
                txtBairro.Text = fornecedor.bairro;
                txtEndereco.Text = fornecedor.endereco;
                txtTelefone.Text = fornecedor.telefone;
                cmbCidade.Text = fornecedor.cidade;
                cmbUF.Text = fornecedor.uf;
                btnSalvar.Text = "Salvar";
            }
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            clFornecedor fornecedor = new clFornecedor();
            fornecedor.nome = txtNome.Text;
            fornecedor.cnpj = txtCnpj.Text;
            fornecedor.cep = txtCEP.Text;
            fornecedor.endereco = txtEndereco.Text;
            fornecedor.complemento = txtComplemento.Text;
            fornecedor.bairro = txtBairro.Text;
            fornecedor.uf = cmbUF.Text;
            fornecedor.cidade = cmbCidade.Text;
            fornecedor.telefone = txtTelefone.Text;
            

            if (txtID.Text == "" || txtID.Text == "0")
            {
                txtID.Text = Convert.ToString(fornecedor.Salvar());
            }
            else
            {
                fornecedor.idfornecedor = int.Parse(txtID.Text);
                fornecedor.Atualizar();
                
            }
            
            
        }

        private void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCEP.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Erro na requisição: " + ChecaServidor.StatusCode.ToString());
                return; // Encerra o códigoz
            }

            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        String response = responseReader.ReadToEnd();
                      //  MessageBox.Show(response);
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");
                       // MessageBox.Show(response);

                        String[] substrings = response.Split('\n');


                        // CEP
                        string[] valor = substrings[1].Split(':');
                        txtCEP.Text = valor[1].Trim(' ').ToString();

                        // Logradouro
                        string[] valor1 = substrings[2].Split(':');
                        txtEndereco.Text = valor1[1].Trim(' ').ToString();

                        // Bairro
                        string[] valor2 = substrings[4].Split(':');
                        txtBairro.Text = valor2[1].Trim(' ').ToString();

                        // Cidade
                        string[] valor3 = substrings[5].Split(':');
                        cmbCidade.Text = valor3[1].Trim(' ').ToString();

                        // UF
                        string[] valor4 = substrings[6].Split(':');
                        cmbUF.Text = valor4[1].Trim(' ').ToString();

                        // Complemento
                        string[] valor5 = substrings[3].Split(':');
                        txtComplemento.Text = valor5[1].Trim(' ').ToString();
                    }
                }
            }
        }
    }
}
