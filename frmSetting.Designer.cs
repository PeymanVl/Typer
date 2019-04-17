using System.ComponentModel;
using System.Windows.Forms;

namespace Typer
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.cbTextType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGeneralLanguage = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdtGerman = new System.Windows.Forms.RadioButton();
            this.rdtFrench = new System.Windows.Forms.RadioButton();
            this.rdtPersian = new System.Windows.Forms.RadioButton();
            this.rdtEnglish = new System.Windows.Forms.RadioButton();
            this.gbProgrammingLanguage = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdtCSS = new System.Windows.Forms.RadioButton();
            this.rdtHtml = new System.Windows.Forms.RadioButton();
            this.rdtVB = new System.Windows.Forms.RadioButton();
            this.rdtJava = new System.Windows.Forms.RadioButton();
            this.rdtCSharp = new System.Windows.Forms.RadioButton();
            this.gbCombinatorial = new System.Windows.Forms.GroupBox();
            this.cbtFunctionKey = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdtRandom = new System.Windows.Forms.RadioButton();
            this.rdtShortcuts = new System.Windows.Forms.RadioButton();
            this.btSSaveFile = new System.Windows.Forms.Button();
            this.btSaveOne = new System.Windows.Forms.Button();
            this.btSDefault = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btReadSetting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbOtherSetting = new System.Windows.Forms.GroupBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.rdArangebyParagraph = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rdArangebyWords = new System.Windows.Forms.RadioButton();
            this.cbJustlittleWords = new System.Windows.Forms.CheckBox();
            this.gbGeneralLanguage.SuspendLayout();
            this.gbProgrammingLanguage.SuspendLayout();
            this.gbCombinatorial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbOtherSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTextType
            // 
            resources.ApplyResources(this.cbTextType, "cbTextType");
            this.cbTextType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTextType.FormattingEnabled = true;
            this.cbTextType.Items.AddRange(new object[] {
            resources.GetString("cbTextType.Items"),
            resources.GetString("cbTextType.Items1"),
            resources.GetString("cbTextType.Items2"),
            resources.GetString("cbTextType.Items3"),
            resources.GetString("cbTextType.Items4"),
            resources.GetString("cbTextType.Items5")});
            this.cbTextType.Name = "cbTextType";
            this.cbTextType.SelectedIndexChanged += new System.EventHandler(this.cbTextType_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // gbGeneralLanguage
            // 
            resources.ApplyResources(this.gbGeneralLanguage, "gbGeneralLanguage");
            this.gbGeneralLanguage.Controls.Add(this.cbJustlittleWords);
            this.gbGeneralLanguage.Controls.Add(this.label2);
            this.gbGeneralLanguage.Controls.Add(this.rdtGerman);
            this.gbGeneralLanguage.Controls.Add(this.rdtFrench);
            this.gbGeneralLanguage.Controls.Add(this.rdtPersian);
            this.gbGeneralLanguage.Controls.Add(this.rdtEnglish);
            this.gbGeneralLanguage.Name = "gbGeneralLanguage";
            this.gbGeneralLanguage.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rdtGerman
            // 
            resources.ApplyResources(this.rdtGerman, "rdtGerman");
            this.rdtGerman.Name = "rdtGerman";
            this.rdtGerman.Tag = "0";
            this.rdtGerman.UseVisualStyleBackColor = true;
            // 
            // rdtFrench
            // 
            resources.ApplyResources(this.rdtFrench, "rdtFrench");
            this.rdtFrench.Name = "rdtFrench";
            this.rdtFrench.Tag = "0";
            this.rdtFrench.UseVisualStyleBackColor = true;
            // 
            // rdtPersian
            // 
            resources.ApplyResources(this.rdtPersian, "rdtPersian");
            this.rdtPersian.Name = "rdtPersian";
            this.rdtPersian.Tag = "0";
            this.rdtPersian.UseVisualStyleBackColor = true;
            // 
            // rdtEnglish
            // 
            resources.ApplyResources(this.rdtEnglish, "rdtEnglish");
            this.rdtEnglish.Checked = true;
            this.rdtEnglish.Name = "rdtEnglish";
            this.rdtEnglish.TabStop = true;
            this.rdtEnglish.Tag = "0";
            this.rdtEnglish.UseVisualStyleBackColor = true;
            // 
            // gbProgrammingLanguage
            // 
            resources.ApplyResources(this.gbProgrammingLanguage, "gbProgrammingLanguage");
            this.gbProgrammingLanguage.Controls.Add(this.label4);
            this.gbProgrammingLanguage.Controls.Add(this.rdtCSS);
            this.gbProgrammingLanguage.Controls.Add(this.rdtHtml);
            this.gbProgrammingLanguage.Controls.Add(this.rdtVB);
            this.gbProgrammingLanguage.Controls.Add(this.rdtJava);
            this.gbProgrammingLanguage.Controls.Add(this.rdtCSharp);
            this.gbProgrammingLanguage.Name = "gbProgrammingLanguage";
            this.gbProgrammingLanguage.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // rdtCSS
            // 
            resources.ApplyResources(this.rdtCSS, "rdtCSS");
            this.rdtCSS.Name = "rdtCSS";
            this.rdtCSS.Tag = "0";
            this.rdtCSS.UseVisualStyleBackColor = true;
            // 
            // rdtHtml
            // 
            resources.ApplyResources(this.rdtHtml, "rdtHtml");
            this.rdtHtml.Name = "rdtHtml";
            this.rdtHtml.Tag = "0";
            this.rdtHtml.UseVisualStyleBackColor = true;
            // 
            // rdtVB
            // 
            resources.ApplyResources(this.rdtVB, "rdtVB");
            this.rdtVB.Name = "rdtVB";
            this.rdtVB.Tag = "0";
            this.rdtVB.UseVisualStyleBackColor = true;
            // 
            // rdtJava
            // 
            resources.ApplyResources(this.rdtJava, "rdtJava");
            this.rdtJava.Name = "rdtJava";
            this.rdtJava.Tag = "0";
            this.rdtJava.UseVisualStyleBackColor = true;
            // 
            // rdtCSharp
            // 
            resources.ApplyResources(this.rdtCSharp, "rdtCSharp");
            this.rdtCSharp.Name = "rdtCSharp";
            this.rdtCSharp.Tag = "0";
            this.rdtCSharp.UseVisualStyleBackColor = true;
            // 
            // gbCombinatorial
            // 
            resources.ApplyResources(this.gbCombinatorial, "gbCombinatorial");
            this.gbCombinatorial.Controls.Add(this.cbtFunctionKey);
            this.gbCombinatorial.Controls.Add(this.label6);
            this.gbCombinatorial.Controls.Add(this.rdtRandom);
            this.gbCombinatorial.Controls.Add(this.rdtShortcuts);
            this.gbCombinatorial.Name = "gbCombinatorial";
            this.gbCombinatorial.TabStop = false;
            // 
            // cbtFunctionKey
            // 
            resources.ApplyResources(this.cbtFunctionKey, "cbtFunctionKey");
            this.cbtFunctionKey.Name = "cbtFunctionKey";
            this.cbtFunctionKey.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // rdtRandom
            // 
            resources.ApplyResources(this.rdtRandom, "rdtRandom");
            this.rdtRandom.Name = "rdtRandom";
            this.rdtRandom.Tag = "0";
            this.rdtRandom.UseVisualStyleBackColor = true;
            // 
            // rdtShortcuts
            // 
            resources.ApplyResources(this.rdtShortcuts, "rdtShortcuts");
            this.rdtShortcuts.Name = "rdtShortcuts";
            this.rdtShortcuts.Tag = "0";
            this.rdtShortcuts.UseVisualStyleBackColor = true;
            // 
            // btSSaveFile
            // 
            resources.ApplyResources(this.btSSaveFile, "btSSaveFile");
            this.btSSaveFile.Name = "btSSaveFile";
            this.toolTip.SetToolTip(this.btSSaveFile, resources.GetString("btSSaveFile.ToolTip"));
            this.btSSaveFile.UseVisualStyleBackColor = true;
            // 
            // btSaveOne
            // 
            resources.ApplyResources(this.btSaveOne, "btSaveOne");
            this.btSaveOne.Name = "btSaveOne";
            this.toolTip.SetToolTip(this.btSaveOne, resources.GetString("btSaveOne.ToolTip"));
            this.btSaveOne.UseVisualStyleBackColor = true;
            // 
            // btSDefault
            // 
            resources.ApplyResources(this.btSDefault, "btSDefault");
            this.btSDefault.Name = "btSDefault";
            this.toolTip.SetToolTip(this.btSDefault, resources.GetString("btSDefault.ToolTip"));
            this.btSDefault.UseVisualStyleBackColor = true;
            this.btSDefault.Click += new System.EventHandler(this.btSDefault_Click);
            // 
            // btReadSetting
            // 
            resources.ApplyResources(this.btReadSetting, "btReadSetting");
            this.btReadSetting.Name = "btReadSetting";
            this.toolTip.SetToolTip(this.btReadSetting, resources.GetString("btReadSetting.ToolTip"));
            this.btReadSetting.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btReadSetting);
            this.groupBox1.Controls.Add(this.btSaveOne);
            this.groupBox1.Controls.Add(this.btSSaveFile);
            this.groupBox1.Controls.Add(this.btSDefault);
            this.groupBox1.Controls.Add(this.label7);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // gbOtherSetting
            // 
            this.gbOtherSetting.Controls.Add(this.txtTime);
            this.gbOtherSetting.Controls.Add(this.rdArangebyParagraph);
            this.gbOtherSetting.Controls.Add(this.label5);
            this.gbOtherSetting.Controls.Add(this.label3);
            this.gbOtherSetting.Controls.Add(this.rdArangebyWords);
            resources.ApplyResources(this.gbOtherSetting, "gbOtherSetting");
            this.gbOtherSetting.Name = "gbOtherSetting";
            this.gbOtherSetting.TabStop = false;
            // 
            // txtTime
            // 
            resources.ApplyResources(this.txtTime, "txtTime");
            this.txtTime.Name = "txtTime";
            this.txtTime.TextChanged += new System.EventHandler(this.txtTime_TextChanged);
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // rdArangebyParagraph
            // 
            resources.ApplyResources(this.rdArangebyParagraph, "rdArangebyParagraph");
            this.rdArangebyParagraph.Name = "rdArangebyParagraph";
            this.rdArangebyParagraph.Tag = "1";
            this.rdArangebyParagraph.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rdArangebyWords
            // 
            resources.ApplyResources(this.rdArangebyWords, "rdArangebyWords");
            this.rdArangebyWords.Checked = true;
            this.rdArangebyWords.Name = "rdArangebyWords";
            this.rdArangebyWords.TabStop = true;
            this.rdArangebyWords.Tag = "1";
            this.rdArangebyWords.UseVisualStyleBackColor = true;
            // 
            // cbJustlittleWords
            // 
            resources.ApplyResources(this.cbJustlittleWords, "cbJustlittleWords");
            this.cbJustlittleWords.Checked = true;
            this.cbJustlittleWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJustlittleWords.Name = "cbJustlittleWords";
            this.cbJustlittleWords.UseVisualStyleBackColor = true;
            // 
            // FrmSetting
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOtherSetting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbCombinatorial);
            this.Controls.Add(this.gbProgrammingLanguage);
            this.Controls.Add(this.gbGeneralLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTextType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSetting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.gbGeneralLanguage.ResumeLayout(false);
            this.gbGeneralLanguage.PerformLayout();
            this.gbProgrammingLanguage.ResumeLayout(false);
            this.gbProgrammingLanguage.PerformLayout();
            this.gbCombinatorial.ResumeLayout(false);
            this.gbCombinatorial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbOtherSetting.ResumeLayout(false);
            this.gbOtherSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTextType;
        private Label label1;
        private GroupBox gbGeneralLanguage;
        private RadioButton rdtGerman;
        private RadioButton rdtFrench;
        private RadioButton rdtPersian;
        private RadioButton rdtEnglish;
        private Label label2;
        private GroupBox gbProgrammingLanguage;
        private Label label4;
        private RadioButton rdtCSS;
        private RadioButton rdtHtml;
        private RadioButton rdtVB;
        private RadioButton rdtJava;
        private RadioButton rdtCSharp;
        private GroupBox gbCombinatorial;
        private CheckBox cbtFunctionKey;
        private Label label6;
        private RadioButton rdtRandom;
        private RadioButton rdtShortcuts;
        private Button btSSaveFile;
        private ToolTip toolTip;
        private Button btSaveOne;
        private Button btSDefault;
        private GroupBox groupBox1;
        private Button btReadSetting;
        private Label label7;
        private Label label8;
        private GroupBox gbOtherSetting;
        private TextBox txtTime;
        private RadioButton rdArangebyParagraph;
        private Label label5;
        private Label label3;
        private RadioButton rdArangebyWords;
        private CheckBox cbJustlittleWords;
    }
}