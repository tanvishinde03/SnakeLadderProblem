using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    public class SnakeLadderGame
    {
        public void PoisitionCheck()
        {
            int player_no = 1;
            int start_position = 0;
            Console.WriteLine("Start Position of Player no {0} is : {1} ", player_no, start_position);
            Console.ReadLine();

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Dice Number : " + DiceRoll);             //UC2
            Console.ReadLine();

            Random random1 = new Random();
            int option = random1.Next(1, 4);
            Console.WriteLine("Number of option " + option);           //UC3
            Console.Write("\n");

            int Player_position = 0;
            int No_Play = 0;

            if (option == 1)
            {
                Player_position = Player_position + DiceRoll;
                Console.WriteLine("Player position moves ahead by the number on dice : " + Player_position);
                Console.ReadLine();
            }
            else if (option == 2)
            {
                Player_position = Player_position - DiceRoll;
                Console.WriteLine("Player position moves behind by the number on dice : " + Player_position);
                Console.ReadLine();

            }
            else
            {
                Player_position = Player_position + No_Play;
                Console.WriteLine("Player position remain same : " + Player_position);
                Console.ReadLine();
            }

            
        }





    }
}
