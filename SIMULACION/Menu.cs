using System;
using System.Windows.Forms;

namespace SIMULACION
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SIMULACION S = new SIMULACION();

            this.Hide();

            S.Show();
        }

        private void tutorial_Click(object sender, EventArgs e)
        {
            TUTORIAL T = new TUTORIAL();

            this.Hide();

            T.Show();

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
