using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer.Forms
{
    public partial class FrmCharCount : Form
    {
        public FrmCharCount()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter )
            {
                Text = textBox1.TextLength.ToString();
                e.Handled = true;
            }
        }

        private void FrmCharCount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Control)
            {
                Text = textBox1.TextLength.ToString();

            }
        }
    }
}
