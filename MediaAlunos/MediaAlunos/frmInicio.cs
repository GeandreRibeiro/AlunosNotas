using MediaAlunos.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAlunos
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtCaminho.Text = folderBrowserDialog1.SelectedPath;
        }

        private void frmInicio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btoOk_Click(object sender, EventArgs e)
        {
            try
            {
                //Validações da pasta
                if(!Directory.Exists(txtCaminho.Text))
                {
                    Directory.CreateDirectory(txtCaminho.Text);
                }

                if (string.IsNullOrWhiteSpace(txtCaminho.Text))
                {
                    MessageBox.Show("Selecione uma pasta para continuar.");
                    btnCaminho.Focus();
                    return;
                }

                //Iniciando banco de dados
                if(RepositorioXml.IniciarBanco(txtCaminho.Text))
                {
                    //Exibir a tela com o resultado 
                    frmApuracao frm = new frmApuracao(TipoConexao.ArquivoXML);
                    frm.Caminho = txtCaminho.Text;
                    frm.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrWhiteSpace(txtBancoSQL.Text))
                {
                    MessageBox.Show("Informe um banco de dados.");
                    txtBancoSQL.Focus();
                }

                if (new RepositorioSQL().IniciaBancoDados(txtBancoSQL.Text))
                {
                    MessageBox.Show("Banco de Dados conectado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Falha na Conexão com o Banco de Dados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmarBanco_Click(object sender, EventArgs e)
        {
            try
            {
                RepositorioSQL sql = new RepositorioSQL();
                if (sql.IniciaBancoDados(txtBancoSQL.Text))
                {
                    if (!sql.ExisteDados())
                        if (!sql.PopularTabelas())
                            return;

                    //Exibir a tela com o resultado
                    frmApuracao frm = new frmApuracao(TipoConexao.SQLServer);
                    frm.Caminho = txtBancoSQL.Text;
                    frm.ShowDialog();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
