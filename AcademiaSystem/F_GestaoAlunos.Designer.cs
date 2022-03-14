namespace AcademiaSystem
{
    partial class F_GestaoAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_financeiro = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Dgv_aluno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.Cb_turmas = new System.Windows.Forms.ComboBox();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_financeiro);
            this.panel1.Controls.Add(this.Btn_excluir);
            this.panel1.Controls.Add(this.Btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 33);
            this.panel1.TabIndex = 0;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(459, 3);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(146, 23);
            this.Btn_fechar.TabIndex = 3;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Btn_financeiro
            // 
            this.Btn_financeiro.Location = new System.Drawing.Point(307, 3);
            this.Btn_financeiro.Name = "Btn_financeiro";
            this.Btn_financeiro.Size = new System.Drawing.Size(146, 23);
            this.Btn_financeiro.TabIndex = 2;
            this.Btn_financeiro.Text = "Financeiro";
            this.Btn_financeiro.UseVisualStyleBackColor = true;
            this.Btn_financeiro.Click += new System.EventHandler(this.Btn_financeiro_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Location = new System.Drawing.Point(155, 3);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(146, 23);
            this.Btn_excluir.TabIndex = 1;
            this.Btn_excluir.Text = "Excluir Aluno";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Location = new System.Drawing.Point(3, 3);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(146, 23);
            this.Btn_salvar.TabIndex = 0;
            this.Btn_salvar.Text = "Salvar Edições";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Dgv_aluno
            // 
            this.Dgv_aluno.AllowUserToAddRows = false;
            this.Dgv_aluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_aluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aluno.EnableHeadersVisualStyles = false;
            this.Dgv_aluno.Location = new System.Drawing.Point(12, 12);
            this.Dgv_aluno.MultiSelect = false;
            this.Dgv_aluno.Name = "Dgv_aluno";
            this.Dgv_aluno.ReadOnly = true;
            this.Dgv_aluno.RowHeadersVisible = false;
            this.Dgv_aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_aluno.Size = new System.Drawing.Size(283, 455);
            this.Dgv_aluno.TabIndex = 1;
            this.Dgv_aluno.SelectionChanged += new System.EventHandler(this.Dgv_aluno_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turmas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clique duplo para alterar a foto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone";
            // 
            // Tb_nome
            // 
            this.Tb_nome.Location = new System.Drawing.Point(304, 28);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(279, 20);
            this.Tb_nome.TabIndex = 7;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(304, 78);
            this.maskedTextBox1.Mask = "(00)00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(108, 20);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // Cb_status
            // 
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Location = new System.Drawing.Point(424, 78);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(159, 21);
            this.Cb_status.TabIndex = 9;
            // 
            // Cb_turmas
            // 
            this.Cb_turmas.FormattingEnabled = true;
            this.Cb_turmas.Location = new System.Drawing.Point(304, 135);
            this.Cb_turmas.Name = "Cb_turmas";
            this.Cb_turmas.Size = new System.Drawing.Size(279, 21);
            this.Cb_turmas.TabIndex = 10;
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.Location = new System.Drawing.Point(304, 177);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(279, 23);
            this.Btn_imprimir.TabIndex = 11;
            this.Btn_imprimir.Text = "Imprimir Carteirinha";
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(317, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_imprimir);
            this.Controls.Add(this.Cb_turmas);
            this.Controls.Add(this.Cb_status);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_aluno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Alunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_aluno;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_financeiro;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.ComboBox Cb_turmas;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}