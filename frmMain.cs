using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Typer.Classes;

namespace Typer
{
    public partial class FrmMain : Form
    {
        #region vars

        public Setting Setting { get; set; }
        readonly List<string> _wordsList = new List<string>();
        readonly List<string> _randomedWords = new List<string>();
        private int _index;
        private int _secound;
        private bool _firsttime = true;
        private int _charlenght;
        private int CurrectCounter { get; set; }
        public int IncurrectCounter { get; set; }
        private int _lastindex;

        #endregion

        public FrmMain()
        {
            InitializeComponent();
            var f = new Setting();
            Setting = f;

            _secound = decimal.ToInt32(Setting.Time) * 60;
            FillText();


        }

        public FrmMain(Setting setting)
        {

            InitializeComponent();
            //Set clock
            Setting = setting;
            _secound = decimal.ToInt32(Setting.Time) * 60;

            FillText();


        }
        private void NewStart(RichTextBox Words, RichTextBox Input)
        {

            Words.Text = string.Empty;
            GetWords();
            CurrectCounter = IncurrectCounter = 0;
            _secound = decimal.ToInt32(Setting.Time) * 60;

            _index = 0;
            
            Input.ReadOnly = false;
            _firsttime = false;
            Input.Clear();
            _firsttime = true;
            Words.Select(0, _randomedWords[_index].Length);
            using (var f = new Font(Words.Font, FontStyle.Underline))
            {

                Words.SelectionFont = f;
                //txtWords.SelectionBackColor = Color.DimGray;
            }
            Input.Focus();
        }

