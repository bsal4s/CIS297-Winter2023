
namespace Yahtzee
{
    public class Player
    {
        public int? OnesScore { get; private set; }
        public int? TwosScore { get; private set; }
        public int? ThreesScore { get; private set; }
        public int? FoursScore { get; private set; }
        public int? FivesScore { get; private set; }
        public int? SixesScore { get; private set; }

        public int? ThreeOfAKindScore { get; private set; }
        public int? FourOfAKindScore { get; private set; }
        public int? SmallStrightScore { get; private set; }
        public int? LargeStraightScore { get; private set; }
        public int? FullHouseScore { get; private set; }
        public int? YahtzeeScore { get; private set; }
        public int? ChanceScore { get; private set; }

        public Player()
        {
            OnesScore = null;
            TwosScore = null;
            ThreesScore = null;
            FoursScore = null;
            FivesScore= null;
            SixesScore = null;
            ThreeOfAKindScore = null;
            FourOfAKindScore = null;
            SmallStrightScore = null;
            LargeStraightScore = null;
            FullHouseScore = null;
            YahtzeeScore = null;
            ChanceScore = null;
        }

        public void SetOnesScore(int score)
        {
            if (OnesScore == null)
            {
                OnesScore = score;
            }
        }

        public void SetTwosScore(int score)
        {
            if (TwosScore == null)
            {
                TwosScore = score;
            }
        }

        public void SetThreesScore(int score)
        {
            if (ThreesScore == null)
            {
                ThreesScore = score;
            }
        }

        public void SetFoursScore(int score)
        {
            if (FoursScore == null)
            {
                FoursScore = score;
            }
        }

        public void SetFivesScore(int score)
        {
            if (FivesScore == null)
            {
                FivesScore = score;
            }
        }

        public void SetSixesScore(int score)
        {
            if (SixesScore == null)
            {
                SixesScore = score;
            }
        }

        public void SetThreeOfAKindScore(int score)
        {
            if (ThreeOfAKindScore == null)
            {
                ThreeOfAKindScore = score;
            }
        }

        public void SetFourOfAKindScoreScore(int score)
        {
            if (FourOfAKindScore == null)
            {
                FourOfAKindScore = score;
            }
        }

        public void SetSmallStraightScore(int score)
        {
            if (SmallStrightScore == null)
            {
                SmallStrightScore = score;
            }
        }

        public void SetLargeStraightScore(int score)
        {
            if (LargeStraightScore == null)
            {
                LargeStraightScore = score;
            }
        }

        public void SetFullHouseScore(int score)
        {
            if (FullHouseScore == null)
            {
                FullHouseScore = score;
            }
        }

        public void SetYahtzeeScore(int score)
        {
            if (YahtzeeScore == null)
            {
                YahtzeeScore = score;
            }
        }

        public void SetChanceScore(int score)
        {
            if (ChanceScore == null)
            {
                ChanceScore = score;
            }
        }

        public int UpperTotal =>
            OnesScore ?? 0 +
            TwosScore ?? 0 +
            ThreesScore ?? 0 +
            FoursScore ?? 0 +
            FivesScore ?? 0 +
            SixesScore ?? 0;

        public int UpperBonus => UpperTotal >= 63 ? 35 : 0;

        public int LowerTotal =>
            ThreeOfAKindScore ?? 0 +
            FourOfAKindScore ?? 0 +
            SmallStrightScore ?? 0 +
            LargeStraightScore ?? 0 +
            FullHouseScore ?? 0 +
            YahtzeeScore ?? 0 +
            ChanceScore ?? 0;

        public int GrandTotal => UpperTotal + UpperBonus + LowerTotal;
    }
}
