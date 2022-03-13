namespace AcademiaSystem
{
    partial class F_NovoAluno
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
            this.Btn_novo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_gravar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.Tb_plano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.Btn_selPlano = new System.Windows.Forms.Button();
            this.Btn_matricular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(3, 3);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(95, 23);
            this.Btn_novo.TabIndex = 6;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_gravar);
            this.panel1.Controls.Add(this.Btn_cancelar);
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 29);
            this.panel1.TabIndex = 15;
            // 
            // Btn_gravar
            // 
            this.Btn_gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_gravar.Enabled = false;
            this.Btn_gravar.Location = new System.Drawing.Point(120, 3);
            this.Btn_gravar.Name = "Btn_gravar";
            this.Btn_gravar.Size = new System.Drawing.Size(95, 23);
            this.Btn_gravar.TabIndex = 7;
            this.Btn_gravar.Text = "Gravar";
            this.Btn_gravar.UseVisualStyleBackColor = true;
            this.Btn_gravar.Click += new System.EventHandler(this.Btn_gravar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.Enabled = false;
            this.Btn_cancelar.Location = new System.Drawing.Point(233, 3);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(95, 23);
            this.Btn_cancelar.TabIndex = 8;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(368, 3);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(95, 23);
            this.Btn_fechar.TabIndex = 9;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Tb_nome
            // 
            this.Tb_nome.Enabled = false;
            this.Tb_nome.Location = new System.Drawing.Point(12, 25);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(289, 20);
            this.Tb_nome.TabIndex = 1;
            // 
            // Tb_plano
            // 
            this.Tb_plano.Location = new System.Drawing.Point(12, 123);
            this.Tb_plano.Name = "Tb_plano";
            this.Tb_plano.ReadOnly = true;
            this.Tb_plano.Size = new System.Drawing.Size(214, 20);
            this.Tb_plano.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Plano";
            // 
            // Mtb_telefone
            // 
            this.Mtb_telefone.Enabled = false;
            this.Mtb_telefone.Location = new System.Drawing.Point(317, 25);
            this.Mtb_telefone.Mask = "(00)00000-0000";
            this.Mtb_telefone.Name = "Mtb_telefone";
            this.Mtb_telefone.Size = new System.Drawing.Size(133, 20);
            this.Mtb_telefone.TabIndex = 2;
            // 
            // Cb_status
            // 
            this.Cb_status.Enabled = false;
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Location = new System.Drawing.Point(12, 74);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(162, 21);
            this.Cb_status.TabIndex = 3;
            // 
            // Btn_selPlano
            // 
            this.Btn_selPlano.Location = new System.Drawing.Point(222, 121);
            this.Btn_selPlano.Name = "Btn_selPlano";
            this.Btn_selPlano.Size = new System.Drawing.Size(30, 23);
            this.Btn_selPlano.TabIndex = 26;
            this.Btn_selPlano.Text = "...";
            this.Btn_selPlano.UseVisualStyleBackColor = true;
            // 
            // Btn_matricular
            // 
            this.Btn_matricular.Location = new System.Drawing.Point(317, 72);
            this.Btn_matricular.Name = "Btn_matricular";
            this.Btn_matricular.Size = new System.Drawing.Size(133, 48);
            this.Btn_matricular.TabIndex = 27;
            this.Btn_matricular.Text = "Matricular Aluno";
            this.Btn_matricular.UseVisualStyleBackColor = true;
            this.Btn_matricular.Click += new System.EventHandler(this.Btn_matricular_Click);
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 192);
            this.Controls.Add(this.Btn_matricular);
            this.Controls.Add(this.Btn_selPlano);
            this.Controls.Add(this.Cb_status);
            this.Controls.Add(this.Mtb_telefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_plano);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_gravar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.TextBox Tb_plano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Mtb_telefone;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.Button Btn_selPlano;
        private System.Windows.Forms.Button Btn_matricular;
    }
}