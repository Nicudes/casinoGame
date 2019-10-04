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


            /* //OLD FUNCTION LIST NOT IMPLEMENTED
            //list of int outcome. outcome of a face card is 4 times as high as the other cards.
            List<int> cards = new List<int> { 2, 3, 4,5,6,7,8,9,10,10,10,10,11 };

            //Creates a random function
            Random random = new Random();
            int cardIndex = random.Next(cards.Count);
            int card = cards[cardIndex];
            */

            //Declaring 6 player random cards
            Random random = new Random();
            int card1 = random.Next(2, 12);
            int card2 = random.Next(2, 12);
            int card3 = random.Next(2, 12);
            int card4 = random.Next(2, 12);
            int card5 = random.Next(2, 12);
            int card6 = random.Next(2, 12);

            //Declaring 6 computer random cards
            int pcCard1 = random.Next(2, 12);
            int pcCard2 = random.Next(2, 12);
            int pcCard3 = random.Next(2, 12);
            int pcCard4 = random.Next(2, 12);
            int pcCard5 = random.Next(2, 12);
            int pcCard6 = random.Next(2, 12);



            int bet = 0; // Bet amount
            int choice; // hit or hold
            int playerHand = 0; // player hand
            int dealerHand = 0; // dealer hand



            //calling GameManager

            Console.Clear();
            Console.WriteLine("----BlackJack game initiated----");
            Console.WriteLine("--BLACKJACK Gives double 3x bet-");
            Console.WriteLine("Your balance is: " + GameManager.Balance);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("How much would you like to bet?");
            bet = Convert.ToInt32(Console.ReadLine()); //Input bet here

            //Instead of writing the whole function of Incorrect bet, made this a method to make the code look slimmer!
            bet = IncorrectBet(bet);

            Console.WriteLine("Drawing cards");

            playerHand += card1;
            Console.WriteLine($"[{card1}]");
            playerHand += card2;
            Console.WriteLine($"[{card2}]");
            
            //If the game happens to draw 2 aces (11) then make it automatically blackjack! FOR FREE!
            if (playerHand == 22)
            {
                playerHand -= 1;

            }

            Console.WriteLine("\n Current hand is: " + playerHand);
            Console.WriteLine("Press 1 to hit and press 2 to Hold!");

            //If you get blackjack, end game instantly and player wins 3x
            if (playerHand == 21)
            {

                Console.WriteLine("BlackJack! YOU WIN!");
                GameManager.Balance += bet * 2;
                endGame();
            }
            //While loop som spelaren kan välja hit eller hold. Om du får 21 kommer den automatiskt Breaka ur loopen.

            while (playerHand <= 21)
            {


                choice = Convert.ToInt32(Console.ReadLine());

                //If player choses to hit
                if (choice == 1)
                {
                    playerHand += card3;
                    Console.WriteLine("You draw a new card: ");
                    Console.WriteLine($"[{card3}]");
                    Console.WriteLine("Your total value is: " + playerHand);

                    if (playerHand > 21)
                    {
                        Console.WriteLine("Player busts!");
                        GameManager.Balance -= bet;
                        endGame();
                    }
                }
                if (choice == 2)
                {
                    Console.WriteLine($"Holding at: {playerHand}");
                    break;
                }
                if (playerHand == 21)
                {
                    Console.WriteLine("You got the maximum value: 21! Auto-holding");
                    break;
                }

                choice = Convert.ToInt32(Console.ReadLine());

                //If player choses to hit
                if (choice == 1)
                {
                    playerHand += card4;
                    Console.WriteLine("You draw a new card: ");
                    Console.WriteLine($"[{card4}]");
                    Console.WriteLine("Your total value is: " + playerHand);

                    if (playerHand > 21)
                    {
                        Console.WriteLine("Player busts!");
                        GameManager.Balance -= bet;
                        endGame();
                    }
                }
                if (choice == 2)
                {
                    Console.WriteLine($"Holding at: {playerHand}");
                    break;
                }

                if (playerHand == 21)
                {
                    Console.WriteLine("You got the maximum value: 21! Auto-holding");
                    break;

                }

                choice = Convert.ToInt32(Console.ReadLine());

                //If player choses to hit
                if (choice == 1)
                {
                    playerHand += card5;
                    Console.WriteLine("You draw a new card: ");
                    Console.WriteLine($"[{card5}]");
                    Console.WriteLine("Your total value is: " + playerHand);

                    if (playerHand > 21)
                    {
                        Console.WriteLine("Player busts!");
                        GameManager.Balance -= bet;
                        endGame();
                        ;
                    }
                }
                //If player hand holds, break out of the loop and continue the code! 
                if (choice == 2)
                {
                    Console.WriteLine($"Holding at: {playerHand}");
                    break;
                }

                if (playerHand == 21)
                {
                    Console.WriteLine("You got the maximum value: 21! Auto-holding");
                    break;

                }

                choice = Convert.ToInt32(Console.ReadLine());

                //If player choses to hit
                if (choice == 1)
                {
                    playerHand += card6;
                    Console.WriteLine("You draw a new card: ");
                    Console.WriteLine($"[{card6}]");
                    Console.WriteLine("Your total value is: " + playerHand);

                    if (playerHand > 21)
                    {
                        Console.WriteLine("Player busts!");
                        GameManager.Balance -= bet;
                        endGame();
                        ;
                    }
                }
                if (choice == 2)
                {
                    Console.WriteLine($"Holding at: {playerHand}");
                    break;
                }

                if (playerHand == 21)
                {
                    Console.WriteLine("You got the maximum value: 21! Auto-holding");
                    break;

                }

            }

            //Dealer turn to draw cards! 
            Console.WriteLine("\n");
            Console.WriteLine("---Dealer turn---");
            Console.WriteLine("Dealer draws: ");
            //Dealer draws first random card
            dealerHand += pcCard1;
            Console.WriteLine($"[{pcCard1}]");
            //Dealer draws first random card!" 
            dealerHand += pcCard2;
            Console.WriteLine($"[{pcCard2}]");
            Console.WriteLine($"Dealer hand: {dealerHand}");

            //While dealer has card values bellow 17, dealer hits! 
            while (dealerHand < 17)
            {
                Console.WriteLine("-------------------------");
     
                Console.WriteLine($"Dealer draws: ");
                Console.WriteLine($"[{pcCard3}]");
                dealerHand += pcCard3;
                Console.WriteLine("New dealer hand: " + dealerHand);
                Console.WriteLine("-------------------------");
                if (dealerHand < 17)
                {

                    Console.WriteLine("-------------------------");
             
                    Console.WriteLine($"Dealer draws: ");
                    Console.WriteLine($"[{pcCard4}]");
                    dealerHand += pcCard4;
                    Console.WriteLine("New dealer hand: " + dealerHand);
                    Console.WriteLine("-------------------------");

                    if (dealerHand < 17)
                    {


                        Console.WriteLine("-------------------------");
                
                        Console.WriteLine($"Dealer draws: ");
                        Console.WriteLine($"[{pcCard5}]");
                        dealerHand += pcCard5;
                        Console.WriteLine("New dealer hand: " + dealerHand);
                        Console.WriteLine("-------------------------");


                        if (dealerHand < 17)
                        {

                            Console.WriteLine("-------------------------");

                            Console.WriteLine($"Dealer draws: ");
                            Console.WriteLine($"[{pcCard6}]");
                            dealerHand += pcCard6;
                            Console.WriteLine("New dealer hand: " + dealerHand);
                            Console.WriteLine("-------------------------");

                        }
                    }


                }
            }


            //if player loses against dealer hand and dealer hand must be 21 or lower
            if (playerHand < dealerHand && dealerHand <= 21)
            {
                GameManager.Balance -= bet;
                Console.WriteLine("Final results:");
                Console.WriteLine($"| Player: {playerHand} | Computer: {dealerHand} |");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("YOU LOSE: " + bet);
                Console.WriteLine("Your total balance is: " + GameManager.Balance);
                endGame();
            }

            //if player hand is higher than dealer hand or dealer hand busts > above 21
            if (playerHand > dealerHand || dealerHand > 21)
            {
                GameManager.Balance += bet;
                Console.WriteLine("Final results:");
                Console.WriteLine($"| Player: {playerHand} | Computer: {dealerHand} |");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("YOU WIN: " + bet);
                Console.WriteLine("Your total balance is: " + GameManager.Balance);
                endGame();
            }
            //If player and dealer goes even!
            if (playerHand == dealerHand)
            {
                Console.WriteLine("Final results:");
                Console.WriteLine($"| Player: {playerHand} | Computer: {dealerHand} |");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("EVEN! Player get money back!");
                endGame();

            }

            if (GameManager.Balance <= 0)
            {
                Console.WriteLine("Out of Balance! Sending you back to the main page!");
                switchCase s1 = new switchCase();
                s1.switches();

            }

        }

        private static int IncorrectBet(int bet)
        {
            if (bet > GameManager.Balance || bet <= 0)
            {
                Console.WriteLine("Invalid input please try again!");
                Console.WriteLine("***************************************");
                Console.WriteLine("Rules: \n*Can't bet lower than 1");
                Console.WriteLine("*Player can't bet more than balance");
                Console.WriteLine("Current balance is: " + GameManager.Balance);
                Console.WriteLine("***************************************");
                Console.WriteLine("Bet: ");
                bet = Int32.Parse(Console.ReadLine()); //Try again
            }

            return bet;
        }





        public void endGame()
        {
            int gameFinish;

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|      | 1 |          |      | 2 |       |");
            Console.WriteLine("| Play 50/50 again!   |    Main menu     |");
            Console.WriteLine("------------------------------------------");
            gameFinish = Convert.ToInt32(Console.ReadLine());

            switch (gameFinish)
            {
                case 1:

                    blackJackGame();
                    break;
                case 2:
                    switchCase switchCase = new switchCase();
                    switchCase.switches();

                    break;


                default:
                    break;
            }

        }
    }
}