using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose
{
    class BlackJack
    {
        public void blackJackGame()
        {
            //list of int outcome. outcome of a face card is 4 times as high as the other cards.
            List<int> cards = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };
            //Creates an random function.
            Random random = new Random();

            int card = random.Next(cards[2 - 12]);

            int outcome;    //Outcome money
            int bet = 0; // Bet amount
            int choice; // hit or hold
            int hands = 0; // player hand
            int dealerHand = 0; // dealer hand 


           
            //calling GameManager
            GameManager gameManager = new GameManager();

            Console.WriteLine("----BlackJack game initiated----");
            Console.WriteLine("Your balance is: ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("How much would you like to bet?");
            
            bet =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you curret card is");
            choice = Convert.ToInt32(Console.ReadLine());
            outcome = choice;
            
            if (outcome == 1)
            {
                

            
            }
         
      
            
            //Outcome is added to the balance.
            gameManager.balance =+ outcome;
            




        }
    }
}
