
namespace Yahtzee
{
    public class Dice
    {
        public event Action? Rolled;

        public int Die1 { get; private set; }
        public int Die2 { get; private set; }
        public int Die3 { get; private set; }
        public int Die4 { get; private set; }
        public int Die5 { get; private set; }

        private IRandom random;

        public int NumberOfRollsLeft { get; private set; }

        public bool HoldDie1 { get; set; }
        public bool HoldDie2 { get; set; }
        public bool HoldDie3 { get; set; }
        public bool HoldDie4 { get; set; }
        public bool HoldDie5 { get; set; }

        public Dice(IRandom random)
        {
            this.random = random;

            Die1 = random.Next(1, 7);
            Die2 = random.Next(1, 7);
            Die3 = random.Next(1, 7);
            Die4 = random.Next(1, 7);
            Die5 = random.Next(1, 7);

            NumberOfRollsLeft = 2;

            HoldDie1 = false;
            HoldDie2 = false;
            HoldDie3 = false;
            HoldDie4 = false;
            HoldDie5 = false;

            
        }

        public void roll()
        {
            if (NumberOfRollsLeft > 0)
            {
                NumberOfRollsLeft--;
                if (!HoldDie1)
                {
                    Die1 = random.Next(1, 7);
                }
                if (!HoldDie2)
                {
                    Die2 = random.Next(1, 7);
                }
                if (!HoldDie3)
                {
                    Die3 = random.Next(1, 7);
                }
                if (!HoldDie4)
                {
                    Die4 = random.Next(1, 7);
                }
                if (!HoldDie5)
                {
                    Die5 = random.Next(1, 7);
                }
            }

            Rolled?.Invoke();
        }
    }
}
