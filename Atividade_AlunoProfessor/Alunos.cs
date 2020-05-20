using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_AlunoProfessor
{
    class Alunos: Pessoa
    {
        public string Curso;
        public int n_matricula;

        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("\nNome: " + Nome + "\nIdade: " + Idade.ToString() + "\nMatrícula: " + n_matricula.ToString() + "\nCurso:" + Curso + "\n CADASTRO REALIZADO COM SUCESSO!");
        }
    }
}
