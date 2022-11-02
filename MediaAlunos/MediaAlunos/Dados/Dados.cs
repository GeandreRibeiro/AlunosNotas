using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos.Dados
{
    public class Alunos
    {
        /// <summary>
        /// Id do Aluno Automatico
        /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// Nome do Aluno
        /// </summary>
        public string Nome { get; set; }
       
        /// <summary>
        /// Notas do Aluno
        /// </summary>
        public Notas Notas { get; set; }
       
        /// <summary>
        /// Media das notas do Aluno
        /// </summary>
        public decimal Media 
        {
            get 
            {
                return (Notas.Nota_01 + Notas.Nota_02 + Notas.Nota_03 + Notas.Nota_04) / 4;
            } 
        }
        
        /// <summary>
        /// Resultado da aprovação do Aluno
        /// </summary>
        public string Rresultado 
        {
            get
            {
                string resultado = "";
                if (Media > 7)
                    resultado = "Aprovado";
                else if (Media > 5 && Media < 7)
                    resultado = "Recuperação";
                else if (Media <= 5)
                    resultado = "Reprovado";

                return resultado;
            }
        }

        public Alunos()
        {

        }

        public Alunos(int id, string nome, Notas notas)
        {
            Id = id;
            Nome = nome;
            Notas = notas;
        }
    }

    public class Notas
    {
        /// <summary>
        /// Id da nota automatico
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Id do Aluno
        /// </summary>
        public int id_Aluno { get; set; }

        /// <summary>
        /// Valor da nota 01
        /// </summary>
        public decimal Nota_01 { get; set; }

        /// <summary>
        /// Valor da nota 02
        /// </summary>
        public decimal Nota_02 { get; set; }

        /// <summary>
        /// Valor da nota 03
        /// </summary>
        public decimal Nota_03 { get; set; }

        /// <summary>
        /// Valor da nota 04
        /// </summary>
        public decimal Nota_04 { get; set; }


        public Notas(int id, int id_Aluno, decimal nota_01, decimal nota_02, decimal nota_03, decimal nota_04)
        {
            Id = id;
            this.id_Aluno = id_Aluno;
            Nota_01 = nota_01;
            Nota_02 = nota_02;
            Nota_03 = nota_03;
            Nota_04 = nota_04;
        }
        public Notas()
        {

        }

    }

}
