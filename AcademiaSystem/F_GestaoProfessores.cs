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
    public partial class F_gestaoProfessores : Form
    {
        public F_gestaoProfessores()
        {
            InitializeComponent();
        }

        private void F_gestaoProfessores_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDPROFESSOR as 'ID',
                    T_NOMEPROFESSOR as 'Nome',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR
            ";
            Dgv_professor.DataSource = Banco.Dql(vquery);
            Dgv_professor.Columns[0].Width = 70;
            Dgv_professor.Columns[1].Width = 230;
            Dgv_professor.Columns[2].Width = 120;
        }

        private void Dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                        SELECT 
                            *
                        FROM
                            tb_professores 
                        WHERE
                            N_IDPROFESSOR =" + vId;

                dt = Banco.Dql(vquery);
                Tb_idProfessor.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                Mtb_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                Tb_nomeProfessor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
            }
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Tb_idProfessor.Clear();
            Tb_nomeProfessor.Clear();
            Mtb_telefone.Clear();
            Tb_nomeProfessor.Focus();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (Tb_idProfessor.Text == "")
            {
                vquery = "INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) VALUES('" + Tb_nomeProfessor.Text + "','" + Mtb_telefone.Text + "' )";
            }
            else
            {
                vquery = "UPDATE tb_professores SET T_NOMEPROFESSOR = '" + Tb_nomeProfessor.Text + "', T_TELEFONE = '" + Mtb_telefone.Text + "' WHERE N_IDPROFESSOR =" + Tb_idProfessor.Text;
            }
            Banco.Dml(vquery);
            vquery = @"
                SELECT
                    N_IDPROFESSOR as 'ID',
                    T_NOMEPROFESSOR as 'Nome',
                    T_TELEFONE as 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR
            ";
            Dgv_professor.DataSource = Banco.Dql(vquery);
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_professores WHERE N_IDPROFESSOR =" + Tb_idProfessor.Text;
                Banco.Dml(vquery);
                Dgv_professor.Rows.Remove(Dgv_professor.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
