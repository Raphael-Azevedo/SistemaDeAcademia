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
    public partial class F_SelecionarTurma : Form
    {
        F_MatricularAluno formMatricula;
        public F_SelecionarTurma(F_MatricularAluno f)
        {
            InitializeComponent();
            formMatricula = f;
        }

        private void F_SelecionarTurma_Load(object sender, EventArgs e)
        {
            string queryTurmas = String.Format(@"
            SELECT
                tbt.N_IDTURMA as 'ID',
                tbt.T_DSCTURMA as 'Turma',
                tbh.T_DSCHORARIO as 'Horário',
                tbp.T_NOMEPROFESSOR as 'Professor',
                tbt.N_MAXALUNOS as 'Máx. Alunos',
                (SELECT 
                    count(N_IDALUNO)
                FROM
                    tb_alunosTurma as tbat
                WHERE
                    tbat.N_IDTURMA = tbt.N_IDTURMA and T_STATUS = 'A'
                ) as 'Qtd. Alunos'
                
            FROM
                tb_turmas as tbt
            INNER JOIN
                tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
            INNER JOIN
                tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
            
            ");
            Dgv_turmas.DataSource = Banco.Dql(queryTurmas);
        }

        private void Dgv_turmas_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxAlunos = 0;
            int qtdeAlunos = 0;
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());
            if (qtdeAlunos >= maxAlunos)
            {
                MessageBox.Show("Não há vagas nesta turma");
            }
            else
            {
                formMatricula.Tb_turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formMatricula.Tb_turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
            
        }
    }
}
