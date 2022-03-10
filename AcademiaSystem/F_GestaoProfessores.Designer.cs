namespace AcademiaSystem
{
    partial class F_gestaoProfessores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.Dgv_professor = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Tb_idProfessor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_nomeProfessor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_professor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mtb_telefone
            // 
            this.Mtb_telefone.Location = new System.Drawing.Point(364, 26);
            this.Mtb_telefone.Mask = "(00)00000-0000";
            this.Mtb_telefone.Name = "Mtb_telefone";
            this.Mtb_telefone.Size = new System.Drawing.Size(89, 20);
            this.Mtb_telefone.TabIndex = 12;
            // 
            // Dgv_professor
            // 
            this.Dgv_professor.AllowUserToAddRows = false;
            this.Dgv_professor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_professor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_professor.EnableHeadersVisualStyles = false;
            this.Dgv_professor.Location = new System.Drawing.Point(12, 52);
            this.Dgv_professor.MultiSelect = false;
            this.Dgv_professor.Name = "Dgv_professor";
            this.Dgv_professor.ReadOnly = true;
            this.Dgv_professor.RowHeadersVisible = false;
            this.Dgv_professor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_professor.Size = new System.Drawing.Size(442, 453);
            this.Dgv_professor.TabIndex = 11;
            this.Dgv_professor.SelectionChanged += new System.EventHandler(this.Dgv_horarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_salvar);
            this.panel1.Controls.Add(this.Btn_excluir);
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 42);
            this.panel1.TabIndex = 10;
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(120, 13);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(110, 23);
            this.Btn_salvar.TabIndex = 3;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excluir.Location = new System.Drawing.Point(236, 13);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(110, 23);
            this.Btn_excluir.TabIndex = 2;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(352, 13);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(110, 23);
            this.Btn_fechar.TabIndex = 1;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(4, 13);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(110, 23);
            this.Btn_novo.TabIndex = 0;
            this.Btn_novo.Text = "Novo Professor";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Tb_idProfessor
            // 
            this.Tb_idProfessor.Location = new System.Drawing.Point(12, 26);
            this.Tb_idProfessor.Name = "Tb_idProfessor";
            this.Tb_idProfessor.ReadOnly = true;
            this.Tb_idProfessor.Size = new System.Drawing.Size(82, 20);
            this.Tb_idProfessor.TabIndex = 9;
            this.Tb_idProfessor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Professor";
            // 
            // Tb_nomeProfessor
            // 
            this.Tb_nomeProfessor.Location = new System.Drawing.Point(101, 26);
            this.Tb_nomeProfessor.Name = "Tb_nomeProfessor";
            this.Tb_nomeProfessor.Size = new System.Drawing.Size(257, 20);
            this.Tb_nomeProfessor.TabIndex = 14;
            // 
            // F_gestaoProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 553);
            this.Controls.Add(this.Tb_nomeProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mtb_telefone);
            this.Controls.Add(this.Dgv_professor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tb_idProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_gestaoProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Professores";
            this.Load += new System.EventHandler(this.F_gestaoProfessores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_professor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Mtb_telefone;
        private System.Windows.Forms.DataGridView Dgv_professor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.TextBox Tb_idProfessor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_nomeProfessor;
    }
}