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
    public partial class F_NovoUsuario : Form
    {
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();

            LimparCampos();

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            Tb_nome.Clear();
            Tb_username.Clear();
            Tb_senha.Clear();
            Cb_status.Text = "";
            N_nivel.Value = 0;
            Tb_nome.Focus();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja sair sem salvar?", "Salvar Cadastro!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (confirm.ToString().ToUpper() == "NO")
            {
                return;
            }
            LimparCampos();
        }

        private void SalvarUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.nome = Tb_nome.Text;
            usuario.username = Tb_username.Text;
            usuario.senha = Tb_senha.Text;
            usuario.status = Cb_status.Text;
            usuario.nivel = Int32.Parse(N_nivel.Value.ToString());

            Banco.NovoUsuario(usuario);
        }
    }
}
