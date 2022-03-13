namespace AcademiaSystem
{
    partial class F_MatricularAluno
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_matricular = new System.Windows.Forms.Button();
            this.Dgv_aluno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_id = new System.Windows.Forms.TextBox();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_turma = new System.Windows.Forms.TextBox();
            this.Btn_turma = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aluno)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_matricular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 49);
            this.panel1.TabIndex = 0;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(194, 22);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(136, 23);
            this.Btn_fechar.TabIndex = 11;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Btn_matricular
            // 
            this.Btn_matricular.Location = new System.Drawing.Point(3, 22);
            this.Btn_matricular.Name = "Btn_matricular";
            this.Btn_matricular.Size = new System.Drawing.Size(136, 23);
            this.Btn_matricular.TabIndex = 9;
            this.Btn_matricular.Text = "Matricular";
            this.Btn_matricular.UseVisualStyleBackColor = true;
            this.Btn_matricular.Click += new System.EventHandler(this.Btn_matricular_Click);
            // 
            // Dgv_aluno
            // 
            this.Dgv_aluno.AllowUserToAddRows = false;
            this.Dgv_aluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_aluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_aluno.EnableHeadersVisualStyles = false;
            this.Dgv_aluno.Location = new System.Drawing.Point(12, 12);
            this.Dgv_aluno.MultiSelect = false;
            this.Dgv_aluno.Name = "Dgv_aluno";
            this.Dgv_aluno.ReadOnly = true;
            this.Dgv_aluno.RowHeadersVisible = false;
            this.Dgv_aluno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_aluno.Size = new System.Drawing.Size(313, 253);
            this.Dgv_aluno.TabIndex = 1;
            this.Dgv_aluno.SelectionChanged += new System.EventHandler(this.Dgv_aluno_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // Tb_id
            // 
            this.Tb_id.Location = new System.Drawing.Point(12, 284);
            this.Tb_id.Name = "Tb_id";
            this.Tb_id.ReadOnly = true;
            this.Tb_id.Size = new System.Drawing.Size(57, 20);
            this.Tb_id.TabIndex = 3;
            // 
            // Tb_nome
            // 
            this.Tb_nome.Location = new System.Drawing.Point(94, 284);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(231, 20);
            this.Tb_nome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Turma";
            // 
            // Tb_turma
            // 
            this.Tb_turma.Location = new System.Drawing.Point(12, 334);
            this.Tb_turma.Name = "Tb_turma";
            this.Tb_turma.ReadOnly = true;
            this.Tb_turma.Size = new System.Drawing.Size(175, 20);
            this.Tb_turma.TabIndex = 7;
            this.Tb_turma.Tag = "2";
            // 
            // Btn_turma
            // 
            this.Btn_turma.Location = new System.Drawing.Point(183, 332);
            this.Btn_turma.Name = "Btn_turma";
            this.Btn_turma.Size = new System.Drawing.Size(27, 23);
            this.Btn_turma.TabIndex = 8;
            this.Btn_turma.Text = "...";
            this.Btn_turma.UseVisualStyleBackColor = true;
            this.Btn_turma.Click += new System.EventHandler(this.Btn_turma_Click);
            // 
            // F_MatricularAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 410);
            this.Controls.Add(this.Btn_turma);
            this.Controls.Add(this.Tb_turma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.Tb_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_aluno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_MatricularAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricular Aluno";
            this.Load += new System.EventHandler(this.F_MatricularAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_aluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_aluno;
        private System.Windows.Forms.Button Btn_matricular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_id;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_turma;
        private System.Windows.Forms.Button Btn_fechar;
        public System.Windows.Forms.TextBox Tb_turma;
    }
}