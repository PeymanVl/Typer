using System.ComponentModel;
using System.Windows.Forms;

namespace Typer.Forms
{
    partial class FrmFarsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFarsi));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFarsi = new System.Windows.Forms.Panel();
            this.lbzaman = new System.Windows.Forms.Label();
            this.btShoru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtwordsFarsi = new System.Windows.Forms.RichTextBox();
            this.txtInputFarsi = new System.Windows.Forms.RichTextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.pnlHeader.Controls.Add(this.picClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(672, 50);
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
            this.label2.Location = new System.Drawing.Point(51, 12);
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
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(628, 12);
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
            this.panel2.Controls.Add(this.pnlFarsi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(672, 360);
            this.panel2.TabIndex = 18;
            // 
            // pnlFarsi
            // 
            this.pnlFarsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.pnlFarsi.Controls.Add(this.lbzaman);
            this.pnlFarsi.Controls.Add(this.btShoru);
            this.pnlFarsi.Controls.Add(this.label1);
            this.pnlFarsi.Controls.Add(this.txtwordsFarsi);
            this.pnlFarsi.Controls.Add(this.txtInputFarsi);
            this.pnlFarsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFarsi.Location = new System.Drawing.Point(0, 0);
            this.pnlFarsi.Name = "pnlFarsi";
            this.pnlFarsi.Size = new System.Drawing.Size(672, 360);
            this.pnlFarsi.TabIndex = 34;
            // 
            // lbzaman
            // 
            this.lbzaman.AutoSize = true;
            this.lbzaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.lbzaman.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lbzaman.ForeColor = System.Drawing.Color.White;
            this.lbzaman.Location = new System.Drawing.Point(75, 286);
            this.lbzaman.Name = "lbzaman";
            this.lbzaman.Size = new System.Drawing.Size(0, 27);
            this.lbzaman.TabIndex = 30;
            // 
            // btShoru
            // 
            this.btShoru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShoru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShoru.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btShoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.btShoru.Location = new System.Drawing.Point(251, 272);
            this.btShoru.Margin = new System.Windows.Forms.Padding(5);
            this.btShoru.Name = "btShoru";
            this.btShoru.Size = new System.Drawing.Size(183, 58);
            this.btShoru.TabIndex = 42;
            this.btShoru.Text = "شروع";
            this.btShoru.UseVisualStyleBackColor = false;
            this.btShoru.Click += new System.EventHandler(this.btShoru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(581, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 37;
            this.label1.Text = "فارسی";
            // 
            // txtwordsFarsi
            // 
            this.txtwordsFarsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txtwordsFarsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtwordsFarsi.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtwordsFarsi.ForeColor = System.Drawing.Color.White;
            this.txtwordsFarsi.Location = new System.Drawing.Point(49, 53);
            this.txtwordsFarsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtwordsFarsi.Name = "txtwordsFarsi";
            this.txtwordsFarsi.ReadOnly = true;
            this.txtwordsFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtwordsFarsi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtwordsFarsi.Size = new System.Drawing.Size(597, 148);
            this.txtwordsFarsi.TabIndex = 36;
            this.txtwordsFarsi.TabStop = false;
            this.txtwordsFarsi.Text = "این متن فارسی است برای تست";
            // 
            // txtInputFarsi
            // 
            this.txtInputFarsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(128)))), ((int)(((byte)(197)))));
            this.txtInputFarsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputFarsi.Font = new System.Drawing.Font("Iranian Sans", 20F);
            this.txtInputFarsi.ForeColor = System.Drawing.Color.White;
            this.txtInputFarsi.Location = new System.Drawing.Point(50, 209);
            this.txtInputFarsi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputFarsi.Name = "txtInputFarsi";
            this.txtInputFarsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInputFarsi.Size = new System.Drawing.Size(596, 44);
            this.txtInputFarsi.TabIndex = 38;
            this.txtInputFarsi.Text = "";
            this.txtInputFarsi.TextChanged += new System.EventHandler(this.txtInputFarsi_TextChanged);
            this.txtInputFarsi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputFarsi_KeyPress);
            // 
            // FrmFarsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 410);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmFarsi";
            this.Text = "تایپر";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlFarsi.ResumeLayout(false);
            this.pnlFarsi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Timer Timer;
        private Panel pnlHeader;
        private PictureBox picClose;
        private Panel panel2;
        private Panel pnlFarsi;
        private RichTextBox txtInputFarsi;
        private Label label1;
        private RichTextBox txtwordsFarsi;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btShoru;
        private Label lbzaman;
    }
}

