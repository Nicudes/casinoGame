using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager.Balance = 100;
            SplashPage splashPage = new SplashPage();
            splashPage.splashPage();
            



            Console.ReadKey();

        }
    }
}
