namespace AcademiaSystem
{
    partial class F_GestaoTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.Btn_imprimirTurma = new System.Windows.Forms.Button();
            this.Btn_excluirTurma = new System.Windows.Forms.Button();
            this.Btn_novaTurma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cb_professor = new System.Windows.Forms.ComboBox();
            this.N_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.Cb_horario = new System.Windows.Forms.ComboBox();
            this.Dgv_turmas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_dscTurma = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_maxAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_salvarEdicoes);
            this.panel1.Controls.Add(this.Btn_imprimirTurma);
            this.panel1.Controls.Add(this.Btn_excluirTurma);
            this.panel1.Controls.Add(this.Btn_novaTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 32);
            this.panel1.TabIndex = 0;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(604, 3);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(100, 23);
            this.Btn_fechar.TabIndex = 10;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Btn_salvarEdicoes
            // 
            this.Btn_salvarEdicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvarEdicoes.Location = new System.Drawing.Point(154, 3);
            this.Btn_salvarEdicoes.Name = "Btn_salvarEdicoes";
            this.Btn_salvarEdicoes.Size = new System.Drawing.Size(136, 23);
            this.Btn_salvarEdicoes.TabIndex = 7;
            this.Btn_salvarEdicoes.Text = "Salvar Edições";
            this.Btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.Btn_salvarEdicoes.Click += new System.EventHandler(this.Btn_salvarEdicoes_Click);
            // 
            // Btn_imprimirTurma
            // 
            this.Btn_imprimirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_imprimirTurma.Location = new System.Drawing.Point(438, 3);
            this.Btn_imprimirTurma.Name = "Btn_imprimirTurma";
            this.Btn_imprimirTurma.Size = new System.Drawing.Size(136, 23);
            this.Btn_imprimirTurma.TabIndex = 9;
            this.Btn_imprimirTurma.Text = "Imprimir Turma";
            this.Btn_imprimirTurma.UseVisualStyleBackColor = true;
            // 
            // Btn_excluirTurma
            // 
            this.Btn_excluirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excluirTurma.Location = new System.Drawing.Point(296, 3);
            this.Btn_excluirTurma.Name = "Btn_excluirTurma";
            this.Btn_excluirTurma.Size = new System.Drawing.Size(136, 23);
            this.Btn_excluirTurma.TabIndex = 8;
            this.Btn_excluirTurma.Text = "Excluir Turma";
            this.Btn_excluirTurma.UseVisualStyleBackColor = true;
            this.Btn_excluirTurma.Click += new System.EventHandler(this.Btn_excluirTurma_Click);
            // 
            // Btn_novaTurma
            // 
            this.Btn_novaTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novaTurma.Location = new System.Drawing.Point(12, 3);
            this.Btn_novaTurma.Name = "Btn_novaTurma";
            this.Btn_novaTurma.Size = new System.Drawing.Size(136, 23);
            this.Btn_novaTurma.TabIndex = 6;
            this.Btn_novaTurma.Text = "Nova Turma";
            this.Btn_novaTurma.UseVisualStyleBackColor = true;
            this.Btn_novaTurma.Click += new System.EventHandler(this.Btn_novaTurma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Máximo Alunos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // Cb_professor
            // 
            this.Cb_professor.FormattingEnabled = true;
            this.Cb_professor.Location = new System.Drawing.Point(406, 74);
            this.Cb_professor.Name = "Cb_professor";
            this.Cb_professor.Size = new System.Drawing.Size(297, 21);
            this.Cb_professor.TabIndex = 2;
            // 
            // N_maxAlunos
            // 
            this.N_maxAlunos.Location = new System.Drawing.Point(406, 130);
            this.N_maxAlunos.Name = "N_maxAlunos";
            this.N_maxAlunos.Size = new System.Drawing.Size(136, 20);
            this.N_maxAlunos.TabIndex = 3;
            // 
            // Cb_status
            // 
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Location = new System.Drawing.Point(548, 130);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(155, 21);
            this.Cb_status.TabIndex = 4;
            // 
            // Cb_horario
            // 
            this.Cb_horario.FormattingEnabled = true;
            this.Cb_horario.Location = new System.Drawing.Point(406, 189);
            this.Cb_horario.Name = "Cb_horario";
            this.Cb_horario.Size = new System.Drawing.Size(297, 21);
            this.Cb_horario.TabIndex = 5;
            // 
            // Dgv_turmas
            // 
            this.Dgv_turmas.AllowUserToAddRows = false;
            this.Dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_turmas.EnableHeadersVisualStyles = false;
            this.Dgv_turmas.Location = new System.Drawing.Point(6, 9);
            this.Dgv_turmas.MultiSelect = false;
            this.Dgv_turmas.Name = "Dgv_turmas";
            this.Dgv_turmas.ReadOnly = true;
            this.Dgv_turmas.RowHeadersVisible = false;
            this.Dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_turmas.Size = new System.Drawing.Size(395, 401);
            this.Dgv_turmas.TabIndex = 9;
            this.Dgv_turmas.SelectionChanged += new System.EventHandler(this.Dgv_turmas_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome da Turma";
            // 
            // Tb_dscTurma
            // 
            this.Tb_dscTurma.Location = new System.Drawing.Point(407, 25);
            this.Tb_dscTurma.Name = "Tb_dscTurma";
            this.Tb_dscTurma.Size = new System.Drawing.Size(296, 20);
            this.Tb_dscTurma.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vagas";
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Tb_dscTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_turmas);
            this.Controls.Add(this.Cb_horario);
            this.Controls.Add(this.Cb_status);
            this.Controls.Add(this.N_maxAlunos);
            this.Controls.Add(this.Cb_professor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.N_maxAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_salvarEdicoes;
        private System.Windows.Forms.Button Btn_imprimirTurma;
        private System.Windows.Forms.Button Btn_excluirTurma;
        private System.Windows.Forms.Button Btn_novaTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cb_professor;
        private System.Windows.Forms.NumericUpDown N_maxAlunos;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.ComboBox Cb_horario;
        private System.Windows.Forms.DataGridView Dgv_turmas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_dscTurma;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}