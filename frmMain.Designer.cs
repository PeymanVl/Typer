using System.ComponentModel;
using System.Windows.Forms;

namespace Typer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcLang = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pbAbout = new System.Windows.Forms.PictureBox();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.picTheme = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSetting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlEnglish = new System.Windows.Forms.Panel();
            this.lbtime = new System.Windows.Forms.Label();
            this.btClock = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbLang = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.pnlFarsi = new System.Windows.Forms.Panel();
            this.lbzaman = new System.Windows.Forms.Label();
            this.btShoru = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.txtwordsFarsi = new System.Windows.Forms.RichTextBox();
            this.txtInputFarsi = new System.Windows.Forms.RichTextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlEnglish.SuspendLayout();
            this.pnlFarsi.SuspendLayout();
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
            this.pnlHeader.Controls.Add(this.pcLang);
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Controls.Add(this.pbAbout);
            this.pnlHeader.Controls.Add(this.pbTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(756, 50);
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
            this.label2.Location = new System.Drawing.Point(50, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 27);
            this.label2.TabIndex = 29;
            this.label2.Text = "Typer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pcLang
            // 
            this.pcLang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcLang.Image = ((System.Drawing.Image)(resources.GetObject("pcLang.Image")));
            this.pcLang.Location = new System.Drawing.Point(636, 12);
            this.pcLang.Name = "pcLang";
            this.pcLang.Size = new System.Drawing.Size(32, 32);
            this.pcLang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcLang.TabIndex = 28;
            this.pcLang.TabStop = false;
            this.pcLang.Click += new System.EventHandler(this.radLabel3_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(712, 12);
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
            // pbAbout
            // 
            this.pbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAbout.Image = ((System.Drawing.Image)(resources.GetObject("pbAbout.Image")));
            this.pbAbout.Location = new System.Drawing.Point(674, 12);
            this.pbAbout.Name = "pbAbout";
            this.pbAbout.Size = new System.Drawing.Size(32, 32);
            this.pbAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAbout.TabIndex = 18;
            this.pbAbout.TabStop = false;
            this.pbAbout.Click += new System.EventHandler(this.pbAbout_Click);
            this.pbAbout.MouseEnter += new System.EventHandler(this.pbAbout_MouseEnter);
            this.pbAbout.MouseLeave += new System.EventHandler(this.pbAbout_MouseLeave);
            // 
            // pbTime
            // 
            this.pbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTime.Image = ((System.Drawing.Image)(resources.GetObject("pbTime.Image")));
            this.pbTime.Location = new System.Drawing.Point(598, 11);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(32, 32);
            this.pbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTime.TabIndex = 19;
            this.pbTime.TabStop = false;
            this.pbTime.Visible = false;
            // 
            // picTheme
            // 
            this.picTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picTheme.Image = ((System.Drawing.Image)(resources.GetObject("picTheme.Image")));
            this.picTheme.Location = new System.Drawing.Point(15, 356);
            this.picTheme.Name = "picTheme";
            this.picTheme.Size = new System.Drawing.Size(32, 32);
            this.picTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTheme.TabIndex = 31;
            this.picTheme.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btSetting);
            this.panel1.Controls.Add(this.picTheme);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(65, 400);
            this.panel1.TabIndex = 17;
            // 
            // btSetting
            // 
            this.btSetting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btSetting.AutoSize = true;
            this.btSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSetting.BorderRadius = 0;
            this.btSetting.ButtonText = "";
            this.btSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSetting.DisabledColor = System.Drawing.Color.Gray;
            this.btSetting.Iconcolor = System.Drawing.Color.Transparent;
            this.btSetting.Iconimage = ((System.Drawing.Image)(resources.GetObject("btSetting.Iconimage")));
            this.btSetting.Iconimage_right = null;
            this.btSetting.Iconimage_right_Selected = null;
            this.btSetting.Iconimage_Selected = null;
            this.btSetting.IconMarginLeft = 0;
            this.btSetting.IconMarginRight = 0;
            this.btSetting.IconRightVisible = true;
            this.btSetting.IconRightZoom = 0D;
            this.btSetting.IconVisible = true;
            this.btSetting.IconZoom = 75D;
            this.btSetting.IsTab = false;
            this.btSetting.Location = new System.Drawing.Point(5, 296);
            this.btSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSetting.Name = "btSetting";
            this.btSetting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.btSetting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btSetting.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btSetting.selected = false;
            this.btSetting.Size = new System.Drawing.Size(55, 60);
            this.btSetting.TabIndex = 42;
            this.btSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSetting.Textcolor = System.Drawing.Color.White;
            this.btSetting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.pnlEnglish);
            this.panel2.Controls.Add(this.pnlFarsi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(65, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 400);
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
            this.pnlEnglish.Size = new System.Drawing.Size(691, 400);
            this.pnlEnglish.TabIndex = 30;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.lbtime.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbtime.ForeColor = System.Drawing.Color.White;
            this.lbtime.Location = new System.Drawing.Point(588, 242);
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
            this.btClock.Location = new System.Drawing.Point(240, 296);
            this.btClock.Margin = new System.Windows.Forms.Padding(5);
            this.btClock.Name = "btClock";
            this.btClock.Size = new System.Drawing.Size(181, 41);
            this.btClock.TabIndex = 41;
            this.btClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btClock.Click += new System.EventHandler(this.btnClock_Click);
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbLang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.lbLang.Location = new System.Drawing.Point(17, 14);
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
            this.txtWords.Location = new System.Drawing.Point(22, 90);
            this.txtWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWords.Name = "txtWords";
            this.txtWords.ReadOnly = true;
            this.txtWords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWords.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtWords.Size = new System.Drawing.Size(631, 133);
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
            this.txtInput.Location = new System.Drawing.Point(22, 231);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(631, 44);
            this.txtInput.TabIndex = 39;
            this.txtInput.Text = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // pnlFarsi
            // 
            this.pnlFarsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlFarsi.Controls.Add(this.lbzaman);
            this.pnlFarsi.Controls.Add(this.btShoru);
            this.pnlFarsi.Controls.Add(this.label1);
            this.pnlFarsi.Controls.Add(this.txtwordsFarsi);
            this.pnlFarsi.Controls.Add(this.txtInputFarsi);
            this.pnlFarsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFarsi.Location = new System.Drawing.Point(0, 0);
            this.pnlFarsi.Name = "pnlFarsi";
            this.pnlFarsi.Size = new System.Drawing.Size(691, 400);
            this.pnlFarsi.TabIndex = 34;
            this.pnlFarsi.Visible = false;
            // 
            // lbzaman
            // 
            this.lbzaman.AutoSize = true;
            this.lbzaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.lbzaman.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbzaman.ForeColor = System.Drawing.Color.White;
            this.lbzaman.Location = new System.Drawing.Point(44, 257);
            this.lbzaman.Name = "lbzaman";
            this.lbzaman.Size = new System.Drawing.Size(0, 27);
            this.lbzaman.TabIndex = 30;
            // 
            // btShoru
            // 
            this.btShoru.ActiveBorderThickness = 1;
            this.btShoru.ActiveCornerRadius = 20;
            this.btShoru.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btShoru.ActiveForecolor = System.Drawing.Color.White;
            this.btShoru.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btShoru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.btShoru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btShoru.BackgroundImage")));
            this.btShoru.ButtonText = "شروع";
            this.btShoru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShoru.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btShoru.IdleBorderThickness = 1;
            this.btShoru.IdleCornerRadius = 20;
            this.btShoru.IdleFillColor = System.Drawing.Color.White;
            this.btShoru.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btShoru.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btShoru.Location = new System.Drawing.Point(249, 310);
            this.btShoru.Margin = new System.Windows.Forms.Padding(5);
            this.btShoru.Name = "btShoru";
            this.btShoru.Size = new System.Drawing.Size(181, 41);
            this.btShoru.TabIndex = 42;
            this.btShoru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btShoru.Click += new System.EventHandler(this.btShoru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(603, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "فارسی";
            // 
            // txtwordsFarsi
            // 
            this.txtwordsFarsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtwordsFarsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtwordsFarsi.Font = new System.Drawing.Font("Iranian Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtwordsFarsi.ForeColor = System.Drawing.Color.Silver;
            this.txtwordsFarsi.Location = new System.Drawing.Point(34, 90);
            this.txtwordsFarsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwordsFarsi.Name = "txtwordsFarsi";
            this.txtwordsFarsi.ReadOnly = true;
            this.txtwordsFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtwordsFarsi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtwordsFarsi.Size = new System.Drawing.Size(634, 148);
            this.txtwordsFarsi.TabIndex = 36;
            this.txtwordsFarsi.TabStop = false;
            this.txtwordsFarsi.Text = "این متن فارسی است برای تست";
            // 
            // txtInputFarsi
            // 
            this.txtInputFarsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtInputFarsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputFarsi.Font = new System.Drawing.Font("Iranian Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInputFarsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(192)))), ((int)(((byte)(37)))));
            this.txtInputFarsi.Location = new System.Drawing.Point(34, 248);
            this.txtInputFarsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputFarsi.Name = "txtInputFarsi";
            this.txtInputFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInputFarsi.Size = new System.Drawing.Size(634, 44);
            this.txtInputFarsi.TabIndex = 38;
            this.txtInputFarsi.Text = "";
            this.txtInputFarsi.TextChanged += new System.EventHandler(this.txtInputFarsi_TextChanged);
            this.txtInputFarsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputFarsi_KeyPress);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "تایپر";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTheme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlEnglish.ResumeLayout(false);
            this.pnlEnglish.PerformLayout();
            this.pnlFarsi.ResumeLayout(false);
            this.pnlFarsi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Timer Timer;
        private Panel pnlHeader;
        private PictureBox picClose;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pbAbout;
        private PictureBox pbTime;
        private PictureBox pcLang;
        private Panel pnlEnglish;
        private Label lbLang;
        private RichTextBox txtWords;
        private Panel pnlFarsi;
        private RichTextBox txtInputFarsi;
        private Label label1;
        private RichTextBox txtwordsFarsi;
        private PictureBox picTheme;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private RichTextBox txtInput;
        private Label lbtime;
        private Bunifu.Framework.UI.BunifuThinButton2 btClock;
        private Bunifu.Framework.UI.BunifuFlatButton btSetting;
        private Bunifu.Framework.UI.BunifuThinButton2 btShoru;
        private Label lbzaman;
    }
}

