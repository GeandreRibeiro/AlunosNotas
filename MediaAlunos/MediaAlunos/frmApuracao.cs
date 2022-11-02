using MediaAlunos.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAlunos
{
    public partial class frmApuracao : Form
    {
        public string Caminho { get; set; }
        private TipoConexao Conexao;
        public frmApuracao(TipoConexao conexao)
        {
            InitializeComponent();
            this.Conexao = conexao;
        }

        private void frmApuracao_Load(object sender, EventArgs e)
        {
            try
            {
                List<Alunos> Alunos = new List<Alunos>();
                if (Conexao == TipoConexao.ArquivoXML)
                {
                    //Buscando os alunos no arquivo
                    Alunos = Dados.RepositorioXml.BuscarAlunos(Caminho);
                }
                else if (Conexao == TipoConexao.SQLServer)
                {
                    //Buscando as notas no banco de dados
                    RepositorioSQL sql = new RepositorioSQL();
                    //Inicia o banco de dados
                    sql.IniciaBancoDados(Caminho);
                    //Buscando as notas no banco de dados
                    Alunos = sql.BuscarAlunos();
                }
                else
                {
                    MessageBox.Show("Tipo de conexão não implementado");
                    return;
                }
                
                //Carregando a View para exibir
                dataGridView1.DataSource = ViewAlunoMedia.CarregarView(Alunos);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public enum TipoConexao
    {
        SQLServer = 1,
        ArquivoXML = 2
    }
}
