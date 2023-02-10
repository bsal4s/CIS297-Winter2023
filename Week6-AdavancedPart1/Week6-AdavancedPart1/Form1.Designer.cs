namespace Week6_AdavancedPart1
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.yearTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(304, 157);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(125, 27);
            this.numberTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Double with try parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(399, 258);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(50, 20);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Double with exception handling";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(455, 363);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(50, 20);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "US",
            "EU",
            "ISO"});
            this.comboBox1.Location = new System.Drawing.Point(416, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // yearTrackBar
            // 
            this.yearTrackBar.Location = new System.Drawing.Point(41, 40);
            this.yearTrackBar.Maximum = 3000;
            this.yearTrackBar.Name = "yearTrackBar";
            this.yearTrackBar.Size = new System.Drawing.Size(698, 56);
            this.yearTrackBar.TabIndex = 6;
            this.yearTrackBar.Scroll += new System.EventHandler(this.yearTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearTrackBar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yearTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox numberTextBox;
        private Button button1;
        private Label numberLabel;
        private Button button2;
        private Label dateLabel;
        private ComboBox comboBox1;
        private TrackBar yearTrackBar;
    }
}