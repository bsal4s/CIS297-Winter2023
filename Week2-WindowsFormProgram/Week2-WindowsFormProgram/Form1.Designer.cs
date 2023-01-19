namespace Week2_WindowsFormProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickMeButton = new System.Windows.Forms.Button();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deductionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dedutionsLabel = new System.Windows.Forms.Label();
            this.deductionButton = new System.Windows.Forms.Button();
            this.singleRaidoButton = new System.Windows.Forms.RadioButton();
            this.marriedRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taxInfoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clickMeButton
            // 
            this.clickMeButton.Location = new System.Drawing.Point(386, 33);
            this.clickMeButton.Name = "clickMeButton";
            this.clickMeButton.Size = new System.Drawing.Size(122, 29);
            this.clickMeButton.TabIndex = 0;
            this.clickMeButton.Text = "Add Income";
            this.clickMeButton.UseVisualStyleBackColor = true;
            this.clickMeButton.Click += new System.EventHandler(this.clickMeButton_Click);
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(32, 107);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(0, 20);
            this.incomeLabel.TabIndex = 1;
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(246, 34);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(125, 27);
            this.incomeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter a W2 Total Income";
            // 
            // deductionTextBox
            // 
            this.deductionTextBox.Location = new System.Drawing.Point(246, 67);
            this.deductionTextBox.Name = "deductionTextBox";
            this.deductionTextBox.Size = new System.Drawing.Size(125, 27);
            this.deductionTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter some deductions";
            // 
            // dedutionsLabel
            // 
            this.dedutionsLabel.AutoSize = true;
            this.dedutionsLabel.Location = new System.Drawing.Point(32, 155);
            this.dedutionsLabel.Name = "dedutionsLabel";
            this.dedutionsLabel.Size = new System.Drawing.Size(0, 20);
            this.dedutionsLabel.TabIndex = 6;
            // 
            // deductionButton
            // 
            this.deductionButton.Location = new System.Drawing.Point(386, 68);
            this.deductionButton.Name = "deductionButton";
            this.deductionButton.Size = new System.Drawing.Size(94, 29);
            this.deductionButton.TabIndex = 7;
            this.deductionButton.Text = "Deduct Me!";
            this.deductionButton.UseVisualStyleBackColor = true;
            this.deductionButton.Click += new System.EventHandler(this.deductionButton_Click);
            // 
            // singleRaidoButton
            // 
            this.singleRaidoButton.AutoSize = true;
            this.singleRaidoButton.Checked = true;
            this.singleRaidoButton.Location = new System.Drawing.Point(38, 37);
            this.singleRaidoButton.Name = "singleRaidoButton";
            this.singleRaidoButton.Size = new System.Drawing.Size(71, 24);
            this.singleRaidoButton.TabIndex = 8;
            this.singleRaidoButton.TabStop = true;
            this.singleRaidoButton.Text = "Single";
            this.singleRaidoButton.UseVisualStyleBackColor = true;
            this.singleRaidoButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // marriedRadioButton
            // 
            this.marriedRadioButton.AutoSize = true;
            this.marriedRadioButton.Location = new System.Drawing.Point(38, 67);
            this.marriedRadioButton.Name = "marriedRadioButton";
            this.marriedRadioButton.Size = new System.Drawing.Size(82, 24);
            this.marriedRadioButton.TabIndex = 9;
            this.marriedRadioButton.Text = "Married";
            this.marriedRadioButton.UseVisualStyleBackColor = true;
            this.marriedRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.singleRaidoButton);
            this.groupBox1.Controls.Add(this.marriedRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(32, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 125);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filing Status";
            // 
            // taxInfoLabel
            // 
            this.taxInfoLabel.AutoSize = true;
            this.taxInfoLabel.Location = new System.Drawing.Point(413, 175);
            this.taxInfoLabel.Name = "taxInfoLabel";
            this.taxInfoLabel.Size = new System.Drawing.Size(0, 20);
            this.taxInfoLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taxInfoLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deductionButton);
            this.Controls.Add(this.dedutionsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deductionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.incomeLabel);
            this.Controls.Add(this.clickMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clickMeButton;
        private Label incomeLabel;
        private TextBox incomeTextBox;
        private Label label1;
        private TextBox deductionTextBox;
        private Label label2;
        private Label dedutionsLabel;
        private Button deductionButton;
        private RadioButton singleRaidoButton;
        private RadioButton marriedRadioButton;
        private GroupBox groupBox1;
        private Label taxInfoLabel;
    }
}