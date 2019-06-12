namespace Typer.Forms
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btFarsi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btEnglish = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btFarsi);
            this.bunifuGradientPanel1.Controls.Add(this.btEnglish);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Window;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(566, 256);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btFarsi
            // 
            this.btFarsi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btFarsi.BackColor = System.Drawing.Color.Maroon;
            this.btFarsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFarsi.BorderRadius = 0;
            this.btFarsi.ButtonText = "فارسی";
            this.btFarsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFarsi.DisabledColor = System.Drawing.Color.Gray;
            this.btFarsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFarsi.Iconcolor = System.Drawing.Color.Transparent;
            this.btFarsi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btFarsi.Iconimage")));
            this.btFarsi.Iconimage_right = null;
            this.btFarsi.Iconimage_right_Selected = null;
            this.btFarsi.Iconimage_Selected = null;
            this.btFarsi.IconMarginLeft = 0;
            this.btFarsi.IconMarginRight = 0;
            this.btFarsi.IconRightVisible = true;
            this.btFarsi.IconRightZoom = 0D;
            this.btFarsi.IconVisible = true;
            this.btFarsi.IconZoom = 90D;
            this.btFarsi.IsTab = false;
            this.btFarsi.Location = new System.Drawing.Point(106, 92);
            this.btFarsi.Name = "btFarsi";
            this.btFarsi.Normalcolor = System.Drawing.Color.Maroon;
            this.btFarsi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btFarsi.OnHoverTextColor = System.Drawing.Color.White;
            this.btFarsi.selected = false;
            this.btFarsi.Size = new System.Drawing.Size(145, 59);
            this.btFarsi.TabIndex = 1;
            this.btFarsi.Text = "فارسی";
            this.btFarsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFarsi.Textcolor = System.Drawing.Color.White;
            this.btFarsi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFarsi.Click += new System.EventHandler(this.BtFarsi_Click);
            // 
            // btEnglish
            // 
            this.btEnglish.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btEnglish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEnglish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEnglish.BorderRadius = 0;
            this.btEnglish.ButtonText = "English";
            this.btEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnglish.DisabledColor = System.Drawing.Color.Gray;
            this.btEnglish.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnglish.Iconcolor = System.Drawing.Color.Transparent;
            this.btEnglish.Iconimage = ((System.Drawing.Image)(resources.GetObject("btEnglish.Iconimage")));
            this.btEnglish.Iconimage_right = null;
            this.btEnglish.Iconimage_right_Selected = null;
            this.btEnglish.Iconimage_Selected = null;
            this.btEnglish.IconMarginLeft = 0;
            this.btEnglish.IconMarginRight = 0;
            this.btEnglish.IconRightVisible = true;
            this.btEnglish.IconRightZoom = 0D;
            this.btEnglish.IconVisible = true;
            this.btEnglish.IconZoom = 90D;
            this.btEnglish.IsTab = false;
            this.btEnglish.Location = new System.Drawing.Point(310, 92);
            this.btEnglish.Name = "btEnglish";
            this.btEnglish.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEnglish.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btEnglish.OnHoverTextColor = System.Drawing.Color.White;
            this.btEnglish.selected = false;
            this.btEnglish.Size = new System.Drawing.Size(145, 59);
            this.btEnglish.TabIndex = 0;
            this.btEnglish.Text = "English";
            this.btEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnglish.Textcolor = System.Drawing.Color.White;
            this.btEnglish.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnglish.Click += new System.EventHandler(this.BtEnglish_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 256);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starter";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btFarsi;
        private Bunifu.Framework.UI.BunifuFlatButton btEnglish;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}