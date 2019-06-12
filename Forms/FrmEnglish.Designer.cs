using System.ComponentModel;
using System.Windows.Forms;

namespace Typer.Forms
{
    partial class FrmEnglish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnglish));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEnglish = new System.Windows.Forms.Panel();
            this.lbtime = new System.Windows.Forms.Label();
            this.btClock = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbLang = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlEnglish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(672, 53);
            this.pnlHeader.TabIndex = 15;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnboder_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnboder_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnboder_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Typer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(628, 13);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 21;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnboder_MouseDown);
            this.picClose.MouseEnter += new System.EventHandler(this.picClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnboder_MouseMove);
            this.picClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnboder_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pnlEnglish);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 357);
            this.panel2.TabIndex = 18;
            // 
            // pnlEnglish
            // 
            this.pnlEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.pnlEnglish.Controls.Add(this.lbtime);
            this.pnlEnglish.Controls.Add(this.btClock);
            this.pnlEnglish.Controls.Add(this.lbLang);
            this.pnlEnglish.Controls.Add(this.txtWords);
            this.pnlEnglish.Controls.Add(this.txtInput);
            this.pnlEnglish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnglish.Location = new System.Drawing.Point(0, 0);
            this.pnlEnglish.Name = "pnlEnglish";
            this.pnlEnglish.Size = new System.Drawing.Size(672, 357);
            this.pnlEnglish.TabIndex = 30;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lbtime.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbtime.ForeColor = System.Drawing.Color.White;
            this.lbtime.Location = new System.Drawing.Point(588, 234);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(0, 27);
            this.lbtime.TabIndex = 40;
            // 
            // btClock
            // 
            this.btClock.ActiveBorderThickness = 1;
            this.btClock.ActiveCornerRadius = 20;
            this.btClock.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btClock.ActiveForecolor = System.Drawing.Color.White;
            this.btClock.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(240)))));
            this.btClock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btClock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btClock.BackgroundImage")));
            this.btClock.ButtonText = "New";
            this.btClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btClock.IdleBorderThickness = 1;
            this.btClock.IdleCornerRadius = 20;
            this.btClock.IdleFillColor = System.Drawing.Color.White;
            this.btClock.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btClock.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btClock.Location = new System.Drawing.Point(231, 278);
            this.btClock.Margin = new System.Windows.Forms.Padding(5);
            this.btClock.Name = "btClock";
            this.btClock.Size = new System.Drawing.Size(199, 64);
            this.btClock.TabIndex = 41;
            this.btClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.lbLang.Location = new System.Drawing.Point(17, 15);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(80, 27);
            this.lbLang.TabIndex = 28;
            this.lbLang.Text = "English";
            // 
            // txtWords
            // 
            this.txtWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWords.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.txtWords.ForeColor = System.Drawing.Color.Silver;
            this.txtWords.Location = new System.Drawing.Point(22, 61);
            this.txtWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtWords.Size = new System.Drawing.Size(631, 141);
            this.txtWords.TabIndex = 6;
            this.txtWords.TabStop = false;
            this.txtWords.Text = "we have text here which  you can type in box under this text\na\na";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.txtInput.Location = new System.Drawing.Point(22, 222);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(631, 47);
            this.txtInput.TabIndex = 39;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // FrmEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 410);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmEnglish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تایپر";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlEnglish.ResumeLayout(false);
            this.pnlEnglish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Timer Timer;
        private Panel pnlHeader;
        private PictureBox picClose;
        private Panel panel2;
        private Panel pnlEnglish;
        private Label lbLang;
        private RichTextBox txtWords;
        private Label label2;
        private PictureBox pictureBox1;
        private RichTextBox txtInput;
        private Label lbtime;
        private Bunifu.Framework.UI.BunifuThinButton2 btClock;
    }
}

