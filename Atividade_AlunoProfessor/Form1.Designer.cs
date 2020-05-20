namespace Atividade_AlunoProfessor
{
    partial class frmInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.lblSistemaEscola = new System.Windows.Forms.Label();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.lblCreditos = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSistemaEscola
            // 
            this.lblSistemaEscola.AutoSize = true;
            this.lblSistemaEscola.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaEscola.Location = new System.Drawing.Point(222, 9);
            this.lblSistemaEscola.Name = "lblSistemaEscola";
            this.lblSistemaEscola.Size = new System.Drawing.Size(207, 32);
            this.lblSistemaEscola.TabIndex = 0;
            this.lblSistemaEscola.Text = "Sistema Escola";
            // 
            // btnProfessor
            // 
            this.btnProfessor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessor.Location = new System.Drawing.Point(228, 88);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(99, 36);
            this.btnProfessor.TabIndex = 1;
            this.btnProfessor.Text = "Professores";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.BtnProfessor_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(99, 52);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(461, 22);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Para registrar alguém selecione os botões abaixo:";
            // 
            // btnAlunos
            // 
            this.btnAlunos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlunos.Location = new System.Drawing.Point(333, 88);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(99, 36);
            this.btnAlunos.TabIndex = 3;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.BtnAlunos_Click);
            // 
            // lblCreditos
            // 
            this.lblCreditos.AutoSize = true;
            this.lblCreditos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditos.Location = new System.Drawing.Point(70, 137);
            this.lblCreditos.Name = "lblCreditos";
            this.lblCreditos.Size = new System.Drawing.Size(540, 16);
            this.lblCreditos.TabIndex = 4;
            this.lblCreditos.Text = "Versão 1.0 desenvolvida durante as aulas de Desenvolvimento de Sistemas na ETEC d" +
    "e Guarulhos";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(595, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 164);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCreditos);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.lblSistemaEscola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSistemaEscola;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Label lblCreditos;
        private System.Windows.Forms.Button btnSair;
    }
}

