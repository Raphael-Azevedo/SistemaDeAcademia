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
    public partial class F_MatricularAluno : Form
    {
        public F_MatricularAluno()
        {
            InitializeComponent();
        }
        string idSelecionado;
        private void F_MatricularAluno_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                SELECT
                    N_IDALUNO as 'ID',
                    T_NOMEALUNO as 'Nome'        
                FROM
                    tb_alunos 
            ";
            Dgv_aluno.DataSource = Banco.Dql(vqueryDGV);
            Dgv_aluno.Columns[0].Width = 40;
            Dgv_aluno.Columns[1].Width = 230;
            
        }

        private void Dgv_aluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                idSelecionado = Dgv_aluno.Rows[Dgv_aluno.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                    SELECT                       
                        N_IDALUNO,
                        T_NOMEALUNO                        
                    FROM
                        tb_alunos
                    WHERE
                        N_IDALUNO =" + idSelecionado;

                DataTable dt = Banco.Dql(vqueryCampos);
                Tb_id.Text = idSelecionado;
                Tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEALUNO");
                }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_matricular_Click(object sender, EventArgs e)
        {
            string queryVerificarAluno = String.Format(@"
                SELECT 
                    count(N_IDALUNO) as 'count'
                FROM
                    tb_alunosTurma as tbat
                WHERE
                    tbat.N_IDTURMA = {0} and tbat.N_IDALUNO = {1}
                ",Tb_turma.Tag,int.Parse(Tb_id.Text));
             DataTable dt = Banco.Dql(queryVerificarAluno);
            var contAluno =Int32.Parse(dt.Rows[0].Field<Int64>("count").ToString());
            if(contAluno > 1)
            {
                MessageBox.Show("Aluno já matriculado nesta turma!");
            }
            else
            {
                string queryInsertAluno = String.Format(@"
            INSERT INTO tb_alunosTurma
                (N_IDALUNO, N_IDTURMA)
            VALUES
                ({0}, {1})
            ", int.Parse(Tb_id.Text), Tb_turma.Tag.ToString());
                Banco.Dml(queryInsertAluno);
                MessageBox.Show("Novo Aluno inserido");
                Tb_turma.Clear();
                Tb_nome.Clear();
                Tb_id.Clear();
            }
            
        }

        private void Btn_turma_Click(object sender, EventArgs e)
        {
            F_SelecionarTurma f_SelecionarTurma = new F_SelecionarTurma(this);
            f_SelecionarTurma.ShowDialog();
        }
    }
}
