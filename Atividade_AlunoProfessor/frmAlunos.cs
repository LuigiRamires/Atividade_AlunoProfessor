using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_AlunoProfessor
{
    public partial class frmAlunos : Form
    {
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos();
            alunos.Nome = txtNome.Text;
            alunos.Idade = int.Parse(txtIdade.Text);
            alunos.Curso = cbxCurso.SelectedItem.ToString();
            alunos.n_matricula = int.Parse(txtMatricula.Text);
            this.Hide();
            alunos.exibir();
        }
    }
}
