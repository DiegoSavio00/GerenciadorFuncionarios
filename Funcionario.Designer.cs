namespace GerenciadorEmpregados
{
    partial class Funcionario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FuncDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.FuncionarioParaPrincipal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FuncDeletar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FuncEditar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FuncAdicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FuncGeneroCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FuncEducacaoCb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FuncDob = new System.Windows.Forms.DateTimePicker();
            this.FuncCargoCb = new System.Windows.Forms.ComboBox();
            this.FuncTelefoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FuncEnderecoTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FuncNomeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FuncIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.FuncSair = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gerenciar Funcionario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FuncDGV);
            this.panel1.Controls.Add(this.FuncionarioParaPrincipal);
            this.panel1.Controls.Add(this.FuncDeletar);
            this.panel1.Controls.Add(this.FuncEditar);
            this.panel1.Controls.Add(this.FuncAdicionar);
            this.panel1.Controls.Add(this.FuncGeneroCb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.FuncEducacaoCb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FuncDob);
            this.panel1.Controls.Add(this.FuncCargoCb);
            this.panel1.Controls.Add(this.FuncTelefoneTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FuncEnderecoTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FuncNomeTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FuncIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 653);
            this.panel1.TabIndex = 4;
            // 
            // FuncDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.FuncDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FuncDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FuncDGV.ColumnHeadersHeight = 25;
            this.FuncDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FuncDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.FuncDGV.GridColor = System.Drawing.Color.LightSkyBlue;
            this.FuncDGV.Location = new System.Drawing.Point(584, 23);
            this.FuncDGV.Name = "FuncDGV";
            this.FuncDGV.RowHeadersVisible = false;
            this.FuncDGV.Size = new System.Drawing.Size(889, 614);
            this.FuncDGV.TabIndex = 24;
            this.FuncDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FuncDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FuncDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FuncDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FuncDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FuncDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FuncDGV.ThemeStyle.GridColor = System.Drawing.Color.LightSkyBlue;
            this.FuncDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FuncDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FuncDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FuncDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FuncDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.FuncDGV.ThemeStyle.ReadOnly = false;
            this.FuncDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FuncDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FuncDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FuncDGV.ThemeStyle.RowsStyle.Height = 22;
            this.FuncDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FuncDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FuncDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FuncDGV_CellContentClick);
            // 
            // FuncionarioParaPrincipal
            // 
            this.FuncionarioParaPrincipal.ActiveBorderThickness = 1;
            this.FuncionarioParaPrincipal.ActiveCornerRadius = 20;
            this.FuncionarioParaPrincipal.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.FuncionarioParaPrincipal.ActiveForecolor = System.Drawing.Color.White;
            this.FuncionarioParaPrincipal.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.FuncionarioParaPrincipal.BackColor = System.Drawing.Color.White;
            this.FuncionarioParaPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FuncionarioParaPrincipal.BackgroundImage")));
            this.FuncionarioParaPrincipal.ButtonText = "Principal";
            this.FuncionarioParaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FuncionarioParaPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncionarioParaPrincipal.ForeColor = System.Drawing.Color.SeaGreen;
            this.FuncionarioParaPrincipal.IdleBorderThickness = 1;
            this.FuncionarioParaPrincipal.IdleCornerRadius = 20;
            this.FuncionarioParaPrincipal.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.FuncionarioParaPrincipal.IdleForecolor = System.Drawing.Color.White;
            this.FuncionarioParaPrincipal.IdleLineColor = System.Drawing.Color.White;
            this.FuncionarioParaPrincipal.Location = new System.Drawing.Point(152, 565);
            this.FuncionarioParaPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuncionarioParaPrincipal.Name = "FuncionarioParaPrincipal";
            this.FuncionarioParaPrincipal.Size = new System.Drawing.Size(129, 37);
            this.FuncionarioParaPrincipal.TabIndex = 23;
            this.FuncionarioParaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FuncionarioParaPrincipal.Click += new System.EventHandler(this.FuncionarioParaPrincipal_Click);
            // 
            // FuncDeletar
            // 
            this.FuncDeletar.ActiveBorderThickness = 1;
            this.FuncDeletar.ActiveCornerRadius = 20;
            this.FuncDeletar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.FuncDeletar.ActiveForecolor = System.Drawing.Color.White;
            this.FuncDeletar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.FuncDeletar.BackColor = System.Drawing.Color.White;
            this.FuncDeletar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FuncDeletar.BackgroundImage")));
            this.FuncDeletar.ButtonText = "Deletar";
            this.FuncDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FuncDeletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncDeletar.ForeColor = System.Drawing.Color.SeaGreen;
            this.FuncDeletar.IdleBorderThickness = 1;
            this.FuncDeletar.IdleCornerRadius = 20;
            this.FuncDeletar.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.FuncDeletar.IdleForecolor = System.Drawing.Color.White;
            this.FuncDeletar.IdleLineColor = System.Drawing.Color.White;
            this.FuncDeletar.Location = new System.Drawing.Point(298, 498);
            this.FuncDeletar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuncDeletar.Name = "FuncDeletar";
            this.FuncDeletar.Size = new System.Drawing.Size(129, 37);
            this.FuncDeletar.TabIndex = 22;
            this.FuncDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FuncDeletar.Click += new System.EventHandler(this.FuncDeletar_Click);
            // 
            // FuncEditar
            // 
            this.FuncEditar.ActiveBorderThickness = 1;
            this.FuncEditar.ActiveCornerRadius = 20;
            this.FuncEditar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.FuncEditar.ActiveForecolor = System.Drawing.Color.White;
            this.FuncEditar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.FuncEditar.BackColor = System.Drawing.Color.White;
            this.FuncEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FuncEditar.BackgroundImage")));
            this.FuncEditar.ButtonText = "Editar";
            this.FuncEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FuncEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncEditar.ForeColor = System.Drawing.Color.SeaGreen;
            this.FuncEditar.IdleBorderThickness = 1;
            this.FuncEditar.IdleCornerRadius = 20;
            this.FuncEditar.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.FuncEditar.IdleForecolor = System.Drawing.Color.White;
            this.FuncEditar.IdleLineColor = System.Drawing.Color.White;
            this.FuncEditar.Location = new System.Drawing.Point(152, 498);
            this.FuncEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuncEditar.Name = "FuncEditar";
            this.FuncEditar.Size = new System.Drawing.Size(129, 37);
            this.FuncEditar.TabIndex = 21;
            this.FuncEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FuncEditar.Click += new System.EventHandler(this.FuncEditar_Click);
            // 
            // FuncAdicionar
            // 
            this.FuncAdicionar.ActiveBorderThickness = 1;
            this.FuncAdicionar.ActiveCornerRadius = 20;
            this.FuncAdicionar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.FuncAdicionar.ActiveForecolor = System.Drawing.Color.White;
            this.FuncAdicionar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.FuncAdicionar.BackColor = System.Drawing.Color.White;
            this.FuncAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FuncAdicionar.BackgroundImage")));
            this.FuncAdicionar.ButtonText = "Adicionar";
            this.FuncAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FuncAdicionar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncAdicionar.ForeColor = System.Drawing.Color.SeaGreen;
            this.FuncAdicionar.IdleBorderThickness = 1;
            this.FuncAdicionar.IdleCornerRadius = 20;
            this.FuncAdicionar.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.FuncAdicionar.IdleForecolor = System.Drawing.Color.White;
            this.FuncAdicionar.IdleLineColor = System.Drawing.Color.White;
            this.FuncAdicionar.Location = new System.Drawing.Point(7, 498);
            this.FuncAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FuncAdicionar.Name = "FuncAdicionar";
            this.FuncAdicionar.Size = new System.Drawing.Size(129, 37);
            this.FuncAdicionar.TabIndex = 20;
            this.FuncAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FuncAdicionar.Click += new System.EventHandler(this.FuncAdicionar_Click);
            // 
            // FuncGeneroCb
            // 
            this.FuncGeneroCb.FormattingEnabled = true;
            this.FuncGeneroCb.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.FuncGeneroCb.Location = new System.Drawing.Point(7, 440);
            this.FuncGeneroCb.Name = "FuncGeneroCb";
            this.FuncGeneroCb.Size = new System.Drawing.Size(226, 21);
            this.FuncGeneroCb.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(3, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Funcionario Genero";
            // 
            // FuncEducacaoCb
            // 
            this.FuncEducacaoCb.FormattingEnabled = true;
            this.FuncEducacaoCb.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "MCom"});
            this.FuncEducacaoCb.Location = new System.Drawing.Point(243, 353);
            this.FuncEducacaoCb.Name = "FuncEducacaoCb";
            this.FuncEducacaoCb.Size = new System.Drawing.Size(226, 21);
            this.FuncEducacaoCb.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(239, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Funcionario Educacao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(3, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcionario Telefone";
            // 
            // FuncDob
            // 
            this.FuncDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncDob.Location = new System.Drawing.Point(223, 253);
            this.FuncDob.Name = "FuncDob";
            this.FuncDob.Size = new System.Drawing.Size(213, 20);
            this.FuncDob.TabIndex = 14;
            // 
            // FuncCargoCb
            // 
            this.FuncCargoCb.FormattingEnabled = true;
            this.FuncCargoCb.Items.AddRange(new object[] {
            "Gerente",
            "Dev Senior",
            "Dev Junior",
            "Estagiario",
            "Recepcionista"});
            this.FuncCargoCb.Location = new System.Drawing.Point(7, 252);
            this.FuncCargoCb.Name = "FuncCargoCb";
            this.FuncCargoCb.Size = new System.Drawing.Size(193, 21);
            this.FuncCargoCb.TabIndex = 13;
            // 
            // FuncTelefoneTb
            // 
            this.FuncTelefoneTb.BorderColor = System.Drawing.Color.Blue;
            this.FuncTelefoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FuncTelefoneTb.DefaultText = "";
            this.FuncTelefoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FuncTelefoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FuncTelefoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncTelefoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncTelefoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncTelefoneTb.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncTelefoneTb.ForeColor = System.Drawing.Color.Blue;
            this.FuncTelefoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncTelefoneTb.Location = new System.Drawing.Point(7, 353);
            this.FuncTelefoneTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuncTelefoneTb.Name = "FuncTelefoneTb";
            this.FuncTelefoneTb.PasswordChar = '\0';
            this.FuncTelefoneTb.PlaceholderText = "";
            this.FuncTelefoneTb.SelectedText = "";
            this.FuncTelefoneTb.Size = new System.Drawing.Size(160, 33);
            this.FuncTelefoneTb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(3, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Funcionario Cargo";
            // 
            // FuncEnderecoTb
            // 
            this.FuncEnderecoTb.BorderColor = System.Drawing.Color.Blue;
            this.FuncEnderecoTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FuncEnderecoTb.DefaultText = "";
            this.FuncEnderecoTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FuncEnderecoTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FuncEnderecoTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncEnderecoTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncEnderecoTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncEnderecoTb.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncEnderecoTb.ForeColor = System.Drawing.Color.Blue;
            this.FuncEnderecoTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncEnderecoTb.Location = new System.Drawing.Point(7, 162);
            this.FuncEnderecoTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuncEnderecoTb.Name = "FuncEnderecoTb";
            this.FuncEnderecoTb.PasswordChar = '\0';
            this.FuncEnderecoTb.PlaceholderText = "";
            this.FuncEnderecoTb.SelectedText = "";
            this.FuncEnderecoTb.Size = new System.Drawing.Size(429, 33);
            this.FuncEnderecoTb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Funcionario Endereco";
            // 
            // FuncNomeTb
            // 
            this.FuncNomeTb.BorderColor = System.Drawing.Color.Blue;
            this.FuncNomeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FuncNomeTb.DefaultText = "";
            this.FuncNomeTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FuncNomeTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FuncNomeTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncNomeTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncNomeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncNomeTb.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncNomeTb.ForeColor = System.Drawing.Color.Blue;
            this.FuncNomeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncNomeTb.Location = new System.Drawing.Point(223, 75);
            this.FuncNomeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuncNomeTb.Name = "FuncNomeTb";
            this.FuncNomeTb.PasswordChar = '\0';
            this.FuncNomeTb.PlaceholderText = "";
            this.FuncNomeTb.SelectedText = "";
            this.FuncNomeTb.Size = new System.Drawing.Size(213, 33);
            this.FuncNomeTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(250, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Funcionario Nome";
            // 
            // FuncIdTb
            // 
            this.FuncIdTb.BorderColor = System.Drawing.Color.Blue;
            this.FuncIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FuncIdTb.DefaultText = "";
            this.FuncIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FuncIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FuncIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FuncIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncIdTb.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncIdTb.ForeColor = System.Drawing.Color.Blue;
            this.FuncIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncIdTb.Location = new System.Drawing.Point(7, 75);
            this.FuncIdTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuncIdTb.Name = "FuncIdTb";
            this.FuncIdTb.PasswordChar = '\0';
            this.FuncIdTb.PlaceholderText = "";
            this.FuncIdTb.SelectedText = "";
            this.FuncIdTb.Size = new System.Drawing.Size(160, 33);
            this.FuncIdTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionario Id";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FuncSair
            // 
            this.FuncSair.AutoSize = true;
            this.FuncSair.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncSair.ForeColor = System.Drawing.Color.White;
            this.FuncSair.Location = new System.Drawing.Point(1477, 9);
            this.FuncSair.Name = "FuncSair";
            this.FuncSair.Size = new System.Drawing.Size(23, 25);
            this.FuncSair.TabIndex = 25;
            this.FuncSair.Text = "X";
            this.FuncSair.Click += new System.EventHandler(this.FuncSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 88);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1512, 808);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FuncSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FuncDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox FuncIdTb;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox FuncNomeTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox FuncTelefoneTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox FuncEnderecoTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox FuncCargoCb;
        private System.Windows.Forms.DateTimePicker FuncDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FuncEducacaoCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FuncGeneroCb;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 FuncAdicionar;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Bunifu.Framework.UI.BunifuThinButton2 FuncEditar;
        private Bunifu.Framework.UI.BunifuThinButton2 FuncDeletar;
        private Bunifu.Framework.UI.BunifuThinButton2 FuncionarioParaPrincipal;
        private Guna.UI2.WinForms.Guna2DataGridView FuncDGV;
        private System.Windows.Forms.Label FuncSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}