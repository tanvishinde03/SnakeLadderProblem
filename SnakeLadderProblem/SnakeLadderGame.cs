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
            Console.WriteLine("Dice Number : " + DiceRoll);
            Console.ReadLine();


        }





    }
}
