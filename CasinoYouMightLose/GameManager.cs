using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose
{
    public static class GameManager
    {
        public static int Balance { get; set; }
        public static string Name { get; set; }
        public static int Loan { get; set; }


        public static void endGame()
        {
            
            Console.WriteLine("\n");
            Console.WriteLine("Out of balance! ");
            
            switchCase s1 = new switchCase();
            s1.switches();
            

        }

}


}

