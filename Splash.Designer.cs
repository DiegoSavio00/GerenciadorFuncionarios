namespace GerenciadorEmpregados
{
    partial class Splash
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Meuprogresso = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CirclePictureBar1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.Meuprogresso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema Gerenciador de Funcionarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(314, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DesenvolvidoPorDS";
            // 
            // Meuprogresso
            // 
            this.Meuprogresso.Controls.Add(this.guna2CirclePictureBar1);
            this.Meuprogresso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Meuprogresso.FillThickness = 10;
            this.Meuprogresso.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Meuprogresso.ForeColor = System.Drawing.Color.White;
            this.Meuprogresso.Location = new System.Drawing.Point(172, 42);
            this.Meuprogresso.Minimum = 0;
            this.Meuprogresso.Name = "Meuprogresso";
            this.Meuprogresso.ProgressThickness = 10;
            this.Meuprogresso.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Meuprogresso.Size = new System.Drawing.Size(166, 166);
            this.Meuprogresso.TabIndex = 2;
            this.Meuprogresso.Text = "guna2CircleProgressBar1";
            // 
            // guna2CirclePictureBar1
            // 
            this.guna2CirclePictureBar1.ImageRotate = 0F;
            this.guna2CirclePictureBar1.Location = new System.Drawing.Point(33, 29);
            this.guna2CirclePictureBar1.Name = "guna2CirclePictureBar1";
            this.guna2CirclePictureBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBar1.Size = new System.Drawing.Size(99, 107);
            this.guna2CirclePictureBar1.TabIndex = 0;
            this.guna2CirclePictureBar1.TabStop = false;
            // 
            // Temporizador
            // 
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.Meuprogresso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.Meuprogresso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar Meuprogresso;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBar1;
        private System.Windows.Forms.Timer Temporizador;
    }
}

