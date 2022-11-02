using MediaAlunos.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAlunos
{
    public class ViewAlunoMedia
    {
        public string Aluno { get; set; }
        public decimal Nota_01 { get; set; }
        public decimal Nota_02 { get; set; }
        public decimal Nota_03 { get; set; }
        public decimal Nota_04 { get; set; }
        public decimal Media { get; set; }
        public string Resultado { get; set; }

        public ViewAlunoMedia(string aluno, decimal nota_01, decimal nota_02, decimal nota_03, decimal nota_04, decimal media, string resultado)
        {
            Aluno = aluno;
            Nota_01 = nota_01;
            Nota_02 = nota_02;
            Nota_03 = nota_03;
            Nota_04 = nota_04;
            Media = media;
            Resultado = resultado;
        }

        /// <summary>
        /// Carrega a View para exibir no grid
        /// </summary>
        /// <param name="alunos">Dados contendo os alunos e as notas</param>
        /// <returns>Uma ViewAlunoMedia com os dados da tabela</returns>
        public static List<ViewAlunoMedia> CarregarView(List<Alunos> alunos)
        {

            try
            {
                //retorno para a função
                List<ViewAlunoMedia> ret = new List<ViewAlunoMedia>();

                //Transformando os dados em View
                foreach (var item in alunos)
                {
                    ViewAlunoMedia v = new ViewAlunoMedia(item.Nome, item.Notas.Nota_01, item.Notas.Nota_02, item.Notas.Nota_03, item.Notas.Nota_04, item.Media, item.Rresultado);
                    ret.Add(v);
                }

                //Retornando
                return ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<ViewAlunoMedia>();
            }

        }
    }
}
