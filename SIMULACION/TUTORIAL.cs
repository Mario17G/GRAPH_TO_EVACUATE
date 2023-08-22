using System;
using System.Windows.Forms;

namespace SIMULACION
{
    public partial class TUTORIAL : Form
    {
        public TUTORIAL()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void TUTORIAL_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            this.Hide();
            m.Show();
        }
    }
}