        private void FillText()
        {
            string type = "";
            string method = Setting.ShowType;
            _wordsList.Clear();
            RichTextBox wordscontrol = new RichTextBox();
            RichTextBox inputcontrol = new RichTextBox();
            _randomedWords.Clear(); switch (Setting.Type)
            {
                case Istaha.Zabanha.English:
                    type = @"Files/en-";
                    wordscontrol = txtWords;
                    inputcontrol = txtInput;
                    break;
                case Istaha.Zabanha.Persian:
                    type = @"Files/fa-";
                    wordscontrol = txtwordsFarsi;
                    inputcontrol = txtInputFarsi;
                    break;
                case Istaha.Zabanha.French:
                    type = @"Files/fr-";
                    break;
                case Istaha.Zabanha.German:
                    type = @"Files/gr-";
                    break;
                case Istaha.TypeProgramming.CSharp:
                    type = @"Files/csharp-";
                    break;
                case Istaha.TypeProgramming.Css:
                    type = @"Files/css-";
                    break;
                case Istaha.TypeProgramming.Html:
                    type = @"Files/html-";
                    break;
                case Istaha.TypeProgramming.Java:
                    type = @"Files/java-";
                    break;
                case Istaha.TypeProgramming.Vb:
                    type = @"Files/vb-";
                    break;
                case Istaha.TypeCombinatorial.ShortCuts:
                    type = @"Files/shortcut";
                    method = "";
                    break;
                case Istaha.TypeCombinatorial.Randomed:
                    type = @"Files/randomed";
                    method = "";
                    break;
            }

            try
            {
                if (type == string.Empty)
                    type = @"Files/en-";
                var path = new StringBuilder().Append(type);
                path.Append(method);
                path.Append(".txt");
                var s = File.ReadAllLines(path.ToString(), Encoding.UTF8).Select(x => x)
                    .Where(x => x.ToString().Length < 8).ToList();
                if (Setting.SmallWord)
                    foreach (var word in s)
                    {
                        _wordsList.Add(word.Trim(' ').ToLower());
                    }
                else
                {
                    foreach (var word in s)
                    {
                        _wordsList.Add(word.Trim(' '));
                    }
                }
            }



            catch (Exception)
            {
                throw new Exception("خطا رد خواندن فایل");
            }
            NewStart(wordscontrol, inputcontrol);
        }
        private void GetWords()
        {
            _randomedWords.Clear();
            StringBuilder sb = new StringBuilder();
            var rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                var r = rnd.Next(_wordsList.Count);
                sb.Append(_wordsList[r]);
                sb.Append(' ');
                _randomedWords.Add(_wordsList[r]);
            }
            switch (Setting.Type)
            {
                case Istaha.Zabanha.English:
                    txtWords.Text = sb.ToString();
                    break;
                case Istaha.Zabanha.Persian:
                    txtwordsFarsi.Text = sb.ToString();
                    break;
            }

        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInput.Text != "")
                {
                    if (txtInput.TextLength <= _randomedWords[_index].Length)
                    {
                        _charlenght = txtInput.TextLength - 1;
                        txtWords.SelectionBackColor = Equals(_randomedWords[_index][_charlenght], txtInput.Text[_charlenght])
                            ? Color.FromArgb(36, 50, 80)
                            : Color.FromArgb(150, 50, 60);
                    }
                    else if (txtInput.TextLength > _randomedWords[_index].Length)
                    {
                        txtWords.SelectionBackColor = Color.FromArgb(150, 50, 60);
                    }
                }
            }
            catch (Exception)
            {
                txtInput.Text = @" ";
            }
            // Delete space when you press for check your world
            if (((RichTextBox)sender).Text == @" ")
            { ((RichTextBox)sender).Text = ""; }


            if (txtInput.Text == "") txtWords.SelectionBackColor = Color.FromArgb(36, 50, 80);
            //check  is the first time we start a new game
            if (!_firsttime) return;
            Timer.Enabled = _firsttime;

            _firsttime = false;
        }

        //two method to return word index in richtextbox for highlight it
        private int BringStartIndex(int index, object control)
        {
            int counter = index, endIndex = 0;
            RichTextBox c = control as RichTextBox;
            foreach (var item in c.Text.Split(' '))
            {

                if (counter < 0)
                    break;
                endIndex += item.Length + 1;
                counter--;
            }
            return endIndex;
        }
        private int BringStartIndex(object control)
        {
            int counter = _index, endIndex = 0;
            RichTextBox c = control as RichTextBox;
            foreach (var item in c.Text.Split(' '))
            {

                if (counter < 0)
                    break;
                endIndex += item.Length + 1;
                counter--;
            }
            return endIndex;
        }
        //highlight next word
        private void HighlightNextWord(object control)
        {
            RichTextBox c = control as RichTextBox;
            c.Select(BringStartIndex(c), _randomedWords[_index + 1].Length);
            using (var f = new Font(txtWords.Font, FontStyle.Underline))
            {
                c.SelectionFont = f;
                c.SelectionBackColor = Color.DimGray;

            }


        }
        private void SelectText(object Words, object Input)
        {
            int loop = 0;
            RichTextBox w = Words as RichTextBox;
            RichTextBox I = Input as RichTextBox;
            foreach (var word in w.Text.Split(' '))
            {
                loop++;
                if (word == I.Text && loop - 1 == _index)
                {
                    _lastindex = BringStartIndex(_index - 1, w);
                    w.Select(_lastindex, word.Length);
                    using (var f = new Font(w.Font, FontStyle.Regular))
                    {
                        if (word == _randomedWords[_index])
                        {
                            w.SelectionFont = f;
                            w.SelectionColor = Color.FromArgb(46, 139, 87);
                            w.SelectionBackColor = w.BackColor;
                        }
                    }
                    break;
                }
                if (word == _randomedWords[_index] && loop - 1 == _index)
                {
                    int startpoint = BringStartIndex(_index - 1, w);
                    w.Select(startpoint, word.Length);
                    using (var f = new Font(w.Font, FontStyle.Strikeout))
                    {
                        w.SelectionFont = f;
                        w.SelectionColor = Color.Red;
                        w.SelectionBackColor = w.BackColor;
                    }
                    _lastindex = startpoint;

                    break;
                }
            }
            if (_index < 199)
                HighlightNextWord(w);

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (_index <= 199)
                {
                    if (string.Equals(txtInput.Text, _randomedWords[_index]))
                    {
                        CurrectCounter++;
                        //scroll on our line
                        txtWords.ScrollToCaret();
                    }
                    else
                    {
                        txtWords.ScrollToCaret();
                        IncurrectCounter++;
                    }
                }
                else
                {
                    var newstart = MessageBox.Show($@"End of Words!{Environment.NewLine}    Do you want try again?",
                        @"Test Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (newstart == DialogResult.Yes)
                    {
                        btnClock_Click(sender, e);

                        txtInput_TextChanged(sender, e);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                SelectText(txtWords, txtInput);
                _index++;
                txtInput.Clear();
            }
        }


        private int _sec = 60;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_secound < 1)
            {
                _secound = Setting.Time * 60;
                Timer.Enabled = false;
                txtInput.ReadOnly = true;
                _sec = 60;
                lbtime.Text = @"0:00";
                lbzaman.Text = @"0:00";
                if (pnlFarsi.Visible)
                {
                    txtwordsFarsi.Text = $@"صحیح: {CurrectCounter}        اشتباه: {IncurrectCounter}";
                    txtInputFarsi.Visible = false;
                    txtwordsFarsi.Focus();
                    lbzaman.Text = "";
                }
                else if (pnlEnglish.Visible)
                {
                    txtWords.Text = $@"Currect Words:{CurrectCounter}      Incurrect Words:{IncurrectCounter}";
                    txtInput.Visible = false;
                    txtWords.Focus();
                    lbtime.Text = "";
                }

            }
            else
            {
                if (_sec < 0)
                    _sec = 60;
                _secound--;
                _sec--;
                lbtime.Text = $@"{_secound / 60}:{_sec}"; lbzaman.Text = $@"{_secound / 60}:{_sec}";
            }
        }
        private void btSetting_Click(object sender, EventArgs e)
        {
            Timer.Enabled = false;
            var f = new FrmSetting();
            f.ShowDialog();

            Setting = f.ReturnSetting;
            btnClock_Click(sender, e);
        }

        private int _x, _y;
        private bool _clicked;

        private void pnboder_MouseUp(object sender, MouseEventArgs e)
        {
            _clicked = false;
        }

        private void pnboder_MouseMove(object sender, MouseEventArgs e)
        {
            if (_clicked)
            {
                Location = new Point((Location.X - _x) + e.X, (Location.Y - _y) + e.Y);
            }
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BorderStyle = BorderStyle.None;
        }



        private void btnClock_Click(object sender, EventArgs e)
        {
            FillText(); Timer.Enabled = false;
            txtInput.Visible = true;
            NewStart(txtWords, txtInput);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void pbAbout_MouseEnter(object sender, EventArgs e)
        {
            pbAbout.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbAbout_MouseLeave(object sender, EventArgs e)
        {
            pbAbout.BorderStyle = BorderStyle.None;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
                Application.Exit();
        }

        private void radLabel3_Click(object sender, EventArgs e)
        {
            lbtime.Text = lbzaman.Text = "";
            if (pnlEnglish.Visible)
            {

                Setting.Type = Istaha.Zabanha.Persian;
                btShoru_Click(sender, e);
                pnlEnglish.Visible = false;
                pnlFarsi.Visible = true;
            }
            else
            {
                Setting.Type = Istaha.Zabanha.English;
                btnClock_Click(sender, e);
                pnlEnglish.Visible = true;
                pnlFarsi.Visible = false;

            }
        }

        private void txtInputFarsi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInputFarsi.Text != "")
                {
                    _charlenght = txtInputFarsi.TextLength - 1;
                    txtInputFarsi.BackColor = Equals(_randomedWords[_index][_charlenght], txtInputFarsi.Text[_charlenght]) ?
                        Color.FromArgb(40, 25, 40) : Color.FromArgb(150, 50, 60);
                }
            }
            catch (Exception)
            {
                txtInputFarsi.Text = @" ";
            }
            // Delete space when you press for check your world
            if (((RichTextBox)sender).Text == @" ")
            { ((RichTextBox)sender).Text = ""; }


            if (txtInputFarsi.Text == "") txtInputFarsi.BackColor = Color.FromArgb(40, 25, 40);
            //check  is the first time we start a new game
            if (!_firsttime) return;
            Timer.Enabled = _firsttime;

            _firsttime = false;
        }

        private void txtInputFarsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                if (_index <= 199)
                {
                    if (string.Equals(txtInputFarsi.Text, _randomedWords[_index]))
                    {
                        CurrectCounter++;
                        //scroll on our line
                        txtwordsFarsi.ScrollToCaret();
                    }
                    else
                    {
                        txtwordsFarsi.ScrollToCaret();
                        IncurrectCounter++;
                    }
                }
                else
                {
                    var newstart = MessageBox.Show($@"End of Words!{Environment.NewLine}    Do you want try again?",
                        @"Test Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (newstart == DialogResult.Yes)
                    {
                        btnClock_Click(sender, e);

                        txtInputFarsi_TextChanged(sender, e);
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                SelectText(txtwordsFarsi, txtInputFarsi);
                _index++;
                txtInputFarsi.Clear();
            }


        }

        private void btShoru_Click(object sender, EventArgs e)
        {
            FillText();
            Timer.Enabled = false;
            NewStart(txtwordsFarsi, txtInputFarsi);
        }

        private void pnboder_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
            _clicked = true;
        }
    }
}
