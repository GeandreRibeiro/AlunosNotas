using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MediaAlunos.Dados
{
    public class RepositorioSQL
    {
        private SqlConnection Cnn { get; set; }
        
        /// <summary>
        /// Inicia a configuração do banco de dados
        /// </summary>
        /// <param name="BancoDeDados">Instância do banco de dados</param>
        /// <returns>true se deu tudo certo, false se ocorreu algum erro</returns>
        public bool IniciaBancoDados(string BancoDeDados)
        {
            try
            {
                string Tabela = "Alunos";
                this.Cnn = new SqlConnection($@"Data Source={BancoDeDados}; Database={Tabela}; Integrated Security=true");
                Cnn.Open();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Popula a tabela com informações pré definidas
        /// </summary>
        /// <returns>true se deu tudo certo, false se ocorreu algum erro</returns>
        public bool PopularTabelas()
        {
            try
            {
                List<Alunos> alunos = new List<Alunos>();

                Notas n = new Notas(0, 0, 9, decimal.Parse("6,5"), 6, 6);
                Alunos a = new Alunos(0, "Geandre Ribeiro", n);
                alunos.Add(a);

                n = new Notas(0, 0, 7, decimal.Parse("5,5"), 4, 3);
                a = new Alunos(0, "Alexandre Ribeiro", n);
                alunos.Add(a);

                n = new Notas(0, 0, 9, decimal.Parse("7,5"), 6, 7);
                a = new Alunos(0, "Lourdes Augusta", n);
                alunos.Add(a);

                if (!GravarDados(alunos))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Verifica se existe dados nas tabelas
        /// </summary>
        /// <returns>true se existe, false se não existe</returns>
        public bool ExisteDados()
        {
            try
            {
                string strSQL = "SELECT id FROM Alunos";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Alunos");

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Grava os dados na tabela
        /// </summary>
        /// <param name="alunos">Coleção de alunos para a gravação</param>
        /// <returns>true se deu tudo certo, false se ocorreu algum erro</returns>
        public bool GravarDados(List<Alunos> alunos)
        {
            try
            {
                foreach (var item in alunos)
                {
                    //Primeiro vou gravar os alunos
                    string strSQL = "INSERT INTO Alunos(" +
                        "nome" +
                        ")VALUES(" +
                        "@Nome)";

                    SqlCommand cmd = new SqlCommand(strSQL, Cnn);
                    cmd.Parameters.Add(new SqlParameter("@Nome", item.Nome));
                    cmd.ExecuteNonQuery();

                    //Pegando o ultimo id gravado
                    int id = PegarUltimoId();

                    //agora gravando as notas
                    strSQL = "INSERT INTO Notas(" +
                        "id_aluno, " + 
                        "nota_01, " +
                        "nota_02, " +
                        "nota_03, " +
                        "nota_04" +
                        ")VALUES(" +
                        "@id_aluno, " +
                        "@nota_01, " +
                        "@nota_02, " +
                        "@nota_03, " +
                        "@nota_04" +
                        ")";

                    cmd = new SqlCommand(strSQL, Cnn);
                    cmd.Parameters.Add(new SqlParameter("@id_aluno", id));
                    cmd.Parameters.Add(new SqlParameter("@nota_01", item.Notas.Nota_01));
                    cmd.Parameters.Add(new SqlParameter("@nota_02", item.Notas.Nota_02));
                    cmd.Parameters.Add(new SqlParameter("@nota_03", item.Notas.Nota_03));
                    cmd.Parameters.Add(new SqlParameter("@nota_04", item.Notas.Nota_04));
                    cmd.ExecuteNonQuery();
                }
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Buscar os alunos e suas notas no banco de dados
        /// </summary>
        /// <returns>Uma lista contendo os alunos e suas notas</returns>
        public List<Alunos> BuscarAlunos()
        {
            try
            {
                List<Alunos> ret = new List<Alunos>();

                string strSQL = "SELECT " +
                    "a.id, " +
                    "a.nome, " +
                    "n.id, " +
                    "n.id_aluno, " +
                    "n.nota_01, " +
                    "n.nota_02, " +
                    "n.nota_03, " +
                    "n.nota_04 " +
                    "FROM Alunos a " +
                    "INNER JOIN Notas n on a.id = n.id_aluno ";

                SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
                DataSet ds =new DataSet();

                da.Fill(ds, "Alunos");

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    Notas n = new Notas((int)item["id1"], (int)item["id"], (decimal)item["nota_01"], (decimal)item["nota_02"], (decimal)item["nota_03"], (decimal)item["nota_04"]);
                    Alunos a = new Alunos((int)item["id"], item["Nome"].ToString(), n);

                    ret.Add(a);
                }

                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Alunos>();
            }
        }

        /// <summary>
        /// Pega o ultimo Id gravado na tabela
        /// </summary>
        /// <returns>Número do Id</returns>
        private int PegarUltimoId()
        {
            try
            {
                string strSQL = "SELECT MAX(id) FROM Alunos";
                SqlDataAdapter da = new SqlDataAdapter(strSQL, Cnn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Alunos");

                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    return int.Parse(item[0].ToString());
                }

                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
}
