using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_AlunoProfessor
{
    class Professores : Pessoa
    {
        public string Disciplina;
        public int Salario;

        public void exibir()
        {
            System.Windows.Forms.MessageBox.Show("\nNome: " + Nome + "\nIdade: " + Idade.ToString() + "\nSalário: " + Salario.ToString() + "\nDisciplina:" + Disciplina + "\n CADASTRO REALIZADO COM SUCESSO!");
        }
    }
}
