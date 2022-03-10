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
    public partial class F_horarios : Form
    {
        public F_horarios()
        {
            InitializeComponent();
        }

        private void F_horarios_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDHORARIO as 'ID',
                    T_DSCHORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
            Dgv_horarios.DataSource = Banco.Dql(vquery);
            Dgv_horarios.Columns[0].Width = 70;
            Dgv_horarios.Columns[1].Width = 330;
        }

        private void Dgv_horarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();

                string vId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                        SELECT 
                            *
                        FROM
                            tb_horarios 
                        WHERE
                            N_IDHORARIO =" + vId;

                dt = Banco.Dql(vquery);
                Tb_idHorario.Text = dt.Rows[0].Field<Int64>("N_IDHORARIO").ToString();
                Mtb_dscHorario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
            }
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Tb_idHorario.Clear();
            Mtb_dscHorario.Clear();
            Mtb_dscHorario.Focus();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (Tb_idHorario.Text == "")
            {
                vquery = "INSERT INTO tb_horarios (T_DSCHORARIO) VALUES('" + Mtb_dscHorario.Text + "')";
            }
            else
            {
                vquery = "UPDATE tb_horarios SET T_DSCHORARIO = '" + Mtb_dscHorario.Text + "' WHERE N_IDHORARIO ="+Tb_idHorario.Text;
            }
                Banco.Dml(vquery);
                vquery = @"
                SELECT
                    N_IDHORARIO as 'ID',
                    T_DSCHORARIO as 'Horário'
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
                Dgv_horarios.DataSource = Banco.Dql(vquery);
            
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_horarios WHERE N_IDHORARIO =" +Tb_idHorario.Text;
                Banco.Dml(vquery);
                Dgv_horarios.Rows.Remove(Dgv_horarios.CurrentRow);
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
