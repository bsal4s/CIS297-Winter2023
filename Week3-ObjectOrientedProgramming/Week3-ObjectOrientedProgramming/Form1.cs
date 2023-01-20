namespace Week3_ObjectOrientedProgramming
{
    public partial class Form1 : Form
    {
        Cup cup;
        Cup cup2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cup cup;
            //cup = new Cup();

            cup = new Cup("glass");
            cup2 = makeCoffee();

            // property with a public set can be changed
            cup.Contents = "tea";

            cup2.drink(5);

            dislayCup(cup2);

            drinkCoffeeButton.Enabled = true;
        }

        private Cup makeCoffee()
        {
            return new Cup("wood", "coffee", 250);
        }

        private void dislayCup(Cup cup2)
        {
            label1.Text = $"Cup color: {cup2.Color} " +
                $"- Cup Contents: {cup2.Contents}" +
                $"- Volume: {cup2.getVolumeInMilliliters()}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cup2.drink(Convert.ToInt32(drinkVolumeTextBox.Text)))
            {
                drinkVolumeTextBox.Text = "";
                dislayCup(cup2);
            }
            else
            {
                dislayCup(cup2);
                label1.Text += "\nYou can't drink that much...";
            }
            Rectangle smallRectangle = new Rectangle();
            smallRectangle.Length = 10;
            smallRectangle.Width = 5;
            label1.Text += $"\n Area of a rectangle is {smallRectangle.Area}";
            label1.Text += $"\n Area of a rectangle is {smallRectangle.getArea()}";
        }
    }
}