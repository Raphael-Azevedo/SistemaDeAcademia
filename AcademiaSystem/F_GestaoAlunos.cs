using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaSystem
{
    public partial class F_GestaoAlunos : Form
    {
        string vqueryDGV = "";
        string turmaAtual = "";
        string idSelecionado = "";
        string turma = "";
        int linha = 0;
        public F_GestaoAlunos()
        {
            InitializeComponent();
        }

        private void F_GestaoAlunos_Load(object sender, EventArgs e)
        {
           vqueryDGV = @"
            SELECT
                N_IDALUNO as 'ID',
                T_NOMEALUNO as 'Aluno'
            FROM
                tb_alunos
            ";

            Dgv_aluno.DataSource = Banco.Dql(vqueryDGV);
            Dgv_aluno.Columns[0].Width = 40;
            Dgv_aluno.Columns[1].Width = 120;

            Tb_nome.Text = Dgv_aluno.Rows[Dgv_aluno.SelectedRows[0].Index].Cells[1].Value.ToString();
            // tem que fazer um join

            string vqueryTurmas = @"
            SELECT
                N_IDTURMA,
                ('Vagas: ' || (
                                    (N_MAXALUNOS) - (
                                                        SELECT
                                                            count(tbat.N_IDALUNO)
                                                        FROM
                                                            tb_alunosTurma as tbat
                                                        INNER JOIN
                                                            tb_alunos as tba on tba.N_IDALUNO = tbat.N_IDALUNO    
                                                        WHERE
                                                            tba.T_STATUS = 'A' and tbat.N_IDTURMA = N_IDTURMA
                                                    )
                               ) || ' / Turma: ' || T_DSCTURMA
                ) as 'Turma'
                FROM
                    tb_turmas
                ORDER BY
                    N_IDTURMA
            ";
            Cb_turmas.Items.Clear();
            Cb_turmas.DataSource = Banco.Dql(vqueryTurmas);
            Cb_turmas.DisplayMember = "Turma";
            Cb_turmas.ValueMember = "N_IDTURMA";

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("A", "Ativo");
            dic.Add("B", "Bloqueado");
            dic.Add("C", "Cancelado");
            Cb_status.DataSource = new BindingSource(dic, null);
            Cb_status.DisplayMember = "Value";
            Cb_status.ValueMember = "Key";

            turma = Cb_turmas.Text;
            turmaAtual = Cb_turmas.Text;
            idSelecionado = Dgv_aluno.Rows[0].Cells[0].Value.ToString();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if(turmaAtual != turma)
            {
                string[] t = turma.Split(' ');
                int vagas = int.Parse(t[1]);
                if(vagas < 1)
                {
                    MessageBox.Show("Não há vagas na turma selecionada, selecione outra turma");
                    Cb_turmas.Focus();
                    return;
                }
            }
            linha = Dgv_aluno.SelectedRows[0].Index;
            string queryAtualizarAluno = String.Format(@"
                UPDATE
                    tb_alunos
                SET
                    T_NOMEALUNO= '{0}',
                    T_TELEFONE = '{1}',
                    T_STATUS = '{2}'
                WHERE
                    N_IDALUNO = {3}",Tb_nome.Text, maskedTextBox1.Text, Cb_status.SelectedValue, idSelecionado);
            Banco.Dml(queryAtualizarAluno);
            Dgv_aluno[1, linha].Value = Tb_nome.Text;
            MessageBox.Show("Atualizações gravadas");
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                if( File.Exists(pictureBox1.ImageLocation))
                {
                    File.Delete(pictureBox1.ImageLocation);
                }
                string vqueryExcluirAluno = String.Format(@"
                    DELETE FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO = {0}",idSelecionado);
                Banco.Dml(vqueryExcluirAluno);
                Dgv_aluno.Rows.Remove(Dgv_aluno.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_financeiro_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if(dgv.SelectedRows.Count > 0)
            {
                idSelecionado = Dgv_aluno.Rows[0].Cells[0].Value.ToString();
                Tb_nome.Text = Dgv_aluno.Rows[Dgv_aluno.SelectedRows[0].Index].Cells[1].Value.ToString();
                idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = String.Format(@"
                    SELECT
                        N_IDALUNO,
                        T_NOMEALUNO,
                        T_TELEFONE,
                        T_STATUS,
                        T_FOTO
                    FROM
                        tb_alunos
                    WHERE N_IDALUNO = {0}",idSelecionado);
                DataTable dt = Banco.Dql(vqueryCampos);
                Tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                maskedTextBox1.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                Cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                turmaAtual = Cb_turmas.Text;
                pictureBox1.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
            }
        }
    }
}
