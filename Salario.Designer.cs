namespace GerenciadorEmpregados
{
    partial class Salario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalarioSlip = new System.Windows.Forms.RichTextBox();
            this.SalarioParaPrincipal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BuscarFuncionario = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SalarioParaVisualizar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Print = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.FuncCargoCb = new System.Windows.Forms.ComboBox();
            this.DiasTrabalhadosTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FuncNomeTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FuncIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FuncSair = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 88);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Salario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SalarioSlip);
            this.panel1.Controls.Add(this.SalarioParaPrincipal);
            this.panel1.Controls.Add(this.BuscarFuncionario);
            this.panel1.Controls.Add(this.SalarioParaVisualizar);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FuncCargoCb);
            this.panel1.Controls.Add(this.DiasTrabalhadosTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FuncNomeTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FuncIdTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 653);
            this.panel1.TabIndex = 31;
            // 
            // SalarioSlip
            // 
            this.SalarioSlip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarioSlip.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioSlip.Location = new System.Drawing.Point(649, 85);
            this.SalarioSlip.Name = "SalarioSlip";
            this.SalarioSlip.Size = new System.Drawing.Size(777, 450);
            this.SalarioSlip.TabIndex = 25;
            this.SalarioSlip.Text = "";
            // 
            // SalarioParaPrincipal
            // 
            this.SalarioParaPrincipal.ActiveBorderThickness = 1;
            this.SalarioParaPrincipal.ActiveCornerRadius = 20;
            this.SalarioParaPrincipal.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.SalarioParaPrincipal.ActiveForecolor = System.Drawing.Color.White;
            this.SalarioParaPrincipal.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.SalarioParaPrincipal.BackColor = System.Drawing.Color.White;
            this.SalarioParaPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalarioParaPrincipal.BackgroundImage")));
            this.SalarioParaPrincipal.ButtonText = "Principal";
            this.SalarioParaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalarioParaPrincipal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioParaPrincipal.ForeColor = System.Drawing.Color.SeaGreen;
            this.SalarioParaPrincipal.IdleBorderThickness = 1;
            this.SalarioParaPrincipal.IdleCornerRadius = 20;
            this.SalarioParaPrincipal.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.SalarioParaPrincipal.IdleForecolor = System.Drawing.Color.White;
            this.SalarioParaPrincipal.IdleLineColor = System.Drawing.Color.White;
            this.SalarioParaPrincipal.Location = new System.Drawing.Point(45, 526);
            this.SalarioParaPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalarioParaPrincipal.Name = "SalarioParaPrincipal";
            this.SalarioParaPrincipal.Size = new System.Drawing.Size(129, 37);
            this.SalarioParaPrincipal.TabIndex = 23;
            this.SalarioParaPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalarioParaPrincipal.Click += new System.EventHandler(this.SalarioParaPrincipal_Click);
            // 
            // BuscarFuncionario
            // 
            this.BuscarFuncionario.ActiveBorderThickness = 1;
            this.BuscarFuncionario.ActiveCornerRadius = 20;
            this.BuscarFuncionario.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.BuscarFuncionario.ActiveForecolor = System.Drawing.Color.White;
            this.BuscarFuncionario.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.BuscarFuncionario.BackColor = System.Drawing.Color.White;
            this.BuscarFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarFuncionario.BackgroundImage")));
            this.BuscarFuncionario.ButtonText = "Buscar";
            this.BuscarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuscarFuncionario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarFuncionario.ForeColor = System.Drawing.Color.SeaGreen;
            this.BuscarFuncionario.IdleBorderThickness = 1;
            this.BuscarFuncionario.IdleCornerRadius = 20;
            this.BuscarFuncionario.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.BuscarFuncionario.IdleForecolor = System.Drawing.Color.White;
            this.BuscarFuncionario.IdleLineColor = System.Drawing.Color.White;
            this.BuscarFuncionario.Location = new System.Drawing.Point(374, 95);
            this.BuscarFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarFuncionario.Name = "BuscarFuncionario";
            this.BuscarFuncionario.Size = new System.Drawing.Size(163, 48);
            this.BuscarFuncionario.TabIndex = 22;
            this.BuscarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BuscarFuncionario.Click += new System.EventHandler(this.BuscarFuncionario_Click);
            // 
            // SalarioParaVisualizar
            // 
            this.SalarioParaVisualizar.ActiveBorderThickness = 1;
            this.SalarioParaVisualizar.ActiveCornerRadius = 20;
            this.SalarioParaVisualizar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.SalarioParaVisualizar.ActiveForecolor = System.Drawing.Color.White;
            this.SalarioParaVisualizar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.SalarioParaVisualizar.BackColor = System.Drawing.Color.White;
            this.SalarioParaVisualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalarioParaVisualizar.BackgroundImage")));
            this.SalarioParaVisualizar.ButtonText = "Visualizar";
            this.SalarioParaVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalarioParaVisualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarioParaVisualizar.ForeColor = System.Drawing.Color.SeaGreen;
            this.SalarioParaVisualizar.IdleBorderThickness = 1;
            this.SalarioParaVisualizar.IdleCornerRadius = 20;
            this.SalarioParaVisualizar.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.SalarioParaVisualizar.IdleForecolor = System.Drawing.Color.White;
            this.SalarioParaVisualizar.IdleLineColor = System.Drawing.Color.White;
            this.SalarioParaVisualizar.Location = new System.Drawing.Point(243, 526);
            this.SalarioParaVisualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalarioParaVisualizar.Name = "SalarioParaVisualizar";
            this.SalarioParaVisualizar.Size = new System.Drawing.Size(129, 37);
            this.SalarioParaVisualizar.TabIndex = 21;
            this.SalarioParaVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SalarioParaVisualizar.Click += new System.EventHandler(this.SalarioParaVisualizar_Click);
            // 
            // Print
            // 
            this.Print.ActiveBorderThickness = 1;
            this.Print.ActiveCornerRadius = 20;
            this.Print.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
            this.Print.ActiveForecolor = System.Drawing.Color.White;
            this.Print.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
            this.Print.BackColor = System.Drawing.Color.White;
            this.Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print.BackgroundImage")));
            this.Print.ButtonText = "Print";
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.SeaGreen;
            this.Print.IdleBorderThickness = 1;
            this.Print.IdleCornerRadius = 20;
            this.Print.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.Print.IdleForecolor = System.Drawing.Color.White;
            this.Print.IdleLineColor = System.Drawing.Color.White;
            this.Print.Location = new System.Drawing.Point(968, 565);
            this.Print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(129, 37);
            this.Print.TabIndex = 20;
            this.Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(41, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dias Trabalhados";
            // 
            // FuncCargoCb
            // 
            this.FuncCargoCb.Enabled = false;
            this.FuncCargoCb.FormattingEnabled = true;
            this.FuncCargoCb.Items.AddRange(new object[] {
            "Gerente",
            "Dev Senior",
            "Dev Junior",
            "Estagiario",
            "Recepcionista"});
            this.FuncCargoCb.Location = new System.Drawing.Point(45, 328);
            this.FuncCargoCb.Name = "FuncCargoCb";
            this.FuncCargoCb.Size = new System.Drawing.Size(193, 21);
            this.FuncCargoCb.TabIndex = 13;
            // 
            // DiasTrabalhadosTb
            // 
            this.DiasTrabalhadosTb.BorderColor = System.Drawing.Color.Blue;
            this.DiasTrabalhadosTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DiasTrabalhadosTb.DefaultText = "";
            this.DiasTrabalhadosTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DiasTrabalhadosTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DiasTrabalhadosTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DiasTrabalhadosTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DiasTrabalhadosTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DiasTrabalhadosTb.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiasTrabalhadosTb.ForeColor = System.Drawing.Color.Blue;
            this.DiasTrabalhadosTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DiasTrabalhadosTb.Location = new System.Drawing.Point(45, 426);
            this.DiasTrabalhadosTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiasTrabalhadosTb.Name = "DiasTrabalhadosTb";
            this.DiasTrabalhadosTb.PasswordChar = '\0';
            this.DiasTrabalhadosTb.PlaceholderText = "";
            this.DiasTrabalhadosTb.SelectedText = "";
            this.DiasTrabalhadosTb.Size = new System.Drawing.Size(193, 33);
            this.DiasTrabalhadosTb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(41, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Funcionario Cargo";
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
            this.FuncNomeTb.Enabled = false;
            this.FuncNomeTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncNomeTb.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncNomeTb.ForeColor = System.Drawing.Color.Blue;
            this.FuncNomeTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FuncNomeTb.Location = new System.Drawing.Point(41, 217);
            this.FuncNomeTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuncNomeTb.Name = "FuncNomeTb";
            this.FuncNomeTb.PasswordChar = '\0';
            this.FuncNomeTb.PlaceholderText = "";
            this.FuncNomeTb.SelectedText = "";
            this.FuncNomeTb.Size = new System.Drawing.Size(197, 33);
            this.FuncNomeTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(41, 192);
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
            this.FuncIdTb.Location = new System.Drawing.Point(45, 110);
            this.FuncIdTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FuncIdTb.Name = "FuncIdTb";
            this.FuncIdTb.PasswordChar = '\0';
            this.FuncIdTb.PlaceholderText = "";
            this.FuncIdTb.SelectedText = "";
            this.FuncIdTb.Size = new System.Drawing.Size(193, 33);
            this.FuncIdTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Funcionario Id";
            // 
            // FuncSair
            // 
            this.FuncSair.AutoSize = true;
            this.FuncSair.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuncSair.ForeColor = System.Drawing.Color.White;
            this.FuncSair.Location = new System.Drawing.Point(1477, 9);
            this.FuncSair.Name = "FuncSair";
            this.FuncSair.Size = new System.Drawing.Size(23, 25);
            this.FuncSair.TabIndex = 32;
            this.FuncSair.Text = "X";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1512, 808);
            this.Controls.Add(this.FuncSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario";
            this.Load += new System.EventHandler(this.Salario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SalarioParaPrincipal;
        private Bunifu.Framework.UI.BunifuThinButton2 BuscarFuncionario;
        private Bunifu.Framework.UI.BunifuThinButton2 SalarioParaVisualizar;
        private Bunifu.Framework.UI.BunifuThinButton2 Print;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FuncCargoCb;
        private Guna.UI2.WinForms.Guna2TextBox DiasTrabalhadosTb;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox FuncNomeTb;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox FuncIdTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SalarioSlip;
        private System.Windows.Forms.Label FuncSair;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}