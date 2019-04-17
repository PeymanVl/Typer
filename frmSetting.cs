using System;
using System.Windows.Forms;
using Typer.Classes;

namespace Typer
{
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
            //cbTextType.SelectedIndex = 0;
        }

        public bool Changed { get; set; }

        private void Setting_Load(object sender, EventArgs e)
        {
            FillDefaultData();
        }

        private void FillDefaultData()
        {
            cbTextType.SelectedIndex = 0;
            gbGeneralLanguage.Enabled = false;
            gbProgrammingLanguage.Enabled = false;
            gbCombinatorial.Enabled = false;
            txtTime.Text = 1.ToString();
            rdArangebyWords.PerformClick();
            gbOtherSetting.Enabled = false;
            Config.Type = "انگلیسی";
            Config.Show = "words";
            Config.Time = 1;
            Config.SmallWord = cbJustlittleWords.Checked = true;
        }

        private void Start()
        {
            ReturnSetting = new Setting();
            DialogResult = DialogResult.OK;
            Close();

        }

        public Setting ReturnSetting { get; set; }

        private void btSDefault_Click(object sender, EventArgs e)
        {
            switch (cbTextType.SelectedIndex)
            {
                case 0:
                    Start();
                    return;
                    break;
                case 1:
                    if (rdtPersian.Checked)
                        Config.Type = Istaha.Zabanha.Persian;
                    else if (rdtEnglish.Checked)
                        Config.Type = Istaha.Zabanha.English;
                    else if (rdtGerman.Checked)
                        Config.Type = Istaha.Zabanha.German;
                    else if (rdtFrench.Checked)
                        Config.Type = Istaha.Zabanha.French;
                    Config.SmallWord = cbJustlittleWords.Checked;
                    break;
                case 2:
                    if (rdtCSharp.Checked)
                        Config.Type = Istaha.TypeProgramming.CSharp;
                    else if (rdtCSS.Checked)
                        Config.Type = Istaha.TypeProgramming.Css;
                    else if (rdtHtml.Checked)
                        Config.Type = Istaha.TypeProgramming.Html;
                    else if (rdtVB.Checked)
                        Config.Type = Istaha.TypeProgramming.Vb;
                    else if (rdtJava.Checked)
                        Config.Type = Istaha.TypeProgramming.Java;
                    Config.SmallWord = cbJustlittleWords.Checked;
                    break;
                case 3:
                    if (rdtShortcuts.Checked)
                        Config.Type = Istaha.TypeCombinatorial.ShortCuts;
                    else if (rdtRandom.Checked)
                        Config.Type = Istaha.TypeCombinatorial.Randomed;
                    break;
                case 4:
                    break;
                case 5:
                    break;

            }
            Config.Time = int.Parse(txtTime.Text);
            Config.Show = rdArangebyWords.Checked
                ? Istaha.Showtype.WordbyWord
                : Istaha.Showtype.Paragraph;
            Start();
        }


        private void cbTextType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changed = true;
            switch (cbTextType.SelectedIndex)
            {
                case 0:
                    gbGeneralLanguage.Enabled = false;
                    gbProgrammingLanguage.Enabled = false;
                    gbCombinatorial.Enabled = false;
                    FillDefaultData();

                    break;
                case 1:
                    MessageBox.Show("به زودی به برنامه اضافه می شود", "فعلا پول نداریم");
                    cbTextType.SelectedIndex = 0;
                    return;
                    gbGeneralLanguage.Enabled = true;
                    gbProgrammingLanguage.Enabled = false;
                    gbCombinatorial.Enabled = false;
                    gbOtherSetting.Enabled = true;
                    break;
                case 2:
                    MessageBox.Show("به زودی به برنامه اضافه می شود", "فعلا پول نداریم");
                    cbTextType.SelectedIndex = 0;
                    return;
                    gbGeneralLanguage.Enabled = false;
                    gbProgrammingLanguage.Enabled = true;
                    gbCombinatorial.Enabled = false;
                    gbOtherSetting.Enabled = true;
                    break;
                case 3:
                    MessageBox.Show("به زودی به برنامه اضافه می شود", "فعلا پول نداریم");
                    cbTextType.SelectedIndex = 0;
                    return;
                    gbGeneralLanguage.Enabled = false;
                    gbProgrammingLanguage.Enabled = false;
                    gbCombinatorial.Enabled = true;
                    gbOtherSetting.Enabled = true;
                    break;
                case 4:
                case 5:
                    MessageBox.Show("به زودی به برنامه اضافه می شود", "فعلا پول نداریم");
                    cbTextType.SelectedIndex = 0;
                    return;
                    gbOtherSetting.Enabled = false;
                    gbGeneralLanguage.Enabled = false;
                    gbProgrammingLanguage.Enabled = false;
                    gbCombinatorial.Enabled = false;
                    break;

            }

        }



        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) //&& (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //// only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtTime_TextChanged(object sender, EventArgs e)
        {
            if (txtTime.Text != string.Empty)
                if (int.Parse(txtTime.Text) > 60)
                    txtTime.Text = 60.ToString();
                else if (int.Parse(txtTime.Text) < 1)
                {
                    txtTime.Text = 1.ToString();
                }

        }
    }
}
