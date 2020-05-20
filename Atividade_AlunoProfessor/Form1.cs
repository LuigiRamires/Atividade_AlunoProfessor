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
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private void BtnAlunos_Click(object sender, EventArgs e)
        {
            frmAlunos frmAlunos = new frmAlunos();
            frmAlunos.ShowDialog();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            frmProfessores frmProfessores = new frmProfessores();
            frmProfessores.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
