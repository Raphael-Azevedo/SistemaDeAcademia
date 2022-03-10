namespace AcademiaSystem
{
    partial class F_GestaoUsuarios
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.N_nivel = new System.Windows.Forms.NumericUpDown();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_novoUsuario = new System.Windows.Forms.Button();
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.N_nivel)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "D = Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "B = Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "A = Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status";
            // 
            // N_nivel
            // 
            this.N_nivel.Location = new System.Drawing.Point(196, 184);
            this.N_nivel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.N_nivel.Name = "N_nivel";
            this.N_nivel.Size = new System.Drawing.Size(129, 20);
            this.N_nivel.TabIndex = 5;
            // 
            // Cb_status
            // 
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.Cb_status.Location = new System.Drawing.Point(12, 184);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(130, 21);
            this.Cb_status.TabIndex = 4;
            // 
            // Tb_senha
            // 
            this.Tb_senha.Location = new System.Drawing.Point(196, 132);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.PasswordChar = '*';
            this.Tb_senha.Size = new System.Drawing.Size(129, 20);
            this.Tb_senha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            // 
            // Tb_username
            // 
            this.Tb_username.Location = new System.Drawing.Point(12, 132);
            this.Tb_username.Name = "Tb_username";
            this.Tb_username.Size = new System.Drawing.Size(130, 20);
            this.Tb_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Username";
            // 
            // Tb_nome
            // 
            this.Tb_nome.Location = new System.Drawing.Point(12, 74);
            this.Tb_nome.Name = "Tb_nome";
            this.Tb_nome.Size = new System.Drawing.Size(316, 20);
            this.Tb_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // Tb_id
            // 
            this.Tb_id.Location = new System.Drawing.Point(12, 31);
            this.Tb_id.Name = "Tb_id";
            this.Tb_id.ReadOnly = true;
            this.Tb_id.Size = new System.Drawing.Size(130, 20);
            this.Tb_id.TabIndex = 27;
            this.Tb_id.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_excluir);
            this.panel1.Controls.Add(this.Btn_salvar);
            this.panel1.Controls.Add(this.Btn_novoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 33);
            this.panel1.TabIndex = 28;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(575, 4);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(121, 23);
            this.Btn_fechar.TabIndex = 9;
            this.Btn_fechar.Text = "Fechar ";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excluir.Location = new System.Drawing.Point(258, 4);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(121, 23);
            this.Btn_excluir.TabIndex = 8;
            this.Btn_excluir.Text = "Excluir usuário";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(131, 4);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(121, 23);
            this.Btn_salvar.TabIndex = 7;
            this.Btn_salvar.Text = "Salvar alterações";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_novoUsuario
            // 
            this.Btn_novoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novoUsuario.Location = new System.Drawing.Point(4, 4);
            this.Btn_novoUsuario.Name = "Btn_novoUsuario";
            this.Btn_novoUsuario.Size = new System.Drawing.Size(121, 23);
            this.Btn_novoUsuario.TabIndex = 6;
            this.Btn_novoUsuario.Text = "Novo Usuário";
            this.Btn_novoUsuario.UseVisualStyleBackColor = true;
            this.Btn_novoUsuario.Click += new System.EventHandler(this.Btn_novoUsuario_Click);
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.EnableHeadersVisualStyles = false;
            this.Dgv_usuarios.Location = new System.Drawing.Point(334, 15);
            this.Dgv_usuarios.MultiSelect = false;
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            this.Dgv_usuarios.RowHeadersVisible = false;
            this.Dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_usuarios.Size = new System.Drawing.Size(362, 229);
            this.Dgv_usuarios.TabIndex = 29;
            this.Dgv_usuarios.SelectionChanged += new System.EventHandler(this.Dgv_usuarios_SelectionChanged);
            // 
            // F_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 299);
            this.Controls.Add(this.Dgv_usuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tb_id);
            this.Controls.Add(this.label9);
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
            this.Name = "F_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Usuários";
            this.Load += new System.EventHandler(this.F_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N_nivel)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown N_nivel;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_novoUsuario;
    }
}