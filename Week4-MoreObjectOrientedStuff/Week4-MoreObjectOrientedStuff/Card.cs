using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_MoreObjectOrientedStuff
{
    public enum Suit { Hearts, Spades, Diamonds, Clubs }
    public enum Face { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    public class Card
    {
        static int Ace = 0;
        static Random random = new Random();

        private readonly Face face;
        private Suit suit;
        public Card(Face face, Suit suit) {
            this.face = face;
            this.suit = suit;
        }

        public void setSuit(Suit suit)
        {
            this.suit = suit;
        }

        public TwoNumerics GetNumericValues()
        {
            return new TwoNumerics((int)face, (int)suit);
        }

        public (int, int) OtherGetNumericValues()
        {
            return ((int)face, (int)suit);
        }

        public (int, string, double) Garbage()
        {
            return (0, "", 0.0);
        }

        public Suit GetSuit()
        {
            return this.suit;
        }

        public Face GetFace()
        {
            return this.face;
        }

        public override string ToString()
        {
            return $"{face} of {suit}";
        }

        public Card()
        {
            
            // used chat gpt "how do i get a random enum value from an enum in c#"
            Suit[] suits = Enum.GetValues<Suit>();
            suit = suits[random.Next(suits.Length)];
            int randomNumber1To6 = random.Next(1, 7);
            int alsoRandomNumber1To6 = random.Next(6) + 1;
            
            Face[] faces = Enum.GetValues<Face>();
            face = faces[random.Next(faces.Length)];
        }
    }

    public class TwoNumerics
    {
        public int faceValue;
        public int suitValue;

        public TwoNumerics(int value1, int value2)
        {
            faceValue = value1;
            suitValue = value2;
        }
    }

}
