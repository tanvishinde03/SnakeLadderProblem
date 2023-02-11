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
          
            int Player_position = 0;
            int No_Play = 0;
            while (Player_position <= 100)        //UC4
            {
                Random random = new Random();
                int DiceRoll = random.Next(1, 7);
                Console.WriteLine("Dice Number : " + DiceRoll);             
                Console.ReadLine();

                Random random1 = new Random();
                int option = random1.Next(1, 4);
                Console.WriteLine("Number of option " + option);           
                
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
}
