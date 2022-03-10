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


    }
}
