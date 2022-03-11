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
    public partial class F_GestaoTurmas : Form
    {
        string idSelecionado;
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                SELECT
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            ";
            Dgv_turmas.DataSource = Banco.Dql(vqueryDGV);
            Dgv_turmas.Columns[0].Width = 40;
            Dgv_turmas.Columns[1].Width = 120;
            Dgv_turmas.Columns[2].Width = 85;

            string vqueryProfessores = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR
            ";
            Cb_professor.Items.Clear();
            Cb_professor.DataSource = Banco.Dql(vqueryProfessores);
            Cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            Cb_professor.ValueMember = "N_IDPROFESSOR";

            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A","Ativa");
            status.Add("P","Paralisada");
            status.Add("C","Cancelada");

            Cb_status.Items.Clear();
            Cb_status.DataSource = new BindingSource(status,null);
            Cb_status.DisplayMember = "Value";
            Cb_status.ValueMember = "Key";

            string vqueryHorarios = @"
                SELECT
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
            Cb_horario.Items.Clear();
            Cb_horario.DataSource = Banco.Dql(vqueryHorarios);
            Cb_horario.DisplayMember = "T_DSCHORARIO";
            Cb_horario.ValueMember = "N_IDHORARIO";
        }

        private void Dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if(contLinhas > 0)
            {
                idSelecionado = Dgv_turmas.Rows[Dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT
                        T_DSCTURMA,
                        N_IDPROFESSOR,
                        N_IDHORARIO,
                        N_MAXALUNOS,
                        T_STATUS
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA ="+idSelecionado;

                DataTable dt = Banco.Dql(vqueryCampos);
                Cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                N_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                Cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                Cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                Tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
            }
        }

        private void Btn_novaTurma_Click(object sender, EventArgs e)
        {
            Cb_professor.SelectedIndex = -1;
            N_maxAlunos.Value = 0;
            Cb_status.SelectedIndex = -1;
            Cb_horario.SelectedIndex = -1;
            Tb_dscTurma.Clear();
            Tb_dscTurma.Focus();
        }

        private void Btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            int linha = Dgv_turmas.SelectedRows[0].Index;
            string queryAtualizarTurma = String.Format(@"
                UPDATE
                    tb_turmas
                SET
                    T_DSCTURMA = '{0}',
                    N_IDPROFESSOR = {1},
                    N_IDHORARIO = {2},
                    N_MAXALUNOS = {3},
                    T_STATUS = '{4}'
                WHERE 
                    N_IDTURMA = {5}
            ",Tb_dscTurma.Text, Cb_professor.SelectedValue, Cb_horario.SelectedValue, Int32.Parse(N_maxAlunos.Value.ToString()), Cb_status.SelectedValue, idSelecionado);
            Banco.Dml(queryAtualizarTurma);
            Dgv_turmas[1, linha].Value = Tb_dscTurma.Text;
            Dgv_turmas[2, linha].Value = Cb_horario.Text;
            MessageBox.Show("Dados Gravados");
        }

        private void Btn_excluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão?", "Excluir?", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                    DELETE
                    FROM
                        tb_turmas
                    WHERE
                        N_IDTURMA = {0}
                    ",idSelecionado);
                Banco.Dml(queryExcluirTurma);
                Dgv_turmas.Rows.Remove(Dgv_turmas.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
