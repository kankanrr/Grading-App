
namespace FinalF21
{
    partial class FormFinalF21
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBonus = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPresentationScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAppScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonAverage = new System.Windows.Forms.Button();
            this.listBoxBonus = new System.Windows.Forms.ListBox();
            this.listBoxPresScore = new System.Windows.Forms.ListBox();
            this.listBoxAppScore = new System.Windows.Forms.ListBox();
            this.listBoxProjectGrade = new System.Windows.Forms.ListBox();
            this.listBoxProjectScore = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxBonus);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxPresentationScore);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAppScore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 293);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Score";
            // 
            // checkBoxBonus
            // 
            this.checkBoxBonus.AutoSize = true;
            this.checkBoxBonus.Location = new System.Drawing.Point(20, 160);
            this.checkBoxBonus.Name = "checkBoxBonus";
            this.checkBoxBonus.Size = new System.Drawing.Size(138, 24);
            this.checkBoxBonus.TabIndex = 3;
            this.checkBoxBonus.Text = "Bonus Applied";
            this.checkBoxBonus.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(20, 217);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(224, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "&Add Project";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPresentationScore
            // 
            this.textBoxPresentationScore.Location = new System.Drawing.Point(189, 95);
            this.textBoxPresentationScore.Name = "textBoxPresentationScore";
            this.textBoxPresentationScore.Size = new System.Drawing.Size(55, 26);
            this.textBoxPresentationScore.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Presentation Score";
            // 
            // textBoxAppScore
            // 
            this.textBoxAppScore.Location = new System.Drawing.Point(189, 40);
            this.textBoxAppScore.Name = "textBoxAppScore";
            this.textBoxAppScore.Size = new System.Drawing.Size(55, 26);
            this.textBoxAppScore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application Score";
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(706, 340);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(122, 38);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(539, 340);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(122, 38);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonAverage
            // 
            this.buttonAverage.Location = new System.Drawing.Point(328, 340);
            this.buttonAverage.Name = "buttonAverage";
            this.buttonAverage.Size = new System.Drawing.Size(166, 38);
            this.buttonAverage.TabIndex = 13;
            this.buttonAverage.Text = "&Get Average Score";
            this.buttonAverage.UseVisualStyleBackColor = true;
            this.buttonAverage.Click += new System.EventHandler(this.buttonAverage_Click);
            // 
            // listBoxBonus
            // 
            this.listBoxBonus.FormattingEnabled = true;
            this.listBoxBonus.ItemHeight = 20;
            this.listBoxBonus.Items.AddRange(new object[] {
            "Bonus",
            "********"});
            this.listBoxBonus.Location = new System.Drawing.Point(534, 27);
            this.listBoxBonus.Name = "listBoxBonus";
            this.listBoxBonus.Size = new System.Drawing.Size(64, 284);
            this.listBoxBonus.TabIndex = 20;
            this.listBoxBonus.TabStop = false;
            // 
            // listBoxPresScore
            // 
            this.listBoxPresScore.FormattingEnabled = true;
            this.listBoxPresScore.ItemHeight = 20;
            this.listBoxPresScore.Items.AddRange(new object[] {
            "Pres. Score",
            "***************"});
            this.listBoxPresScore.Location = new System.Drawing.Point(429, 27);
            this.listBoxPresScore.Name = "listBoxPresScore";
            this.listBoxPresScore.Size = new System.Drawing.Size(99, 284);
            this.listBoxPresScore.TabIndex = 19;
            this.listBoxPresScore.TabStop = false;
            // 
            // listBoxAppScore
            // 
            this.listBoxAppScore.FormattingEnabled = true;
            this.listBoxAppScore.ItemHeight = 20;
            this.listBoxAppScore.Items.AddRange(new object[] {
            "App Score",
            "**************"});
            this.listBoxAppScore.Location = new System.Drawing.Point(328, 27);
            this.listBoxAppScore.Name = "listBoxAppScore";
            this.listBoxAppScore.Size = new System.Drawing.Size(99, 284);
            this.listBoxAppScore.TabIndex = 18;
            this.listBoxAppScore.TabStop = false;
            // 
            // listBoxProjectGrade
            // 
            this.listBoxProjectGrade.FormattingEnabled = true;
            this.listBoxProjectGrade.ItemHeight = 20;
            this.listBoxProjectGrade.Items.AddRange(new object[] {
            "Project Grade",
            "***************"});
            this.listBoxProjectGrade.Location = new System.Drawing.Point(719, 27);
            this.listBoxProjectGrade.Name = "listBoxProjectGrade";
            this.listBoxProjectGrade.Size = new System.Drawing.Size(109, 284);
            this.listBoxProjectGrade.TabIndex = 17;
            this.listBoxProjectGrade.TabStop = false;
            // 
            // listBoxProjectScore
            // 
            this.listBoxProjectScore.FormattingEnabled = true;
            this.listBoxProjectScore.ItemHeight = 20;
            this.listBoxProjectScore.Items.AddRange(new object[] {
            "Project Score",
            "****************"});
            this.listBoxProjectScore.Location = new System.Drawing.Point(604, 27);
            this.listBoxProjectScore.Name = "listBoxProjectScore";
            this.listBoxProjectScore.Size = new System.Drawing.Size(109, 284);
            this.listBoxProjectScore.TabIndex = 16;
            this.listBoxProjectScore.TabStop = false;
            // 
            // FormFinalF21
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(866, 437);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxBonus);
            this.Controls.Add(this.listBoxPresScore);
            this.Controls.Add(this.listBoxAppScore);
            this.Controls.Add(this.listBoxProjectGrade);
            this.Controls.Add(this.listBoxProjectScore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAverage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormFinalF21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grading App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBonus;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPresentationScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAppScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAverage;
        private System.Windows.Forms.ListBox listBoxBonus;
        private System.Windows.Forms.ListBox listBoxPresScore;
        private System.Windows.Forms.ListBox listBoxAppScore;
        private System.Windows.Forms.ListBox listBoxProjectGrade;
        private System.Windows.Forms.ListBox listBoxProjectScore;
    }
}

