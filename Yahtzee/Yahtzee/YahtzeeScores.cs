
namespace Yahtzee
{

    // using chat gpt prompt "write a C# class that represents a yahtzee scorecard, have it accept a set of dice and show all possible scores for the given dice"
    // follow up "can you write it without using linq?"
    public class YahtzeeScores
    {
        private int[] dice;

        public YahtzeeScores(Dice yahtzeeDice)
        {
            dice = new int[]{  yahtzeeDice.Die1, yahtzeeDice.Die2,
             yahtzeeDice.Die3, yahtzeeDice.Die4, yahtzeeDice.Die5};
        }

        public int OnesScore()
        {
            return CountScore(1);
        }

        public int TwosScore()
        {
            return CountScore(2);
        }
        public int ThreesScore()
        {
            return CountScore(3);
        }
        public int FoursScore()
        {
            return CountScore(4);
        }
        public int FivesScore()
        {
            return CountScore(5);
        }
        public int SixesScore()
        {
            return CountScore(6);
        }

        private int CountScore(int number)
        {
            int score = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == number)
                    score += number;
            }
            return score;
        }

        public int ThreeOfAKind()
        {
            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == i)
                        count++;
                }
                if (count >= 3)
                    return SumDice();
            }
            return 0;
        }

        public int FourOfAKind()
        {
            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == i)
                        count++;
                }
                if (count >= 4)
                    return SumDice();
            }
            return 0;
        }

        public int FullHouse()
        {
            bool threeOfAKind = false;
            bool twoOfAKind = false;
            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == i)
                        count++;
                }
                if (count == 2)
                    twoOfAKind = true;
                if (count == 3)
                    threeOfAKind = true;
            }
            if (twoOfAKind && threeOfAKind)
                return 25;
            return 0;
        }

        public int SmallStraight()
        {
            return HasStraight(4) ? 30 : 0;
        }

        public int LargeStraight()
        {
            return HasStraight(5) ? 40 : 0;
        }



        private bool HasStraight(int length)
        {
            int count = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (dice.Contains(i))
                {
                    count++;
                    if (count >= length)
                        return true;
                }
                else
                    count = 0;
            }
            return false;
        }

        public int Yahtzee()
        {
            for (int i = 1; i <= 6; i++)
            {
                int count = 0;
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == i)
                        count++;
                }
                if (count == 5)
                    return 50;
            }
            return 0;
        }

        public int Chance()
        {
            return SumDice();
        }

        private int SumDice()
        {
            int sum = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                sum += dice[i];
            }
            return sum;
        }
    }
}
