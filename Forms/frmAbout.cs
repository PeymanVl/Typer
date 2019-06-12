using System;
using System.Windows.Forms;


namespace Typer
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void btAboutBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAbout_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }
    }
}
