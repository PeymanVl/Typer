using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Typer.Forms
{
    public partial class FrmMain : BunifuForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtEnglish_Click(object sender, System.EventArgs e)
        {
            var enf=new FrmEnglish();
            enf.FormClosed += Enf_FormClosed;
            enf.Show();
            Hide();
        }

        private void Enf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        private void BtFarsi_Click(object sender, System.EventArgs e)
        {
            var enf=new FrmFarsi();
            enf.FormClosed += Enf_FormClosed;
            enf.Show();
            Hide();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Application.Exit();
        }
    }
}
