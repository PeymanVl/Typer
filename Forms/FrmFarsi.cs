using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Typer.Classes;

namespace Typer.Forms
{
    public partial class FrmFarsi : Form
    {
        private bool _clicked;

        #region vars

        public Setting Setting { get; set; }
        private readonly List<string> _wordsList = new List<string>();
        private readonly List<string> _randomedWords = new List<string>();
        private int _index;
        private int _secound;
        private bool _firsttime = true;
        private int _charlenght;
        private int CurrectCounter { get; set; }
        public int IncurrectCounter { get; set; }
        private int _lastindex;
        private int _sec = 60;

        private int _x, _y;
        #endregion
    

        public FrmFarsi()
        {
            InitializeComponent();
            var f = new Setting();
            Setting = f;

            _secound = decimal.ToInt32(Setting.Time) * 60;
            FillText();
        }

        public FrmFarsi(Setting setting)
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
            var type = "";
            var method = Setting.ShowType;
            _wordsList.Clear();
            var wordscontrol = new RichTextBox();
            var inputcontrol = new RichTextBox();
            _randomedWords.Clear();
            switch (Setting.Type)
            {
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
                        _wordsList.Add(word.Trim(' ').ToLower());
                else
                    foreach (var word in s)
                        _wordsList.Add(word.Trim(' '));
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
            var sb = new StringBuilder();
            var rnd = new Random();
            for (var i = 0; i < 200; i++)
            {
                var r = rnd.Next(_wordsList.Count);
                sb.Append(_wordsList[r]);
                sb.Append(' ');
                _randomedWords.Add(_wordsList[r]);
            }

            txtwordsFarsi.Text = sb.ToString();
        }

        //two method to return word index in richtextbox for highlight it
        private int BringStartIndex(int index, object control)
        {
            int counter = index, endIndex = 0;
            var c = control as RichTextBox;
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
            var c = control as RichTextBox;
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
            var c = control as RichTextBox;
            c.Select(BringStartIndex(c), _randomedWords[_index + 1].Length);
            using (var f = new Font(txtwordsFarsi.Font, FontStyle.Underline))
            {
                c.SelectionFont = f;
                c.SelectionBackColor = Color.DimGray;
            }
        }

        private void SelectText(object Words, object Input)
        {
            var loop = 0;
            var w = Words as RichTextBox;
            var I = Input as RichTextBox;
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
                    var startpoint = BringStartIndex(_index - 1, w);
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_secound < 1)
            {
                _secound = Setting.Time * 60;
                Timer.Enabled = false;
                txtInputFarsi.ReadOnly = true;
                _sec = 60;
                lbzaman.Text = @"0:00";
                if (pnlFarsi.Visible)
                {
                    txtwordsFarsi.Text = $@"صحیح: {CurrectCounter}        اشتباه: {IncurrectCounter}";
                    txtInputFarsi.Visible = false;
                    txtwordsFarsi.Focus();
                    lbzaman.Text = "";
                }
            }
            else
            {
                if (_sec < 0)
                    _sec = 60;
                _secound--;
                _sec--;
                lbzaman.Text = $@"{_secound / 60}:{_sec}";
                lbzaman.Text = $@"{_secound / 60}:{_sec}";
            }
        }

        private void pnboder_MouseUp(object sender, MouseEventArgs e)
        {
            _clicked = false;
        }

        private void pnboder_MouseMove(object sender, MouseEventArgs e)
        {
            if (_clicked) Location = new Point(Location.X - _x + e.X, Location.Y - _y + e.Y);
        }

        private void picClose_MouseEnter(object sender, EventArgs e)
        {
            picClose.BorderStyle = BorderStyle.FixedSingle;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BorderStyle = BorderStyle.None;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Application.Exit();
        }

        private void txtInputFarsi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtInputFarsi.Text != "")
                {
                    _charlenght = txtInputFarsi.TextLength - 1;
                    txtInputFarsi.BackColor =
                        Equals(_randomedWords[_index][_charlenght], txtInputFarsi.Text[_charlenght])
                            ? Color.FromArgb(40, 25, 40)
                            : Color.FromArgb(150, 50, 60);
                }
            }
            catch (Exception)
            {
                txtInputFarsi.Text = @" ";
            }

            // Delete space when you press for check your world
            if (((RichTextBox) sender).Text == @" ") ((RichTextBox) sender).Text = "";


            if (txtInputFarsi.Text == "") txtInputFarsi.BackColor = Color.FromArgb(40, 25, 40);
            //check  is the first time we start a new game
            if (!_firsttime) return;
            Timer.Enabled = _firsttime;

            _firsttime = false;
        }

        private void txtInputFarsi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Space)
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
                        txtInputFarsi_TextChanged(sender, e);
                    else
                        Application.Exit();
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