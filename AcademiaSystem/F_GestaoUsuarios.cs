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
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            Dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            Dgv_usuarios.Columns[0].Width = 85;
            Dgv_usuarios.Columns[1].Width = 227;
        }

        private void Dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int contLinhas = dgv.SelectedRows.Count;
            if ( contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.ObterDadosUsuario(vId);
                Tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                Tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                Tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                Tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                Cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                N_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");

            }
            
        }

        private void Btn_novoUsuario_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            Dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = Dgv_usuarios.SelectedRows[0].Index;
            Usuario usuario = new Usuario();
            usuario.id = Convert.ToInt32(Tb_id.Text);
            usuario.nome = Tb_nome.Text;
            usuario.username = Tb_username.Text;
            usuario.senha = Tb_senha.Text;
            usuario.status = Cb_status.Text;
            usuario.nivel = Int32.Parse(N_nivel.Value.ToString());
            Banco.AtualizarUsuario(usuario);
            Dgv_usuarios[1, linha].Value = Tb_nome.Text;
            Dgv_usuarios.CurrentCell = Dgv_usuarios[0, linha];
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar exclusão?","Excluir?", MessageBoxButtons.YesNo);
            if(resposta == DialogResult.Yes)
            {
                Banco.DeletarUsuario(Tb_id.Text);
                Dgv_usuarios.Rows.Remove(Dgv_usuarios.CurrentRow);
            }
        }
    }
}
