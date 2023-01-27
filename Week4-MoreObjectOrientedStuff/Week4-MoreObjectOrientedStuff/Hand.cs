using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOrientedStuff
{
    public class Hand
    {
        public Card? Card1;
        public Card? Card2;
        public Card? Card3;
        public Card? Card4;
        public Card? Card5;

        // better way, but isn't the illustration
        private List<Card> cards;

        public Hand()
        {
            Card1 = new Card();
            Card2 = null;
            Card3 = null;
            Card4 = null;
            Card5 = null;
        }

        public (string, string) GetStrings()
        {
            string hand = "";
            if ( Card1 != null )
            {
                hand += Card1.ToString();
            }
            if (Card2 != null)
            {
                hand += Card2.ToString();
            }
            if (Card3 != null)
            {
                hand += Card3.ToString();
            }
            if (Card4 != null)
            {
                hand += Card4.ToString();
            }
            if (Card5 != null)
            {
                hand += Card5.ToString();
            }
            else
            {
                hand += "no card 5";
            }

            string otherHand = "";
            otherHand += Card1?.ToString();
            otherHand += Card2?.ToString();
            otherHand += Card3?.ToString();
            otherHand += Card4?.ToString();
            otherHand += Card5?.ToString() ?? "no card 5";

            return (hand, otherHand);
        }

    }
}
