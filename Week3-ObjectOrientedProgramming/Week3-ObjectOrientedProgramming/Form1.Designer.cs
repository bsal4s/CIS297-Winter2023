namespace Week3_ObjectOrientedProgramming
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drinkCoffeeButton = new System.Windows.Forms.Button();
            this.drinkVolumeTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make Coffee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // drinkCoffeeButton
            // 
            this.drinkCoffeeButton.Enabled = false;
            this.drinkCoffeeButton.Location = new System.Drawing.Point(445, 125);
            this.drinkCoffeeButton.Name = "drinkCoffeeButton";
            this.drinkCoffeeButton.Size = new System.Drawing.Size(134, 29);
            this.drinkCoffeeButton.TabIndex = 2;
            this.drinkCoffeeButton.Text = "Drink Coffee";
            this.drinkCoffeeButton.UseVisualStyleBackColor = true;
            this.drinkCoffeeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // drinkVolumeTextBox
            // 
            this.drinkVolumeTextBox.Location = new System.Drawing.Point(463, 86);
            this.drinkVolumeTextBox.Name = "drinkVolumeTextBox";
            this.drinkVolumeTextBox.Size = new System.Drawing.Size(125, 27);
            this.drinkVolumeTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.drinkVolumeTextBox);
            this.Controls.Add(this.drinkCoffeeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Button drinkCoffeeButton;
        private TextBox drinkVolumeTextBox;
        private PictureBox pictureBox1;
    }
}