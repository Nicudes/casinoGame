using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoYouMightLose
{
    class SplashPage
    {

        public void splashPage()
        {

           

            Console.WriteLine(" ____________________________________________________________________________________________________________");
            Console.WriteLine(@"|   __          __  _                            _          _   _             _____          _             _ |");
            Console.WriteLine(@"|   \ \        / / | |                          | |        | | | |           / ____|        (_)           | ||");
            Console.WriteLine(@"|    \ \  /\  / /__| | ___ ___  _ __ ___   ___  | |_ ___   | |_| |__   ___  | |     __ _ ___ _ _ __   ___ | ||");
            Console.WriteLine(@"|     \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | __/ _ \  | __| '_ \ / _ \ | |    / _` / __| | '_ \ / _ \| ||");
            Console.WriteLine(@"|      \  /\  /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |_| | | |  __/ | |___| (_| \__ \ | | | | (_) |_||");
            Console.WriteLine(@"|       \/  \/ \___|_|\___\___/|_| |_| |_|\___|  \__\___/   \__|_| |_|\___|  \_____\__,_|___/_|_| |_|\___/(_)|");
            Console.WriteLine("|____________________________________________________________________________________________________________|");
            Console.WriteLine("|_______________________________________Enter your name to continue!_________________________________________|");



            GameManager.Name = Convert.ToString(Console.ReadLine());

            switchCase switchCase = new switchCase();
            switchCase.switches();
                                                                                                          

        }
    }
}
