using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose.VideoPoker
{
    class Card
    {
        //Inside card we create a library(enumeration) which contains the type of cards inside a deck

        public enum SUIT
        {
                HEARTS, 
                SPADES,
                DIAMONDS,
                CLUBS

        }
        public enum VALUE
        {
            Two = 2, THREE, FOUR, FIVE, SIX, SEVEN, 
            EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
        }

        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
    }
}
