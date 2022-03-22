namespace AcademiaSystem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_nomeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matricularAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pb_ledLogado = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pn_menu = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Btn_adm = new System.Windows.Forms.Button();
            this.Btn_academia = new System.Windows.Forms.Button();
            this.Btn_menu = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_dashboard = new FontAwesome.Sharp.IconButton();
            this.Btn_tecnico = new FontAwesome.Sharp.IconButton();
            this.Btn_administrativo = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Btn_gestao = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Btn_academ = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ledLogado)).BeginInit();
            this.panel3.SuspendLayout();
            this.Pn_menu.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Lb_nomeUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Lb_acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pb_ledLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 33);
            this.panel1.TabIndex = 0;
            // 
            // Lb_nomeUsuario
            // 
            this.Lb_nomeUsuario.AutoSize = true;
            this.Lb_nomeUsuario.Location = new System.Drawing.Point(168, 11);
            this.Lb_nomeUsuario.Name = "Lb_nomeUsuario";
            this.Lb_nomeUsuario.Size = new System.Drawing.Size(16, 13);
            this.Lb_nomeUsuario.TabIndex = 4;
            this.Lb_nomeUsuario.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário: ";
            // 
            // Lb_acesso
            // 
            this.Lb_acesso.AutoSize = true;
            this.Lb_acesso.Location = new System.Drawing.Point(80, 11);
            this.Lb_acesso.Name = "Lb_acesso";
            this.Lb_acesso.Size = new System.Drawing.Size(13, 13);
            this.Lb_acesso.TabIndex = 2;
            this.Lb_acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoAlunoToolStripMenuItem,
            this.matricularAlunoToolStripMenuItem,
            this.gestãoDeAlunosToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.alunosToolStripMenuItem.Text = "Alunos";
            // 
            // novoAlunoToolStripMenuItem
            // 
            this.novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            this.novoAlunoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            this.novoAlunoToolStripMenuItem.Click += new System.EventHandler(this.novoAlunoToolStripMenuItem_Click);
            // 
            // matricularAlunoToolStripMenuItem
            // 
            this.matricularAlunoToolStripMenuItem.Name = "matricularAlunoToolStripMenuItem";
            this.matricularAlunoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.matricularAlunoToolStripMenuItem.Text = "Matricular Aluno";
            this.matricularAlunoToolStripMenuItem.Click += new System.EventHandler(this.matricularAlunoToolStripMenuItem_Click);
            // 
            // gestãoDeAlunosToolStripMenuItem
            // 
            this.gestãoDeAlunosToolStripMenuItem.Name = "gestãoDeAlunosToolStripMenuItem";
            this.gestãoDeAlunosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.gestãoDeAlunosToolStripMenuItem.Text = "Gestão de Alunos";
            this.gestãoDeAlunosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeAlunosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gestãoDeUsuáriosToolStripMenuItem});
            this.usuáriosToolStripMenuItem.Enabled = false;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            this.gestãoDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuáriosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancoDeDadosToolStripMenuItem,
            this.horáriosToolStripMenuItem,
            this.gestãoDeProfessoresToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Enabled = false;
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // bancoDeDadosToolStripMenuItem
            // 
            this.bancoDeDadosToolStripMenuItem.Name = "bancoDeDadosToolStripMenuItem";
            this.bancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bancoDeDadosToolStripMenuItem.Text = "Banco de Dados";
            this.bancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.bancoDeDadosToolStripMenuItem_Click);
            // 
            // horáriosToolStripMenuItem
            // 
            this.horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            this.horáriosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.horáriosToolStripMenuItem.Text = "Horários";
            this.horáriosToolStripMenuItem.Click += new System.EventHandler(this.horáriosToolStripMenuItem_Click);
            // 
            // gestãoDeProfessoresToolStripMenuItem
            // 
            this.gestãoDeProfessoresToolStripMenuItem.Name = "gestãoDeProfessoresToolStripMenuItem";
            this.gestãoDeProfessoresToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestãoDeProfessoresToolStripMenuItem.Text = "Gestão de Professores";
            this.gestãoDeProfessoresToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProfessoresToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.turmasToolStripMenuItem.Text = "Turmas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logonToolStripMenuItem.Text = "Logon";
            this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // Pb_ledLogado
            // 
            this.Pb_ledLogado.Image = global::AcademiaSystem.Properties.Resources.led_vermelha_pgn;
            this.Pb_ledLogado.Location = new System.Drawing.Point(7, 8);
            this.Pb_ledLogado.Name = "Pb_ledLogado";
            this.Pb_ledLogado.Size = new System.Drawing.Size(20, 18);
            this.Pb_ledLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ledLogado.TabIndex = 0;
            this.Pb_ledLogado.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1182, 65);
            this.panel3.TabIndex = 3;
            // 
            // Pn_menu
            // 
            this.Pn_menu.BackColor = System.Drawing.Color.BlueViolet;
            this.Pn_menu.Controls.Add(this.panel12);
            this.Pn_menu.Controls.Add(this.panel11);
            this.Pn_menu.Controls.Add(this.panel10);
            this.Pn_menu.Controls.Add(this.panel9);
            this.Pn_menu.Controls.Add(this.panel8);
            this.Pn_menu.Controls.Add(this.panel7);
            this.Pn_menu.Controls.Add(this.panel6);
            this.Pn_menu.Controls.Add(this.panel5);
            this.Pn_menu.Controls.Add(this.panel4);
            this.Pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pn_menu.Location = new System.Drawing.Point(0, 89);
            this.Pn_menu.Name = "Pn_menu";
            this.Pn_menu.Size = new System.Drawing.Size(180, 489);
            this.Pn_menu.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Btn_dashboard);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 60);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 5);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Btn_tecnico);
            this.panel6.Controls.Add(this.Btn_adm);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 60);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 5);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Btn_administrativo);
            this.panel8.Controls.Add(this.Btn_academia);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 130);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 60);
            this.panel8.TabIndex = 4;
            // 
            // Btn_adm
            // 
            this.Btn_adm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_adm.Location = new System.Drawing.Point(0, 0);
            this.Btn_adm.Name = "Btn_adm";
            this.Btn_adm.Size = new System.Drawing.Size(180, 60);
            this.Btn_adm.TabIndex = 1;
            this.Btn_adm.Tag = "Administrativo";
            this.Btn_adm.Text = "Administrativo";
            this.Btn_adm.UseVisualStyleBackColor = true;
            // 
            // Btn_academia
            // 
            this.Btn_academia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_academia.Location = new System.Drawing.Point(0, 0);
            this.Btn_academia.Name = "Btn_academia";
            this.Btn_academia.Size = new System.Drawing.Size(180, 60);
            this.Btn_academia.TabIndex = 1;
            this.Btn_academia.Tag = "Academia";
            this.Btn_academia.Text = "Academia";
            this.Btn_academia.UseVisualStyleBackColor = true;
            this.Btn_academia.Click += new System.EventHandler(this.button5_Click);
            // 
            // Btn_menu
            // 
            this.Btn_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_menu.FlatAppearance.BorderSize = 0;
            this.Btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.Btn_menu.IconColor = System.Drawing.Color.White;
            this.Btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_menu.IconSize = 35;
            this.Btn_menu.Location = new System.Drawing.Point(0, 0);
            this.Btn_menu.Name = "Btn_menu";
            this.Btn_menu.Size = new System.Drawing.Size(180, 65);
            this.Btn_menu.TabIndex = 1;
            this.Btn_menu.UseVisualStyleBackColor = true;
            this.Btn_menu.Click += new System.EventHandler(this.Btn_menu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 65);
            this.panel2.TabIndex = 2;
            // 
            // Btn_dashboard
            // 
            this.Btn_dashboard.BackColor = System.Drawing.Color.Indigo;
            this.Btn_dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.Btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.Btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_dashboard.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_dashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.GripHorizontal;
            this.Btn_dashboard.IconColor = System.Drawing.Color.White;
            this.Btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_dashboard.IconSize = 40;
            this.Btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.Btn_dashboard.Name = "Btn_dashboard";
            this.Btn_dashboard.Size = new System.Drawing.Size(180, 60);
            this.Btn_dashboard.TabIndex = 1;
            this.Btn_dashboard.Tag = "Dashboard";
            this.Btn_dashboard.Text = "Dashboard";
            this.Btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_dashboard.UseVisualStyleBackColor = false;
            // 
            // Btn_tecnico
            // 
            this.Btn_tecnico.BackColor = System.Drawing.Color.Indigo;
            this.Btn_tecnico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_tecnico.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.Btn_tecnico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.Btn_tecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_tecnico.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_tecnico.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_tecnico.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.Btn_tecnico.IconColor = System.Drawing.Color.White;
            this.Btn_tecnico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_tecnico.IconSize = 38;
            this.Btn_tecnico.Location = new System.Drawing.Point(0, 0);
            this.Btn_tecnico.Name = "Btn_tecnico";
            this.Btn_tecnico.Size = new System.Drawing.Size(180, 60);
            this.Btn_tecnico.TabIndex = 2;
            this.Btn_tecnico.Tag = "Técnico";
            this.Btn_tecnico.Text = "Técnico";
            this.Btn_tecnico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_tecnico.UseVisualStyleBackColor = false;
            // 
            // Btn_administrativo
            // 
            this.Btn_administrativo.BackColor = System.Drawing.Color.Indigo;
            this.Btn_administrativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_administrativo.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.Btn_administrativo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.Btn_administrativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_administrativo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_administrativo.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_administrativo.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.Btn_administrativo.IconColor = System.Drawing.Color.White;
            this.Btn_administrativo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_administrativo.IconSize = 30;
            this.Btn_administrativo.Location = new System.Drawing.Point(0, 0);
            this.Btn_administrativo.Name = "Btn_administrativo";
            this.Btn_administrativo.Size = new System.Drawing.Size(180, 60);
            this.Btn_administrativo.TabIndex = 3;
            this.Btn_administrativo.Tag = "Administrativo";
            this.Btn_administrativo.Text = "Administrativo";
            this.Btn_administrativo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_administrativo.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 190);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(180, 5);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.Btn_gestao);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 195);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(180, 60);
            this.panel10.TabIndex = 6;
            // 
            // Btn_gestao
            // 
            this.Btn_gestao.BackColor = System.Drawing.Color.DarkOrchid;
            this.Btn_gestao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_gestao.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.Btn_gestao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.Btn_gestao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_gestao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_gestao.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_gestao.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.Btn_gestao.IconColor = System.Drawing.Color.White;
            this.Btn_gestao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_gestao.IconSize = 30;
            this.Btn_gestao.Location = new System.Drawing.Point(0, 0);
            this.Btn_gestao.Name = "Btn_gestao";
            this.Btn_gestao.Size = new System.Drawing.Size(180, 60);
            this.Btn_gestao.TabIndex = 4;
            this.Btn_gestao.Tag = "Gestão";
            this.Btn_gestao.Text = "Gestão";
            this.Btn_gestao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_gestao.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 255);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(180, 5);
            this.panel11.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.Btn_academ);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 260);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(180, 60);
            this.panel12.TabIndex = 8;
            // 
            // Btn_academ
            // 
            this.Btn_academ.BackColor = System.Drawing.Color.DarkOrchid;
            this.Btn_academ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_academ.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.Btn_academ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.Btn_academ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_academ.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_academ.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_academ.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            this.Btn_academ.IconColor = System.Drawing.Color.White;
            this.Btn_academ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_academ.IconSize = 30;
            this.Btn_academ.Location = new System.Drawing.Point(0, 0);
            this.Btn_academ.Name = "Btn_academ";
            this.Btn_academ.Size = new System.Drawing.Size(180, 60);
            this.Btn_academ.TabIndex = 5;
            this.Btn_academ.Tag = "Academia";
            this.Btn_academ.Text = "Academia";
            this.Btn_academ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_academ.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 611);
            this.Controls.Add(this.Pn_menu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia - v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ledLogado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.Pn_menu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox Pb_ledLogado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label Lb_nomeUsuario;
        public System.Windows.Forms.Label Lb_acesso;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matricularAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeAlunosToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Pn_menu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_academia;
        private System.Windows.Forms.Button Btn_adm;
        private FontAwesome.Sharp.IconButton Btn_menu;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Btn_dashboard;
        private FontAwesome.Sharp.IconButton Btn_tecnico;
        private System.Windows.Forms.Panel panel12;
        private FontAwesome.Sharp.IconButton Btn_academ;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private FontAwesome.Sharp.IconButton Btn_gestao;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton Btn_administrativo;
    }
}

