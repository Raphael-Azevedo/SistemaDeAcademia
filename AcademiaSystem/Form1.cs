using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
            Restricao();
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
            Restricao();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lb_acesso.Text = "0";
            Lb_nomeUsuario.Text = "---";
            Pb_ledLogado.Image = Properties.Resources.led_vermelha_pgn;
            Globais.nivel = 0;
            Globais.logado = false;
            Restricao();
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
            f_GestaoUsuarios.ShowDialog();
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        private void Restricao()
        {
            if(Globais.logado && Globais.nivel == 3)
            {
                manutençãoToolStripMenuItem.Enabled = true;
                usuáriosToolStripMenuItem.Enabled = true;
            }
            if (Globais.logado && Globais.nivel == 2)
            {
                usuáriosToolStripMenuItem.Enabled = true;
                manutençãoToolStripMenuItem.Enabled = false;
            }
            if (Globais.logado && Globais.nivel == 1)
            {
                usuáriosToolStripMenuItem.Enabled=false;
                manutençãoToolStripMenuItem.Enabled = false;
            }
            if ((Globais.logado && Globais.nivel == 0) || (!Globais.logado))
            {
                usuáriosToolStripMenuItem.Enabled = false;
                manutençãoToolStripMenuItem.Enabled = false;
            }
          

        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_horarios f_Horarios = new F_horarios();
            f_Horarios.ShowDialog();
        }

        private void gestãoDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_gestaoProfessores f_GestaoProfessores = new F_gestaoProfessores();
            f_GestaoProfessores.ShowDialog();
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            f_GestaoTurmas.ShowDialog();
        }
    }
}
