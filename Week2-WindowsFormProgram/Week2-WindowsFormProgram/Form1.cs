namespace Week2_WindowsFormProgram
{
    public partial class Form1 : Form
    {
        // from https://github.com/EricCharnesky/CIS297-Winter2023/blob/main/Week2-TaxEstimator/Week2-TaxEstimator/Program.cs
        const int STANDARD_DEDUCTION_SINGLE = 12_950;
        const int START_OF_10_PERCENT_BRACKET_SINGLE = 0;
        const int START_OF_12_PERCENT_BRACKET_SINGLE = 10_275;
        const int START_OF_22_PERCENT_BRACKET_SINGLE = 41_775;
        const int START_OF_24_PERCENT_BRACKET_SINGLE = 89_075;
        const int START_OF_32_PERCENT_BRACKET_SINGLE = 170_050;
        const int START_OF_35_PERCENT_BRACKET_SINGLE = 215_950;
        const int START_OF_37_PERCENT_BRACKET_SINGLE = 539_900;

        const int STANDARD_DEDUCTION_MARRIED = 25_900;
        const int START_OF_10_PERCENT_BRACKET_MARRIED = 0;
        const int START_OF_12_PERCENT_BRACKET_MARRIED = 20_550;
        const int START_OF_22_PERCENT_BRACKET_MARRIED = 83_550;
        const int START_OF_24_PERCENT_BRACKET_MARRIED = 178_150;
        const int START_OF_32_PERCENT_BRACKET_MARRIED = 340_100;
        const int START_OF_35_PERCENT_BRACKET_MARRIED = 431_900;
        const int START_OF_37_PERCENT_BRACKET_MARRIED = 647_850;

        private int grossIncome;
        private int totalDeductions;

        public Form1()
        {
            InitializeComponent();
            grossIncome = 0;
            totalDeductions = 0;
            caluclateTax();
        }

        private void caluclateTax()
        {
            int claimedDeductcions = totalDeductions;
            if ( singleRaidoButton.Checked)
            {
                if (claimedDeductcions < STANDARD_DEDUCTION_SINGLE)
                {
                    claimedDeductcions = STANDARD_DEDUCTION_SINGLE;
                }
            }
            else
            {
                if (claimedDeductcions < STANDARD_DEDUCTION_MARRIED)
                {
                    claimedDeductcions = STANDARD_DEDUCTION_MARRIED;
                }
            }
            

            int adjustedGrossIncome = grossIncome - claimedDeductcions;
            if ( adjustedGrossIncome < 0)
            {
                adjustedGrossIncome = 0;
            }

            taxInfoLabel.Text = $"Your adjusted gross income is {adjustedGrossIncome}";

            double taxesOwedAt10Percent;
            double taxesOwedAt12Percent;
            double taxesOwedAt22Percent;
            double taxesOwedAt24Percent;
            double taxesOwedAt32Percent;
            double taxesOwedAt35Percent;
            double taxesOwedAt37Percent;


            if (singleRaidoButton.Checked)
            {
                 taxesOwedAt10Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_10_PERCENT_BRACKET_SINGLE, START_OF_12_PERCENT_BRACKET_SINGLE, .1);
                 taxesOwedAt12Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_12_PERCENT_BRACKET_SINGLE, START_OF_22_PERCENT_BRACKET_SINGLE, .12);
                 taxesOwedAt22Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_22_PERCENT_BRACKET_SINGLE, START_OF_24_PERCENT_BRACKET_SINGLE, .22);
                 taxesOwedAt24Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_24_PERCENT_BRACKET_SINGLE, START_OF_32_PERCENT_BRACKET_SINGLE, .24);
                 taxesOwedAt32Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_32_PERCENT_BRACKET_SINGLE, START_OF_35_PERCENT_BRACKET_SINGLE, .32);
                 taxesOwedAt35Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_35_PERCENT_BRACKET_SINGLE, START_OF_37_PERCENT_BRACKET_SINGLE, .35);
                 taxesOwedAt37Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_37_PERCENT_BRACKET_SINGLE, int.MaxValue, .37);
            }
            else
            {
                 taxesOwedAt10Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_10_PERCENT_BRACKET_MARRIED, START_OF_12_PERCENT_BRACKET_MARRIED, .1);
                 taxesOwedAt12Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_12_PERCENT_BRACKET_MARRIED, START_OF_22_PERCENT_BRACKET_MARRIED, .12);
                 taxesOwedAt22Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_22_PERCENT_BRACKET_MARRIED, START_OF_24_PERCENT_BRACKET_MARRIED, .22);
                 taxesOwedAt24Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_24_PERCENT_BRACKET_MARRIED, START_OF_32_PERCENT_BRACKET_MARRIED, .24);
                 taxesOwedAt32Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_32_PERCENT_BRACKET_MARRIED, START_OF_35_PERCENT_BRACKET_MARRIED, .32);
                 taxesOwedAt35Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_35_PERCENT_BRACKET_MARRIED, START_OF_37_PERCENT_BRACKET_MARRIED, .35);
                 taxesOwedAt37Percent = getTaxesAtBracket(adjustedGrossIncome, START_OF_37_PERCENT_BRACKET_MARRIED, int.MaxValue, .37);

            }

            taxInfoLabel.Text += $"\nTaxes at 10% : ${taxesOwedAt10Percent}";
            taxInfoLabel.Text += $"\nTaxes at 12% : ${taxesOwedAt12Percent}";
            taxInfoLabel.Text += $"\nTaxes at 22% : ${taxesOwedAt22Percent}";
            taxInfoLabel.Text += $"\nTaxes at 24% : ${taxesOwedAt24Percent}";
            taxInfoLabel.Text += $"\nTaxes at 32% : ${taxesOwedAt32Percent}";
            taxInfoLabel.Text += $"\nTaxes at 35% : ${taxesOwedAt35Percent}";
            taxInfoLabel.Text += $"\nTaxes at 37% : ${taxesOwedAt37Percent}";

            double totalTaxesOwed = taxesOwedAt10Percent +
                taxesOwedAt12Percent +
                taxesOwedAt22Percent +
                taxesOwedAt24Percent +
                taxesOwedAt32Percent +
                taxesOwedAt35Percent +
                taxesOwedAt37Percent;

            taxInfoLabel.Text += $"\nTotal taxes owed: ${totalTaxesOwed}";
            taxInfoLabel.Text += $"\nTaxes owed as % of gross income: ${totalTaxesOwed / grossIncome * 100}";
            taxInfoLabel.Text += $"\nTaxes owed as % of adjusted gross income: ${totalTaxesOwed / adjustedGrossIncome * 100}";
        }

        static double getTaxesAtBracket(int income, int startOfBracket, int endOfBracket, double taxRate)
        {
            if (income > endOfBracket)
            {
                return (endOfBracket - startOfBracket) * taxRate;
            }
            else if (income < startOfBracket)
            {
                return 0;
            }
            else
            {
                return (income - startOfBracket) * taxRate;
            }
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            grossIncome += Convert.ToInt32(incomeTextBox.Text);
            incomeTextBox.Text = string.Empty; // same as "" 
            incomeLabel.Text = $"Gross Income: ${grossIncome}";
            caluclateTax();
        }

        private void deductionButton_Click(object sender, EventArgs e)
        {
            totalDeductions += Convert.ToInt32(deductionTextBox.Text);
            deductionTextBox.Text = string.Empty; // same as "" 
            dedutionsLabel.Text = $"Total Deductions: ${totalDeductions}";
            caluclateTax();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            caluclateTax();

            // from https://github.com/EricCharnesky/CIS297-Winter2023/blob/main/Week2-TaxEstimator/Week2-TaxEstimator/Program.cs
        }
    }
}