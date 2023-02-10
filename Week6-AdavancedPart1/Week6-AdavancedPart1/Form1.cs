using System.Xml.Linq;

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

            sum(1);
            sum(1, 2, 3, 4);
            sum(1, 135, 146, 426, 357, 37373, 2, 37, 357, 3573, 134);

            string name = "Eric Charnesky";
            dateLabel.Text = name.Scramble();
            dateLabel.Text = Scramble(name);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ChangeArrayElements(numbers, Double);

            ChangeArrayElements(numbers, new AddOne());

        }

        // instead of overloading,
        // you can add default values to parameters
        //public void magicNumber()
        //{
        //    magicNumber(42);
        //}

        // thanks Players Guide!
        int AddOne(int number) => number + 1;
        int SubtractOne(int number) => number - 1;
        int Double(int number) => number * 2;

        public delegate int NumberDelegate(int number);

        int[] ChangeArrayElements(int[] numbers, Func<int, int> operation)
        {
            int[] result = new int[numbers.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                result[index] = operation(numbers[index]);
            }

            return result;
        }

        int[] ChangeArrayElements(int[] numbers, NumberDelegate operation)
        {
            int[] result = new int[numbers.Length];

            for ( int index = 0; index < numbers.Length; index++)
            {
                result[index] = operation(numbers[index]);
            }

            return result;
        }

        int[] ChangeArrayElements(int[] numbers, INumberOperation numberOperation)
        {
            int[] result = new int[numbers.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                result[index] = numberOperation.Operation(numbers[index]);
            }

            return result;
        }

        public int sum(params int[] numbers)
        {
            int total = 0;
            
            foreach ( int number in numbers)
            {
                total += number;
            }

            return total;
        }

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

        public string Scramble(string text)
        {
            char[] characters = text.ToCharArray();

            Random random = new Random();

            // from ChatGPT
            // prompt 
            // how do you randomize the elements in an array in c#
            for (int i = characters.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = characters[i];
                characters[i] = characters[j];
                characters[j] = temp;
            }


            return new string(characters);
        }
    }


    public static class ABC
    {
        public static string Scramble(this string text)
        {
            char[] characters = text.ToCharArray();

            Random random = new Random();

            // from ChatGPT
            // prompt 
            // how do you randomize the elements in an array in c#
            for (int i = characters.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = characters[i];
                characters[i] = characters[j];
                characters[j] = temp;
            }


            return new string( characters );
        }
    }

    class Rectangle
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            if ( width <= 0)
            {
                throw new ArgumentException("Invalid width, must be > 0");
            }
            if (height <= 0)
            {
                throw new ArgumentException("Invalid width, must be > 0");
            }

            Width = width;
            Height = height;
        }   
    }

    public interface INumberOperation
    {
        int Operation(int number);
    }

    public class AddOne : INumberOperation
    {
        public int Operation(int number)
        {
            return number + 1;
        }
    }

    public class SubtractOne : INumberOperation
    {
        public int Operation(int number)
        {
            return number - 1;
        }
    }

}