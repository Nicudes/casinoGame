using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose
{
    class switchCase
    {


        GameManager gameManager = new GameManager();
        public void switches()
        {


   
            Console.Clear();
            Console.WriteLine("                                           Game Menu                                ");
            Console.WriteLine("             ~~~~~~~~~~~~~~~~~~~~~ Make a choice by pressing: ~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("              |   |1|  |     |2|    |   |3|   |    |4|      |   |5|   |    |6|    |");
            Console.WriteLine("              |  50/50 |  BlackJack |  Poker  | SlotMachine |   Bank  | Exit Game |");
            Console.WriteLine("             ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Good Luck! ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"               ~~~~~~~~~~~~~~~~~~~~~~~ Current balance: {gameManager.balance} ~~~~~~~~~~~~~~~~~~~~~~~~ ");



            string choice = Convert.ToString(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    Console.Clear();

                    FiftyFifty g1 = new FiftyFifty();
                    g1.FiftyFiftyGame();
                    break;

                case "2":
                    BlackJack g2 = new BlackJack();
                    g2.blackJackGame();
                    break;

                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;

                default:
                    break;


            }
        }
    }
}
