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
    public partial class frmProfessores : Form
    {
        public frmProfessores()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Professores professores = new Professores();
            professores.Nome = txtNome.Text;
            professores.Idade = int.Parse(txtIdade.Text);
            professores.Disciplina = cbxCurso.SelectedItem.ToString();
            professores.Salario = int.Parse(txtMatricula.Text);
            this.Hide();
            professores.exibir();
        }
    }
}
