namespace Week4_MoreObjectOrientedStuff
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
            this.getCardButton = new System.Windows.Forms.Button();
            this.cardLabel = new System.Windows.Forms.Label();
            this.numericValueLabel = new System.Windows.Forms.Label();
            this.handLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getCardButton
            // 
            this.getCardButton.Location = new System.Drawing.Point(454, 136);
            this.getCardButton.Name = "getCardButton";
            this.getCardButton.Size = new System.Drawing.Size(94, 29);
            this.getCardButton.TabIndex = 0;
            this.getCardButton.Text = "Get a card";
            this.getCardButton.UseVisualStyleBackColor = true;
            this.getCardButton.Click += new System.EventHandler(this.getCardButton_Click);
            // 
            // cardLabel
            // 
            this.cardLabel.AutoSize = true;
            this.cardLabel.Location = new System.Drawing.Point(320, 265);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.Size = new System.Drawing.Size(47, 20);
            this.cardLabel.TabIndex = 1;
            this.cardLabel.Text = "Card: ";
            // 
            // numericValueLabel
            // 
            this.numericValueLabel.AutoSize = true;
            this.numericValueLabel.Location = new System.Drawing.Point(325, 201);
            this.numericValueLabel.Name = "numericValueLabel";
            this.numericValueLabel.Size = new System.Drawing.Size(50, 20);
            this.numericValueLabel.TabIndex = 2;
            this.numericValueLabel.Text = "label1";
            // 
            // handLabel
            // 
            this.handLabel.AutoSize = true;
            this.handLabel.Location = new System.Drawing.Point(621, 234);
            this.handLabel.Name = "handLabel";
            this.handLabel.Size = new System.Drawing.Size(50, 20);
            this.handLabel.TabIndex = 3;
            this.handLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.handLabel);
            this.Controls.Add(this.numericValueLabel);
            this.Controls.Add(this.cardLabel);
            this.Controls.Add(this.getCardButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getCardButton;
        private Label cardLabel;
        private Label numericValueLabel;
        private Label handLabel;
    }
}