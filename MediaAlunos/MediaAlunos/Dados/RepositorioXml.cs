using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MediaAlunos.Dados
{
    public static class RepositorioXml
    {
        /// <summary>
        /// Inicia o banco com dados fixos para teste XML
        /// </summary>
        /// <param name="caminho">Caminho para o banco de dados em xml</param>
        /// <returns>true se deu tudo certo, false se ocorreu algum erro</returns>
        public static bool IniciarBanco(string caminho)
        {
            try
            {
                //configurando o caminho para o arquivo tabela
                string Arquivo = $@"{caminho}\Alunos.xml";

                //se não existir o arquivo vamos criar um novo
                using (XmlTextWriter wxml = new XmlTextWriter(Arquivo, System.Text.Encoding.UTF8))
                {
                    wxml.WriteStartDocument(true);
                    wxml.Indentation = 2;
                    wxml.WriteStartElement("Alunos");

                    //Geandre
                    wxml.WriteStartElement("Aluno");

                    wxml.WriteElementString("id", "1");
                    wxml.WriteElementString("nome", "Geandre Ribeiro");

                    wxml.WriteStartElement("Nota");
                    wxml.WriteElementString("id", "1");
                    wxml.WriteElementString("id_aluno", "1");
                    wxml.WriteElementString("nota_01", "9");
                    wxml.WriteElementString("nota_02", "6.5");
                    wxml.WriteElementString("nota_03", "6");
                    wxml.WriteElementString("nota_04", "6");
                    wxml.WriteEndElement();
                    wxml.WriteEndElement();
                    //Alexandre
                    wxml.WriteStartElement("Aluno");

                    wxml.WriteElementString("id", "2");
                    wxml.WriteElementString("nome", "Alexandre Ribeiro");

                    wxml.WriteStartElement("Nota");
                    wxml.WriteElementString("id", "2");
                    wxml.WriteElementString("id_aluno", "2");
                    wxml.WriteElementString("nota_01", "7");
                    wxml.WriteElementString("nota_02", "5.5");
                    wxml.WriteElementString("nota_03", "4");
                    wxml.WriteElementString("nota_04", "3");
                    wxml.WriteEndElement();
                    wxml.WriteEndElement();

                    //Lourdes
                    wxml.WriteStartElement("Aluno");

                    wxml.WriteElementString("id", "3");
                    wxml.WriteElementString("nome", "Lourdes Franco");

                    wxml.WriteStartElement("Nota");
                    wxml.WriteElementString("id", "3");
                    wxml.WriteElementString("id_aluno", "3");
                    wxml.WriteElementString("nota_01", "9");
                    wxml.WriteElementString("nota_02", "7.5");
                    wxml.WriteElementString("nota_03", "6");
                    wxml.WriteElementString("nota_04", "7");
                    wxml.WriteEndElement();
                    wxml.WriteEndElement();

                    wxml.Close();
                    wxml.Dispose();
                }

                return true;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// Busca os alunos gravados no xml
        /// </summary>
        /// <param name="caminho">Caminho do xml</param>
        /// <returns>Uma lista contendo os alunos e suas notas</returns>
        public static List<Alunos> BuscarAlunos(string caminho)
        {
            try
            {
                string Arquivo = $@"{caminho}\Alunos.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(Arquivo);

                List<Alunos> ret = new List<Alunos>();
                Alunos a = null;
                Notas n = null;
                foreach (XmlNode item in doc.ChildNodes)
                {
                    if(item.Name == "Alunos")
                    {
                        foreach (XmlNode Aluno in item.ChildNodes)
                        {
                            foreach (XmlNode al in Aluno.ChildNodes)
                            {
                                if (al.Name == "id")
                                {
                                    a = new Alunos();
                                    a.Id = int.Parse(al.InnerText);
                                }
                                if (al.Name == "nome")
                                    a.Nome = al.InnerText;

                                if (al.Name == "Nota")
                                {
                                    foreach (XmlNode nota in al.ChildNodes)
                                    {
                                        if(nota.Name == "id")
                                        {
                                            n = new Notas();
                                            n.Id = int.Parse(nota.InnerText);
                                        }

                                        if(nota.Name == "id_aluno")
                                            n.id_Aluno = int.Parse(nota.InnerText);

                                        if (nota.Name == "nota_01")
                                            n.Nota_01 = decimal.Parse(nota.InnerText.Replace(".", ","));

                                        if (nota.Name == "nota_02")
                                            n.Nota_02 = decimal.Parse(nota.InnerText.Replace(".", ","));

                                        if (nota.Name == "nota_03")
                                            n.Nota_03 = decimal.Parse(nota.InnerText.Replace(".", ","));

                                        if (nota.Name == "nota_04")
                                        {
                                            n.Nota_04 = decimal.Parse(nota.InnerText.Replace(".", ","));
                                            a.Notas = n;
                                            ret.Add(a);
                                        }
                                    }
                                }
                            }
                            
                        }
                    }
                }

                return ret;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Alunos>();
            }
        }
        
    }
}
