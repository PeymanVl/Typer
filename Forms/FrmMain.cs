using System.Windows.Forms;

namespace Typer.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtEnglish_Click(object sender, System.EventArgs e)
        {
            var enf = new FrmEnglish();
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
            var enf = new FrmFarsi();
            enf.FormClosed += Enf_FormClosed;
            enf.Show();
            Hide();
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Application.Exit();

        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Control)
            {
                var frmCharCount = new FrmCharCount().ShowDialog();
            }
        }

        private void BtStart_Click(object sender, System.EventArgs e)
        {

            Form formToLoad = null;
            //Check Language
            if(rbEnglish.Checked)
                formToLoad=new FrmEnglish();
            if(rbPersian.Checked)
                formToLoad=new FrmFarsi();

            formToLoad.ShowDialog();
        }
    }

    enum WordsType
    {
        Advance,
        Simple,
        Text
    }

    enum Language
    {
        English,
        Persian,
        French
    }
}
