namespace AcademiaSystem
{
    partial class F_horarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_idHorario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Dgv_horarios = new System.Windows.Forms.DataGridView();
            this.Mtb_dscHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário";
            // 
            // Tb_idHorario
            // 
            this.Tb_idHorario.Location = new System.Drawing.Point(15, 25);
            this.Tb_idHorario.Name = "Tb_idHorario";
            this.Tb_idHorario.ReadOnly = true;
            this.Tb_idHorario.Size = new System.Drawing.Size(64, 20);
            this.Tb_idHorario.TabIndex = 2;
            this.Tb_idHorario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_salvar);
            this.panel1.Controls.Add(this.Btn_excluir);
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 42);
            this.panel1.TabIndex = 4;
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(120, 13);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(110, 23);
            this.Btn_salvar.TabIndex = 3;
            this.Btn_salvar.Text = "Salvar Horário";
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
            this.Btn_excluir.Text = "Excluir Horário";
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
            this.Btn_novo.Text = "Novo Horário";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Dgv_horarios
            // 
            this.Dgv_horarios.AllowUserToAddRows = false;
            this.Dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_horarios.EnableHeadersVisualStyles = false;
            this.Dgv_horarios.Location = new System.Drawing.Point(15, 51);
            this.Dgv_horarios.MultiSelect = false;
            this.Dgv_horarios.Name = "Dgv_horarios";
            this.Dgv_horarios.ReadOnly = true;
            this.Dgv_horarios.RowHeadersVisible = false;
            this.Dgv_horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_horarios.Size = new System.Drawing.Size(440, 426);
            this.Dgv_horarios.TabIndex = 5;
            this.Dgv_horarios.SelectionChanged += new System.EventHandler(this.Dgv_horarios_SelectionChanged);
            // 
            // Mtb_dscHorario
            // 
            this.Mtb_dscHorario.Location = new System.Drawing.Point(103, 25);
            this.Mtb_dscHorario.Mask = "99:99 - 99:99";
            this.Mtb_dscHorario.Name = "Mtb_dscHorario";
            this.Mtb_dscHorario.Size = new System.Drawing.Size(100, 20);
            this.Mtb_dscHorario.TabIndex = 6;
            // 
            // F_horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 525);
            this.Controls.Add(this.Mtb_dscHorario);
            this.Controls.Add(this.Dgv_horarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tb_idHorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horários";
            this.Load += new System.EventHandler(this.F_horarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_idHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.DataGridView Dgv_horarios;
        private System.Windows.Forms.MaskedTextBox Mtb_dscHorario;
    }
}