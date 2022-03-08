namespace AcademiaSystem
{
    partial class F_Login
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
            this.Tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_senha = new System.Windows.Forms.TextBox();
            this.Btn_logar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Tb_username
            // 
            this.Tb_username.Location = new System.Drawing.Point(16, 29);
            this.Tb_username.Name = "Tb_username";
            this.Tb_username.Size = new System.Drawing.Size(168, 20);
            this.Tb_username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // Tb_senha
            // 
            this.Tb_senha.Location = new System.Drawing.Point(16, 79);
            this.Tb_senha.Name = "Tb_senha";
            this.Tb_senha.PasswordChar = '*';
            this.Tb_senha.Size = new System.Drawing.Size(168, 20);
            this.Tb_senha.TabIndex = 3;
            // 
            // Btn_logar
            // 
            this.Btn_logar.Location = new System.Drawing.Point(12, 120);
            this.Btn_logar.Name = "Btn_logar";
            this.Btn_logar.Size = new System.Drawing.Size(168, 23);
            this.Btn_logar.TabIndex = 4;
            this.Btn_logar.Text = "Logar";
            this.Btn_logar.UseVisualStyleBackColor = true;
            this.Btn_logar.Click += new System.EventHandler(this.Btn_logar_Click);
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(12, 149);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(168, 23);
            this.Btn_cancelar.TabIndex = 5;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            this.Btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 183);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_logar);
            this.Controls.Add(this.Tb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_senha;
        private System.Windows.Forms.Button Btn_logar;
        private System.Windows.Forms.Button Btn_cancelar;
    }
}