namespace Yahtzee
{
    public partial class Form1 : Form
    {
        Player player1;
        Player player2;
        Player currentPlayer;
        Dice dice;
        YahtzeeScores possibleScores;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player();
            player2 = new Player();
            dice = new Dice(new ActuallyRandom());
            
            possibleScores = new YahtzeeScores(dice);

            currentPlayer = player1;

            updateLabels();

        }

        private void updateLabels()
        {
            // check for game over
            // if all scores are NOT null, game over!
            // check player1 grand total vs player 2 grand total
            
            
            updateDiceLabels();
            updateScoreLabels();
            updateScoreButtons();


        }

        private void updateScoreButtons()
        {
            //if (currentPlayer.OnesScore == null)
            //{
            //    scoreOnesButton.Enabled = true;
            //}
            //else
            //{
            //    scoreOnesButton.Enabled = false;
            //}
            scoreOnesButton.Enabled = currentPlayer.OnesScore == null;
            scoreTwosButton.Enabled = currentPlayer.TwosScore == null;
            scoreThreesButton.Enabled = currentPlayer.ThreesScore == null;
            scoreFoursButton.Enabled = currentPlayer.FoursScore == null;
            scoreFivesButton.Enabled = currentPlayer.FivesScore == null;
            scoreSixesButton.Enabled = currentPlayer.SixesScore == null;
            scoreThreeOfAKindButton.Enabled = currentPlayer.ThreeOfAKindScore == null;
            scoreFourOfAKindButton.Enabled = currentPlayer.FourOfAKindScore == null;
            scoreFullHouseButton.Enabled = currentPlayer.FullHouseScore == null;
            scoreSmallStraightButton.Enabled = currentPlayer.SmallStrightScore == null;
            scoreLargeStraightButton.Enabled = currentPlayer.LargeStraightScore == null;
            scoreYahtzeeButton.Enabled = currentPlayer.YahtzeeScore == null;
            scoreChanceButton.Enabled = currentPlayer.ChanceScore == null;
        }

        private void updateScoreLabels()
        {
            if (currentPlayer.OnesScore != null)
            {
                onesScoreLabel.Text = currentPlayer.OnesScore.ToString();
            }
            else
            {
                onesScoreLabel.Text = possibleScores.OnesScore().ToString();
            }

            if (currentPlayer.TwosScore != null)
            {
                twosScoreLabel.Text = currentPlayer.TwosScore.ToString();
            }
            else
            {
                twosScoreLabel.Text = possibleScores.TwosScore().ToString();
            }

            if (currentPlayer.ThreesScore != null)
            {
                threesScoreLabel.Text = currentPlayer.ThreesScore.ToString();
            }
            else
            {
                threesScoreLabel.Text = possibleScores.ThreesScore().ToString();
            }

            if (currentPlayer.FoursScore != null)
            {
                foursScoreLabel.Text = currentPlayer.FoursScore.ToString();
            }
            else
            {
                foursScoreLabel.Text = possibleScores.FoursScore().ToString();
            }

            if (currentPlayer.FivesScore != null)
            {
                fivesScoreLabel.Text = currentPlayer.FivesScore.ToString();
            }
            else
            {
                fivesScoreLabel.Text = possibleScores.FivesScore().ToString();
            }

            if (currentPlayer.SixesScore != null)
            {
                sixesScoreLabel.Text = currentPlayer.SixesScore.ToString();
            }
            else
            {
                sixesScoreLabel.Text = possibleScores.SixesScore().ToString();
            }

            if (currentPlayer.ThreeOfAKindScore != null)
            {
                threeOfAKindLabel.Text = currentPlayer.ThreeOfAKindScore.ToString();
            }
            else
            {
                threeOfAKindLabel.Text = possibleScores.ThreeOfAKind().ToString();
            }

            if (currentPlayer.FourOfAKindScore != null)
            {
                fourOfAKindLabel.Text = currentPlayer.FourOfAKindScore.ToString();
            }
            else
            {
                fourOfAKindLabel.Text = possibleScores.FourOfAKind().ToString();
            }

            if (currentPlayer.FullHouseScore != null)
            {
                fullHouseLabel.Text = currentPlayer.FullHouseScore.ToString();
            }
            else
            {
                fullHouseLabel.Text = possibleScores.FullHouse().ToString();
            }

            if (currentPlayer.SmallStrightScore != null)
            {
                smallStraightLabel.Text = currentPlayer.SmallStrightScore.ToString();
            }
            else
            {
                smallStraightLabel.Text = possibleScores.SmallStraight().ToString();
            }

            if (currentPlayer.LargeStraightScore != null)
            {
                largeStraightLabel.Text = currentPlayer.LargeStraightScore.ToString();
            }
            else
            {
                largeStraightLabel.Text = possibleScores.LargeStraight().ToString();
            }

            if (currentPlayer.YahtzeeScore != null)
            {
                yahtzeeLabel.Text = currentPlayer.YahtzeeScore.ToString();
            }
            else
            {
                yahtzeeLabel.Text = possibleScores.Yahtzee().ToString();
            }

            if (currentPlayer.ChanceScore != null)
            {
                chancelLabel.Text = currentPlayer.ChanceScore.ToString();
            }
            else
            {
                chancelLabel.Text = possibleScores.Chance().ToString();
            }

            upperBonusLabel.Text = $"Upper Bonus: {currentPlayer.UpperBonus}";
            upperTotalLabel.Text = $"Upper Total: {currentPlayer.UpperTotal}";
            lowerTotalLabel.Text = $"Lower Total: {currentPlayer.LowerTotal}";
            grandTotalLabel.Text = $"Grand Total: {currentPlayer.GrandTotal}";
        }
        private void updateDiceLabels()
        {
            die1Label.Text = dice.Die1.ToString();
            die2Label.Text = dice.Die2.ToString();
            die3Label.Text = dice.Die3.ToString();
            die4Label.Text = dice.Die4.ToString();
            die5Label.Text = dice.Die5.ToString();
            rollsLeftLabel.Text = $"Rolls Left: {dice.NumberOfRollsLeft}";
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            dice.HoldDie1 = holdDie1Checkbox.Checked;
            dice.HoldDie2 = holdDie2Checkbox.Checked;
            dice.HoldDie3 = holdDie3Checkbox.Checked;
            dice.HoldDie4 = holdDie4Checkbox.Checked;
            dice.HoldDie5 = holdDie5Checkbox.Checked;

            dice.roll();

            possibleScores = new YahtzeeScores(dice);

            updateLabels();

            if (dice.NumberOfRollsLeft == 0)
            {
                rollButton.Enabled = false;
            }
        }

