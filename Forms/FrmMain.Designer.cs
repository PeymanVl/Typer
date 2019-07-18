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
            this.btStart = new System.Windows.Forms.Button();
            this.gbWordTypes = new System.Windows.Forms.GroupBox();
            this.rbAdvance = new System.Windows.Forms.RadioButton();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.rbFrench = new System.Windows.Forms.RadioButton();
            this.rbPersian = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.gbWordTypes.SuspendLayout();
            this.gbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(292, 225);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(89, 34);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // gbWordTypes
            // 
            this.gbWordTypes.Controls.Add(this.rbText);
            this.gbWordTypes.Controls.Add(this.rbSimple);
            this.gbWordTypes.Controls.Add(this.rbAdvance);
            this.gbWordTypes.Location = new System.Drawing.Point(12, 12);
            this.gbWordTypes.Name = "gbWordTypes";
            this.gbWordTypes.Size = new System.Drawing.Size(369, 97);
            this.gbWordTypes.TabIndex = 1;
            this.gbWordTypes.TabStop = false;
            this.gbWordTypes.Text = "Word Types";
            // 
            // rbAdvance
            // 
            this.rbAdvance.AutoSize = true;
            this.rbAdvance.Location = new System.Drawing.Point(25, 39);
            this.rbAdvance.Name = "rbAdvance";
            this.rbAdvance.Size = new System.Drawing.Size(71, 19);
            this.rbAdvance.TabIndex = 0;
            this.rbAdvance.Text = "Advance";
            this.rbAdvance.UseVisualStyleBackColor = true;
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Checked = true;
            this.rbSimple.Location = new System.Drawing.Point(112, 39);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(61, 19);
            this.rbSimple.TabIndex = 0;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(192, 39);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(46, 19);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbFrench);
            this.gbLanguage.Controls.Add(this.rbPersian);
            this.gbLanguage.Controls.Add(this.rbEnglish);
            this.gbLanguage.Location = new System.Drawing.Point(12, 115);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(369, 97);
            this.gbLanguage.TabIndex = 1;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Language";
            // 
            // rbFrench
            // 
            this.rbFrench.AutoSize = true;
            this.rbFrench.Location = new System.Drawing.Point(192, 39);
            this.rbFrench.Name = "rbFrench";
            this.rbFrench.Size = new System.Drawing.Size(61, 19);
            this.rbFrench.TabIndex = 0;
            this.rbFrench.Text = "French";
            this.rbFrench.UseVisualStyleBackColor = true;
            // 
            // rbPersian
            // 
            this.rbPersian.AutoSize = true;
            this.rbPersian.Location = new System.Drawing.Point(112, 39);
            this.rbPersian.Name = "rbPersian";
            this.rbPersian.Size = new System.Drawing.Size(63, 19);
            this.rbPersian.TabIndex = 0;
            this.rbPersian.Text = "Persian";
            this.rbPersian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Checked = true;
            this.rbEnglish.Location = new System.Drawing.Point(25, 39);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(63, 19);
            this.rbEnglish.TabIndex = 0;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 271);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.gbWordTypes);
            this.Controls.Add(this.btStart);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmMain_KeyPress);
            this.gbWordTypes.ResumeLayout(false);
            this.gbWordTypes.PerformLayout();
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox gbWordTypes;
        private System.Windows.Forms.RadioButton rbText;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbAdvance;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.RadioButton rbFrench;
        private System.Windows.Forms.RadioButton rbPersian;
        private System.Windows.Forms.RadioButton rbEnglish;
    }
}