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
                HEART, 
                SPADES,
                DIAMONDS,
                CLUBS

        }
        public enum VALUE
        {
            TWO = 2, THREE = 3, FOUR = 4, FIVE = 5, SIX = 6, SEVEN = 7, 
            EIGHT=8, NINE=9, TEN=10, JACK = 11, QUEEN = 12, KING = 13, A = 14 
        }


        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }
    }
}
