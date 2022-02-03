using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playrandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;




            Random random = new Random();
            for(int i =0;i<10;i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadLine();

                playrandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playrandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("enemy AI rolled a " + enemyRandomNum);

                if(playrandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if(playrandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("enemy wins this round1");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("the score is now - player : " + playerPoints + ".Enemy : " + enemyPoints + ".");
                Console.WriteLine();

             

            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("you win !");
            }
            else if(playerPoints<enemyPoints)
            {
                Console.WriteLine("you lose!");
            }
            else
            {
                Console.WriteLine("It's a draw");
            }
            Console.ReadLine();






        }
    }
}
