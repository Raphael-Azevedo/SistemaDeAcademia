namespace AcademiaSystem
{
    partial class F_NovoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.Tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.N_nivel = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.N_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Tb_nome
            // 
            this.Tb_nome.Location = new System.Drawing.Point(12, 29);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(316, 20);
            this.Tb_nome.TabIndex = 1;
            // 
            // Tb_username
            // 
            this.Tb_username.Location = new System.Drawing.Point(350, 29);
            this.Tb_username.Name = "Tb_username";
            this.Tb_username.Size = new System.Drawing.Size(130, 20);
            this.Tb_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // Tb_senha
            // 
            this.Tb_senha.Location = new System.Drawing.Point(498, 29);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.PasswordChar = '*';
            this.Tb_senha.Size = new System.Drawing.Size(130, 20);
            this.Tb_senha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // Cb_status
            // 
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.Cb_status.Location = new System.Drawing.Point(12, 91);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(130, 21);
            this.Cb_status.TabIndex = 6;
            // 
            // N_nivel
            // 
            this.N_nivel.Location = new System.Drawing.Point(173, 91);
            this.N_nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.N_nivel.Name = "N_nivel";
            this.N_nivel.Size = new System.Drawing.Size(75, 20);
            this.N_nivel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nível";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "A = Ativo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "B = Bloqueado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "D = Desligado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_cancelar);
            this.panel1.Controls.Add(this.Btn_salvar);
            this.panel1.Controls.Add(this.Btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 37);
            this.panel1.TabIndex = 13;
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(3, 7);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_novo.TabIndex = 0;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(84, 7);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_salvar.TabIndex = 1;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_cancelar.Location = new System.Drawing.Point(166, 7);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelar.TabIndex = 2;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(558, 7);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 23);
            this.Btn_fechar.TabIndex = 3;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // F_NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 190);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.N_nivel);
            this.Controls.Add(this.Cb_status);
            this.Controls.Add(this.Tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NovoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.N_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.TextBox Tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.NumericUpDown N_nivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_novo;
    }
}