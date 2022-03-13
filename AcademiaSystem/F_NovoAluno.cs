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
    public partial class F_NovoAluno : Form
    {
        public F_NovoAluno()
        {
            InitializeComponent();
        }

        private void F_NovoAluno_Load(object sender, EventArgs e)
        {
            Dictionary<string,string> status = new Dictionary<string, string>();
            status.Add("A", "Ativo");
            status.Add("B", "Bloqueado");
            status.Add("C", "Cancelado");

            Cb_status.DataSource = new BindingSource(status,null);
            Cb_status.DisplayMember = "Value";
            Cb_status.ValueMember = "Key";
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Tb_nome.Enabled = true;
            Mtb_telefone.Enabled = true;
            Cb_status.Enabled = true;
            Tb_nome.Clear();
            Mtb_telefone.Clear();
            Tb_plano.Clear();
            Cb_status.SelectedIndex = 0;
            Tb_nome.Focus();

            Btn_gravar.Enabled = true;
            Btn_cancelar.Enabled = true;
            Btn_novo.Enabled = false;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            DesabilitarBotao();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_gravar_Click(object sender, EventArgs e)
        {
            string queryInsertAluno = String.Format(@"
            INSERT INTO tb_alunos
                (T_NOMEALUNO, T_TELEFONE, T_STATUS)
            VALUES
                ('{0}', '{1}', '{2}')
            ", Tb_nome.Text, Mtb_telefone.Text, Cb_status.SelectedValue);
            Banco.Dml(queryInsertAluno);
            MessageBox.Show("Novo Aluno inserido");
            DesabilitarBotao();
        }
        private void DesabilitarBotao()
        {
            Tb_nome.Enabled = false;
            Mtb_telefone.Enabled = false;
            Cb_status.Enabled = false;
            Tb_nome.Clear();
            Mtb_telefone.Clear();
            Tb_plano.Clear();
            Cb_status.SelectedIndex = 0;

            Btn_gravar.Enabled = false;
            Btn_cancelar.Enabled = false;
            Btn_novo.Enabled = true;
        }

        private void Btn_matricular_Click(object sender, EventArgs e)
        {
            F_MatricularAluno f_MatricularAluno = new F_MatricularAluno();
            f_MatricularAluno.ShowDialog();
        }
    }
}
