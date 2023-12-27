using System;
using System.Windows.Forms;

namespace GerenciadorEmpregados
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startpoint = 0;

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            Meuprogresso.Value = startpoint;
            if (Meuprogresso.Value == 100)
            {
                Meuprogresso.Value = 0;
                Temporizador.Stop();
                Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Temporizador.Start();
        }
    }
}
