using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AcademiaSystem
{
    public partial class F_NovoAluno : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
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
            if (destinoCompleto == "")
            {
                if(MessageBox.Show("Sem foto selecionada, deseja conitnuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pictureBox1.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar foto, deseja conitnuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
           
            string queryInsertAluno = String.Format(@"
            INSERT INTO tb_alunos
                (T_NOMEALUNO, T_TELEFONE, T_STATUS, T_FOTO)
            VALUES
                ('{0}', '{1}', '{2}', '{3}')
            ", Tb_nome.Text, Mtb_telefone.Text, Cb_status.SelectedValue, destinoCompleto);
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

        private void Btn_add_Click(object sender, EventArgs e)
        {
            origemCompleto = "";
            foto = "";
            pastaDestino = Globais.caminhoFotos;
            destinoCompleto = "";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if(File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }          
            }          
            pictureBox1.ImageLocation = origemCompleto;
        }
    }
}
