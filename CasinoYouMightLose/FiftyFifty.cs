
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose

{
    public class FiftyFifty
    {
        public void FiftyFiftyGame()
        {

         
            int bet;
            int guess;


            int gameFinish;

            //calling class GameManager

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"New Initiaded! Your current balance is {GameManager.Balance}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("How much do you want to bet?");

            bet = Convert.ToInt32(Console.ReadLine());

            //Random generator
            Random random = new Random();
            int randomNr = random.Next(1, 3);


            while (bet < 0)
            {
                Console.WriteLine("Bet is higher than your balance, please try again");
                Console.WriteLine("How much do you want to bet?");
                bet = Convert.ToInt32(Console.ReadLine());

            }


            Console.WriteLine("Your bet is: " + bet);
            Console.WriteLine("..................................................................");
            Console.WriteLine("Pick RED or BLACK ");
            Console.WriteLine("_________________        ___________________");
            Console.WriteLine("|PRESS 1 for RED|        |PRESS 2 for BLACK|");
            Console.WriteLine("|_______________|        |_________________|");
            guess = Convert.ToInt32(Console.ReadLine());


                    //Spelare och CPU vinner
            if (guess == randomNr)
            {
                if (randomNr == 1)
                {
                    Console.ForegroundColor
                     = ConsoleColor.Red;
                    Red();


                }
                if (randomNr == 2)
                {

                    Console.ForegroundColor
                       = ConsoleColor.DarkGray;
                    Black();

                }

                else if (guess >= 2)
                {
                    Console.WriteLine("Incorrect input, please try again!");
                    return;

                }

                Console.WriteLine("YOU WIN!");

                GameManager.Balance += bet;
                Console.WriteLine("Current balance is: " + GameManager.Balance
                    );
                Console.WriteLine("|      | 1 |          |      | 2 |       |");
                Console.WriteLine("| Play 50/50 again!   |    Main menu     |");
                gameFinish = Convert.ToInt32(Console.ReadLine());

                switch (gameFinish)
                {
                    case 1:
                        FiftyFiftyGame();
                        break;
                    case 2:
                        switchCase switchCase = new switchCase();
                        switchCase.switches();

                        break;


                    default:
                        break;
                }
            }
            if (guess != randomNr)
            {
                if (randomNr == 1)
                {
                    Console.ForegroundColor
                     = ConsoleColor.Red;

                    Red();

                }
                if (randomNr == 2)
                {

                    Console.ForegroundColor
                       = ConsoleColor.DarkGray;

                    Black();

                }

                GameManager.Balance -= bet;
                Console.WriteLine("YOU LOST! current balance is: "+ GameManager.Balance);
                Console.WriteLine("|      | 1 |          |      | 2 |       |");
                Console.WriteLine("| Play 50/50 again!   |    Main menu     |");
                gameFinish = Convert.ToInt32(Console.ReadLine());
                
                switch (gameFinish)
                {
                    case 1:
                        
                        FiftyFiftyGame();
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

        private static void Red()
        {
            Console.WriteLine("--------------------RESULTS-----------------");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-----oooooo--------oooooooo---oooo----------");
            Console.WriteLine("-----oooooooo------oooooooo---oooooo--------");
            Console.WriteLine("-----ooo---ooo-----ooo--------ooo-ooo-------");
            Console.WriteLine("-----oooooooo------ooooooo----ooo---ooo-----");
            Console.WriteLine("-----ooo---ooo-----ooo--------ooo--ooo------");
            Console.WriteLine("-----ooo----ooo----oooooooo---ooo-ooo-------");
            Console.WriteLine("-----ooo-----ooo---oooooooo---oooo----------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------RESULTS-----------------");
            Console.ResetColor();
        }

        private static void Black()
        {
            Console.WriteLine("--------------------------------RESULTS-----------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("-----oooooooo-----ooo-----------oooooo----------ooooooo---ooo-----ooo-----");
            Console.WriteLine("-----ooooooooo----ooo----------oooooooo-------ooooooooo---ooo----ooo------");
            Console.WriteLine("-----ooo---ooo----ooo---------ooo----ooo-----ooo----------ooo--ooo--------");
            Console.WriteLine("-----oooooooo-----ooo---------ooo----ooo----ooo-----------oooooo----------");
            Console.WriteLine("-----ooo---ooo----ooo--------oooooooooooo---ooo-----------ooooo-----------");
            Console.WriteLine("-----ooooooooo----oooooooo---ooo------ooo---ooooooooooo---ooo--ooo--------");
            Console.WriteLine("-----ooooooo------oooooooo---ooo------ooo-----ooooooooo---ooo----ooo------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------RESULTS-----------------------------------");
            Console.ResetColor();
        }
    }
}




