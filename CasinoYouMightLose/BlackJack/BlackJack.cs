using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose.BlackJack
{
    class BlackJack
    {
        public void blackJackGame()
        {
            //list of int outcome. outcome of a face card is 4 times as high as the other cards.
            List<int> cards = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            //Creates an random function.
        

            //String array for FACE cards
            string[] faceCard = { "J", "Q", "K" };
            Random random = new Random();

            int card;
            int outcome;    //Outcome money
            int bet = 0; // Bet amount
            int choice; // hit or hold
            int playerHand = 0; // player hand
            int dealerHand = 0; // dealer hand

            
           
            //calling GameManager
            GameManager gameManager = new GameManager();
            Console.WriteLine();
            Console.WriteLine("----BlackJack game initiated----");
            Console.WriteLine("Your balance is: ********* ");      //Creating placeholder for BALANCE
            Console.WriteLine("--------------------------------");
            Console.WriteLine("How much would you like to bet?");
            bet =  Convert.ToInt32(Console.ReadLine()); //Input bet here

            Console.WriteLine("you curret card is");
 
            Console.WriteLine("\n Current hand is: "  + playerHand );
            Console.WriteLine("Press 1 to hit and press 2 to Hold!");

            choice = Convert.ToInt32(Console.ReadLine());
       


            //If player choses to hit
            if (choice == 1)
            {
                card = random.Next();
                playerHand += card;

                Console.WriteLine(card + playerHand);
            
            }

            if (choice == 2)
            {



            }
         
      
            
            




        }
    }
}
