namespace Week2_WindowsFormProgram
{
    public partial class Form1 : Form
    {

        private int grossIncome;
        private int totalDeductions;

        public Form1()
        {
            InitializeComponent();
            grossIncome = 0;
            totalDeductions = 0;
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            grossIncome += Convert.ToInt32(nameTextBox.Text);
            nameTextBox.Text = string.Empty; // same as "" 
            label.Text = $"Gross Income: ${grossIncome}";
        }

        private void deductionButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dedutionsLabel.Text = "Radio button 1";
            }
            else if (radioButton2.Checked)
            {
                dedutionsLabel.Text = "Radio button 2";
            }
            else
            {
                dedutionsLabel.Text = "Radio button 3";
            }

            // from https://github.com/EricCharnesky/CIS297-Winter2023/blob/main/Week2-TaxEstimator/Week2-TaxEstimator/Program.cs
        }
    }
}