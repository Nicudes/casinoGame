using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose.VideoPoker
{
    class VideoPoker
    {
        int bet;
        
        public void PokerGame()
        {
            Console.WriteLine($"Current balance is: {GameManager.Balance}" );
            Console.WriteLine();
            Console.WriteLine("~ Welcome to the VideoPoker game ~");
            Console.WriteLine("How much would you like to bet?");
            Console.WriteLine("Bet: ");
            bet = int.Parse(Console.ReadLine());

            GameStart();
        }
        public static void GameStart()
        {
            Console.WriteLine($"        -------    -------    -------    -------    -------        ");
            Console.WriteLine($"       |       |  |       |  |       |  |       |  |       |       ");
            Console.WriteLine($"       |       |  |       |  |       |  |       |  |       |       ");
            Console.WriteLine($"       |       |  |       |  |       |  |       |  |       |       ");
            Console.WriteLine($"        -------    -------    -------    -------    -------        ");

        }
        public static void GameResults()
        {

        }
        public static void DoubleUp()
        {

        }


    }

}