        private void scoreOnesButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetOnesScore(possibleScores.OnesScore());

            nextPlayersTurn();
        }

        private void nextPlayersTurn()
        {
            if (currentPlayer == player1)
            {
                currentPlayerLabel.Text = "Player 2's turn";
                currentPlayer = player2;
            }
            else
            {
                currentPlayerLabel.Text = "Player 1's turn";
                currentPlayer = player1;
            }

            dice = new Dice(new ActuallyRandom());
            possibleScores = new YahtzeeScores(dice);
            updateLabels();
            rollButton.Enabled = true;
            holdDie1Checkbox.Checked = false;
            holdDie2Checkbox.Checked = false;
            holdDie3Checkbox.Checked = false;
            holdDie4Checkbox.Checked = false;
            holdDie5Checkbox.Checked = false;
        }

        private void scoreTwosButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetTwosScore(possibleScores.TwosScore());

            nextPlayersTurn();
        }

        private void scoreThreesButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetThreesScore(possibleScores.ThreesScore());

            nextPlayersTurn();
        }

        private void scoreFoursButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetFoursScore(possibleScores.FoursScore());

            nextPlayersTurn();
        }

        private void scoreFivesButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetFivesScore(possibleScores.FivesScore());

            nextPlayersTurn();
        }

        private void scoreSixesButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetSixesScore(possibleScores.SixesScore());

            nextPlayersTurn();
        }

        private void scoreThreeOfAKindButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetThreeOfAKindScore(possibleScores.ThreeOfAKind());

            nextPlayersTurn();
        }

        private void scoreFourOfAKindButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetFourOfAKindScoreScore(possibleScores.FourOfAKind());

            nextPlayersTurn();
        }

        private void scoreFullHouseButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetFullHouseScore(possibleScores.FullHouse());

            nextPlayersTurn();
        }

        private void scoreSmallStraightButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetSmallStraightScore(possibleScores.SmallStraight());

            nextPlayersTurn();
        }

        private void scoreLargeStraightButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetLargeStraightScore(possibleScores.LargeStraight());

            nextPlayersTurn();
        }

        private void scoreYahtzeeButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetYahtzeeScore(possibleScores.Yahtzee());

            nextPlayersTurn();

        }

        private void scoreChanceButton_Click(object sender, EventArgs e)
        {
            currentPlayer.SetChanceScore(possibleScores.Chance());

            nextPlayersTurn();
        }
    }
}