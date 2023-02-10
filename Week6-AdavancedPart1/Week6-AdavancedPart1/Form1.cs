namespace Week6_AdavancedPart1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int number;
            // passes number as reference, not by value
            changeNumber(25, out number);

            magicNumber();
            magicNumber(number);
            magicNumber(number, 27);

            // using named arguments
            magicNumber(anotherNumber: 27, number: 15);
            magicNumber(anotherNumber: 27);

        }

        // instead of overloading,
        // you can add default values to parameters
        //public void magicNumber()
        //{
        //    magicNumber(42);
        //}

        public void setDate(int day = 9, int month = 2, int year = 2023, String format = "US")
        {
            if ( format == "US")
            {
                dateLabel.Text = $"{month:D2}/{day:D2}/{year}";
            } else if ( format == "EU")
            {
                dateLabel.Text = $"{day:D2}/{month:D2}/{year}";
            } else
            {
                dateLabel.Text = $"{year}-{month:D2}-{day:D2}";
            }
        }

        public void magicNumber(int number = 42, int anotherNumber = 777)
        {
            numberLabel.Text = number.ToString();
        }

        public void changeNumber(int multiple, out int number)
        {
            number = multiple * 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int someNumber;
            
            if (int.TryParse(numberTextBox.Text, out someNumber))
            {
                someNumber *= 2;
                numberLabel.Text = someNumber.ToString();
            }
            else
            {
                numberLabel.Text = "invalid numeric input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int someNumber = Convert.ToInt32(numberTextBox.Text);
                someNumber *= 2;
                numberLabel.Text = someNumber.ToString();

            }
            catch(OverflowException ex)
            {
                numberLabel.Text = "invalid numeric input";
            }
            catch(FormatException ex) {
                numberLabel.Text = "invalid numeric input";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void yearTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void UpdateDate()
        {
            string format = comboBox1.Text;
            int year = yearTrackBar.Value;
            setDate(year: year, format: format);
        }
    }
}