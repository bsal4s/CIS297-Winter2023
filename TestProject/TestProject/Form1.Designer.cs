namespace TestProject
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
            label1 = new Label();
            button1 = new Button();
            departmentTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numberTextBox = new TextBox();
            label4 = new Label();
            nameTextBox = new TextBox();
            addCourseButton = new Button();
            courseListBox = new ListBox();
            updateCourseButton = new Button();
            textBox1 = new TextBox();
            courseFilter = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 90);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(213, 39);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(507, 145);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(219, 27);
            departmentTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 149);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 3;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 199);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 5;
            label3.Text = "Number";
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(507, 195);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(219, 27);
            numberTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 255);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(507, 251);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(219, 27);
            nameTextBox.TabIndex = 6;
            // 
            // addCourseButton
            // 
            addCourseButton.Location = new Point(507, 317);
            addCourseButton.Name = "addCourseButton";
            addCourseButton.Size = new Size(94, 29);
            addCourseButton.TabIndex = 8;
            addCourseButton.Text = "Add Course";
            addCourseButton.UseVisualStyleBackColor = true;
            addCourseButton.Click += addCourseButton_Click;
            // 
            // courseListBox
            // 
            courseListBox.FormattingEnabled = true;
            courseListBox.ItemHeight = 20;
            courseListBox.Location = new Point(62, 191);
            courseListBox.Name = "courseListBox";
            courseListBox.Size = new Size(324, 104);
            courseListBox.TabIndex = 9;
            courseListBox.SelectedIndexChanged += courseListBox_SelectedIndexChanged;
            // 
            // updateCourseButton
            // 
            updateCourseButton.Location = new Point(607, 317);
            updateCourseButton.Name = "updateCourseButton";
            updateCourseButton.Size = new Size(126, 29);
            updateCourseButton.TabIndex = 10;
            updateCourseButton.Text = "Update Course";
            updateCourseButton.UseVisualStyleBackColor = true;
            updateCourseButton.Click += updateCourseButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // courseFilter
            // 
            courseFilter.Location = new Point(62, 158);
            courseFilter.Name = "courseFilter";
            courseFilter.Size = new Size(125, 27);
            courseFilter.TabIndex = 12;
            courseFilter.TextChanged += courseFilter_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(courseFilter);
            Controls.Add(textBox1);
            Controls.Add(updateCourseButton);
            Controls.Add(courseListBox);
            Controls.Add(addCourseButton);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(numberTextBox);
            Controls.Add(label2);
            Controls.Add(departmentTextBox);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox departmentTextBox;
        private Label label2;
        private Label label3;
        private TextBox numberTextBox;
        private Label label4;
        private TextBox nameTextBox;
        private Button addCourseButton;
        private ListBox courseListBox;
        private Button updateCourseButton;
        private TextBox textBox1;
        private TextBox courseFilter;
    }
}